using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class CountryForm : Form
    {
        private readonly CountryFacade _facade = new();
        private int? editingId = null;

        public CountryForm()
        {
            InitializeComponent();
            LoadCountries();
            SetFormEnabled(false);
        }

        private void LoadCountries()
        {
            var list = _facade.GetAllCountries().ToList();
            dataGridViewCountries.DataSource = null;
            dataGridViewCountries.DataSource = list;
            dataGridViewCountries.Columns["CountryId"].HeaderText = "ID";
            dataGridViewCountries.Columns["IsoCode"].HeaderText = "ISO Code";
            dataGridViewCountries.Columns["Name"].HeaderText = "Name";
            dataGridViewCountries.Columns["IsActive"].HeaderText = "Active";
            dataGridViewCountries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCountries.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingId = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxIsoCode.Enabled = enabled;
            textBoxName.Enabled = enabled;
            checkBoxActive.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewCountries.ClearSelection();
            textBoxIsoCode.Text = "";
            textBoxName.Text = "";
            checkBoxActive.Checked = true;
            editingId = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxIsoCode.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var iso = textBoxIsoCode.Text.Trim();
            var name = textBoxName.Text.Trim();
            var isActive = checkBoxActive.Checked;

            if (string.IsNullOrWhiteSpace(iso) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("ISO Code and Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingId == null)
            {
                var newCountry = new Country
                {
                    IsoCode = iso,
                    Name = name,
                    IsActive = isActive
                };
                _facade.AddCountry(newCountry);
            }
            else
            {
                var updatedCountry = new Country
                {
                    CountryId = editingId.Value,
                    IsoCode = iso,
                    Name = name,
                    IsActive = isActive
                };
                _facade.UpdateCountry(updatedCountry);
            }

            LoadCountries();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCountries.CurrentRow?.DataBoundItem is Country selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete '{selected.Name}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteCountry(selected.CountryId);
                    LoadCountries();
                }
            }
            else
            {
                MessageBox.Show("Please select a country to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewCountries_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCountries.CurrentRow?.DataBoundItem is Country selected)
            {
                textBoxIsoCode.Text = selected.IsoCode;
                textBoxName.Text = selected.Name;
                checkBoxActive.Checked = selected.IsActive;
                editingId = selected.CountryId;
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
            dataGridViewCountries.ClearSelection();
            textBoxIsoCode.Text = "";
            textBoxName.Text = "";
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