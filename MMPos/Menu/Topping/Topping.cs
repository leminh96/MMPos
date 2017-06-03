using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPos.Menu.Topping
{
    public partial class Topping : Drink
    {
        private static Topping _instance;
        public static Topping Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Topping();
                }
                return _instance;
            }
        }
        public Topping()
        {
            InitializeComponent();
        }

        private void Flan_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("FLAN");
        }

        private void Jelly_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("JEL");
        }

        private void Peach_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("PCH");
        }

        private void Cream_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CRM");
        }

        private void Syrup_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("SYRP");
        }

        private void Lychee_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("LYCH");
        }

        private void Oreo_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("ORE");
        }

        private void Cheese_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CHES");
        }

        private void Honey_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("HNEY");
        }
    }
}
