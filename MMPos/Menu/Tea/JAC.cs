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
    public partial class JAC : Drink
    {
        private static JAC _instance;
        public static JAC Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new JAC();
                }
                return _instance;
            }
        }
        public JAC()
        {
            InitializeComponent();
        }

        private void JAS_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("JACL");
        }

        private void JAS_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("JACS");
        }

        private void JAS_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("JACH");
        }
    }
}
