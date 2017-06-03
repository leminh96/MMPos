using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MMPos
{
    public partial class StaffInfo : EditInfo
    {
        public StaffInfo()
        {
            InitializeComponent();
            Staff_ListView.Columns.Add("Staff ID", 120);
            Staff_ListView.Columns.Add("Name", 385);
            //Staff_ListView.Columns.Add("Position", 250);
            Staff_ListView.Columns.Add("Password", 180);
            ConnectDB();
            LoadStaff();
        }
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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadStaff()
        {
            Staff_ListView.Items.Clear();
            dt = new DataTable();
            cmd = new SqlCommand(@"select * from Users", con);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] arr = new string[3];
                ListViewItem item;
                arr[0] = dt.Rows[i][0].ToString();
                arr[1] = dt.Rows[i][1].ToString();
                arr[2] = dt.Rows[i][2].ToString();
                item = new ListViewItem(arr);
                Staff_ListView.Items.Add(item);
            }
        }
        public void ClearTextbox()
        {
            staffid_textbox.Text = string.Empty;
            name_textbox.Text = string.Empty;
            password_textbox.Text = string.Empty;
        }
        public void AddStaffToDB()
        {
            if (staffid_textbox.Text == string.Empty || name_textbox.Text == string.Empty || password_textbox.Text == string.Empty)
            {
                MessageBox.Show("Please insert all staff information");
            }
            else
            {
                cmd = new SqlCommand(@"insert into Users values (@id, @name, @pass)", con);
                string id, name, pass;
                id = staffid_textbox.Text;
                name = name_textbox.Text;
                pass = password_textbox.Text;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@pass", pass);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Insert failed, database haved this ID already");
                }
                LoadStaff();
            }
        }
        public void RemoveStaffFromDB(string id)
        {
            cmd = new SqlCommand(@"delete from Users where ID = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        private void Close_Click(object sender, System.EventArgs e)
        {
            Hide();
        }
        public void DisableTextbox()
        {
            name_textbox.Enabled = false;
            staffid_textbox.Enabled = false;
            password_textbox.Enabled = false;
        }
        public void EnableTextbox()
        {
            name_textbox.Enabled = true;
            staffid_textbox.Enabled = true;
            password_textbox.Enabled = true;
        }
    }
}
