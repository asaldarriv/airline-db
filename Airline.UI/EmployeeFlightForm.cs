using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class EmployeeFlightForm : Form
    {
        private readonly EmployeeFlightFacade _facade = new();
        private int? editingEmployeeId = null;
        private int? editingFlightId = null;

        public EmployeeFlightForm()
        {
            InitializeComponent();
            LoadEmployeeFlights();
            SetFormEnabled(false);
        }

        private void LoadEmployeeFlights()
        {
            var list = _facade.GetAllEmployeeFlights().ToList();
            dataGridViewEmployeeFlights.DataSource = null;
            dataGridViewEmployeeFlights.DataSource = list;
            dataGridViewEmployeeFlights.Columns["EmployeeId"].HeaderText = "Employee ID";
            dataGridViewEmployeeFlights.Columns["FlightId"].HeaderText = "Flight ID";
            dataGridViewEmployeeFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployeeFlights.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingEmployeeId = null;
            editingFlightId = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxEmployeeId.Enabled = enabled && editingEmployeeId == null;
            textBoxFlightId.Enabled = enabled && editingFlightId == null;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewEmployeeFlights.ClearSelection();
            textBoxEmployeeId.Text = "";
            textBoxFlightId.Text = "";
            editingEmployeeId = null;
            editingFlightId = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxEmployeeId.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxEmployeeId.Text, out int employeeId) ||
                !int.TryParse(textBoxFlightId.Text, out int flightId))
            {
                MessageBox.Show("Employee ID and Flight ID must be valid integers.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingEmployeeId == null && editingFlightId == null)
            {
                var newEF = new EmployeeFlight
                {
                    EmployeeId = employeeId,
                    FlightId = flightId
                };
                _facade.AddEmployeeFlight(newEF);
            }
            else
            {
                // No update, solo delete/add por ser PK compuesta
                MessageBox.Show("To modify, delete and add a new record.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadEmployeeFlights();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployeeFlights.CurrentRow?.DataBoundItem is EmployeeFlight selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete assignment Employee '{selected.EmployeeId}' - Flight '{selected.FlightId}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteEmployeeFlight(selected.EmployeeId, selected.FlightId);
                    LoadEmployeeFlights();
                }
            }
            else
            {
                MessageBox.Show("Please select an assignment to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewEmployeeFlights_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmployeeFlights.CurrentRow?.DataBoundItem is EmployeeFlight selected)
            {
                textBoxEmployeeId.Text = selected.EmployeeId.ToString();
                textBoxFlightId.Text = selected.FlightId.ToString();
                editingEmployeeId = selected.EmployeeId;
                editingFlightId = selected.FlightId;
                SetFormEnabled(false);
                buttonSave.Text = "Save";
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
            dataGridViewEmployeeFlights.ClearSelection();
            textBoxEmployeeId.Text = "";
            textBoxFlightId.Text = "";
            editingEmployeeId = null;
            editingFlightId = null;
            SetFormEnabled(false);
            buttonCancel.Visible = false;
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }
    }
}