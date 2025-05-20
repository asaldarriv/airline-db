using System;
using System.Windows.Forms;

namespace Airline.UI
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            // This will signal Program.cs to show the login form again
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}