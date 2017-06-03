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
    public partial class OM : Drink
    {
        private static OM _instance;
        public static OM Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OM();
                }
                return _instance;
            }
        }
        public OM()
        {
            InitializeComponent();
        }

        private void OM_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("OML");
        }

        private void OM_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("OMS");
        }

        private void OM_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("OMH");
        }
    }
}
