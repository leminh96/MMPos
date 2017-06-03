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
    public partial class LM : Drink
    {
        private static LM _instance;
        public static LM Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LM();
                }
                return _instance;
            }
        }

        public LM()
        {
            InitializeComponent();
        }

        private void LM_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("LML");
        }

        private void LM_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("LMS");
        }

        private void LM_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("LMH");
        }
    }
}
