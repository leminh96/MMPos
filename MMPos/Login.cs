using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace MMPos
{
    public partial class Login : UserControl
    {
        private static Login _instance;
        public static Login Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Login();
                }
                return _instance;
            }
        }

        public delegate void ChangeScreenDelegate(int n, string name);
        public ChangeScreenDelegate myDelegate;

        public SqlConnection con;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public DataTable dt;

        public Users admin; //1 admin
        public List<Users> cashier; // 4 cashier

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

        public Login()
        {
            InitializeComponent();
            admin = new Users();
            cashier = new List<Users>();
            Pass_0.Click += new EventHandler((sender, e) => Pass_Click(sender, e, "0"));
            Pass_1.Click += new EventHandler((sender, e) => Pass_Click(sender, e, "1"));
            Pass_2.Click += new EventHandler((sender, e) => Pass_Click(sender, e, "2"));
            Pass_3.Click += new EventHandler((sender, e) => Pass_Click(sender, e, "3"));
            Pass_4.Click += new EventHandler((sender, e) => Pass_Click(sender, e, "4"));
            Pass_5.Click += new EventHandler((sender, e) => Pass_Click(sender, e, "5"));
            Pass_6.Click += new EventHandler((sender, e) => Pass_Click(sender, e, "6"));
            Pass_7.Click += new EventHandler((sender, e) => Pass_Click(sender, e, "7"));
            Pass_8.Click += new EventHandler((sender, e) => Pass_Click(sender, e, "8"));
            Pass_9.Click += new EventHandler((sender, e) => Pass_Click(sender, e, "9"));
            ConnectDB();
            TakeLoginPassFromDB();
        }
        
        private void TakeLoginPassFromDB()
        {
            string cmdstr = "select ID, Name ,Pass from Users where ID = '01'";

            //take admin pass
            dt = new DataTable();
            cmd = new SqlCommand(cmdstr, con);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
            admin.Id = dt.Rows[0][0].ToString();
            admin.Name = dt.Rows[0][1].ToString();
            admin.Pass = dt.Rows[0][2].ToString();

            //take cashier pass
            for (int i = 2; i <= 5; i++)
            {
                
                cmdstr = cmdstr.Replace((char)(i + 47), (char)(i + 48)); //replace old ID with new ID
                try
                {
                    dt = new DataTable();
                    cmd = new SqlCommand(cmdstr, con);
                    cmd.ExecuteNonQuery();
                    da = new SqlDataAdapter(cmd);
                    dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    da.Fill(dt);
                    Users temp = new Users();
                    temp.Id = dt.Rows[0][0].ToString();
                    temp.Name = dt.Rows[0][1].ToString();
                    temp.Pass = dt.Rows[0][2].ToString();
                    cashier.Add(temp);
                }
                catch
                {
                    break;
                }
            }
        }

        private void Pass_Click(object sender, EventArgs e, string p)
        {
            Pass_Code.Text += p;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (Pass_Code.Text == admin.Pass)
            {
                myDelegate?.Invoke(0, admin.Name);
            }
            else
            {
                for (int i = 0; i < cashier.Count; i++)
                {
                    if (Pass_Code.Text == cashier[i].Pass)
                    {
                        myDelegate?.Invoke(1, cashier[i].Name);
                    }
                }
            }
            Pass_Code.Text = string.Empty;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            string s = Pass_Code.Text;

            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
            }
            
            Pass_Code.Text = s;
        }
    }
}
