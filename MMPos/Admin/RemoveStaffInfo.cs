using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MMPos
{
    public partial class RemoveStaffInfo : StaffInfo
    {
        private static RemoveStaffInfo _instance;
        public static RemoveStaffInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RemoveStaffInfo();
                }
                return _instance;
            }
        }
        public RemoveStaffInfo()
        {
            InitializeComponent();
            LoadStaff();
            DisableTextbox();
            Help_Lable.Text = "* Select a staff and press OK to delete";
        }
        
        public void SelectToRemove()
        {
            if (Staff_ListView.SelectedItems.Count > 0)
            {
                string id = Staff_ListView.SelectedItems[0].Text;
                ClearTextbox();
                RemoveStaffFromDB(id);
            }
        }

        private void OK_Click(object sender, System.EventArgs e)
        {
            SelectToRemove();
            LoadStaff();
        }

        private void Staff_ListView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ListView.SelectedListViewItemCollection temp = Staff_ListView.SelectedItems;
            foreach(ListViewItem item in temp)
            {
                staffid_textbox.Text = item.SubItems[0].Text;
                name_textbox.Text = item.SubItems[1].Text;
                password_textbox.Text = item.SubItems[2].Text;
            }
        }
    }
}
