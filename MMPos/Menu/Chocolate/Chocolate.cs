using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPos.Menu.Chocolate
{
    public partial class Chocolate : Drink
    {
        private static Chocolate _instance;
        public static Chocolate Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Chocolate();
                }
                return _instance;
            }
        }
        public Chocolate()
        {
            InitializeComponent();
            CHOF.Click += new System.EventHandler((sender, e) => BClick(sender, e, Menu.Chocolate.CHOF.Instance));
            CHO.Click += new System.EventHandler((sender, e) => BClick(sender, e, Menu.Chocolate.CHO.Instance));
        }

        public void AddDrink(string n)
        {
            drinkDelegate?.Invoke(n);
        }

        private void BClick(object sender, EventArgs e, Drink drink)
        {
            myDelegate?.Invoke(drink);
            drink.drinkDelegate = new AddDrinkDelegate(AddDrink);
        }

        private void CHOM_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CHOM");
        }
    }
}
