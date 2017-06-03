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
    public partial class MT : Drink
    {
        private static MT _instance;
        public static MT Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MT();
                }
                return _instance;
            }
        }
        public MT()
        {
            InitializeComponent();
        }

        private void MT_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("MTL");
        }

        private void MT_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("MTS");
        }

        private void MT_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("MTH");
        }
    }
}
