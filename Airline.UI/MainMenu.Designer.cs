namespace Airline.UI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            pictureBoxLogo = new PictureBox();
            labelTitle = new Label();
            buttonLogout = new Button();
            buttonExit = new Button();
            buttonDocumentTypes = new Button();
            buttonCountries = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.ImageLocation = ""; // Use relative path or set as resource
            pictureBoxLogo.Location = new Point(1, 1);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(261, 124);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Image = Properties.Resources.logoEafit;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Navy;
            labelTitle.Location = new Point(403, 51);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(220, 37);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Main Menu";
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Navy;
            buttonLogout.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(117, 324);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(226, 55);
            buttonLogout.TabIndex = 8;
            buttonLogout.Text = "Log Out";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += ButtonLogout_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Navy;
            buttonExit.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(450, 324);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(226, 55);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += ButtonExit_Click;
            // 
            // buttonDocumentTypes
            // 
            buttonDocumentTypes.BackColor = Color.Navy;
            buttonDocumentTypes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDocumentTypes.ForeColor = Color.White;
            buttonDocumentTypes.Location = new Point(320, 200); // Ajusta la posición según tu layout
            buttonDocumentTypes.Name = "buttonDocumentTypes";
            buttonDocumentTypes.Size = new Size(160, 40);
            buttonDocumentTypes.TabIndex = 10;
            buttonDocumentTypes.Text = "Document Types";
            buttonDocumentTypes.UseVisualStyleBackColor = false;
            buttonDocumentTypes.Click += ButtonDocumentTypes_Click;
            // 
            // buttonCountries
            // 
            buttonCountries.BackColor = Color.Navy;
            buttonCountries.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCountries.ForeColor = Color.White;
            buttonCountries.Location = new Point(320, 260); // Ajusta la posición según tu layout
            buttonCountries.Name = "buttonCountries";
            buttonCountries.Size = new Size(160, 40);
            buttonCountries.TabIndex = 11;
            buttonCountries.Text = "Countries";
            buttonCountries.UseVisualStyleBackColor = false;
            buttonCountries.Click += ButtonCountries_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogout);
            Controls.Add(buttonDocumentTypes);
            Controls.Add(buttonCountries);
            Controls.Add(labelTitle);
            Controls.Add(pictureBoxLogo);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label labelTitle;
        private Button buttonLogout;
        private Button buttonExit;
        private Button buttonDocumentTypes;
        private Button buttonCountries;
    }
}