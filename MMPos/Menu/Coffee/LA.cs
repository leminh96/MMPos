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
    public partial class LA : Drink
    {
        private static LA _instance;
        public static LA Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LA();
                }
                return _instance;
            }
        }
        public LA()
        {
            InitializeComponent();
        }

        private void LA_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("LAL");
        }

        private void LA_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("LAS");
        }

        private void LA_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("LAH");
        }
    }
}
