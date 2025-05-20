using System;
using System.Windows.Forms;

namespace Airline.UI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            // This will signal Program.cs to show the login form again
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonDocumentTypes_Click(object sender, EventArgs e)
        {
            using var form = new DocumentTypesForm();
            form.ShowDialog(this);
        }

        private void ButtonCountries_Click(object sender, EventArgs e)
        {
            using var form = new CountryForm();
            form.ShowDialog(this);
        }

        private void ButtonCities_Click(object sender, EventArgs e)
        {
            using var form = new CityForm();
            form.ShowDialog(this);
        }

        private void ButtonLuggageTypes_Click(object sender, EventArgs e)
        {
            using var form = new LuggageTypeForm();
            form.ShowDialog(this);
        }

        private void ButtonAirplaneStatuses_Click(object sender, EventArgs e)
        {
            using var form = new AirplaneStatusForm();
            form.ShowDialog(this);
        }

        private void ButtonFlightStatuses_Click(object sender, EventArgs e)
        {
            using var form = new FlightStatusForm();
            form.ShowDialog(this);
        }

        private void ButtonTicketStatuses_Click(object sender, EventArgs e)
        {
            using var form = new TicketStatusForm();
            form.ShowDialog(this);
        }

        private void ButtonContractsStatuses_Click(object sender, EventArgs e)
        {
            using var form = new ContractsStatusForm();
            form.ShowDialog(this);
        }

        private void ButtonRoles_Click(object sender, EventArgs e)
        {
            using var form = new RoleForm();
            form.ShowDialog(this);
        }

        private void ButtonLuggages_Click(object sender, EventArgs e)
        {
            using var form = new LuggageForm();
            form.ShowDialog(this);
        }

        private void ButtonAirplanes_Click(object sender, EventArgs e)
        {
            using var form = new AirplaneForm();
            form.ShowDialog(this);
        }

        private void ButtonRoutes_Click(object sender, EventArgs e)
        {
            using var form = new RouteForm();
            form.ShowDialog(this);
        }

        private void ButtonLayovers_Click(object sender, EventArgs e)
        {
            using var form = new LayoverForm();
            form.ShowDialog(this);
        }

        private void ButtonFlights_Click(object sender, EventArgs e)
        {
            using var form = new FlightForm();
            form.ShowDialog(this);
        }

        private void ButtonTickets_Click(object sender, EventArgs e)
        {
            using var form = new TicketForm();
            form.ShowDialog(this);
        }

        private void ButtonEmployeesFlights_Click(object sender, EventArgs e)
        {
            using var form = new EmployeeFlightForm();
            form.ShowDialog(this);
        }

        private void ButtonUsers_Click(object sender, EventArgs e)
        {
            using var form = new UserForm();
            form.ShowDialog(this);
        }
    }
}