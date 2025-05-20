using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class FlightForm : Form
    {
        private readonly FlightFacade _facade = new();
        private int? editingId = null;

        public FlightForm()
        {
            InitializeComponent();
            LoadFlights();
            SetFormEnabled(false);
        }

        private void LoadFlights()
        {
            var list = _facade.GetAllFlights().ToList();
            dataGridViewFlights.DataSource = null;
            dataGridViewFlights.DataSource = list;
            dataGridViewFlights.Columns["FlightId"].HeaderText = "ID";
            dataGridViewFlights.Columns["AirplaneId"].HeaderText = "Airplane ID";
            dataGridViewFlights.Columns["RouteId"].HeaderText = "Route ID";
            dataGridViewFlights.Columns["FlightStatusId"].HeaderText = "Status ID";
            dataGridViewFlights.Columns["DepartureTime"].HeaderText = "Departure";
            dataGridViewFlights.Columns["ArrivalTime"].HeaderText = "Arrival";
            dataGridViewFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFlights.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingId = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxAirplaneId.Enabled = enabled;
            textBoxRouteId.Enabled = enabled;
            textBoxStatusId.Enabled = enabled;
            dateTimePickerDeparture.Enabled = enabled;
            dateTimePickerArrival.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewFlights.ClearSelection();
            textBoxAirplaneId.Text = "";
            textBoxRouteId.Text = "";
            textBoxStatusId.Text = "";
            dateTimePickerDeparture.Value = DateTime.Now;
            dateTimePickerArrival.Value = DateTime.Now;
            editingId = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxAirplaneId.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string? airplaneId = string.IsNullOrWhiteSpace(textBoxAirplaneId.Text) ? null : textBoxAirplaneId.Text.Trim();
            int? routeId = null, statusId = null;
            if (!string.IsNullOrWhiteSpace(textBoxRouteId.Text))
            {
                if (!int.TryParse(textBoxRouteId.Text, out int parsedRoute))
                {
                    MessageBox.Show("Route ID must be a valid integer or empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                routeId = parsedRoute;
            }
            if (!string.IsNullOrWhiteSpace(textBoxStatusId.Text))
            {
                if (!int.TryParse(textBoxStatusId.Text, out int parsedStatus))
                {
                    MessageBox.Show("Status ID must be a valid integer or empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                statusId = parsedStatus;
            }

            var departure = dateTimePickerDeparture.Value;
            var arrival = dateTimePickerArrival.Value;

            if (editingId == null)
            {
                var newFlight = new Flight
                {
                    AirplaneId = airplaneId,
                    RouteId = routeId,
                    FlightStatusId = statusId,
                    DepartureTime = departure,
                    ArrivalTime = arrival
                };
                _facade.AddFlight(newFlight);
            }
            else
            {
                var updatedFlight = new Flight
                {
                    FlightId = editingId.Value,
                    AirplaneId = airplaneId,
                    RouteId = routeId,
                    FlightStatusId = statusId,
                    DepartureTime = departure,
                    ArrivalTime = arrival
                };
                _facade.UpdateFlight(updatedFlight);
            }

            LoadFlights();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewFlights.CurrentRow?.DataBoundItem is Flight selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete flight ID '{selected.FlightId}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteFlight(selected.FlightId);
                    LoadFlights();
                }
            }
            else
            {
                MessageBox.Show("Please select a flight to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewFlights_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFlights.CurrentRow?.DataBoundItem is Flight selected)
            {
                textBoxAirplaneId.Text = selected.AirplaneId ?? "";
                textBoxRouteId.Text = selected.RouteId?.ToString() ?? "";
                textBoxStatusId.Text = selected.FlightStatusId?.ToString() ?? "";
                dateTimePickerDeparture.Value = selected.DepartureTime;
                dateTimePickerArrival.Value = selected.ArrivalTime;
                editingId = selected.FlightId;
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
            dataGridViewFlights.ClearSelection();
            textBoxAirplaneId.Text = "";
            textBoxRouteId.Text = "";
            textBoxStatusId.Text = "";
            dateTimePickerDeparture.Value = DateTime.Now;
            dateTimePickerArrival.Value = DateTime.Now;
            editingId = null;
            SetFormEnabled(false);
            buttonCancel.Visible = false;
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }
    }
}