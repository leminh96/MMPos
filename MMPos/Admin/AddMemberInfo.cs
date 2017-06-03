using System;

namespace MMPos
{
    public partial class AddMemberInfo : MembersDetail
    {
        private static AddMemberInfo _instance;
        public static AddMemberInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AddMemberInfo();
                }
                return _instance;
            }
        }
        public AddMemberInfo()
        {
            InitializeComponent();
            EnableTextbox();
            Help_Lable.Text = "*Fill member information in text boxes, then press OK";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            AddMemberToBD();
        }
    }
}
