using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace MMPos
{
    public partial class Member : Form
    {
        private static Member _instance;
        public static Member Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Member();
                }
                return _instance;
            }
        }
        public delegate void DiscountDelegate(string id);
        public DiscountDelegate discountDelegate;
        public Member()
        {
            InitializeComponent();
            Member_0.Click += new EventHandler((sender, e) => Member_Click(sender, e, "0"));
            Member_1.Click += new EventHandler((sender, e) => Member_Click(sender, e, "1"));
            Member_2.Click += new EventHandler((sender, e) => Member_Click(sender, e, "2"));
            Member_3.Click += new EventHandler((sender, e) => Member_Click(sender, e, "3"));
            Member_4.Click += new EventHandler((sender, e) => Member_Click(sender, e, "4"));
            Member_5.Click += new EventHandler((sender, e) => Member_Click(sender, e, "5"));
            Member_6.Click += new EventHandler((sender, e) => Member_Click(sender, e, "6"));
            Member_7.Click += new EventHandler((sender, e) => Member_Click(sender, e, "7"));
            Member_8.Click += new EventHandler((sender, e) => Member_Click(sender, e, "8"));
            Member_9.Click += new EventHandler((sender, e) => Member_Click(sender, e, "9"));
            ConnectDB();
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

        private void Member_Click(object sender, EventArgs e, string m)
        {
            Member_Code.Text += m;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            discountDelegate?.Invoke(GetID());
            Instance.Hide();
            Member_Code.Text = string.Empty;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            string s = Member_Code.Text;

            if (s.Length > 0)
            {
                s = s.Substring(0, s.Length - 1);
            }

            Member_Code.Text = s;
        }
        public string GetID()
        {
            return Member_Code.Text;
        }
    }
}
