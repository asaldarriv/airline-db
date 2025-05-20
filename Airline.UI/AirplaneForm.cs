using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class AirplaneForm : Form
    {
        private readonly AirplaneFacade _facade = new();
        private string? editingRegistration = null;

        public AirplaneForm()
        {
            InitializeComponent();
            LoadAirplanes();
            SetFormEnabled(false);
        }

        private void LoadAirplanes()
        {
            var list = _facade.GetAllAirplanes().ToList();
            dataGridViewAirplanes.DataSource = null;
            dataGridViewAirplanes.DataSource = list;
            dataGridViewAirplanes.Columns["RegistrationNumber"].HeaderText = "Registration";
            dataGridViewAirplanes.Columns["AirplaneStatusId"].HeaderText = "Status ID";
            dataGridViewAirplanes.Columns["PassengerCapacity"].HeaderText = "Capacity";
            dataGridViewAirplanes.Columns["Manufacturer"].HeaderText = "Manufacturer";
            dataGridViewAirplanes.Columns["Model"].HeaderText = "Model";
            dataGridViewAirplanes.Columns["AcquisitionDate"].HeaderText = "Acquisition Date";
            dataGridViewAirplanes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAirplanes.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingRegistration = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxRegistration.Enabled = enabled && editingRegistration == null;
            textBoxStatusId.Enabled = enabled;
            numericUpDownCapacity.Enabled = enabled;
            textBoxManufacturer.Enabled = enabled;
            textBoxModel.Enabled = enabled;
            dateTimePickerAcquisition.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewAirplanes.ClearSelection();
            textBoxRegistration.Text = "";
            textBoxStatusId.Text = "";
            numericUpDownCapacity.Value = 1;
            textBoxManufacturer.Text = "";
            textBoxModel.Text = "";
            dateTimePickerAcquisition.Value = DateTime.Now;
            editingRegistration = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxRegistration.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var reg = textBoxRegistration.Text.Trim();
            var man = textBoxManufacturer.Text.Trim();
            var model = textBoxModel.Text.Trim();
            var capacity = (int)numericUpDownCapacity.Value;
            var date = dateTimePickerAcquisition.Value;

            int? statusId = null;
            if (!string.IsNullOrWhiteSpace(textBoxStatusId.Text))
            {
                if (!int.TryParse(textBoxStatusId.Text, out int parsedStatusId))
                {
                    MessageBox.Show("Status ID must be a valid integer or empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                statusId = parsedStatusId;
            }

            if (string.IsNullOrWhiteSpace(reg) || string.IsNullOrWhiteSpace(man) || string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Registration, Manufacturer, and Model are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingRegistration == null)
            {
                var newAirplane = new Airplane
                {
                    RegistrationNumber = reg,
                    AirplaneStatusId = statusId,
                    PassengerCapacity = capacity,
                    Manufacturer = man,
                    Model = model,
                    AcquisitionDate = date
                };
                _facade.AddAirplane(newAirplane);
            }
            else
            {
                var updatedAirplane = new Airplane
                {
                    RegistrationNumber = editingRegistration,
                    AirplaneStatusId = statusId,
                    PassengerCapacity = capacity,
                    Manufacturer = man,
                    Model = model,
                    AcquisitionDate = date
                };
                _facade.UpdateAirplane(updatedAirplane);
            }

            LoadAirplanes();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAirplanes.CurrentRow?.DataBoundItem is Airplane selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete airplane '{selected.RegistrationNumber}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteAirplane(selected.RegistrationNumber);
                    LoadAirplanes();
                }
            }
            else
            {
                MessageBox.Show("Please select an airplane to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewAirplanes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAirplanes.CurrentRow?.DataBoundItem is Airplane selected)
            {
                textBoxRegistration.Text = selected.RegistrationNumber;
                textBoxStatusId.Text = selected.AirplaneStatusId?.ToString() ?? "";
                numericUpDownCapacity.Value = selected.PassengerCapacity;
                textBoxManufacturer.Text = selected.Manufacturer;
                textBoxModel.Text = selected.Model;
                dateTimePickerAcquisition.Value = selected.AcquisitionDate;
                editingRegistration = selected.RegistrationNumber;
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
            dataGridViewAirplanes.ClearSelection();
            textBoxRegistration.Text = "";
            textBoxStatusId.Text = "";
            numericUpDownCapacity.Value = 1;
            textBoxManufacturer.Text = "";
            textBoxModel.Text = "";
            dateTimePickerAcquisition.Value = DateTime.Now;
            editingRegistration = null;
            SetFormEnabled(false);
            buttonCancel.Visible = false;
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }
    }
}