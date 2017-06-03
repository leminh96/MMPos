using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPos.Menu.Coffee
{
    public partial class CAP : Drink
    {
       
        private static CAP _instance;
        public static CAP Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CAP();
                }
                return _instance;
            }
        }
        public CAP()
        {
            InitializeComponent();
        }

        private void CAP_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CAPL");
        }

        private void CAP_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CAPS");
        }

        private void CAP_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CAPH");
        }
    }
}
