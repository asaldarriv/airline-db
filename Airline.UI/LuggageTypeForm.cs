using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class LuggageTypeForm : Form
    {
        private readonly LuggageTypeFacade _facade = new();
        private int? editingId = null;

        public LuggageTypeForm()
        {
            InitializeComponent();
            LoadLuggageTypes();
            SetFormEnabled(false);
        }

        private void LoadLuggageTypes()
        {
            var list = _facade.GetAllLuggageTypes().ToList();
            dataGridViewLuggageTypes.DataSource = null;
            dataGridViewLuggageTypes.DataSource = list;
            dataGridViewLuggageTypes.Columns["LuggageTypeId"].HeaderText = "ID";
            dataGridViewLuggageTypes.Columns["TypeCode"].HeaderText = "Code";
            dataGridViewLuggageTypes.Columns["Name"].HeaderText = "Name";
            dataGridViewLuggageTypes.Columns["Description"].HeaderText = "Description";
            dataGridViewLuggageTypes.Columns["IsActive"].HeaderText = "Active";
            dataGridViewLuggageTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLuggageTypes.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingId = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxCode.Enabled = enabled;
            textBoxName.Enabled = enabled;
            textBoxDescription.Enabled = enabled;
            checkBoxActive.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewLuggageTypes.ClearSelection();
            textBoxCode.Text = "";
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            checkBoxActive.Checked = true;
            editingId = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxCode.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var code = textBoxCode.Text.Trim();
            var name = textBoxName.Text.Trim();
            var description = textBoxDescription.Text.Trim();
            var isActive = checkBoxActive.Checked;

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Code and Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingId == null)
            {
                var newType = new LuggageType
                {
                    TypeCode = code,
                    Name = name,
                    Description = description,
                    IsActive = isActive
                };
                _facade.AddLuggageType(newType);
            }
            else
            {
                var updatedType = new LuggageType
                {
                    LuggageTypeId = editingId.Value,
                    TypeCode = code,
                    Name = name,
                    Description = description,
                    IsActive = isActive
                };
                _facade.UpdateLuggageType(updatedType);
            }

            LoadLuggageTypes();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewLuggageTypes.CurrentRow?.DataBoundItem is LuggageType selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete '{selected.Name}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteLuggageType(selected.LuggageTypeId);
                    LoadLuggageTypes();
                }
            }
            else
            {
                MessageBox.Show("Please select a luggage type to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewLuggageTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLuggageTypes.CurrentRow?.DataBoundItem is LuggageType selected)
            {
                textBoxCode.Text = selected.TypeCode;
                textBoxName.Text = selected.Name;
                textBoxDescription.Text = selected.Description;
                checkBoxActive.Checked = selected.IsActive;
                editingId = selected.LuggageTypeId;
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
            dataGridViewLuggageTypes.ClearSelection();
            textBoxCode.Text = "";
            textBoxName.Text = "";
            textBoxDescription.Text = "";
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