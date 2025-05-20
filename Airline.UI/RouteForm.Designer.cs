namespace Airline.UI
{
    partial class RouteForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewRoutes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
        private System.Windows.Forms.Label labelOriginCityId;
        private System.Windows.Forms.TextBox textBoxOriginCityId;
        private System.Windows.Forms.Label labelDestinationCityId;
        private System.Windows.Forms.TextBox textBoxDestinationCityId;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            dataGridViewRoutes = new System.Windows.Forms.DataGridView();
            tableLayoutPanelInputs = new System.Windows.Forms.TableLayoutPanel();
            labelOriginCityId = new System.Windows.Forms.Label();
            textBoxOriginCityId = new System.Windows.Forms.TextBox();
            labelDestinationCityId = new System.Windows.Forms.Label();
            textBoxDestinationCityId = new System.Windows.Forms.TextBox();
            flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            buttonAddNew = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(dataGridViewRoutes)).BeginInit();
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelInputs.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            SuspendLayout();

            // tableLayoutPanelMain
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(dataGridViewRoutes, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInputs, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanelButtons, 0, 2);

            // dataGridViewRoutes
            dataGridViewRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewRoutes.AllowUserToAddRows = false;
            dataGridViewRoutes.AllowUserToDeleteRows = false;
            dataGridViewRoutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes.MultiSelect = false;
            dataGridViewRoutes.Name = "dataGridViewRoutes";
            dataGridViewRoutes.ReadOnly = true;
            dataGridViewRoutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRoutes.TabIndex = 0;
            dataGridViewRoutes.SelectionChanged += new System.EventHandler(this.dataGridViewRoutes_SelectionChanged);

            // tableLayoutPanelInputs
            tableLayoutPanelInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanelInputs.AutoSize = true;
            tableLayoutPanelInputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanelInputs.Controls.Add(labelOriginCityId, 0, 0);
            tableLayoutPanelInputs.Controls.Add(textBoxOriginCityId, 1, 0);
            tableLayoutPanelInputs.Controls.Add(labelDestinationCityId, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxDestinationCityId, 1, 1);
            tableLayoutPanelInputs.RowCount = 2;
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.TabIndex = 1;

            // labelOriginCityId
            labelOriginCityId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelOriginCityId.AutoSize = true;
            labelOriginCityId.Text = "Origin City ID:";

            // textBoxOriginCityId
            textBoxOriginCityId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxOriginCityId.Size = new System.Drawing.Size(250, 27);

            // labelDestinationCityId
            labelDestinationCityId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelDestinationCityId.AutoSize = true;
            labelDestinationCityId.Text = "Destination City ID:";

            // textBoxDestinationCityId
            textBoxDestinationCityId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxDestinationCityId.Size = new System.Drawing.Size(250, 27);

            // flowLayoutPanelButtons
            flowLayoutPanelButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            flowLayoutPanelButtons.AutoSize = true;
            flowLayoutPanelButtons.Controls.Add(buttonAddNew);
            flowLayoutPanelButtons.Controls.Add(buttonSave);
            flowLayoutPanelButtons.Controls.Add(buttonDelete);
            flowLayoutPanelButtons.Controls.Add(buttonCancel);
            flowLayoutPanelButtons.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.TabIndex = 2;
            flowLayoutPanelButtons.WrapContents = false;

            // buttonAddNew
            buttonAddNew.Size = new System.Drawing.Size(120, 35);
            buttonAddNew.Text = "Add new route";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += buttonAddNew_Click;

            // buttonSave
            buttonSave.Size = new System.Drawing.Size(80, 35);
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;

            // buttonDelete
            buttonDelete.Size = new System.Drawing.Size(80, 35);
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;

            // buttonCancel
            buttonCancel.Size = new System.Drawing.Size(80, 35);
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;

            // RouteForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(600, 400);
            Controls.Add(tableLayoutPanelMain);
            Name = "RouteForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Routes";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewRoutes)).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}