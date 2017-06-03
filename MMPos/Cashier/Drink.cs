using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPos
{
    public partial class Drink : UserControl
    {
        public delegate void AddDrinkDelegate(string n);
        public AddDrinkDelegate drinkDelegate;

        public delegate void ChangeMenuScreenDelegate(Drink t);
        public ChangeMenuScreenDelegate myDelegate;


        public Drink()
        {
            InitializeComponent();
        }
    }
}
