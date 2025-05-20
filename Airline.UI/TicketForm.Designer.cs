namespace Airline.UI
{
    partial class TicketForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInputs;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.Label labelFlightId;
        private System.Windows.Forms.TextBox textBoxFlightId;
        private System.Windows.Forms.Label labelStatusId;
        private System.Windows.Forms.TextBox textBoxStatusId;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.TextBox textBoxSeat;
        private System.Windows.Forms.Label labelSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaleDate;
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
            dataGridViewTickets = new System.Windows.Forms.DataGridView();
            tableLayoutPanelInputs = new System.Windows.Forms.TableLayoutPanel();
            labelCustomerId = new System.Windows.Forms.Label();
            textBoxCustomerId = new System.Windows.Forms.TextBox();
            labelFlightId = new System.Windows.Forms.Label();
            textBoxFlightId = new System.Windows.Forms.TextBox();
            labelStatusId = new System.Windows.Forms.Label();
            textBoxStatusId = new System.Windows.Forms.TextBox();
            labelPrice = new System.Windows.Forms.Label();
            numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            labelSeat = new System.Windows.Forms.Label();
            textBoxSeat = new System.Windows.Forms.TextBox();
            labelSaleDate = new System.Windows.Forms.Label();
            dateTimePickerSaleDate = new System.Windows.Forms.DateTimePicker();
            flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            buttonAddNew = new System.Windows.Forms.Button();
            buttonSave = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownPrice)).BeginInit();
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
            tableLayoutPanelMain.Controls.Add(dataGridViewTickets, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelInputs, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanelButtons, 0, 2);

            // dataGridViewTickets
            dataGridViewTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewTickets.AllowUserToAddRows = false;
            dataGridViewTickets.AllowUserToDeleteRows = false;
            dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.MultiSelect = false;
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.ReadOnly = true;
            dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTickets.TabIndex = 0;
            dataGridViewTickets.SelectionChanged += new System.EventHandler(this.dataGridViewTickets_SelectionChanged);

            // tableLayoutPanelInputs
            tableLayoutPanelInputs.Anchor = System.Windows.Forms.AnchorStyles.None;
            tableLayoutPanelInputs.AutoSize = true;
            tableLayoutPanelInputs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanelInputs.ColumnCount = 2;
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanelInputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanelInputs.Controls.Add(labelCustomerId, 0, 0);
            tableLayoutPanelInputs.Controls.Add(textBoxCustomerId, 1, 0);
            tableLayoutPanelInputs.Controls.Add(labelFlightId, 0, 1);
            tableLayoutPanelInputs.Controls.Add(textBoxFlightId, 1, 1);
            tableLayoutPanelInputs.Controls.Add(labelStatusId, 0, 2);
            tableLayoutPanelInputs.Controls.Add(textBoxStatusId, 1, 2);
            tableLayoutPanelInputs.Controls.Add(labelPrice, 0, 3);
            tableLayoutPanelInputs.Controls.Add(numericUpDownPrice, 1, 3);
            tableLayoutPanelInputs.Controls.Add(labelSeat, 0, 4);
            tableLayoutPanelInputs.Controls.Add(textBoxSeat, 1, 4);
            tableLayoutPanelInputs.Controls.Add(labelSaleDate, 0, 5);
            tableLayoutPanelInputs.Controls.Add(dateTimePickerSaleDate, 1, 5);
            tableLayoutPanelInputs.RowCount = 6;
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            tableLayoutPanelInputs.Name = "tableLayoutPanelInputs";
            tableLayoutPanelInputs.TabIndex = 1;

            // labelCustomerId
            labelCustomerId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelCustomerId.AutoSize = true;
            labelCustomerId.Text = "Customer ID:";

            // textBoxCustomerId
            textBoxCustomerId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxCustomerId.Size = new System.Drawing.Size(250, 27);

            // labelFlightId
            labelFlightId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelFlightId.AutoSize = true;
            labelFlightId.Text = "Flight ID:";

            // textBoxFlightId
            textBoxFlightId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxFlightId.Size = new System.Drawing.Size(250, 27);

            // labelStatusId
            labelStatusId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelStatusId.AutoSize = true;
            labelStatusId.Text = "Status ID:";

            // textBoxStatusId
            textBoxStatusId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxStatusId.Size = new System.Drawing.Size(250, 27);

            // labelPrice
            labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelPrice.AutoSize = true;
            labelPrice.Text = "Price:";

            // numericUpDownPrice
            numericUpDownPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Minimum = 0;
            numericUpDownPrice.Maximum = 1000000;
            numericUpDownPrice.Value = 0;
            numericUpDownPrice.Size = new System.Drawing.Size(120, 27);

            // labelSeat
            labelSeat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelSeat.AutoSize = true;
            labelSeat.Text = "Assigned Seat:";

            // textBoxSeat
            textBoxSeat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            textBoxSeat.Size = new System.Drawing.Size(120, 27);

            // labelSaleDate
            labelSaleDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelSaleDate.AutoSize = true;
            labelSaleDate.Text = "Sale Date:";

            // dateTimePickerSaleDate
            dateTimePickerSaleDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dateTimePickerSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerSaleDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePickerSaleDate.Size = new System.Drawing.Size(180, 27);

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
            buttonAddNew.Text = "Add new ticket";
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

            // TicketForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 480);
            Controls.Add(tableLayoutPanelMain);
            Name = "TicketForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)(dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericUpDownPrice)).EndInit();
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            tableLayoutPanelInputs.ResumeLayout(false);
            tableLayoutPanelInputs.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}