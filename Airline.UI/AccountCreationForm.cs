using System;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class AccountCreationForm : Form
    {
        private const int CustomerRoleId = 2; // Adjust according to your DB
        private readonly UserFacade _facade = new();

        public AccountCreationForm()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxDocumentTypeId.Text, out int documentTypeId) ||
                !int.TryParse(textBoxCountryId.Text, out int countryId))
            {
                MessageBox.Show("Document Type ID and Country ID are required and must be valid numbers.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? residenceCountryId = string.IsNullOrWhiteSpace(textBoxResidenceCountryId.Text) ? null : int.Parse(textBoxResidenceCountryId.Text);
            int? birthCountryId = string.IsNullOrWhiteSpace(textBoxBirthCountryId.Text) ? null : int.Parse(textBoxBirthCountryId.Text);
            int? contractStatusId = string.IsNullOrWhiteSpace(textBoxContractStatusId.Text) ? null : int.Parse(textBoxContractStatusId.Text);

            var email = textBoxEmail.Text.Trim();
            var firstName = textBoxFirstName.Text.Trim();
            var secondName = string.IsNullOrWhiteSpace(textBoxSecondName.Text) ? null : textBoxSecondName.Text.Trim();
            var firstLastName = textBoxFirstLastName.Text.Trim();
            var secondLastName = string.IsNullOrWhiteSpace(textBoxSecondLastName.Text) ? null : textBoxSecondLastName.Text.Trim();
            var phone = textBoxPhone.Text.Trim();
            var address = textBoxAddress.Text.Trim();
            var birthDate = dateTimePickerBirthDate.Value;
            var trainingInstitution = string.IsNullOrWhiteSpace(textBoxTrainingInstitution.Text) ? null : textBoxTrainingInstitution.Text.Trim();
            var educationLevel = string.IsNullOrWhiteSpace(textBoxEducationLevel.Text) ? null : textBoxEducationLevel.Text.Trim();
            var degreeTitle = string.IsNullOrWhiteSpace(textBoxDegreeTitle.Text) ? null : textBoxDegreeTitle.Text.Trim();
            var username = textBoxUsername.Text.Trim();
            var password = textBoxPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(firstLastName) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All required fields marked with * must be filled.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newUser = new User
            {
                DocumentTypeId = documentTypeId,
                CountryId = countryId,
                RoleId = CustomerRoleId,
                Email = email,
                FirstName = firstName,
                SecondName = secondName,
                FirstLastName = firstLastName,
                SecondLastName = secondLastName,
                PhoneNumber = phone,
                Address = address,
                BirthDate = birthDate,
                TrainingInstitution = trainingInstitution,
                EducationLevel = educationLevel,
                DegreeTitle = degreeTitle,
                ResidenceCountryId = residenceCountryId,
                BirthCountryId = birthCountryId,
                ContractStatusId = contractStatusId,
                Username = username,
                IsActive = true,
                CreatedAt = DateTime.Now
            };

            try
            {
                _facade.AddUser(newUser, password);
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