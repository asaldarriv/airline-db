using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class LuggageSelectionForm : Form
    {
        private readonly Flight _flight;
        private readonly LuggageTypeFacade _luggageTypeFacade = new();
        private readonly List<Luggage> _selectedLuggages = new();

        public List<Luggage> SelectedLuggages => _selectedLuggages;

        public LuggageSelectionForm(Flight flight)
        {
            InitializeComponent();
            _flight = flight;
            LoadLuggageTypes();
        }

        private void LoadLuggageTypes()
        {
            var types = _luggageTypeFacade.GetAllLuggageTypes().Where(t => t.IsActive).ToList();
            comboBoxLuggageType.DataSource = types;
            comboBoxLuggageType.DisplayMember = "Name";
            comboBoxLuggageType.ValueMember = "LuggageTypeId";
        }

        private void buttonAddLuggage_Click(object sender, EventArgs e)
        {
            if (comboBoxLuggageType.SelectedItem is not LuggageType selectedType)
            {
                MessageBox.Show("Please select a luggage type.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantity = (int)numericUpDownQuantity.Value;
            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Permitir varios del mismo tipo, sumando cantidades si ya existe
            var existing = _selectedLuggages.FirstOrDefault(l => l.LuggageTypeId == selectedType.LuggageTypeId);
            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                _selectedLuggages.Add(new Luggage
                {
                    LuggageTypeId = selectedType.LuggageTypeId,
                    Quantity = quantity
                });
            }

            RefreshLuggageList();
        }

        private void RefreshLuggageList()
        {
            var types = _luggageTypeFacade.GetAllLuggageTypes().ToList();
            var display = _selectedLuggages
                .Select(l => new
                {
                    Type = types.FirstOrDefault(t => t.LuggageTypeId == l.LuggageTypeId)?.Name ?? "Unknown",
                    Quantity = l.Quantity
                })
                .ToList();

            dataGridViewSelectedLuggages.DataSource = null;
            dataGridViewSelectedLuggages.DataSource = display;
            dataGridViewSelectedLuggages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dataGridViewSelectedLuggages.CurrentRow == null)
                return;

            string? typeName = dataGridViewSelectedLuggages.CurrentRow.Cells["Type"].Value as string;
            var types = _luggageTypeFacade.GetAllLuggageTypes().ToList();
            var type = types.FirstOrDefault(t => t.Name == typeName);
            if (type != null)
            {
                var toRemove = _selectedLuggages.FirstOrDefault(l => l.LuggageTypeId == type.LuggageTypeId);
                if (toRemove != null)
                {
                    _selectedLuggages.Remove(toRemove);
                    RefreshLuggageList();
                }
            }
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (_selectedLuggages.Count == 0)
            {
                var confirm = MessageBox.Show("No luggages selected. Continue anyway?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes)
                    return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}