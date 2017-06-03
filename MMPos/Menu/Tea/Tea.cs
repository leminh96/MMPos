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
    public partial class Tea : Drink
    {
        private static Tea _instance;
        public static Tea Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Tea();
                }
                return _instance;
            }
        }
       
        public Tea()
        {
            InitializeComponent();
            GL.Click += new EventHandler((sender, e) => BClick(sender, e, Menu.Tea.GL.Instance));
            JAC.Click += new EventHandler((sender, e) => BClick(sender, e, Menu.Tea.JAC.Instance));
            LM.Click += new EventHandler((sender, e) => BClick(sender, e, Menu.Tea.LM.Instance));
            LOC.Click += new EventHandler((sender, e) => BClick(sender, e, Menu.Tea.LOC.Instance));
            MT.Click += new EventHandler((sender, e) => BClick(sender, e, Menu.Tea.MT.Instance));
            OM.Click += new EventHandler((sender, e) => BClick(sender, e, Menu.Tea.OM.Instance));
            OTH.Click += new EventHandler((sender, e) => BClick(sender, e, Menu.Tea.OTH.Instance));
            PMT.Click += new EventHandler((sender, e) => BClick(sender, e, Menu.Tea.PMT.Instance));
            PT.Click += new EventHandler((sender, e) => BClick(sender, e, Menu.Tea.PT.Instance));
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
