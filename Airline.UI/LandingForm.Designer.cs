namespace Airline.UI
{
    partial class LandingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private Airline.UI.Controls.ModernButton buttonCreateAccount;
        private Airline.UI.Controls.ModernButton buttonLogin;
        private Airline.UI.Controls.ModernButton buttonViewFlights;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            labelTitle = new System.Windows.Forms.Label();
            flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            buttonCreateAccount = new Airline.UI.Controls.ModernButton();
            buttonLogin = new Airline.UI.Controls.ModernButton();
            buttonViewFlights = new Airline.UI.Controls.ModernButton();

            tableLayoutPanelMain.SuspendLayout();
            flowLayoutPanelButtons.SuspendLayout();
            SuspendLayout();

            // tableLayoutPanelMain
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanelMain.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanelMain.Controls.Add(flowLayoutPanelButtons, 0, 1);

            // labelTitle
            labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTitle.ForeColor = System.Drawing.Color.Navy;
            labelTitle.Text = "Airline EAFIT";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;

            // flowLayoutPanelButtons
            flowLayoutPanelButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            flowLayoutPanelButtons.AutoSize = true;
            flowLayoutPanelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelButtons.WrapContents = false;
            flowLayoutPanelButtons.Controls.Add(buttonCreateAccount);
            flowLayoutPanelButtons.Controls.Add(buttonLogin);
            flowLayoutPanelButtons.Controls.Add(buttonViewFlights);

            // buttonCreateAccount
            buttonCreateAccount.Text = "Create account";
            buttonCreateAccount.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonCreateAccount.Size = new System.Drawing.Size(320, 55);
            buttonCreateAccount.Margin = new System.Windows.Forms.Padding(20);
            buttonCreateAccount.Click += buttonCreateAccount_Click;

            // buttonLogin
            buttonLogin.Text = "Log In";
            buttonLogin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonLogin.Size = new System.Drawing.Size(320, 55);
            buttonLogin.Margin = new System.Windows.Forms.Padding(20);
            buttonLogin.Click += buttonLogin_Click;

            // buttonViewFlights
            buttonViewFlights.Text = "See available flights";
            buttonViewFlights.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonViewFlights.Size = new System.Drawing.Size(320, 55);
            buttonViewFlights.Margin = new System.Windows.Forms.Padding(20);
            buttonViewFlights.Click += buttonViewFlights_Click;
            buttonViewFlights.Visible = false;

            // LandingForm
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 600);
            Controls.Add(tableLayoutPanelMain);
            Name = "LandingForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Airline EAFIT";
            BackColor = System.Drawing.Color.White;
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            flowLayoutPanelButtons.ResumeLayout(false);
            flowLayoutPanelButtons.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}