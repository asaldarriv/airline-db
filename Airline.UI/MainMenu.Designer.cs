namespace Airline.UI
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDocumentTypes;
        private System.Windows.Forms.Button buttonCountries;
        private System.Windows.Forms.Button buttonCities;
        // Agrega aquí más botones según tus entidades...
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            pictureBoxLogo = new System.Windows.Forms.PictureBox();
            labelTitle = new System.Windows.Forms.Label();
            buttonLogout = new System.Windows.Forms.Button();
            buttonExit = new System.Windows.Forms.Button();
            buttonDocumentTypes = new System.Windows.Forms.Button();
            buttonCountries = new System.Windows.Forms.Button();
            buttonCities = new System.Windows.Forms.Button();
            // Instancia aquí más botones si los tienes...
            tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();

            ((System.ComponentModel.ISupportInitialize)(pictureBoxLogo)).BeginInit();
            SuspendLayout();

            // pictureBoxLogo
            pictureBoxLogo.ImageLocation = "";
            pictureBoxLogo.Location = new System.Drawing.Point(1, 1);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new System.Drawing.Size(261, 124);
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Image = Properties.Resources.logoEafit;

            // labelTitle
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTitle.ForeColor = System.Drawing.Color.Navy;
            labelTitle.Location = new System.Drawing.Point(300, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(220, 37);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Main Menu";

            // tableLayoutPanelMenu
            tableLayoutPanelMenu.ColumnCount = 2;
            tableLayoutPanelMenu.RowCount = 0; // Se ajusta automáticamente
            tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelMenu.Location = new System.Drawing.Point(100, 150);
            tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            tableLayoutPanelMenu.Size = new System.Drawing.Size(600, 250);
            tableLayoutPanelMenu.TabIndex = 3;
            tableLayoutPanelMenu.AutoSize = true;
            tableLayoutPanelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            // buttonDocumentTypes
            buttonDocumentTypes.BackColor = System.Drawing.Color.Navy;
            buttonDocumentTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonDocumentTypes.ForeColor = System.Drawing.Color.White;
            buttonDocumentTypes.Name = "buttonDocumentTypes";
            buttonDocumentTypes.Text = "Document Types";
            buttonDocumentTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonDocumentTypes.Margin = new System.Windows.Forms.Padding(10);
            buttonDocumentTypes.Click += ButtonDocumentTypes_Click;

            // buttonCountries
            buttonCountries.BackColor = System.Drawing.Color.Navy;
            buttonCountries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonCountries.ForeColor = System.Drawing.Color.White;
            buttonCountries.Name = "buttonCountries";
            buttonCountries.Text = "Countries";
            buttonCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonCountries.Margin = new System.Windows.Forms.Padding(10);
            buttonCountries.Click += ButtonCountries_Click;

            // buttonCities
            buttonCities.BackColor = System.Drawing.Color.Navy;
            buttonCities.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonCities.ForeColor = System.Drawing.Color.White;
            buttonCities.Name = "buttonCities";
            buttonCities.Text = "Cities";
            buttonCities.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonCities.Margin = new System.Windows.Forms.Padding(10);
            buttonCities.Click += ButtonCities_Click;

            // buttonLogout
            buttonLogout.BackColor = System.Drawing.Color.Navy;
            buttonLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = System.Drawing.Color.White;
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Text = "Log Out";
            buttonLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonLogout.Margin = new System.Windows.Forms.Padding(10);
            buttonLogout.Click += ButtonLogout_Click;

            // buttonExit
            buttonExit.BackColor = System.Drawing.Color.Navy;
            buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonExit.ForeColor = System.Drawing.Color.White;
            buttonExit.Name = "buttonExit";
            buttonExit.Text = "Exit";
            buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonExit.Margin = new System.Windows.Forms.Padding(10);
            buttonExit.Click += ButtonExit_Click;

            // Añade los botones al TableLayoutPanel
            tableLayoutPanelMenu.Controls.Add(buttonDocumentTypes, 0, 0);
            tableLayoutPanelMenu.Controls.Add(buttonCountries, 1, 0);
            tableLayoutPanelMenu.Controls.Add(buttonCities, 0, 1);
            tableLayoutPanelMenu.Controls.Add(buttonLogout, 1, 1);
            tableLayoutPanelMenu.Controls.Add(buttonExit, 0, 2);

            // MainMenu
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(tableLayoutPanelMenu);
            Controls.Add(labelTitle);
            Controls.Add(pictureBoxLogo);
            Name = "MainMenu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(pictureBoxLogo)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}