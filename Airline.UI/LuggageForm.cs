using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class LuggageForm : Form
    {
        private readonly LuggageFacade _facade = new();
        private int? editingId = null;

        public LuggageForm()
        {
            InitializeComponent();
            LoadLuggages();
            SetFormEnabled(false);
        }

        private void LoadLuggages()
        {
            var list = _facade.GetAllLuggages().ToList();
            dataGridViewLuggages.DataSource = null;
            dataGridViewLuggages.DataSource = list;
            dataGridViewLuggages.Columns["LuggageId"].HeaderText = "ID";
            dataGridViewLuggages.Columns["TicketId"].HeaderText = "Ticket ID";
            dataGridViewLuggages.Columns["LuggageTypeId"].HeaderText = "Luggage Type ID";
            dataGridViewLuggages.Columns["Quantity"].HeaderText = "Quantity";
            dataGridViewLuggages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLuggages.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingId = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxTicketId.Enabled = enabled;
            textBoxLuggageTypeId.Enabled = enabled;
            numericUpDownQuantity.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewLuggages.ClearSelection();
            textBoxTicketId.Text = "";
            textBoxLuggageTypeId.Text = "";
            numericUpDownQuantity.Value = 1;
            editingId = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxTicketId.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxTicketId.Text.Trim(), out int ticketId) ||
                !int.TryParse(textBoxLuggageTypeId.Text.Trim(), out int luggageTypeId))
            {
                MessageBox.Show("Ticket ID and Luggage Type ID must be valid integers.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var quantity = (int)numericUpDownQuantity.Value;

            if (editingId == null)
            {
                var newLuggage = new Luggage
                {
                    TicketId = ticketId,
                    LuggageTypeId = luggageTypeId,
                    Quantity = quantity
                };
                _facade.AddLuggage(newLuggage);
            }
            else
            {
                var updatedLuggage = new Luggage
                {
                    LuggageId = editingId.Value,
                    TicketId = ticketId,
                    LuggageTypeId = luggageTypeId,
                    Quantity = quantity
                };
                _facade.UpdateLuggage(updatedLuggage);
            }

            LoadLuggages();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewLuggages.CurrentRow?.DataBoundItem is Luggage selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete luggage ID '{selected.LuggageId}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteLuggage(selected.LuggageId);
                    LoadLuggages();
                }
            }
            else
            {
                MessageBox.Show("Please select a luggage to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewLuggages_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLuggages.CurrentRow?.DataBoundItem is Luggage selected)
            {
                textBoxTicketId.Text = selected.TicketId.ToString();
                textBoxLuggageTypeId.Text = selected.LuggageTypeId.ToString();
                numericUpDownQuantity.Value = selected.Quantity;
                editingId = selected.LuggageId;
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
            dataGridViewLuggages.ClearSelection();
            textBoxTicketId.Text = "";
            textBoxLuggageTypeId.Text = "";
            numericUpDownQuantity.Value = 1;
            editingId = null;
            SetFormEnabled(false);
            buttonCancel.Visible = false;
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }
    }
}