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
    public partial class ES : Drink
    {
        private static ES _instance;
        public static ES Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ES();
                }
                return _instance;
            }
        }
        public ES()
        {
            InitializeComponent();
        }

        private void ES_1_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("ES");
        }

        private void ES_2_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("ESD");
        }
    }
}
