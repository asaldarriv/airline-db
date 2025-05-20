namespace Airline.UI
{
    partial class AirplaneForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewAirplanes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.TextBox textBoxRegistration;
        private System.Windows.Forms.Label labelStatusId;
        private System.Windows.Forms.TextBox textBoxStatusId;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelAcquisitionDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAcquisition;
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
            dataGridViewAirplanes = new System.Windows.Forms.DataGridView();
            tableLayoutPanelInputs = new System.Windows.Forms.TableLayoutPanel();
            labelRegistration = new System.Windows.Forms.Label();
            textBoxRegistration = new System.Windows.Forms.TextBox();
            labelStatusId = new System.Windows.Forms.Label();
            textBoxStatusId = new System.Windows.Forms.TextBox();
            labelCapacity = new System.Windows.Forms.Label();
            numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            labelManufacturer = new System.Windows.Forms.Label();
            textBoxManufacturer = new System.Windows.Forms.TextBox();
            labelModel = new System.Windows.Forms.Label();
            textBoxModel = new System.Windows.Forms.TextBox();
            labelAcquisitionDate = new System.Windows.Forms.Label();
            dateTimePickerAcquisition = new System.Windows.Forms.DateTimePicker();
            flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            buttonAddNew = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(dataGridViewAirplanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownCapacity)).BeginInit();
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
            tableLayoutPanelMain.Controls.Add(dataGridViewAirplanes, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInputs, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanelButtons, 0, 2);

            // dataGridViewAirplanes
            dataGridViewAirplanes.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewAirplanes.AllowUserToAddRows = false;
            dataGridViewAirplanes.AllowUserToDeleteRows = false;
            dataGridViewAirplanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAirplanes.MultiSelect = false;
            dataGridViewAirplanes.Name = "dataGridViewAirplanes";
            dataGridViewAirplanes.ReadOnly = true;
            dataGridViewAirplanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAirplanes.TabIndex = 0;
            dataGridViewAirplanes.SelectionChanged += new System.EventHandler(this.dataGridViewAirplanes_SelectionChanged);

            // tableLayoutPanelInputs
            tableLayoutPanelInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanelInputs.AutoSize = true;
            tableLayoutPanelInputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanelInputs.Controls.Add(labelRegistration, 0, 0);
            tableLayoutPanelInputs.Controls.Add(textBoxRegistration, 1, 0);
            tableLayoutPanelInputs.Controls.Add(labelStatusId, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxStatusId, 1, 1);
            tableLayoutPanelInputs.Controls.Add(labelCapacity, 0, 2);
            tableLayoutPanelInputs.Controls.Add(numericUpDownCapacity, 1, 2);
            tableLayoutPanelInputs.Controls.Add(labelManufacturer, 0, 3);
            tableLayoutPanelInputs.Controls.Add(textBoxManufacturer, 1, 3);
            tableLayoutPanelInputs.Controls.Add(labelModel, 0, 4);
            tableLayoutPanelInputs.Controls.Add(textBoxModel, 1, 4);
            tableLayoutPanelInputs.Controls.Add(labelAcquisitionDate, 0, 5);
            tableLayoutPanelInputs.Controls.Add(dateTimePickerAcquisition, 1, 5);
            tableLayoutPanelInputs.RowCount = 6;
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.TabIndex = 1;

            // labelRegistration
            labelRegistration.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelRegistration.AutoSize = true;
            labelRegistration.Text = "Registration:";

            // textBoxRegistration
            textBoxRegistration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxRegistration.Size = new System.Drawing.Size(250, 27);

            // labelStatusId
            labelStatusId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelStatusId.AutoSize = true;
            labelStatusId.Text = "Status ID:";

            // textBoxStatusId
            textBoxStatusId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxStatusId.Size = new System.Drawing.Size(250, 27);

            // labelCapacity
            labelCapacity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelCapacity.AutoSize = true;
            labelCapacity.Text = "Capacity:";

            // numericUpDownCapacity
            numericUpDownCapacity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numericUpDownCapacity.Minimum = 1;
            numericUpDownCapacity.Maximum = 1000;
            numericUpDownCapacity.Value = 1;
            numericUpDownCapacity.Size = new System.Drawing.Size(80, 27);

            // labelManufacturer
            labelManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelManufacturer.AutoSize = true;
            labelManufacturer.Text = "Manufacturer:";

            // textBoxManufacturer
            textBoxManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxManufacturer.Size = new System.Drawing.Size(250, 27);

            // labelModel
            labelModel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelModel.AutoSize = true;
            labelModel.Text = "Model:";

            // textBoxModel
            textBoxModel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxModel.Size = new System.Drawing.Size(250, 27);

            // labelAcquisitionDate
            labelAcquisitionDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelAcquisitionDate.AutoSize = true;
            labelAcquisitionDate.Text = "Acquisition Date:";

            // dateTimePickerAcquisition
            dateTimePickerAcquisition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dateTimePickerAcquisition.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerAcquisition.Size = new System.Drawing.Size(150, 27);

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
            buttonAddNew.Text = "Add new airplane";
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

            // AirplaneForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 520);
            Controls.Add(tableLayoutPanelMain);
            Name = "AirplaneForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Airplanes";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewAirplanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownCapacity)).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}