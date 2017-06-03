using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPos.Menu.Smoothies
{
    public partial class Smoothies : Drink
    {
        private static Smoothies _instance;
        public static Smoothies Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Smoothies();
                }
                return _instance;
            }
        }
        public Smoothies()
        {
            InitializeComponent();
        }

        private void FRAP_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("FRAP");
        }

        private void OREO_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("OREO");
        }

        private void VAL_F_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("VALF");
        }

        private void CAR_F_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CARF");
        }

        private void CHO_F_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CHOF");
        }

        private void STR_F_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("STAS");
        }

        private void BAN_F_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("BANS");
        }

        private void STBA_F_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("STBA");
        }

        private void CHOBA_F_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CHOB");
        }
    }
}
