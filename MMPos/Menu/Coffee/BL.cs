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
    public partial class BL : Drink
    {

        private static BL _instance;
        public static BL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BL();
                }
                return _instance;
            }
        }
        public BL()
        {
            InitializeComponent();
        }

        private void BL_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("BLL");
        }

        private void BL_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("BLS");
        }

        private void BL_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("BLH");
        }
    }
}
