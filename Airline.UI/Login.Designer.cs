namespace Airline.UI
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFields;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private Airline.UI.Controls.ModernButton buttonLogin;
        private Airline.UI.Controls.ModernButton buttonExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanelFields = new System.Windows.Forms.FlowLayoutPanel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLogin = new Airline.UI.Controls.ModernButton();
            this.buttonExit = new Airline.UI.Controls.ModernButton();

            this.tableLayoutPanelMain.SuspendLayout();
            this.flowLayoutPanelFields.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            this.SuspendLayout();

            // tableLayoutPanelMain
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelFields, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelButtons, 0, 2);

            // labelTitle
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            this.labelTitle.ForeColor = System.Drawing.Color.Navy;
            this.labelTitle.Text = "Login";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.AutoSize = true;

            // flowLayoutPanelFields
            this.flowLayoutPanelFields.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelFields.AutoSize = true;
            this.flowLayoutPanelFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelFields.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelFields.WrapContents = false;
            this.flowLayoutPanelFields.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flowLayoutPanelFields.Controls.Add(this.labelUsername);
            this.flowLayoutPanelFields.Controls.Add(this.textBoxUsername);
            this.flowLayoutPanelFields.Controls.Add(this.labelPassword);
            this.flowLayoutPanelFields.Controls.Add(this.textBoxPassword);

            // labelUsername
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.labelUsername.Text = "Username:";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);

            // textBoxUsername
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.textBoxUsername.Size = new System.Drawing.Size(260, 32);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);

            // labelPassword
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.labelPassword.Text = "Password:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);

            // textBoxPassword
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.textBoxPassword.Size = new System.Drawing.Size(260, 32);
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);

            // flowLayoutPanelButtons
            this.flowLayoutPanelButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelButtons.AutoSize = true;
            this.flowLayoutPanelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtons.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowLayoutPanelButtons.WrapContents = false;
            this.flowLayoutPanelButtons.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonLogin);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonExit);

            // buttonLogin
            this.buttonLogin.Text = "Log In";
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.buttonLogin.Size = new System.Drawing.Size(120, 40);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);

            // buttonExit
            this.buttonExit.Text = "Exit";
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            this.buttonExit.Size = new System.Drawing.Size(120, 40);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);

            // Login
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500); // Más grande y responsivo
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.BackColor = System.Drawing.Color.White;
            // Elimina el tamaño fijo y permite redimensionar
            // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.flowLayoutPanelFields.ResumeLayout(false);
            this.flowLayoutPanelFields.PerformLayout();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}