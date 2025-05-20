namespace Airline.UI
{
    partial class FlightForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewFlights;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
        private System.Windows.Forms.Label labelAirplaneId;
        private System.Windows.Forms.TextBox textBoxAirplaneId;
        private System.Windows.Forms.Label labelRouteId;
        private System.Windows.Forms.TextBox textBoxRouteId;
        private System.Windows.Forms.Label labelStatusId;
        private System.Windows.Forms.TextBox textBoxStatusId;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
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
            dataGridViewFlights = new System.Windows.Forms.DataGridView();
            tableLayoutPanelInputs = new System.Windows.Forms.TableLayoutPanel();
            labelAirplaneId = new System.Windows.Forms.Label();
            textBoxAirplaneId = new System.Windows.Forms.TextBox();
            labelRouteId = new System.Windows.Forms.Label();
            textBoxRouteId = new System.Windows.Forms.TextBox();
            labelStatusId = new System.Windows.Forms.Label();
            textBoxStatusId = new System.Windows.Forms.TextBox();
            labelDeparture = new System.Windows.Forms.Label();
            dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            labelArrival = new System.Windows.Forms.Label();
            dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            buttonAddNew = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(dataGridViewFlights)).BeginInit();
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
            tableLayoutPanelMain.Controls.Add(dataGridViewFlights, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInputs, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanelButtons, 0, 2);

            // dataGridViewFlights
            dataGridViewFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewFlights.AllowUserToAddRows = false;
            dataGridViewFlights.AllowUserToDeleteRows = false;
            dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFlights.MultiSelect = false;
            dataGridViewFlights.Name = "dataGridViewFlights";
            dataGridViewFlights.ReadOnly = true;
            dataGridViewFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFlights.TabIndex = 0;
            dataGridViewFlights.SelectionChanged += new System.EventHandler(this.dataGridViewFlights_SelectionChanged);

            // tableLayoutPanelInputs
            tableLayoutPanelInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanelInputs.AutoSize = true;
            tableLayoutPanelInputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanelInputs.Controls.Add(labelAirplaneId, 0, 0);
            tableLayoutPanelInputs.Controls.Add(textBoxAirplaneId, 1, 0);
            tableLayoutPanelInputs.Controls.Add(labelRouteId, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxRouteId, 1, 1);
            tableLayoutPanelInputs.Controls.Add(labelStatusId, 0, 2);
            tableLayoutPanelInputs.Controls.Add(textBoxStatusId, 1, 2);
            tableLayoutPanelInputs.Controls.Add(labelDeparture, 0, 3);
            tableLayoutPanelInputs.Controls.Add(dateTimePickerDeparture, 1, 3);
            tableLayoutPanelInputs.Controls.Add(labelArrival, 0, 4);
            tableLayoutPanelInputs.Controls.Add(dateTimePickerArrival, 1, 4);
            tableLayoutPanelInputs.RowCount = 5;
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.TabIndex = 1;

            // labelAirplaneId
            labelAirplaneId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelAirplaneId.AutoSize = true;
            labelAirplaneId.Text = "Airplane ID:";

            // textBoxAirplaneId
            textBoxAirplaneId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxAirplaneId.Size = new System.Drawing.Size(250, 27);

            // labelRouteId
            labelRouteId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelRouteId.AutoSize = true;
            labelRouteId.Text = "Route ID:";

            // textBoxRouteId
            textBoxRouteId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxRouteId.Size = new System.Drawing.Size(250, 27);

            // labelStatusId
            labelStatusId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelStatusId.AutoSize = true;
            labelStatusId.Text = "Status ID:";

            // textBoxStatusId
            textBoxStatusId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxStatusId.Size = new System.Drawing.Size(250, 27);

            // labelDeparture
            labelDeparture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelDeparture.AutoSize = true;
            labelDeparture.Text = "Departure:";

            // dateTimePickerDeparture
            dateTimePickerDeparture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dateTimePickerDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerDeparture.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePickerDeparture.Size = new System.Drawing.Size(180, 27);

            // labelArrival
            labelArrival.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelArrival.AutoSize = true;
            labelArrival.Text = "Arrival:";

            // dateTimePickerArrival
            dateTimePickerArrival.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dateTimePickerArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerArrival.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePickerArrival.Size = new System.Drawing.Size(180, 27);

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
            buttonAddNew.Text = "Add new flight";
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

            // FlightForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 480);
            Controls.Add(tableLayoutPanelMain);
            Name = "FlightForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Flights";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewFlights)).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}