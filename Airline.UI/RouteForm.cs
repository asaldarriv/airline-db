using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class RouteForm : Form
    {
        private readonly RouteFacade _facade = new();
        private int? editingId = null;

        public RouteForm()
        {
            InitializeComponent();
            LoadRoutes();
            SetFormEnabled(false);
        }

        private void LoadRoutes()
        {
            var list = _facade.GetAllRoutes().ToList();
            dataGridViewRoutes.DataSource = null;
            dataGridViewRoutes.DataSource = list;
            dataGridViewRoutes.Columns["RouteId"].HeaderText = "ID";
            dataGridViewRoutes.Columns["OriginCityId"].HeaderText = "Origin City ID";
            dataGridViewRoutes.Columns["DestinationCityId"].HeaderText = "Destination City ID";
            dataGridViewRoutes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRoutes.ClearSelection();
            SetFormEnabled(false);
            buttonSave.Text = "Save";
            buttonCancel.Visible = false;
            editingId = null;
        }

        private void SetFormEnabled(bool enabled)
        {
            textBoxOriginCityId.Enabled = enabled;
            textBoxDestinationCityId.Enabled = enabled;
            buttonSave.Enabled = enabled;
            buttonCancel.Enabled = enabled;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            dataGridViewRoutes.ClearSelection();
            textBoxOriginCityId.Text = "";
            textBoxDestinationCityId.Text = "";
            editingId = null;
            SetFormEnabled(true);
            buttonSave.Text = "Save";
            buttonCancel.Visible = true;
            buttonAddNew.Enabled = false;
            buttonDelete.Visible = false;
            textBoxOriginCityId.Focus();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int? originId = null, destId = null;
            if (!string.IsNullOrWhiteSpace(textBoxOriginCityId.Text))
            {
                if (!int.TryParse(textBoxOriginCityId.Text, out int parsedOrigin))
                {
                    MessageBox.Show("Origin City ID must be a valid integer or empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                originId = parsedOrigin;
            }
            if (!string.IsNullOrWhiteSpace(textBoxDestinationCityId.Text))
            {
                if (!int.TryParse(textBoxDestinationCityId.Text, out int parsedDest))
                {
                    MessageBox.Show("Destination City ID must be a valid integer or empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                destId = parsedDest;
            }

            if (editingId == null)
            {
                var newRoute = new Route
                {
                    OriginCityId = originId,
                    DestinationCityId = destId
                };
                _facade.AddRoute(newRoute);
            }
            else
            {
                var updatedRoute = new Route
                {
                    RouteId = editingId.Value,
                    OriginCityId = originId,
                    DestinationCityId = destId
                };
                _facade.UpdateRoute(updatedRoute);
            }

            LoadRoutes();
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRoutes.CurrentRow?.DataBoundItem is Route selected)
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete route ID '{selected.RouteId}'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _facade.DeleteRoute(selected.RouteId);
                    LoadRoutes();
                }
            }
            else
            {
                MessageBox.Show("Please select a route to delete.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewRoutes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRoutes.CurrentRow?.DataBoundItem is Route selected)
            {
                textBoxOriginCityId.Text = selected.OriginCityId?.ToString() ?? "";
                textBoxDestinationCityId.Text = selected.DestinationCityId?.ToString() ?? "";
                editingId = selected.RouteId;
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
            dataGridViewRoutes.ClearSelection();
            textBoxOriginCityId.Text = "";
            textBoxDestinationCityId.Text = "";
            editingId = null;
            SetFormEnabled(false);
            buttonCancel.Visible = false;
            buttonAddNew.Enabled = true;
            buttonSave.Text = "Save";
            buttonDelete.Visible = false;
        }
    }
}