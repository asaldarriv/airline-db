using System;
using System.Windows.Forms;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBoxUsername.Text.Trim();
                string password = textBoxPassword.Text;

                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("Username field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Password field cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var loginFacade = new LoginFacade();
                bool isValid = loginFacade.ValidateLogin(username, password);

                if (isValid)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.StackTrace}", "Controlled error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}