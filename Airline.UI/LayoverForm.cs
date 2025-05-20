using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class LayoverForm : Form
    {
        private readonly LayoverFacade _facade = new();
        private int? editingId = null;

        public LayoverForm()
        {
            InitializeComponent();
            LoadLayovers();
            SetFormEnabled(false);
        }

        private void LoadLayovers()
        {
            var list = _facade.GetAllLayovers().ToList();
            dataGridViewLayovers.DataSource = null;
            dataGridViewLayovers.DataSource = list;
            dataGridViewLayovers.Columns["LayoverId"].HeaderText = "ID";
            dataGridViewLayovers.Columns["RouteId"].HeaderText = "Route ID";
            dataGridViewLayovers.Columns["CityId"].HeaderText = "City ID";
            dataGridViewLayovers.Columns["StopOrder"].HeaderText = "Stop Order";
            dataGridViewLayovers.Columns["ScheduledArrivalTime"].HeaderText = "Arrival";
            dataGridViewLayovers.Columns["ScheduledDepartureTime"].HeaderText = "Departure";
            dataGridViewLayovers.Columns["LayoverDuration"].HeaderText = "Duration";
            dataGridViewLayovers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLayovers.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingId = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxRouteId.Enabled = enabled;
            textBoxCityId.Enabled = enabled;
            numericUpDownStopOrder.Enabled = enabled;
            dateTimePickerArrival.Enabled = enabled;
            dateTimePickerDeparture.Enabled = enabled;
            maskedTextBoxDuration.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewLayovers.ClearSelection();
            textBoxRouteId.Text = "";
            textBoxCityId.Text = "";
            numericUpDownStopOrder.Value = 1;
            dateTimePickerArrival.Value = DateTime.Now;
            dateTimePickerDeparture.Value = DateTime.Now;
            maskedTextBoxDuration.Text = "00:00:00";
            editingId = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxRouteId.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int? routeId = null, cityId = null;
            if (!string.IsNullOrWhiteSpace(textBoxRouteId.Text))
            {
                if (!int.TryParse(textBoxRouteId.Text, out int parsedRoute))
                {
                    MessageBox.Show("Route ID must be a valid integer or empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                routeId = parsedRoute;
            }
            if (!string.IsNullOrWhiteSpace(textBoxCityId.Text))
            {
                if (!int.TryParse(textBoxCityId.Text, out int parsedCity))
                {
                    MessageBox.Show("City ID must be a valid integer or empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cityId = parsedCity;
            }

            if (!TimeSpan.TryParse(maskedTextBoxDuration.Text, out var duration))
            {
                MessageBox.Show("Duration must be in format hh:mm:ss.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var stopOrder = (int)numericUpDownStopOrder.Value;
            var arrival = dateTimePickerArrival.Value;
            var departure = dateTimePickerDeparture.Value;

            if (editingId == null)
            {
                var newLayover = new Layover
                {
                    RouteId = routeId,
                    CityId = cityId,
                    StopOrder = stopOrder,
                    ScheduledArrivalTime = arrival,
                    ScheduledDepartureTime = departure,
                    LayoverDuration = duration
                };
                _facade.AddLayover(newLayover);
            }
            else
            {
                var updatedLayover = new Layover
                {
                    LayoverId = editingId.Value,
                    RouteId = routeId,
                    CityId = cityId,
                    StopOrder = stopOrder,
                    ScheduledArrivalTime = arrival,
                    ScheduledDepartureTime = departure,
                    LayoverDuration = duration
                };
                _facade.UpdateLayover(updatedLayover);
            }

            LoadLayovers();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewLayovers.CurrentRow?.DataBoundItem is Layover selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete layover ID '{selected.LayoverId}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteLayover(selected.LayoverId);
                    LoadLayovers();
                }
            }
            else
            {
                MessageBox.Show("Please select a layover to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewLayovers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLayovers.CurrentRow?.DataBoundItem is Layover selected)
            {
                textBoxRouteId.Text = selected.RouteId?.ToString() ?? "";
                textBoxCityId.Text = selected.CityId?.ToString() ?? "";
                numericUpDownStopOrder.Value = selected.StopOrder;
                dateTimePickerArrival.Value = selected.ScheduledArrivalTime;
                dateTimePickerDeparture.Value = selected.ScheduledDepartureTime;
                maskedTextBoxDuration.Text = selected.LayoverDuration.ToString(@"hh\:mm\:ss");
                editingId = selected.LayoverId;
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
            dataGridViewLayovers.ClearSelection();
            textBoxRouteId.Text = "";
            textBoxCityId.Text = "";
            numericUpDownStopOrder.Value = 1;
            dateTimePickerArrival.Value = DateTime.Now;
            dateTimePickerDeparture.Value = DateTime.Now;
            maskedTextBoxDuration.Text = "00:00:00";
            editingId = null;
            SetFormEnabled(false);
            buttonCancel.Visible = false;
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }
    }
}