namespace Airline.UI
{
    partial class TicketPurchaseForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.ComboBox comboBoxOrigin;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonSearchFlights;
        private System.Windows.Forms.DataGridView dataGridViewFlights;
        private System.Windows.Forms.Button buttonSelectFlight;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.comboBoxOrigin = new System.Windows.Forms.ComboBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSearchFlights = new System.Windows.Forms.Button();
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.buttonSelectFlight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMain.RowCount = 5;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Controls.Add(this.labelWelcome, 0, 0);
            this.tableLayoutPanelMain.SetColumnSpan(this.labelWelcome, 4);
            this.tableLayoutPanelMain.Controls.Add(this.labelOrigin, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxOrigin, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelDestination, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxDestination, 3, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelDate, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.dateTimePickerDate, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSearchFlights, 3, 2);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewFlights, 0, 4);
            this.tableLayoutPanelMain.SetColumnSpan(this.dataGridViewFlights, 4);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSelectFlight, 3, 3);
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            // 
            // labelWelcome
            // 
            this.labelWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.labelWelcome.ForeColor = System.Drawing.Color.Navy;
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(0, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(800, 60);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome, Customer";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOrigin
            // 
            this.labelOrigin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Text = "Origin City:";
            this.labelOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOrigin.Location = new System.Drawing.Point(20, 70);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(80, 20);
            this.labelOrigin.TabIndex = 1;
            // 
            // comboBoxOrigin
            // 
            this.comboBoxOrigin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrigin.Name = "comboBoxOrigin";
            this.comboBoxOrigin.Size = new System.Drawing.Size(200, 28);
            this.comboBoxOrigin.TabIndex = 2;
            // 
            // labelDestination
            // 
            this.labelDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDestination.AutoSize = true;
            this.labelDestination.Text = "Destination City:";
            this.labelDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDestination.Location = new System.Drawing.Point(420, 70);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(104, 20);
            this.labelDestination.TabIndex = 3;
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(200, 28);
            this.comboBoxDestination.TabIndex = 4;
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDate.AutoSize = true;
            this.labelDate.Text = "Departure date:";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDate.Location = new System.Drawing.Point(20, 110);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 20);
            this.labelDate.TabIndex = 5;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // buttonSearchFlights
            // 
            this.buttonSearchFlights.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearchFlights.Name = "buttonSearchFlights";
            this.buttonSearchFlights.Size = new System.Drawing.Size(200, 30);
            this.buttonSearchFlights.TabIndex = 7;
            this.buttonSearchFlights.Text = "Search flights";
            this.buttonSearchFlights.UseVisualStyleBackColor = true;
            this.buttonSearchFlights.Click += new System.EventHandler(this.buttonSearchFlights_Click);
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.TabIndex = 8;
            this.dataGridViewFlights.ReadOnly = true;
            this.dataGridViewFlights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFlights.BackgroundColor = System.Drawing.Color.Gainsboro;
            // 
            // buttonSelectFlight
            // 
            this.buttonSelectFlight.Text = "Select Flight";
            this.buttonSelectFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectFlight.Size = new System.Drawing.Size(200, 30);
            this.buttonSelectFlight.Click += new System.EventHandler(this.buttonSelectFlight_Click);
            // 
            // TicketPurchaseForm
            // 
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "TicketPurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket purchase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}