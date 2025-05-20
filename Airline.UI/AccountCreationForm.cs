using System;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class AccountCreationForm : Form
    {
        // Set this to the RoleId for CUSTOMER in your database
        private const int CustomerRoleId = 2; // Adjust as needed

        private readonly UserFacade _facade = new();

        public AccountCreationForm()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            var email = textBoxEmail.Text.Trim();
            var firstName = textBoxFirstName.Text.Trim();
            var secondName = string.IsNullOrWhiteSpace(textBoxSecondName.Text) ? null : textBoxSecondName.Text.Trim();
            var firstLastName = textBoxFirstLastName.Text.Trim();
            var secondLastName = string.IsNullOrWhiteSpace(textBoxSecondLastName.Text) ? null : textBoxSecondLastName.Text.Trim();
            var phone = textBoxPhone.Text.Trim();
            var address = textBoxAddress.Text.Trim();
            var birthDate = dateTimePickerBirthDate.Value;
            var username = textBoxUsername.Text.Trim();
            var password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(firstLastName) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields except second name and second last name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newUser = new User
            {
                Email = email,
                FirstName = firstName,
                SecondName = secondName,
                FirstLastName = firstLastName,
                SecondLastName = secondLastName,
                PhoneNumber = phone,
                Address = address,
                BirthDate = birthDate,
                Username = username,
                IsActive = true,
                CreatedAt = DateTime.Now,
                RoleId = CustomerRoleId
            };

            try
            {
                _facade.AddUser(newUser, password); // password en texto plano
                MessageBox.Show("Account created successfully! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}