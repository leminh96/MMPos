using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMPos.Menu.Juice
{
    public partial class Juice : Drink
    {
        private static Juice _instance;
        public static Juice Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Juice();
                }
                return _instance;
            }
        }
        public Juice()
        {
            InitializeComponent();
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("ORA");
        }

        private void Strawberry_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("STA");
        }

        private void Apple_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("APP");
        }

        private void Watermelon_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("WML");
        }

        private void Pineapple_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("PIN");
        }

        private void Apple_Straw_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("APS");
        }

        private void Carrot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("CRT");
        }

        private void Orange_Carrot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("OCR");
        }

        private void Grapefruit_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("GRA");
        }
    }
}
