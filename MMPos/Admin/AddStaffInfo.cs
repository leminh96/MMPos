using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MMPos
{
    public partial class AddStaffInfo : StaffInfo
    {
        private static AddStaffInfo _instance;
        public static AddStaffInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AddStaffInfo();
                }
                return _instance;
            }
        }
        public AddStaffInfo()
        {
            InitializeComponent();
            EnableTextbox();
            OK.Click += new EventHandler(OK_Click);
            Help_Lable.Text = "* Fill staff information in text boxes, then press OK";
        }
        private void OK_Click(object sender, EventArgs e)
        {
            AddStaffToDB();
        }
    }
}