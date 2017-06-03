using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPos
{
    public partial class Manager : UserControl
    {
        private static Manager _instance;
        public static Manager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Manager();
                }
                return _instance;
            }
        }
        public delegate void LockScreenDelegate();
        public LockScreenDelegate lockDelegate;

        public delegate void ChangeScreenDelegate(int n, string name);
        public ChangeScreenDelegate myDelegate;

        public Manager()
        {
            InitializeComponent();
        }

        private void Add_Member_Click(object sender, EventArgs e)
        {
            AddMemberInfo.Instance.Show();
            AddMemberInfo.Instance.LoadMember();
            AddMemberInfo.Instance.ClearTextbox();
        }

        private void Add_Staff_Click(object sender, EventArgs e)
        {
            AddStaffInfo.Instance.Show();
            AddStaffInfo.Instance.LoadStaff();
            AddStaffInfo.Instance.ClearTextbox();
        }

        private void Edit_Price_Click(object sender, EventArgs e)
        {
            EditPrice.Instance.Show();
        }

        private void Remove_Staff_Click(object sender, EventArgs e)
        {
            RemoveStaffInfo.Instance.Show();
            RemoveStaffInfo.Instance.LoadStaff();
            RemoveStaffInfo.Instance.ClearTextbox();
        }

        private void Edit_Staff_Click(object sender, EventArgs e)
        {
            EditStaffInfo.Instance.Show();
            EditStaffInfo.Instance.LoadStaff();
            EditStaffInfo.Instance.ClearTextbox();
        }

        private void Log_Out_Click(object sender, EventArgs e)
        {
            lockDelegate?.Invoke();
        }

        private void Remove_Member_Click(object sender, EventArgs e)
        {
            RemoveMemberInfo.Instance.Show();
            RemoveMemberInfo.Instance.LoadMember();
            RemoveMemberInfo.Instance.ClearTextbox();
        }

        private void Edit_Member_Click(object sender, EventArgs e)
        {
            EditMemberInfo.Instance.Show();
            EditMemberInfo.Instance.LoadMember();
            EditMemberInfo.Instance.ClearTextbox();
        }

        private void Open_Oder_Click(object sender, EventArgs e)
        {
            myDelegate?.Invoke(1, Login.Instance.admin.Name);
        }
    }
}
