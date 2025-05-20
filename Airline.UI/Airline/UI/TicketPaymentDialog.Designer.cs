using Airline.UI.Controls;

namespace Airline.UI
{
    partial class TicketPaymentDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSeat;
        private System.Windows.Forms.TextBox textBoxSeat;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private ModernButton buttonPay;
        private ModernButton buttonReserve;
        private ModernButton buttonCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSeat = new System.Windows.Forms.Label();
            this.textBoxSeat = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonPay = new ModernButton();
            this.buttonReserve = new ModernButton();
            this.buttonCancel = new ModernButton();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();

            // tableLayoutPanelMain
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelMain.RowCount = 5;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanelMain.SetColumnSpan(this.labelTitle, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelSeat, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxSeat, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelPrice, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownPrice, 1, 2);

            // Row 3: Buttons
            var buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            buttonPanel.Controls.Add(this.buttonPay);
            buttonPanel.Controls.Add(this.buttonReserve);
            buttonPanel.Controls.Add(this.buttonCancel);
            buttonPanel.AutoSize = true;
            this.tableLayoutPanelMain.Controls.Add(buttonPanel, 0, 3);
            this.tableLayoutPanelMain.SetColumnSpan(buttonPanel, 2);

            // labelTitle
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.labelTitle.ForeColor = System.Drawing.Color.Navy;
            this.labelTitle.Text = "Ticket Payment / Reservation";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.AutoSize = true;

            // labelSeat
            this.labelSeat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSeat.AutoSize = true;
            this.labelSeat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.labelSeat.Text = "Seat:";
            this.labelSeat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // textBoxSeat
            this.textBoxSeat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSeat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.textBoxSeat.Name = "textBoxSeat";
            this.textBoxSeat.Size = new System.Drawing.Size(180, 29);

            // labelPrice
            this.labelPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.labelPrice.Text = "Price:";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // numericUpDownPrice
            this.numericUpDownPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Minimum = 1;
            this.numericUpDownPrice.Maximum = 1000000;
            this.numericUpDownPrice.Value = 1;
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(120, 29);

            // buttonPay
            this.buttonPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.buttonPay.Text = "Pay";
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(120, 40);
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);

            // buttonReserve
            this.buttonReserve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.buttonReserve.Text = "Reserve";
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(120, 40);
            this.buttonReserve.UseVisualStyleBackColor = true;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);

            // buttonCancel
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 40);
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);

            // TicketPaymentDialog
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "TicketPaymentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ticket Payment / Reservation";

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}