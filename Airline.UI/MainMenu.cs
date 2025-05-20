using System;
using System.Windows.Forms;

namespace Airline.UI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
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

        private void ButtonDocumentTypes_Click(object sender, EventArgs e)
        {
            using var form = new DocumentTypesForm();
            form.ShowDialog(this);
        }

        private void ButtonCountries_Click(object sender, EventArgs e)
        {
            using var form = new CountryForm();
            form.ShowDialog(this);
        }
    }
}