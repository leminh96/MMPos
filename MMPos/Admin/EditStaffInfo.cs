using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPos
{
    public partial class EditStaffInfo : StaffInfo
    {
        private static EditStaffInfo _instance;
        public static EditStaffInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EditStaffInfo();
                }
                return _instance;
            }
        }
        public EditStaffInfo()
        {
            InitializeComponent();
            LoadStaff();
            name_textbox.Enabled = true;
            password_textbox.Enabled = true;
            staffid_textbox.Enabled = false;
            Help_Lable.Text = "* Select a staff and edit information in text boxes on the left, press OK to confirm";
        }
        public string id;
        private void Staff_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection temp = Staff_ListView.SelectedItems;
            foreach (ListViewItem item in temp)
            {
                staffid_textbox.Text = item.SubItems[0].Text;
                name_textbox.Text = item.SubItems[1].Text;
                password_textbox.Text = item.SubItems[2].Text;
            }
            id = staffid_textbox.Text;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            RemoveStaffFromDB(id);
            AddStaffToDB();
            LoadStaff();
        }
    }
}
