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
    public partial class RemoveMemberInfo : MembersDetail
    {
        private static RemoveMemberInfo _instance;
        public static RemoveMemberInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RemoveMemberInfo();
                }
                return _instance;
            }
        }
        public RemoveMemberInfo()
        {
            InitializeComponent();
            LoadMember();
            DisableTextbox();
            Help_Lable.Text = "* Select a member and press OK to delete";
        }
        public void SelectToRemove()
        {
            if (Member_ListView.SelectedItems.Count > 0)
            {
                string id = Member_ListView.SelectedItems[0].Text;
                ClearTextbox();
                RemoveMemberFromDB(id);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            SelectToRemove();
            LoadMember();
        }

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
        }
    }
}
