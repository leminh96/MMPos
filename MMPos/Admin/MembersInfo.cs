using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MMPos
{
    public partial class MembersDetail : EditInfo
    {
        public MembersDetail()
        {
            InitializeComponent();
            Member_ListView.Columns.Add("Member ID", 120);
            Member_ListView.Columns.Add("Name", 300);
            Member_ListView.Columns.Add("National ID", 150);
            Member_ListView.Columns.Add("Phone", 200);
            Member_ListView.Columns.Add("Point", 180);
            ConnectDB();
            LoadMember();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Hide();
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
        public void LoadMember()
        {
            Member_ListView.Items.Clear();
            dt = new DataTable();
            cmd = new SqlCommand(@"select * from Members", con);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] arr = new string[5];
                ListViewItem item;
                arr[0] = dt.Rows[i][0].ToString();
                arr[1] = dt.Rows[i][1].ToString();
                arr[2] = dt.Rows[i][2].ToString();
                arr[3] = dt.Rows[i][3].ToString();
                arr[4] = dt.Rows[i][4].ToString();
                item = new ListViewItem(arr);
                Member_ListView.Items.Add(item);
            }
        }
        public void AddMemberToBD()
        {
            if (memberid_textbox.Text == string.Empty || name_textbox.Text == string.Empty || nationalid_textbox.Text == string.Empty || phone_textbox.Text == string.Empty || point_textbox.Text == string.Empty)
            {
                MessageBox.Show("Please insert all staff information");
            }
            else
            {
                cmd = new SqlCommand(@"insert into Members values (@id, @name, @cmnd, @phone, @point)", con);
                string id, name, cmnd, phone;
                int point;
                id = memberid_textbox.Text;
                name = name_textbox.Text;
                cmnd = nationalid_textbox.Text;
                phone = phone_textbox.Text;
                point = int.Parse(point_textbox.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@cmnd", cmnd);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@point", point);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Insert failed, database haved this ID already");
                }
               LoadMember();
            }
        }
        public void RemoveMemberFromDB(string id)
        {
            cmd = new SqlCommand(@"delete from Members where ID = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
        public void ClearTextbox()
        {
            memberid_textbox.Text = string.Empty;
            name_textbox.Text = string.Empty;
            nationalid_textbox.Text = string.Empty;
            phone_textbox.Text = string.Empty;
            point_textbox.Text = string.Empty;
        }
        public void DisableTextbox()
        {
            name_textbox.Enabled = false;
            memberid_textbox.Enabled = false;
            nationalid_textbox.Enabled = false;
            phone_textbox.Enabled = false;
            point_textbox.Enabled = false;
        }
        public void EnableTextbox()
        {
            name_textbox.Enabled = true;
            memberid_textbox.Enabled = true;
            nationalid_textbox.Enabled = true;
            phone_textbox.Enabled = true;
            point_textbox.Enabled = true;
        }
    }
}
