using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class FlightStatusForm : Form
    {
        private readonly FlightStatusFacade _facade = new();
        private int? editingId = null;

        public FlightStatusForm()
        {
            InitializeComponent();
            LoadStatuses();
            SetFormEnabled(false);
        }

        private void LoadStatuses()
        {
            var list = _facade.GetAllFlightStatuses().ToList();
            dataGridViewStatuses.DataSource = null;
            dataGridViewStatuses.DataSource = list;
            dataGridViewStatuses.Columns["FlightStatusId"].HeaderText = "ID";
            dataGridViewStatuses.Columns["StatusCode"].HeaderText = "Code";
            dataGridViewStatuses.Columns["StatusName"].HeaderText = "Name";
            dataGridViewStatuses.Columns["StatusDescription"].HeaderText = "Description";
            dataGridViewStatuses.Columns["IsActive"].HeaderText = "Active";
            dataGridViewStatuses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStatuses.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingId = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxCode.Enabled = enabled;
            textBoxName.Enabled = enabled;
            textBoxDescription.Enabled = enabled;
            checkBoxActive.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewStatuses.ClearSelection();
            textBoxCode.Text = "";
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            checkBoxActive.Checked = true;
            editingId = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxCode.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var code = textBoxCode.Text.Trim();
            var name = textBoxName.Text.Trim();
            var description = textBoxDescription.Text.Trim();
            var isActive = checkBoxActive.Checked;

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Code and Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingId == null)
            {
                var newStatus = new FlightStatus
                {
                    StatusCode = code,
                    StatusName = name,
                    StatusDescription = description,
                    IsActive = isActive
                };
                _facade.AddFlightStatus(newStatus);
            }
            else
            {
                var updatedStatus = new FlightStatus
                {
                    FlightStatusId = editingId.Value,
                    StatusCode = code,
                    StatusName = name,
                    StatusDescription = description,
                    IsActive = isActive
                };
                _facade.UpdateFlightStatus(updatedStatus);
            }

            LoadStatuses();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStatuses.CurrentRow?.DataBoundItem is FlightStatus selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete '{selected.StatusName}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteFlightStatus(selected.FlightStatusId);
                    LoadStatuses();
                }
            }
            else
            {
                MessageBox.Show("Please select a status to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewStatuses_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStatuses.CurrentRow?.DataBoundItem is FlightStatus selected)
            {
                textBoxCode.Text = selected.StatusCode;
                textBoxName.Text = selected.StatusName;
                textBoxDescription.Text = selected.StatusDescription;
                checkBoxActive.Checked = selected.IsActive;
                editingId = selected.FlightStatusId;
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
            dataGridViewStatuses.ClearSelection();
            textBoxCode.Text = "";
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            checkBoxActive.Checked = true;
            editingId = null;
            SetFormEnabled(false);
            buttonCancel.Visible = false;
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }
    }
}