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
    public partial class RM : Drink
    {
        private static RM _instance;
        public static RM Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RM();
                }
                return _instance;
            }
        }
        public RM()
        {
            InitializeComponent();
        }

        private void RM_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("RML");
        }

        private void RM_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("RMS");
        }

        private void RM_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("RMH");
        }
    }
}
