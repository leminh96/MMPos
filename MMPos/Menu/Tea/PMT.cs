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
    public partial class PMT : Drink
    {
        private static PMT _instance;
        public static PMT Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PMT();
                }
                return _instance;
            }
        }
        public PMT()
        {
            InitializeComponent();
        }

        private void PMT_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("PMTL");
        }

        private void PMT_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("PMTS");
        }

        private void PMT_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("PMTH");
        }
    }
}
