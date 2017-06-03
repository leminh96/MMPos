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
    public partial class OTH : Drink
    {
        private static OTH _instance;
        public static OTH Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OTH();
                }
                return _instance;
            }
        }
        public OTH()
        {
            InitializeComponent();
        }

        private void GR_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("GR");
        }

        private void OL_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("OL");
        }

        private void TK_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("TI");
        }

        private void LO_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("LO");
        }

        private void JA_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("JAS");
        }

        private void RB_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("ROSE");
        }
    }
}
