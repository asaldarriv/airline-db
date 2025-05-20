using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class UserForm : Form
    {
        private readonly UserFacade _facade = new();
        private int? editingId = null;

        public UserForm()
        {
            InitializeComponent();
            LoadUsers();
            SetFormEnabled(false);
        }

        private void LoadUsers()
        {
            var list = _facade.GetAllUsers().ToList();
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = list;
            dataGridViewUsers.Columns["UserId"].HeaderText = "ID";
            dataGridViewUsers.Columns["Email"].HeaderText = "Email";
            dataGridViewUsers.Columns["FirstName"].HeaderText = "First Name";
            dataGridViewUsers.Columns["SecondName"].HeaderText = "Second Name";
            dataGridViewUsers.Columns["FirstLastName"].HeaderText = "First Last Name";
            dataGridViewUsers.Columns["SecondLastName"].HeaderText = "Second Last Name";
            dataGridViewUsers.Columns["PhoneNumber"].HeaderText = "Phone";
            dataGridViewUsers.Columns["Address"].HeaderText = "Address";
            dataGridViewUsers.Columns["BirthDate"].HeaderText = "Birth Date";
            dataGridViewUsers.Columns["Username"].HeaderText = "Username";
            dataGridViewUsers.Columns["PasswordHash"].HeaderText = "Password Hash";
            dataGridViewUsers.Columns["IsActive"].HeaderText = "Active";
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingId = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxEmail.Enabled = enabled;
            textBoxFirstName.Enabled = enabled;
            textBoxSecondName.Enabled = enabled;
            textBoxFirstLastName.Enabled = enabled;
            textBoxSecondLastName.Enabled = enabled;
            textBoxPhone.Enabled = enabled;
            textBoxAddress.Enabled = enabled;
            dateTimePickerBirthDate.Enabled = enabled;
            textBoxUsername.Enabled = enabled;
            textBoxPassword.Enabled = enabled;
            checkBoxIsActive.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.ClearSelection();
            textBoxEmail.Text = "";
            textBoxFirstName.Text = "";
            textBoxSecondName.Text = "";
            textBoxFirstLastName.Text = "";
            textBoxSecondLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            dateTimePickerBirthDate.Value = DateTime.Now;
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            checkBoxIsActive.Checked = true;
            editingId = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxEmail.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
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
            var isActive = checkBoxIsActive.Checked;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(firstLastName) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields except second name and second last name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingId == null)
            {
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
                    PasswordHash = password,
                    IsActive = isActive,
                    CreatedAt = DateTime.Now
                };
                _facade.AddUser(newUser);
            }
            else
            {
                var updatedUser = new User
                {
                    UserId = editingId.Value,
                    Email = email,
                    FirstName = firstName,
                    SecondName = secondName,
                    FirstLastName = firstLastName,
                    SecondLastName = secondLastName,
                    PhoneNumber = phone,
                    Address = address,
                    BirthDate = birthDate,
                    Username = username,
                    PasswordHash = password,
                    IsActive = isActive,
                    CreatedAt = DateTime.Now // O puedes mantener el original si lo deseas
                };
                _facade.UpdateUser(updatedUser);
            }

            LoadUsers();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow?.DataBoundItem is User selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete user '{selected.Email}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteUser(selected.UserId);
                    LoadUsers();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow?.DataBoundItem is User selected)
            {
                textBoxEmail.Text = selected.Email;
                textBoxFirstName.Text = selected.FirstName;
                textBoxSecondName.Text = selected.SecondName ?? "";
                textBoxFirstLastName.Text = selected.FirstLastName;
                textBoxSecondLastName.Text = selected.SecondLastName ?? "";
                textBoxPhone.Text = selected.PhoneNumber;
                textBoxAddress.Text = selected.Address;
                dateTimePickerBirthDate.Value = selected.BirthDate;
                textBoxUsername.Text = selected.Username;
                textBoxPassword.Text = selected.PasswordHash;
                checkBoxIsActive.Checked = selected.IsActive;
                editingId = selected.UserId;
                SetFormEnabled(true);
                buttonSave.Text = "Update";
                buttonCancel.Visible = true;
                buttonDelete.Visible = true;
            }
            else
            {
                SetFormEnabled(false);
                buttonCancel.Visible = false;
                buttonDelete.Visible = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            dataGridViewUsers.ClearSelection();
            textBoxEmail.Text = "";
            textBoxFirstName.Text = "";
            textBoxSecondName.Text = "";
            textBoxFirstLastName.Text = "";
            textBoxSecondLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            dateTimePickerBirthDate.Value = DateTime.Now;
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            checkBoxIsActive.Checked = true;
            editingId = null;
            SetFormEnabled(false);
            buttonCancel.Visible = false;
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }
    }
}