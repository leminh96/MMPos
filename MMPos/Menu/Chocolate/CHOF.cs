using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPos.Menu.Chocolate
{
    public partial class CHOF : Drink
    {
        private static CHOF _instance;
        public static CHOF Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CHOF();
                }
                return _instance;
            }
        }
        public CHOF()
        {
            InitializeComponent();
        }

        private void CHOF_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CHFL");
        }

        private void CHOF_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CHFS");
        }

        private void CHOF_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CHFH");
        }
    }
}
