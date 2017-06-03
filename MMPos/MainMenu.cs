using System;
using System.Windows.Forms;

namespace MMPos
{
    public partial class MMPos : Form
    {
        public MMPos()
        {
            InitializeComponent();
            DrinksMenu.Instance.Load();
        }

        public void ChangeScreen(int n, string name)
        {
            Main_Panel.Controls.Clear();
            if (n == 0)
            {
                Main_Panel.Controls.Add(Manager.Instance);
                Manager.Instance.Dock = DockStyle.Fill;
            }
            else if (n == 1)
            {
                Main_Panel.Controls.Add(Cashier.Instance);
                Cashier.Instance.Dock = DockStyle.Fill;
                Cashier.Instance.SetUserName(name);
            }
        }

        public void LockScreen()
        {
            Main_Panel.Controls.Clear();
            Main_Panel.Controls.Add(Login.Instance);
            Login.Instance.Dock = DockStyle.Fill;
        }

        private void MMPos_Load(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToShortTimeString();
            Date.Text = DateTime.Now.ToLongDateString();
            LockScreen();
            Login.Instance.myDelegate = new Login.ChangeScreenDelegate(ChangeScreen);
            Manager.Instance.myDelegate = new Manager.ChangeScreenDelegate(ChangeScreen);
            Cashier.Instance.lockDelegate = new Cashier.LockScreenDelegate(LockScreen);
            Manager.Instance.lockDelegate = new Manager.LockScreenDelegate(LockScreen);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DrinksMenu.Instance.Update();
            Application.Exit();
        }
    }

    public class CurrentUser
    {
        private string name;

        private static CurrentUser _instance;
        public static CurrentUser Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CurrentUser();
                }
                return _instance;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }

    public class Users
    {
        private string id;
        private string name;
        private string pass;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }
    }

}
