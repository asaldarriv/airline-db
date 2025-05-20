namespace Airline.UI
{
    partial class MainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private Airline.UI.Controls.ModernButton buttonLogout;
        private Airline.UI.Controls.ModernButton buttonExit;
        private Airline.UI.Controls.ModernButton buttonDocumentTypes;
        private Airline.UI.Controls.ModernButton buttonCountries;
        private Airline.UI.Controls.ModernButton buttonCities;
        private Airline.UI.Controls.ModernButton buttonLuggageTypes;
        private Airline.UI.Controls.ModernButton buttonAirplaneStatuses;
        private Airline.UI.Controls.ModernButton buttonFlightStatuses;
        private Airline.UI.Controls.ModernButton buttonTicketStatuses;
        private Airline.UI.Controls.ModernButton buttonContractsStatuses;
        private Airline.UI.Controls.ModernButton buttonRoles;
        private Airline.UI.Controls.ModernButton buttonLuggages;
        private Airline.UI.Controls.ModernButton buttonAirplanes;
        private Airline.UI.Controls.ModernButton buttonRoutes;
        private Airline.UI.Controls.ModernButton buttonLayovers;
        private Airline.UI.Controls.ModernButton buttonFlights;
        private Airline.UI.Controls.ModernButton buttonTickets;
        private Airline.UI.Controls.ModernButton buttonEmployeesFlights;
        private Airline.UI.Controls.ModernButton buttonUsers;

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
            labelTitle = new Label();
            tableLayoutPanelMenu = new TableLayoutPanel();
            buttonLogout = new Airline.UI.Controls.ModernButton();
            buttonExit = new Airline.UI.Controls.ModernButton();
            buttonDocumentTypes = new Airline.UI.Controls.ModernButton();
            buttonCountries = new Airline.UI.Controls.ModernButton();
            buttonCities = new Airline.UI.Controls.ModernButton();
            buttonLuggageTypes = new Airline.UI.Controls.ModernButton();
            buttonAirplaneStatuses = new Airline.UI.Controls.ModernButton();
            buttonFlightStatuses = new Airline.UI.Controls.ModernButton();
            buttonTicketStatuses = new Airline.UI.Controls.ModernButton();
            buttonContractsStatuses = new Airline.UI.Controls.ModernButton();
            buttonRoles = new Airline.UI.Controls.ModernButton();
            buttonLuggages = new Airline.UI.Controls.ModernButton();
            buttonAirplanes = new Airline.UI.Controls.ModernButton();
            buttonRoutes = new Airline.UI.Controls.ModernButton();
            buttonLayovers = new Airline.UI.Controls.ModernButton();
            buttonFlights = new Airline.UI.Controls.ModernButton();
            buttonTickets = new Airline.UI.Controls.ModernButton();
            buttonEmployeesFlights = new Airline.UI.Controls.ModernButton();
            buttonUsers = new Airline.UI.Controls.ModernButton();

            buttonLogout.Click += ButtonLogout_Click;
            buttonExit.Click += ButtonExit_Click;
            buttonDocumentTypes.Click += ButtonDocumentTypes_Click;
            buttonCountries.Click += ButtonCountries_Click;
            buttonCities.Click += ButtonCities_Click;
            buttonLuggageTypes.Click += ButtonLuggageTypes_Click;
            buttonAirplaneStatuses.Click += ButtonAirplaneStatuses_Click;
            buttonFlightStatuses.Click += ButtonFlightStatuses_Click;
            buttonTicketStatuses.Click += ButtonTicketStatuses_Click;
            buttonContractsStatuses.Click += ButtonContractsStatuses_Click;
            buttonRoles.Click += ButtonRoles_Click;
            buttonLuggages.Click += ButtonLuggages_Click;
            buttonAirplanes.Click += ButtonAirplanes_Click;
            buttonRoutes.Click += ButtonRoutes_Click;
            buttonLayovers.Click += ButtonLayovers_Click;
            buttonFlights.Click += ButtonFlights_Click;
            buttonTickets.Click += ButtonTickets_Click;
            buttonEmployeesFlights.Click += ButtonEmployeesFlights_Click;
            buttonUsers.Click += ButtonUsers_Click;

            SuspendLayout();

            // MainMenu properties
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 800);
            BackColor = Color.White;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            MaximizeBox = true;
            MinimizeBox = true;

            // Title label
            labelTitle.Dock = DockStyle.Top;
            labelTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.Navy;
            labelTitle.Text = "Main Menu";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle.AutoSize = true;
            labelTitle.Margin = new Padding(0, 30, 0, 30);

            // TableLayoutPanel for buttons
            tableLayoutPanelMenu.ColumnCount = 4;
            tableLayoutPanelMenu.RowCount = 6;
            tableLayoutPanelMenu.Dock = DockStyle.Fill;
            tableLayoutPanelMenu.ColumnStyles.Clear();
            for (int i = 0; i < 4; i++)
                tableLayoutPanelMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int i = 0; i < 6; i++)
                tableLayoutPanelMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            tableLayoutPanelMenu.Padding = new Padding(40, 20, 40, 20);

            // Diccionario de botones y texto
            var buttonTexts = new Dictionary<Button, string>
    {
        { buttonDocumentTypes, "Document Types" },
        { buttonCountries, "Countries" },
        { buttonCities, "Cities" },
        { buttonLuggageTypes, "Luggage Types" },
        { buttonAirplaneStatuses, "Airplane Statuses" },
        { buttonFlightStatuses, "Flight Statuses" },
        { buttonTicketStatuses, "Ticket Statuses" },
        { buttonContractsStatuses, "Contracts Statuses" },
        { buttonRoles, "Roles" },
        { buttonLuggages, "Luggages" },
        { buttonAirplanes, "Airplanes" },
        { buttonRoutes, "Routes" },
        { buttonLayovers, "Layovers" },
        { buttonFlights, "Flights" },
        { buttonTickets, "Tickets" },
        { buttonEmployeesFlights, "Employees Flights" },
        { buttonUsers, "Users" }
    };

            foreach (var pair in buttonTexts)
            {
                var btn = pair.Key;
                btn.Text = pair.Value;
                btn.Anchor = AnchorStyles.None;
                btn.Font = new Font("Segoe UI", 16F);
                btn.Margin = new Padding(20);
                btn.MinimumSize = new Size(180, 50);
                btn.AutoSize = true;
                btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }

            // Añadir botones al layout
            tableLayoutPanelMenu.Controls.Add(buttonDocumentTypes, 0, 0);
            tableLayoutPanelMenu.Controls.Add(buttonCountries, 1, 0);
            tableLayoutPanelMenu.Controls.Add(buttonCities, 2, 0);
            tableLayoutPanelMenu.Controls.Add(buttonLuggageTypes, 3, 0);

            tableLayoutPanelMenu.Controls.Add(buttonAirplaneStatuses, 0, 1);
            tableLayoutPanelMenu.Controls.Add(buttonFlightStatuses, 1, 1);
            tableLayoutPanelMenu.Controls.Add(buttonTicketStatuses, 2, 1);
            tableLayoutPanelMenu.Controls.Add(buttonContractsStatuses, 3, 1);

            tableLayoutPanelMenu.Controls.Add(buttonRoles, 0, 2);
            tableLayoutPanelMenu.Controls.Add(buttonLuggages, 1, 2);
            tableLayoutPanelMenu.Controls.Add(buttonAirplanes, 2, 2);
            tableLayoutPanelMenu.Controls.Add(buttonRoutes, 3, 2);

            tableLayoutPanelMenu.Controls.Add(buttonLayovers, 0, 3);
            tableLayoutPanelMenu.Controls.Add(buttonFlights, 1, 3);
            tableLayoutPanelMenu.Controls.Add(buttonTickets, 2, 3);
            tableLayoutPanelMenu.Controls.Add(buttonEmployeesFlights, 3, 3);

            tableLayoutPanelMenu.Controls.Add(buttonUsers, 0, 4);

            // Bottom panel con Log Out y Exit
            var flowPanelBottom = new FlowLayoutPanel();
            flowPanelBottom.Dock = DockStyle.Bottom;
            flowPanelBottom.FlowDirection = FlowDirection.LeftToRight;
            flowPanelBottom.AutoSize = true;
            flowPanelBottom.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowPanelBottom.WrapContents = false;
            flowPanelBottom.Padding = new Padding(0, 30, 0, 0);
            flowPanelBottom.Anchor = AnchorStyles.None;

            buttonLogout.Text = "Log Out";
            buttonLogout.Font = new Font("Segoe UI", 16F);
            buttonLogout.Size = new Size(180, 50);
            buttonLogout.Margin = new Padding(60, 0, 60, 0);
            buttonLogout.BackColor = Color.White;
            buttonLogout.ForeColor = Color.Black;
            buttonLogout.Anchor = AnchorStyles.None;

            buttonExit.Text = "Exit";
            buttonExit.Font = new Font("Segoe UI", 16F);
            buttonExit.Size = new Size(180, 50);
            buttonExit.Margin = new Padding(60, 0, 60, 0);
            buttonExit.BackColor = Color.White;
            buttonExit.ForeColor = Color.Black;
            buttonExit.Anchor = AnchorStyles.None;

            flowPanelBottom.Controls.Add(buttonLogout);
            flowPanelBottom.Controls.Add(buttonExit);

            // Layout principal
            var tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanelMain.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelMenu, 0, 1);
            tableLayoutPanelMain.Controls.Add(flowPanelBottom, 0, 2);

            Controls.Clear();
            Controls.Add(tableLayoutPanelMain);

            ResumeLayout(false);
        }

        #endregion
    }
}