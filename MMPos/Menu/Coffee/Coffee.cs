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
    public partial class Coffee : Drink
    {
        private static Coffee _instance;
        public static Coffee Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Coffee();
                }
                return _instance;
            }
        }
        

        public Coffee()
        {
            InitializeComponent();
            BL.Click += new System.EventHandler((sender, e) => BClick(sender, e, Menu.Coffee.BL.Instance));
            RM.Click += new System.EventHandler((sender, e) => BClick(sender, e, Menu.Coffee.RM.Instance));
            CAP.Click += new System.EventHandler((sender, e) => BClick(sender, e, Menu.Coffee.CAP.Instance));
            CAR.Click += new System.EventHandler((sender, e) => BClick(sender, e, Menu.Coffee.CAR.Instance));
            VAL.Click += new System.EventHandler((sender, e) => BClick(sender, e, Menu.Coffee.VAL.Instance));
            LA.Click += new System.EventHandler((sender, e) => BClick(sender, e, Menu.Coffee.LA.Instance));
            ES.Click += new System.EventHandler((sender, e) => BClick(sender, e, Menu.Coffee.ES.Instance));

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

        
    }
}
