using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPos.Menu.Tea
{
    public partial class PT : Drink
    {
        private static PT _instance;
        public static PT Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PT();
                }
                return _instance;
            }
        }
        public PT()
        {
            InitializeComponent();
        }

        private void PT_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("PTL");
        }

        private void PT_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("PTS");
        }

        private void PT_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("PTH");
        }
    }
}
