using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class RoleForm : Form
    {
        private readonly RoleFacade _facade = new();
        private int? editingId = null;

        public RoleForm()
        {
            InitializeComponent();
            LoadRoles();
            SetFormEnabled(false);
        }

        private void LoadRoles()
        {
            var list = _facade.GetAllRoles().ToList();
            dataGridViewRoles.DataSource = null;
            dataGridViewRoles.DataSource = list;
            dataGridViewRoles.Columns["RoleId"].HeaderText = "ID";
            dataGridViewRoles.Columns["Code"].HeaderText = "Code";
            dataGridViewRoles.Columns["Name"].HeaderText = "Name";
            dataGridViewRoles.Columns["Description"].HeaderText = "Description";
            dataGridViewRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRoles.ClearSelection();
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
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewRoles.ClearSelection();
            textBoxCode.Text = "";
            textBoxName.Text = "";
            textBoxDescription.Text = "";
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

            if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Code and Name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingId == null)
            {
                var newRole = new Role
                {
                    Code = code,
                    Name = name,
                    Description = description
                };
                _facade.AddRole(newRole);
            }
            else
            {
                var updatedRole = new Role
                {
                    RoleId = editingId.Value,
                    Code = code,
                    Name = name,
                    Description = description
                };
                _facade.UpdateRole(updatedRole);
            }

            LoadRoles();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoles.CurrentRow?.DataBoundItem is Role selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete '{selected.Name}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteRole(selected.RoleId);
                    LoadRoles();
                }
            }
            else
            {
                MessageBox.Show("Please select a role to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRoles.CurrentRow?.DataBoundItem is Role selected)
            {
                textBoxCode.Text = selected.Code;
                textBoxName.Text = selected.Name;
                textBoxDescription.Text = selected.Description;
                editingId = selected.RoleId;
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
            dataGridViewRoles.ClearSelection();
            textBoxCode.Text = "";
            textBoxName.Text = "";
            textBoxDescription.Text = "";
            editingId = null;
            SetFormEnabled(false);
            buttonCancel.Visible = false;
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }
    }
}