using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class TicketForm : Form
    {
        private readonly TicketFacade _facade = new();
        private int? editingId = null;

        public TicketForm()
        {
            InitializeComponent();
            LoadTickets();
            SetFormEnabled(false);
        }

        private void LoadTickets()
        {
            var list = _facade.GetAllTickets().ToList();
            dataGridViewTickets.DataSource = null;
            dataGridViewTickets.DataSource = list;
            dataGridViewTickets.Columns["TicketId"].HeaderText = "ID";
            dataGridViewTickets.Columns["CustomerId"].HeaderText = "Customer ID";
            dataGridViewTickets.Columns["FlightId"].HeaderText = "Flight ID";
            dataGridViewTickets.Columns["TicketStatusId"].HeaderText = "Status ID";
            dataGridViewTickets.Columns["Price"].HeaderText = "Price";
            dataGridViewTickets.Columns["AssignedSeat"].HeaderText = "Assigned Seat";
            dataGridViewTickets.Columns["SaleDate"].HeaderText = "Sale Date";
            dataGridViewTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTickets.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingId = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxCustomerId.Enabled = enabled;
            textBoxFlightId.Enabled = enabled;
            textBoxStatusId.Enabled = enabled;
            numericUpDownPrice.Enabled = enabled;
            textBoxSeat.Enabled = enabled;
            dateTimePickerSaleDate.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewTickets.ClearSelection();
            textBoxCustomerId.Text = "";
            textBoxFlightId.Text = "";
            textBoxStatusId.Text = "";
            numericUpDownPrice.Value = 0;
            textBoxSeat.Text = "";
            dateTimePickerSaleDate.Value = DateTime.Now;
            editingId = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxCustomerId.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int? customerId = null, flightId = null, statusId = null;
            if (!string.IsNullOrWhiteSpace(textBoxCustomerId.Text))
            {
                if (!int.TryParse(textBoxCustomerId.Text, out int parsedCustomer))
                {
                    MessageBox.Show("Customer ID must be a valid integer or empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                customerId = parsedCustomer;
            }
            if (!string.IsNullOrWhiteSpace(textBoxFlightId.Text))
            {
                if (!int.TryParse(textBoxFlightId.Text, out int parsedFlight))
                {
                    MessageBox.Show("Flight ID must be a valid integer or empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                flightId = parsedFlight;
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

            var price = numericUpDownPrice.Value;
            var seat = textBoxSeat.Text.Trim();
            var saleDate = dateTimePickerSaleDate.Value;

            if (string.IsNullOrWhiteSpace(seat))
            {
                MessageBox.Show("Assigned Seat is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingId == null)
            {
                var newTicket = new Ticket
                {
                    CustomerId = customerId,
                    FlightId = flightId,
                    TicketStatusId = statusId,
                    Price = price,
                    AssignedSeat = seat,
                    SaleDate = saleDate
                };
                _facade.AddTicket(newTicket);
            }
            else
            {
                var updatedTicket = new Ticket
                {
                    TicketId = editingId.Value,
                    CustomerId = customerId,
                    FlightId = flightId,
                    TicketStatusId = statusId,
                    Price = price,
                    AssignedSeat = seat,
                    SaleDate = saleDate
                };
                _facade.UpdateTicket(updatedTicket);
            }

            LoadTickets();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTickets.CurrentRow?.DataBoundItem is Ticket selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete ticket ID '{selected.TicketId}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteTicket(selected.TicketId);
                    LoadTickets();
                }
            }
            else
            {
                MessageBox.Show("Please select a ticket to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTickets.CurrentRow?.DataBoundItem is Ticket selected)
            {
                textBoxCustomerId.Text = selected.CustomerId?.ToString() ?? "";
                textBoxFlightId.Text = selected.FlightId?.ToString() ?? "";
                textBoxStatusId.Text = selected.TicketStatusId?.ToString() ?? "";
                numericUpDownPrice.Value = selected.Price;
                textBoxSeat.Text = selected.AssignedSeat;
                dateTimePickerSaleDate.Value = selected.SaleDate;
                editingId = selected.TicketId;
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
            dataGridViewTickets.ClearSelection();
            textBoxCustomerId.Text = "";
            textBoxFlightId.Text = "";
            textBoxStatusId.Text = "";
            numericUpDownPrice.Value = 0;
            textBoxSeat.Text = "";
            dateTimePickerSaleDate.Value = DateTime.Now;
            editingId = null;
            SetFormEnabled(false);
            buttonCancel.Visible = false;
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }
    }
}