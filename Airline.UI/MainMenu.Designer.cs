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
        private System.Windows.Forms.Button buttonLuggageTypes;
        private System.Windows.Forms.Button buttonAirplaneStatuses;
        private System.Windows.Forms.Button buttonFlightStatuses;
        private System.Windows.Forms.Button buttonTicketStatuses;
        private System.Windows.Forms.Button buttonContractsStatuses;
        private System.Windows.Forms.Button buttonRoles;
        private System.Windows.Forms.Button buttonLuggages;
        private System.Windows.Forms.Button buttonAirplanes;
        private System.Windows.Forms.Button buttonRoutes;
        private System.Windows.Forms.Button buttonLayovers;
        private System.Windows.Forms.Button buttonFlights;
        private System.Windows.Forms.Button buttonTickets;
        private System.Windows.Forms.Button buttonEmployeesFlights;
        private System.Windows.Forms.Button buttonUsers;

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
            buttonLuggageTypes = new System.Windows.Forms.Button();
            buttonAirplaneStatuses = new System.Windows.Forms.Button();
            buttonFlightStatuses = new System.Windows.Forms.Button();
            buttonTicketStatuses = new System.Windows.Forms.Button();
            buttonContractsStatuses = new System.Windows.Forms.Button();
            buttonRoles = new System.Windows.Forms.Button();
            buttonLuggages = new System.Windows.Forms.Button();
            buttonAirplanes = new System.Windows.Forms.Button();
            buttonRoutes = new System.Windows.Forms.Button();
            buttonLayovers = new System.Windows.Forms.Button();
            buttonFlights = new System.Windows.Forms.Button();
            buttonTickets = new System.Windows.Forms.Button(); // Added buttonTickets initialization
            buttonEmployeesFlights = new System.Windows.Forms.Button(); // Added buttonEmployeesFlights initialization
            buttonUsers = new System.Windows.Forms.Button(); // Added buttonUsers initialization
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

            // buttonLuggageTypes
            buttonLuggageTypes.BackColor = System.Drawing.Color.Navy;
            buttonLuggageTypes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonLuggageTypes.ForeColor = System.Drawing.Color.White;
            buttonLuggageTypes.Name = "buttonLuggageTypes";
            buttonLuggageTypes.Text = "Luggage Types";
            buttonLuggageTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonLuggageTypes.Margin = new System.Windows.Forms.Padding(10);
            buttonLuggageTypes.Click += ButtonLuggageTypes_Click;

            // buttonAirplaneStatuses
            buttonAirplaneStatuses.BackColor = System.Drawing.Color.Navy;
            buttonAirplaneStatuses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonAirplaneStatuses.ForeColor = System.Drawing.Color.White;
            buttonAirplaneStatuses.Name = "buttonAirplaneStatuses";
            buttonAirplaneStatuses.Text = "Airplane Statuses";
            buttonAirplaneStatuses.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonAirplaneStatuses.Margin = new System.Windows.Forms.Padding(10);
            buttonAirplaneStatuses.Click += ButtonAirplaneStatuses_Click;

            // buttonFlightStatuses
            buttonFlightStatuses.BackColor = System.Drawing.Color.Navy;
            buttonFlightStatuses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonFlightStatuses.ForeColor = System.Drawing.Color.White;
            buttonFlightStatuses.Name = "buttonFlightStatuses";
            buttonFlightStatuses.Text = "Flight Statuses";
            buttonFlightStatuses.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonFlightStatuses.Margin = new System.Windows.Forms.Padding(10);
            buttonFlightStatuses.Click += ButtonFlightStatuses_Click;

            // buttonTicketStatuses
            buttonTicketStatuses.BackColor = System.Drawing.Color.Navy;
            buttonTicketStatuses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonTicketStatuses.ForeColor = System.Drawing.Color.White;
            buttonTicketStatuses.Name = "buttonTicketStatuses";
            buttonTicketStatuses.Text = "Ticket Statuses";
            buttonTicketStatuses.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonTicketStatuses.Margin = new System.Windows.Forms.Padding(10);
            buttonTicketStatuses.Click += ButtonTicketStatuses_Click;

            // buttonContractsStatuses
            buttonContractsStatuses.BackColor = System.Drawing.Color.Navy;
            buttonContractsStatuses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonContractsStatuses.ForeColor = System.Drawing.Color.White;
            buttonContractsStatuses.Name = "buttonContractsStatuses";
            buttonContractsStatuses.Text = "Contracts Statuses";
            buttonContractsStatuses.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonContractsStatuses.Margin = new System.Windows.Forms.Padding(10);
            buttonContractsStatuses.Click += ButtonContractsStatuses_Click;

            // buttonRoles
            buttonRoles.BackColor = System.Drawing.Color.Navy;
            buttonRoles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonRoles.ForeColor = System.Drawing.Color.White;
            buttonRoles.Name = "buttonRoles";
            buttonRoles.Text = "Roles";
            buttonRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonRoles.Margin = new System.Windows.Forms.Padding(10);
            buttonRoles.Click += ButtonRoles_Click;

            // buttonLuggages
            buttonLuggages.BackColor = System.Drawing.Color.Navy;
            buttonLuggages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonLuggages.ForeColor = System.Drawing.Color.White;
            buttonLuggages.Name = "buttonLuggages";
            buttonLuggages.Text = "Luggages";
            buttonLuggages.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonLuggages.Margin = new System.Windows.Forms.Padding(10);
            buttonLuggages.Click += ButtonLuggages_Click;

            // buttonAirplanes
            buttonAirplanes.BackColor = System.Drawing.Color.Navy;
            buttonAirplanes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonAirplanes.ForeColor = System.Drawing.Color.White;
            buttonAirplanes.Name = "buttonAirplanes";
            buttonAirplanes.Text = "Airplanes";
            buttonAirplanes.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonAirplanes.Margin = new System.Windows.Forms.Padding(10);
            buttonAirplanes.Click += ButtonAirplanes_Click;

            // buttonRoutes
            buttonRoutes.BackColor = System.Drawing.Color.Navy;
            buttonRoutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonRoutes.ForeColor = System.Drawing.Color.White;
            buttonRoutes.Name = "buttonRoutes";
            buttonRoutes.Text = "Routes";
            buttonRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonRoutes.Margin = new System.Windows.Forms.Padding(10);
            buttonRoutes.Click += ButtonRoutes_Click;

            // buttonLayovers
            buttonLayovers.BackColor = System.Drawing.Color.Navy;
            buttonLayovers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonLayovers.ForeColor = System.Drawing.Color.White;
            buttonLayovers.Name = "buttonLayovers";
            buttonLayovers.Text = "Layovers";
            buttonLayovers.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonLayovers.Margin = new System.Windows.Forms.Padding(10);
            buttonLayovers.Click += ButtonLayovers_Click;

            // buttonFlights
            buttonFlights.BackColor = System.Drawing.Color.Navy;
            buttonFlights.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonFlights.ForeColor = System.Drawing.Color.White;
            buttonFlights.Name = "buttonFlights";
            buttonFlights.Text = "Flights";
            buttonFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonFlights.Margin = new System.Windows.Forms.Padding(10);
            buttonFlights.Click += ButtonFlights_Click;

            // buttonTickets
            buttonTickets.BackColor = System.Drawing.Color.Navy;
            buttonTickets.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonTickets.ForeColor = System.Drawing.Color.White;
            buttonTickets.Name = "buttonTickets";
            buttonTickets.Text = "Tickets";
            buttonTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonTickets.Margin = new System.Windows.Forms.Padding(10);
            buttonTickets.Click += ButtonTickets_Click;

            // buttonEmployeesFlights
            buttonEmployeesFlights.BackColor = System.Drawing.Color.Navy;
            buttonEmployeesFlights.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonEmployeesFlights.ForeColor = System.Drawing.Color.White;
            buttonEmployeesFlights.Name = "buttonEmployeesFlights";
            buttonEmployeesFlights.Text = "Employees - Flights";
            buttonEmployeesFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonEmployeesFlights.Margin = new System.Windows.Forms.Padding(10);
            buttonEmployeesFlights.Click += ButtonEmployeesFlights_Click;

            // buttonUsers
            buttonUsers.BackColor = System.Drawing.Color.Navy;
            buttonUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonUsers.ForeColor = System.Drawing.Color.White;
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Text = "Users";
            buttonUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonUsers.Margin = new System.Windows.Forms.Padding(10);
            buttonUsers.Click += ButtonUsers_Click;

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
            tableLayoutPanelMenu.Controls.Add(buttonLuggageTypes, 1, 1);
            tableLayoutPanelMenu.Controls.Add(buttonAirplaneStatuses, 0, 2);
            tableLayoutPanelMenu.Controls.Add(buttonFlightStatuses, 1, 2);
            tableLayoutPanelMenu.Controls.Add(buttonTicketStatuses, 0, 3);
            tableLayoutPanelMenu.Controls.Add(buttonContractsStatuses, 1, 3);
            tableLayoutPanelMenu.Controls.Add(buttonLogout, 0, 4);
            tableLayoutPanelMenu.Controls.Add(buttonExit, 1, 4);
            tableLayoutPanelMenu.Controls.Add(buttonRoles, 1, 5);
            tableLayoutPanelMenu.Controls.Add(buttonLuggages, 0, 5);
            tableLayoutPanelMenu.Controls.Add(buttonAirplanes, 1, 5);
            tableLayoutPanelMenu.Controls.Add(buttonRoutes, 0, 6);
            tableLayoutPanelMenu.Controls.Add(buttonLayovers, 1, 6);
            tableLayoutPanelMenu.Controls.Add(buttonFlights, 0, 7);
            tableLayoutPanelMenu.Controls.Add(buttonTickets, 1, 7); // Added buttonTickets to TableLayoutPanel
            tableLayoutPanelMenu.Controls.Add(buttonEmployeesFlights, 1, 8); // Added buttonEmployeesFlights to TableLayoutPanel
            tableLayoutPanelMenu.Controls.Add(buttonUsers, 0, 9); // Added buttonUsers to TableLayoutPanel

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