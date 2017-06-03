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
    public partial class LOC : Drink
    {
        private static LOC _instance;
        public static LOC Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LOC();
                }
                return _instance;
            }
        }
        public LOC()
        {
            InitializeComponent();
        }

        private void LOC_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("LOCL");
        }

        private void LOC_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("LOCS");
        }

        private void LOC_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("LOCH");
        }
    }
}
