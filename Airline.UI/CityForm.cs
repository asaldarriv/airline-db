using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class CityForm : Form
    {
        private readonly CityFacade _facade = new();
        private int? editingId = null;

        public CityForm()
        {
            InitializeComponent();
            LoadCities();
            SetFormEnabled(false);
        }

        private void LoadCities()
        {
            var list = _facade.GetAllCities().ToList();
            dataGridViewCities.DataSource = null;
            dataGridViewCities.DataSource = list;
            dataGridViewCities.Columns["CityId"].HeaderText = "ID";
            dataGridViewCities.Columns["Name"].HeaderText = "Name";
            dataGridViewCities.Columns["IsActive"].HeaderText = "Active";
            dataGridViewCities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCities.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingId = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxName.Enabled = enabled;
            checkBoxActive.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewCities.ClearSelection();
            textBoxName.Text = "";
            checkBoxActive.Checked = true;
            editingId = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxName.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text.Trim();
            var isActive = checkBoxActive.Checked;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingId == null)
            {
                var newCity = new City
                {
                    Name = name,
                    IsActive = isActive
                };
                _facade.AddCity(newCity);
            }
            else
            {
                var updatedCity = new City
                {
                    CityId = editingId.Value,
                    Name = name,
                    IsActive = isActive
                };
                _facade.UpdateCity(updatedCity);
            }

            LoadCities();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCities.CurrentRow?.DataBoundItem is City selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete '{selected.Name}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteCity(selected.CityId);
                    LoadCities();
                }
            }
            else
            {
                MessageBox.Show("Please select a city to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewCities_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCities.CurrentRow?.DataBoundItem is City selected)
            {
                textBoxName.Text = selected.Name;
                checkBoxActive.Checked = selected.IsActive;
                editingId = selected.CityId;
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
            dataGridViewCities.ClearSelection();
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