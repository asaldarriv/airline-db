using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class CustomerMenuForm : Form
    {
        private readonly User _customer;
        private readonly TicketFacade _ticketFacade = new();
        private readonly TicketStatusFacade _ticketStatusFacade = new();

        public CustomerMenuForm(User customer)
        {
            _customer = customer;
            InitializeComponent();
            labelWelcome.Text = $"Welcome, {_customer.FirstName} {_customer.FirstLastName}";
            LoadTickets();
        }

        private void LoadTickets()
        {
            var tickets = _ticketFacade.GetAllTickets()
                .Where(t => t.CustomerId == _customer.UserId)
                .ToList();

            var statuses = _ticketStatusFacade.GetAllTicketStatuses().ToList();

            var display = tickets.Select(t => new
            {
                t.TicketId,
                t.FlightId,
                Status = statuses.FirstOrDefault(s => s.TicketStatusId == t.TicketStatusId)?.StatusCode ?? "Unknown",
                t.Price,
                t.AssignedSeat,
                t.SaleDate
            }).ToList();

            dataGridViewTickets.DataSource = null;
            dataGridViewTickets.DataSource = display;
            dataGridViewTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (dataGridViewTickets.CurrentRow == null)
            {
                MessageBox.Show("Please select a ticket.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var ticketId = (int)dataGridViewTickets.CurrentRow.Cells["TicketId"].Value;
            var ticket = _ticketFacade.GetAllTickets().FirstOrDefault(t => t.TicketId == ticketId);

            if (ticket == null)
            {
                MessageBox.Show("Ticket not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var statuses = _ticketStatusFacade.GetAllTicketStatuses().ToList();
            var pendingStatus = statuses.FirstOrDefault(s => s.TicketStatusId == ticket.TicketStatusId && s.StatusCode == "PENDING");
            var paidStatus = statuses.FirstOrDefault(s => s.StatusCode == "PAID");

            if (pendingStatus == null)
            {
                MessageBox.Show("This ticket is already paid or cannot be paid.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show("Do you want to pay this ticket now?", "Pay Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            ticket.TicketStatusId = paidStatus.TicketStatusId;
            _ticketFacade.UpdateTicket(ticket);

            MessageBox.Show("Ticket paid successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadTickets();
        }

        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            using var purchaseForm = new TicketPurchaseForm(_customer);
            purchaseForm.ShowDialog(this);
            LoadTickets();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}