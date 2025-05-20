namespace Airline.UI
{
    partial class LayoverForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewLayovers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
        private System.Windows.Forms.Label labelRouteId;
        private System.Windows.Forms.TextBox textBoxRouteId;
        private System.Windows.Forms.Label labelCityId;
        private System.Windows.Forms.TextBox textBoxCityId;
        private System.Windows.Forms.Label labelStopOrder;
        private System.Windows.Forms.NumericUpDown numericUpDownStopOrder;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDuration;
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
            dataGridViewLayovers = new System.Windows.Forms.DataGridView();
            tableLayoutPanelInputs = new System.Windows.Forms.TableLayoutPanel();
            labelRouteId = new System.Windows.Forms.Label();
            textBoxRouteId = new System.Windows.Forms.TextBox();
            labelCityId = new System.Windows.Forms.Label();
            textBoxCityId = new System.Windows.Forms.TextBox();
            labelStopOrder = new System.Windows.Forms.Label();
            numericUpDownStopOrder = new System.Windows.Forms.NumericUpDown();
            labelArrival = new System.Windows.Forms.Label();
            dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            labelDeparture = new System.Windows.Forms.Label();
            dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            labelDuration = new System.Windows.Forms.Label();
            maskedTextBoxDuration = new System.Windows.Forms.MaskedTextBox();
            flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            buttonAddNew = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(dataGridViewLayovers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownStopOrder)).BeginInit();
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
            tableLayoutPanelMain.Controls.Add(dataGridViewLayovers, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInputs, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanelButtons, 0, 2);

            // dataGridViewLayovers
            dataGridViewLayovers.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewLayovers.AllowUserToAddRows = false;
            dataGridViewLayovers.AllowUserToDeleteRows = false;
            dataGridViewLayovers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLayovers.MultiSelect = false;
            dataGridViewLayovers.Name = "dataGridViewLayovers";
            dataGridViewLayovers.ReadOnly = true;
            dataGridViewLayovers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLayovers.TabIndex = 0;
            dataGridViewLayovers.SelectionChanged += new System.EventHandler(this.dataGridViewLayovers_SelectionChanged);

            // tableLayoutPanelInputs
            tableLayoutPanelInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanelInputs.AutoSize = true;
            tableLayoutPanelInputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanelInputs.Controls.Add(labelRouteId, 0, 0);
            tableLayoutPanelInputs.Controls.Add(textBoxRouteId, 1, 0);
            tableLayoutPanelInputs.Controls.Add(labelCityId, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxCityId, 1, 1);
            tableLayoutPanelInputs.Controls.Add(labelStopOrder, 0, 2);
            tableLayoutPanelInputs.Controls.Add(numericUpDownStopOrder, 1, 2);
            tableLayoutPanelInputs.Controls.Add(labelArrival, 0, 3);
            tableLayoutPanelInputs.Controls.Add(dateTimePickerArrival, 1, 3);
            tableLayoutPanelInputs.Controls.Add(labelDeparture, 0, 4);
            tableLayoutPanelInputs.Controls.Add(dateTimePickerDeparture, 1, 4);
            tableLayoutPanelInputs.Controls.Add(labelDuration, 0, 5);
            tableLayoutPanelInputs.Controls.Add(maskedTextBoxDuration, 1, 5);
            tableLayoutPanelInputs.RowCount = 6;
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.TabIndex = 1;

            // labelRouteId
            labelRouteId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelRouteId.AutoSize = true;
            labelRouteId.Text = "Route ID:";

            // textBoxRouteId
            textBoxRouteId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxRouteId.Size = new System.Drawing.Size(250, 27);

            // labelCityId
            labelCityId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelCityId.AutoSize = true;
            labelCityId.Text = "City ID:";

            // textBoxCityId
            textBoxCityId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxCityId.Size = new System.Drawing.Size(250, 27);

            // labelStopOrder
            labelStopOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelStopOrder.AutoSize = true;
            labelStopOrder.Text = "Stop Order:";

            // numericUpDownStopOrder
            numericUpDownStopOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numericUpDownStopOrder.Minimum = 1;
            numericUpDownStopOrder.Maximum = 100;
            numericUpDownStopOrder.Value = 1;
            numericUpDownStopOrder.Size = new System.Drawing.Size(80, 27);

            // labelArrival
            labelArrival.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelArrival.AutoSize = true;
            labelArrival.Text = "Arrival Time:";

            // dateTimePickerArrival
            dateTimePickerArrival.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dateTimePickerArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerArrival.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePickerArrival.Size = new System.Drawing.Size(180, 27);

            // labelDeparture
            labelDeparture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelDeparture.AutoSize = true;
            labelDeparture.Text = "Departure Time:";

            // dateTimePickerDeparture
            dateTimePickerDeparture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dateTimePickerDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerDeparture.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePickerDeparture.Size = new System.Drawing.Size(180, 27);

            // labelDuration
            labelDuration.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelDuration.AutoSize = true;
            labelDuration.Text = "Duration (hh:mm:ss):";

            // maskedTextBoxDuration
            maskedTextBoxDuration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            maskedTextBoxDuration.Mask = "00:00:00";
            maskedTextBoxDuration.Size = new System.Drawing.Size(80, 27);

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
            buttonAddNew.Text = "Add new layover";
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

            // LayoverForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 480);
            Controls.Add(tableLayoutPanelMain);
            Name = "LayoverForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Layovers";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewLayovers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownStopOrder)).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}