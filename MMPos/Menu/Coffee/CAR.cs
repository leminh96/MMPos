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
    public partial class CAR : Drink
    {
        private static CAR _instance;
        public static CAR Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CAR();
                }
                return _instance;
            }
        }
        public CAR()
        {
            InitializeComponent();
        }

        private void CAR_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CARL");
        }

        private void CAR_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CARS");
        }

        private void CAR_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CARH");
        }
    }
}
