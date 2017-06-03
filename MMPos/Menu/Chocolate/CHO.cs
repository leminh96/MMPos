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
    public partial class CHO : Drink
    {
        private static CHO _instance;
        public static CHO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CHO();
                }
                return _instance;
            }
        }
        public CHO()
        {
            InitializeComponent();
        }

        private void CHO_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CHOL");
        }

        private void CHO_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CHOS");
        }

        private void CHO_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CHOH");
        }
    }
}
