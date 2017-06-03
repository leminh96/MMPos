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
    public partial class VAL : Drink
    {
        private static VAL _instance;
        public static VAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VAL();
                }
                return _instance;
            }
        }
        public VAL()
        {
            InitializeComponent();
        }

        private void VAL_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("VALL");
        }

        private void VAL_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("VALS");
        }

        private void VAL_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("VALH");
        }
    }
}
