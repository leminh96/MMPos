using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace MMPos
{
    public partial class Cashier : UserControl
    {
        //Constant
        public const int primaryKeyExist = 2627;
        public const int listViewColumns = 4;
        public delegate void LockScreenDelegate();
        public LockScreenDelegate lockDelegate;
        
        //Singleton
        private static Cashier _instance;
        public static Cashier Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Cashier();
                }
                return _instance;
            }
        }
       
        int cash, change = 0, total = 0;
        char[] BillID;
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        public void ConnectDB()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-79SGS5L\MINHSQLSERVER;Initial Catalog=MMPos;Integrated Security=True");
            try
            {
                con.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public Cashier()
        {
            InitializeComponent();
            ConnectDB();
            listView.Columns.Add("ID", 0);
            listView.Columns.Add("Quantity", 90, HorizontalAlignment.Center);
            listView.Columns.Add("Name", 295);
            listView.Columns.Add("Amount", 100, HorizontalAlignment.Right);
            BillID = NewBill();

            //override button click event
            //9 buttons money
            P_1.Click += new EventHandler((sender, e) => Button_Money_Click(sender, e, 1000));
            P_2.Click += new EventHandler((sender, e) => Button_Money_Click(sender, e, 2000));
            P_5.Click += new EventHandler((sender, e) => Button_Money_Click(sender, e, 5000));
            P_10.Click += new EventHandler((sender, e) => Button_Money_Click(sender, e, 10000));
            P_20.Click += new EventHandler((sender, e) => Button_Money_Click(sender, e, 20000));
            P_50.Click += new EventHandler((sender, e) => Button_Money_Click(sender, e, 50000));
            P_100.Click += new EventHandler((sender, e) => Button_Money_Click(sender, e, 100000));
            P_200.Click += new EventHandler((sender, e) => Button_Money_Click(sender, e, 200000));
            P_500.Click += new EventHandler((sender, e) => Button_Money_Click(sender, e, 500000));

            //button menu
            Coffee.Click += new EventHandler((sender, e) => Menu_Click(sender, e, Menu.Coffee.Coffee.Instance));
            Smoothies.Click += new EventHandler((sender, e) => Menu_Click(sender, e, Menu.Smoothies.Smoothies.Instance));
            Tea.Click += new EventHandler((sender, e) => Menu_Click(sender, e, Menu.Tea.Tea.Instance));
            Topping.Click += new EventHandler((sender, e) => Menu_Click(sender, e, Menu.Topping.Topping.Instance));
            Juice.Click += new EventHandler((sender, e) => Menu_Click(sender, e, Menu.Juice.Juice.Instance));
            Chocolate.Click += new EventHandler((sender, e) => Menu_Click(sender, e, Menu.Chocolate.Chocolate.Instance));
        }

        public void SetUserName(string name)
        {
            userName.Text = "Cashier: " + name;
        }

        public void ChangeMenuScreen(Drink t)
        {
            Menu_Panel.Controls.Clear();
            Menu_Panel.Controls.Add(t);
        }

        //count total bill
        private int CountBill()
        {
            try
            {
                dt = new DataTable();
                cmd = new SqlCommand("Select count(ID) from Bills", con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            da = new SqlDataAdapter(cmd);
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
            return (int)dt.Rows[0][0];
        }

        //create new bill, return billID
        public char[] NewBill()
        {
            int num = CountBill() + 1;
            string temp;

            temp = num.ToString();
            while(temp.Length < 4)
            {
                temp = temp.Insert(0, "0");
            }
            BillNo.Text = "Bill No.: " + temp;

            char[] ID = new char[5];
            ID = temp.ToCharArray();

            cmd = new SqlCommand("insert into Bills values (@ID, @datetime)", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            cmd.ExecuteNonQuery();
            return ID;
        }

        //Update new quantity of the drink to BillDetail
        private void UpdateQuantity(string ID, int quan)
        {
            if (quan == 0)
                DeleteDrinkFromBill(ID);
            cmd = new SqlCommand("Update BillDetail Set Quantity = @Quan where BillID = @BillID and DrinkID = @Drink", con);
            cmd.Parameters.AddWithValue("@Drink", ID);
            cmd.Parameters.AddWithValue("@Quan", quan);
            cmd.Parameters.AddWithValue("@BillID", BillID);
            cmd.ExecuteNonQuery();
        }

        //delete drink from BillDetail
        private void DeleteDrinkFromBill(string id)
        {
            cmd = new SqlCommand("delete from BillDetail where BillID = @BillID and DrinkID = @DrinkID", con);
            cmd.Parameters.AddWithValue("@BillID", BillID);
            cmd.Parameters.AddWithValue("@DrinkID", id);
            cmd.ExecuteNonQuery();
        }

        //Get quantity of the drink
        private int CountDrink(string id)
        {
            dt = new DataTable();
            cmd = new SqlCommand("Select Quantity from BillDetail where BillID = @BillID and DrinkID = @Drink", con);
            cmd.Parameters.AddWithValue("@Drink", id);
            cmd.Parameters.AddWithValue("@BillID", BillID);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
            return (int)dt.Rows[0][0];
        }

        //Refresh the listview
        public void LoadDrink()
        {
            listView.Items.Clear();
            total = 0;
            dt = new DataTable();
            cmd = new SqlCommand(@"Select DrinkID, Quantity from BillDetail where BillID = @BillID", con);
            cmd.Parameters.AddWithValue("@BillID", BillID);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                string[] arr = new string[listViewColumns];
                ListViewItem item;
                int amount = (DrinksMenu.Instance.GetPrice(dt.Rows[i][0].ToString()) * (int)dt.Rows[i][1]);
                arr[0] = dt.Rows[i][0].ToString();
                arr[1] = dt.Rows[i][1].ToString();
                arr[2] = DrinksMenu.Instance.GetName(dt.Rows[i][0].ToString());
                arr[3] = amount.ToString();
                total += amount;
                item = new ListViewItem(arr);
                listView.Items.Add(item);
                Total.Text = total.ToString();
            }
            Total.Text = total.ToString();
        }

        //Add new drink to billDetail or increase quantity
        public void AddDrink(string id)
        {
            
            try
            {
                cmd = new SqlCommand("Insert into BillDetail values (@BillID, @Drink, 1)", con);
                cmd.Parameters.AddWithValue("@Drink", id);
                cmd.Parameters.AddWithValue("@BillID", BillID);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                if(ex.Number == primaryKeyExist)
                {
                    int num = CountDrink(id) + 1;
                    UpdateQuantity(id, num);
                }
            }
            LoadDrink();
        }

        private void Menu_Click(object sender, EventArgs e, Drink drink) //Handle event click of buttons menu-drink
        {
            ChangeMenuScreen(drink);
            drink.myDelegate = new Drink.ChangeMenuScreenDelegate(ChangeMenuScreen);
            drink.drinkDelegate = new Drink.AddDrinkDelegate(AddDrink);
        }
        
        private void Button_Money_Click(object sender, EventArgs e, int money) //Handle event click of 9 buttons money
        {
            cash += money;
            Cash_Textbox.Text = cash.ToString();
        }

        private void P_X_Click(object sender, EventArgs e)
        {
            cash = 0;
            Cash_Textbox.Text = cash.ToString();
        }

        private void P_Exact_Click(object sender, EventArgs e)
        {
            Cash_Textbox.Text = Total.Text;
            cash = int.Parse(Cash_Textbox.Text.ToString()); ;
        }

        
        private void P_Pay_Click(object sender, EventArgs e)
        {
            int temp = int.Parse(Total.Text.ToString());
            if (temp >= 1000000)
            {
                AddMemberInfo.Instance.Show();
            }
            int dis = int.Parse(Discount_Textbox.Text.ToString());
            change = cash - (temp - temp * dis/100);
            cash = 0;
            if (change >= 0)
            {
                Change.Instance.Set_Value(change.ToString() + " VNĐ");
                BillID = NewBill();
                listView.Items.Clear();
                Total.Text = "0";
            }
            else
            {
                Change.Instance.Set_Value("Not enough money");
            }
            
            Change.Instance.Show();
            Change.Instance.closeDelegate = new Change.CloseChangeFormDelegate(CloseChangeForm);
        }

        private void Member_Button_Click(object sender, EventArgs e)
        {
            Member.Instance.Show();
            Member.Instance.discountDelegate = new Member.DiscountDelegate(DiscountForMember);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                int pos = listView.SelectedIndices[0];
                string id = listView.SelectedItems[0].Text;
                int num = CountDrink(id) + 1;
                UpdateQuantity(id, num);
                LoadDrink();
                listView.Items[pos].Selected = true;
                listView.Select();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0) //check if select or not
            {

                int pos = listView.SelectedIndices[0];//take item index

                string id = listView.SelectedItems[0].Text;
                int num = CountDrink(id) - 1;
                UpdateQuantity(id, num);
                LoadDrink();

                //select item again
                listView.Items[pos].Selected = true;
                listView.Select();
            }
        }

        private void Log_Out_Click(object sender, EventArgs e)
        {
            lockDelegate?.Invoke();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                string id = listView.SelectedItems[0].Text;
                DeleteDrinkFromBill(id);
                LoadDrink();
            }
        }

        public void CloseChangeForm()
        {
            Change.Instance.Hide();
        }
        private int GetMemberInfoFromBD(string id)
        {
            dt = new DataTable();
            cmd = new SqlCommand(@"select name, point from Members where ID = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(SqlException)
            {
                MessageBox.Show("Invalid user");
            }
            da = new SqlDataAdapter(cmd);
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
            string name = dt.Rows[0][0].ToString();
            string point = dt.Rows[0][1].ToString();
            Name_Lable.Text = "Member: " + name;
            Point_Lable.Text = "Point: " + point;
            return int.Parse(point);
        }
        public void DiscountForMember(string id)
        {
            int point = GetMemberInfoFromBD(id);
            if (500 <= point)
            {
                Discount_Textbox.Text = "15";
                int ttotal = int.Parse(Total.Text.ToString());
                int tdis = int.Parse(Discount_Textbox.Text.ToString());
                int temp = ttotal - ttotal * tdis / 100;
                Total.Text = temp.ToString();
            }
            else
            {
                Discount_Textbox.Text = "0";
            }
        }
    }
}