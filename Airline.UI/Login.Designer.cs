namespace Airline.UI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBoxLogo = new PictureBox();
            labelTitle = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.ImageLocation = "";
            pictureBoxLogo.Location = new Point(0, 4);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(298, 165);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Image = Properties.Resources.logoEafit;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Navy;
            labelTitle.Location = new Point(409, 60);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(321, 46);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Airline Application";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.Navy;
            labelUsername.Location = new Point(189, 253);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(189, 46);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.Navy;
            labelPassword.Location = new Point(136, 351);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(180, 46);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(379, 253);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(228, 42);
            textBoxUsername.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 15.75F);
            textBoxPassword.Location = new Point(379, 351);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(228, 42);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Navy;
            buttonLogin.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(240, 469);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(160, 73);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Navy;
            buttonExit.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(483, 469);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(160, 73);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += ButtonExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelTitle);
            Controls.Add(pictureBoxLogo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EAFIT University - Airline - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labelTitle;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonExit;
    }
}