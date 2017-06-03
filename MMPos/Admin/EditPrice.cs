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
    public partial class EditPrice : EditInfo
    {
        private static EditPrice _instance;
        public static EditPrice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EditPrice();
                }
                return _instance;
            }
        }
        public EditPrice()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Instance.Hide();
        }
    }
}
