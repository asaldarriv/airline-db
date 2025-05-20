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
            labelTitle = new System.Windows.Forms.Label();
            tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            buttonLogout = new Airline.UI.Controls.ModernButton();
            buttonLogout.Click += ButtonLogout_Click;
            buttonExit = new Airline.UI.Controls.ModernButton();
            buttonExit.Click += ButtonExit_Click;
            buttonDocumentTypes = new Airline.UI.Controls.ModernButton();
            buttonDocumentTypes.Click += ButtonDocumentTypes_Click;
            buttonCountries = new Airline.UI.Controls.ModernButton();
            buttonCountries.Click += ButtonCountries_Click;
            buttonCities = new Airline.UI.Controls.ModernButton();
            buttonCities.Click += ButtonCities_Click;
            buttonLuggageTypes = new Airline.UI.Controls.ModernButton();
            buttonLuggageTypes.Click += ButtonLuggageTypes_Click;
            buttonAirplaneStatuses = new Airline.UI.Controls.ModernButton();
            buttonAirplaneStatuses.Click += ButtonAirplaneStatuses_Click;
            buttonFlightStatuses = new Airline.UI.Controls.ModernButton();
            buttonFlightStatuses.Click += ButtonFlightStatuses_Click;
            buttonTicketStatuses = new Airline.UI.Controls.ModernButton();
            buttonTicketStatuses.Click += ButtonTicketStatuses_Click;
            buttonContractsStatuses = new Airline.UI.Controls.ModernButton();
            buttonContractsStatuses.Click += ButtonContractsStatuses_Click;
            buttonRoles = new Airline.UI.Controls.ModernButton();
            buttonRoles.Click += ButtonRoles_Click;
            buttonLuggages = new Airline.UI.Controls.ModernButton();
            buttonLuggages.Click += ButtonLuggages_Click;
            buttonAirplanes = new Airline.UI.Controls.ModernButton();
            buttonAirplanes.Click += ButtonAirplanes_Click;
            buttonRoutes = new Airline.UI.Controls.ModernButton();
            buttonRoutes.Click += ButtonRoutes_Click;
            buttonLayovers = new Airline.UI.Controls.ModernButton();
            buttonLayovers.Click += ButtonLayovers_Click;
            buttonFlights = new Airline.UI.Controls.ModernButton();
            buttonFlights.Click += ButtonFlights_Click;
            buttonTickets = new Airline.UI.Controls.ModernButton();
            buttonTickets.Click += ButtonTickets_Click;
            buttonEmployeesFlights = new Airline.UI.Controls.ModernButton();
            buttonEmployeesFlights.Click += ButtonEmployeesFlights_Click;
            buttonUsers = new Airline.UI.Controls.ModernButton();
            buttonUsers.Click += ButtonUsers_Click;

            SuspendLayout();

            // MainMenu
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1200, 800);
            BackColor = System.Drawing.Color.White;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Main Menu";
            MaximizeBox = true;
            MinimizeBox = true;

            // labelTitle
            labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            labelTitle.ForeColor = System.Drawing.Color.Navy;
            labelTitle.Text = "Main Menu";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelTitle.AutoSize = true;
            labelTitle.Margin = new System.Windows.Forms.Padding(0, 30, 0, 30);

            // tableLayoutPanelMenu
            tableLayoutPanelMenu.ColumnCount = 4;
            tableLayoutPanelMenu.RowCount = 6;
            tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelMenu.ColumnStyles.Clear();
            for (int i = 0; i < 4; i++)
                tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            for (int i = 0; i < 6; i++)
                tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            tableLayoutPanelMenu.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);

            // Botones principales (tamaño fijo, centrados)
            var allButtons = new System.Windows.Forms.Button[]
            {
                buttonDocumentTypes, buttonCountries, buttonCities, buttonLuggageTypes,
                buttonAirplaneStatuses, buttonFlightStatuses, buttonTicketStatuses, buttonContractsStatuses,
                buttonRoles, buttonLuggages, buttonAirplanes, buttonRoutes,
                buttonLayovers, buttonFlights, buttonTickets, buttonEmployeesFlights,
                buttonUsers
            };
            foreach (var btn in allButtons)
            {
                btn.Anchor = System.Windows.Forms.AnchorStyles.None;
                btn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                btn.Margin = new System.Windows.Forms.Padding(20);
                btn.Size = new System.Drawing.Size(260, 70);
                btn.BackColor = System.Drawing.Color.White;
                btn.ForeColor = System.Drawing.Color.Black;
            }

            // Añade los botones al TableLayoutPanel (4 columnas x 6 filas)
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

            // FlowLayoutPanel para Log Out y Exit centrados abajo
            var flowPanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            flowPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            flowPanelBottom.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flowPanelBottom.AutoSize = true;
            flowPanelBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowPanelBottom.WrapContents = false;
            flowPanelBottom.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            flowPanelBottom.Anchor = System.Windows.Forms.AnchorStyles.None;
            flowPanelBottom.Controls.Add(buttonLogout);
            flowPanelBottom.Controls.Add(buttonExit);

            buttonLogout.Text = "Log Out";
            buttonLogout.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonLogout.Size = new System.Drawing.Size(180, 50);
            buttonLogout.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            buttonLogout.BackColor = System.Drawing.Color.White;
            buttonLogout.ForeColor = System.Drawing.Color.Black;
            buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.None;

            buttonExit.Text = "Exit";
            buttonExit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            buttonExit.Size = new System.Drawing.Size(180, 50);
            buttonExit.Margin = new System.Windows.Forms.Padding(60, 0, 60, 0);
            buttonExit.BackColor = System.Drawing.Color.White;
            buttonExit.ForeColor = System.Drawing.Color.Black;
            buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;

            // Estructura principal
            var tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F)); // Título
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F)); // Botones
            tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F)); // Log Out / Exit
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