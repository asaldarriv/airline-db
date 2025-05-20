using System;
using System.Windows.Forms;

namespace Airline.UI
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            using var form = new AccountCreationForm();
            form.ShowDialog(this);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            using var form = new Login();
            if (form.ShowDialog(this) == DialogResult.OK && form.AuthenticatedUser != null)
            {
                Hide();

                // CUSTOMER role ID is 6
                if (form.AuthenticatedUser.RoleId == 6)
                {
                    using (var customerMenu = new CustomerMenuForm(form.AuthenticatedUser))
                    {
                        customerMenu.ShowDialog();
                    }
                }
                else
                {
                    using (var mainMenu = new MainMenu())
                    {
                        mainMenu.ShowDialog();
                    }
                }
                Show();
            }
        }

        private void buttonViewFlights_Click(object sender, EventArgs e)
        {
            using var form = new FlightForm();
            form.ShowDialog(this);
        }
    }
}