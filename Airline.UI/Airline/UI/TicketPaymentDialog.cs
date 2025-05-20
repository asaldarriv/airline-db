using System;
using System.Windows.Forms;

namespace Airline.UI
{
    public partial class TicketPaymentDialog : Form
    {
        public string AssignedSeat => textBoxSeat.Text.Trim();
        public decimal TicketPrice => numericUpDownPrice.Value;
        public bool IsPaid { get; private set; }

        public TicketPaymentDialog()
        {
            InitializeComponent();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSeat.Text))
            {
                MessageBox.Show("Seat is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IsPaid = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSeat.Text))
            {
                MessageBox.Show("Seat is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show("Price must be greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            IsPaid = false;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}