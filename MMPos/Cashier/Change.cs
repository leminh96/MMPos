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
    public partial class Change : Form
    {
        private static Change _instance;
        public static Change Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Change();
                }
                return _instance;
            }
        }

        public delegate void CloseChangeFormDelegate();
        public CloseChangeFormDelegate closeDelegate;
        
        public Change()
        {
            InitializeComponent();
        }

        public void Set_Value(string t)
        {
            Change_Value.Text = t;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            closeDelegate?.Invoke();
        }
    }
}
