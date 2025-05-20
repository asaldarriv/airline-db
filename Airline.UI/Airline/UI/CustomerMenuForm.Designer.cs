using Airline.UI.Controls;

namespace Airline.UI
{
    partial class CustomerMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelMyTickets;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private ModernButton buttonPay;
        private ModernButton buttonBuyTicket;
        private ModernButton buttonLogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelMyTickets = new System.Windows.Forms.Label();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.buttonPay = new ModernButton();
            this.buttonBuyTicket = new ModernButton();
            this.buttonLogout = new ModernButton();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();

            // tableLayoutPanelMain
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain.Controls.Add(this.labelWelcome, 0, 0);
            this.tableLayoutPanelMain.SetColumnSpan(this.labelWelcome, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelMyTickets, 0, 1);
            this.tableLayoutPanelMain.SetColumnSpan(this.labelMyTickets, 3);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewTickets, 0, 2);
            this.tableLayoutPanelMain.SetColumnSpan(this.dataGridViewTickets, 3);
            this.tableLayoutPanelMain.Controls.Add(this.buttonPay, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.buttonBuyTicket, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.buttonLogout, 2, 3);

            // labelWelcome
            this.labelWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.labelWelcome.ForeColor = System.Drawing.Color.Navy;
            this.labelWelcome.Text = "Welcome, Customer";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWelcome.AutoSize = true;

            // labelMyTickets
            this.labelMyTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMyTickets.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.labelMyTickets.ForeColor = System.Drawing.Color.Navy;
            this.labelMyTickets.Text = "My tickets";
            this.labelMyTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMyTickets.AutoSize = true;

            // dataGridViewTickets
            this.dataGridViewTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.ReadOnly = true;
            this.dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTickets.BackgroundColor = System.Drawing.Color.Gainsboro;

            // buttonPay
            this.buttonPay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.buttonPay.Text = "Pay Ticket";
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(180, 40);
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);

            // buttonBuyTicket
            this.buttonBuyTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonBuyTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.buttonBuyTicket.Text = "Buy New Ticket";
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(180, 40);
            this.buttonBuyTicket.UseVisualStyleBackColor = true;
            this.buttonBuyTicket.Click += new System.EventHandler(this.buttonBuyTicket_Click);

            // buttonLogout
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(180, 40);
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);

            // CustomerMenuForm
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "CustomerMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Menu";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}