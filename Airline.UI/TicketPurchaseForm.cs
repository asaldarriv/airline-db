using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class TicketPurchaseForm : Form
    {
        private readonly User _customer;
        private readonly CityFacade _cityFacade = new();
        private readonly FlightFacade _flightFacade = new();

        public TicketPurchaseForm(User customer)
        {
            _customer = customer;
            InitializeComponent();
            labelWelcome.Text = $"Welcome, {_customer.FirstName} {_customer.FirstLastName} (Customer)";
            LoadCities();
        }

        private void LoadCities()
        {
            var cities = _cityFacade.GetAllCities().Where(c => c.IsActive).ToList();

            comboBoxOrigin.DataSource = new BindingSource(cities, null);
            comboBoxOrigin.DisplayMember = "Name";
            comboBoxOrigin.ValueMember = "CityId";

            comboBoxDestination.DataSource = new BindingSource(cities.ToList(), null);
            comboBoxDestination.DisplayMember = "Name";
            comboBoxDestination.ValueMember = "CityId";
        }

        private void buttonSearchFlights_Click(object sender, EventArgs e)
        {
            if (comboBoxOrigin.SelectedItem is not City origin ||
                comboBoxDestination.SelectedItem is not City destination)
            {
                MessageBox.Show("Please select both origin and destination cities.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var date = dateTimePickerDate.Value.Date;

            var flights = _flightFacade
                .GetAvailableFlights(origin.CityId, destination.CityId, date)
                .ToList();

            dataGridViewFlights.DataSource = null;
            dataGridViewFlights.DataSource = flights;

            // Configura las columnas para mostrar solo lo relevante
            if (flights.Count > 0)
            {
                // Cambia los encabezados
                dataGridViewFlights.Columns["FlightId"].HeaderText = "Flight #";
                dataGridViewFlights.Columns["DepartureTime"].HeaderText = "Departure";
                dataGridViewFlights.Columns["ArrivalTime"].HeaderText = "Arrival";
                if (dataGridViewFlights.Columns.Contains("AirplaneId"))
                    dataGridViewFlights.Columns["AirplaneId"].HeaderText = "Airplane";

                // Oculta columnas técnicas
                foreach (var col in new[] { "RouteId", "FlightStatusId" })
                    if (dataGridViewFlights.Columns.Contains(col))
                        dataGridViewFlights.Columns[col].Visible = false;

                // Opcional: ajusta el ancho de columnas
                dataGridViewFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            if (flights.Count == 0)
            {
                MessageBox.Show("No flights available for the selected criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}