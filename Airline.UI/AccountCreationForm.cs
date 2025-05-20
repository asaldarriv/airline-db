using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class AccountCreationForm : Form
    {
        private const int CustomerRoleId = 2; // Adjust according to your DB
        private const int ActiveContractStatusId = 1; // Set to the correct ID for "ACTIVE"
        private readonly UserFacade _facade = new();
        private readonly CountryFacade _countryFacade = new();
        private readonly DocumentTypeFacade _documentTypeFacade = new();

        public AccountCreationForm()
        {
            InitializeComponent();
            LoadDocumentTypes();
            LoadCountries();
        }

        private void LoadDocumentTypes()
        {
            var types = _documentTypeFacade.GetAllDocumentTypes();
            comboBoxDocumentType.DataSource = null;
            comboBoxDocumentType.DataSource = new List<DocumentType>(types);
            comboBoxDocumentType.DisplayMember = "Name";
            comboBoxDocumentType.ValueMember = "DocumentTypeId";
        }

        private void LoadCountries()
        {
            var countries = _countryFacade.GetAllCountries().ToList();
            comboBoxCountry.DataSource = new List<Country>(countries);
            comboBoxCountry.DisplayMember = "Name";
            comboBoxCountry.ValueMember = "CountryId";

            // Residence Country (optional)
            var residenceCountries = new List<Country>(countries);
            residenceCountries.Insert(0, new Country { CountryId = 0, Name = "(None)" });
            comboBoxResidenceCountry.DataSource = residenceCountries;
            comboBoxResidenceCountry.DisplayMember = "Name";
            comboBoxResidenceCountry.ValueMember = "CountryId";

            // Birth Country (optional)
            var birthCountries = new List<Country>(countries);
            birthCountries.Insert(0, new Country { CountryId = 0, Name = "(None)" });
            comboBoxBirthCountry.DataSource = birthCountries;
            comboBoxBirthCountry.DisplayMember = "Name";
            comboBoxBirthCountry.ValueMember = "CountryId";
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            // Document Type
            if (comboBoxDocumentType.SelectedItem == null)
            {
                MessageBox.Show("Please select a Document Type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int documentTypeId = (int)comboBoxDocumentType.SelectedValue;

            // Country
            if (comboBoxCountry.SelectedItem == null)
            {
                MessageBox.Show("Please select a Country.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int countryId = (int)comboBoxCountry.SelectedValue;

            // Residence Country (optional)
            int? residenceCountryId = null;
            if (comboBoxResidenceCountry.SelectedValue is int resId && resId != 0)
                residenceCountryId = resId;

            // Birth Country (optional)
            int? birthCountryId = null;
            if (comboBoxBirthCountry.SelectedValue is int birthId && birthId != 0)
                birthCountryId = birthId;

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
                ContractStatusId = ActiveContractStatusId, // Always ACTIVE
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