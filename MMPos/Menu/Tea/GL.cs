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
    public partial class GL : Drink
    {
        private static GL _instance;
        public static GL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GL();
                }
                return _instance;
            }
        }
        public GL()
        {
            InitializeComponent();
        }

        private void GL_Large_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("GLL");
        }

        private void GL_Small_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("GLS");
        }

        private void GL_Hot_Click(object sender, EventArgs e)
        {
            drinkDelegate?.Invoke("GLH");
        }
    }
}
