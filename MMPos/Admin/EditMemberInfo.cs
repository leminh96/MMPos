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
    public partial class EditMemberInfo : MembersDetail
    {
        private static EditMemberInfo _instance;
        public static EditMemberInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EditMemberInfo();
                }
                return _instance;
            }
        }
        public EditMemberInfo()
        {
            InitializeComponent();
            LoadMember();
            name_textbox.Enabled = true;
            nationalid_textbox.Enabled = true;
            memberid_textbox.Enabled = false;
            phone_textbox.Enabled = true;
            point_textbox.Enabled = true;
            Help_Lable.Text = "* Select a member and edit information in text boxes on the left, press OK to confirm";
        }
        public string id;

        private void Member_ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection temp = Member_ListView.SelectedItems;
            foreach (ListViewItem item in temp)
            {
                memberid_textbox.Text = item.SubItems[0].Text;
                name_textbox.Text = item.SubItems[1].Text;
                nationalid_textbox.Text = item.SubItems[2].Text;
                phone_textbox.Text = item.SubItems[3].Text;
                point_textbox.Text = item.SubItems[4].Text;
            }
            id = memberid_textbox.Text;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            RemoveMemberFromDB(id);
            AddMemberToBD();
            LoadMember();
        }
    }
}
