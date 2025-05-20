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

        private List<Route>? _routesCache;

        private Route? GetRouteByFlight(Flight flight)
        {
            if (_routesCache == null)
                _routesCache = new RouteFacade().GetAllRoutes().ToList();
            return _routesCache.FirstOrDefault(r => r.RouteId == flight.RouteId);
        }

        public TicketPurchaseForm(User customer)
        {
            _customer = customer;
            InitializeComponent();
            labelWelcome.Text = $"Welcome, {_customer.FirstName} {_customer.FirstLastName}";
            LoadCities();
            LoadAllFlights();
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

            var cities = _cityFacade.GetAllCities().Where(c => c.IsActive).ToList();

            var flightDisplayList = (from f in flights
                                     let route = GetRouteByFlight(f)
                                     let originCity = cities.FirstOrDefault(c => c.CityId == route?.OriginCityId)
                                     let destinationCity = cities.FirstOrDefault(c => c.CityId == route?.DestinationCityId)
                                     select new
                                     {
                                         FlightNumber = f.FlightId,
                                         OriginCity = originCity?.Name ?? "N/A",
                                         DestinationCity = destinationCity?.Name ?? "N/A",
                                         Departure = f.DepartureTime,
                                         Arrival = f.ArrivalTime,
                                         Airplane = f.AirplaneId
                                     }).ToList();

            dataGridViewFlights.DataSource = null;
            dataGridViewFlights.DataSource = flightDisplayList;
            dataGridViewFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (flightDisplayList.Count == 0)
            {
                MessageBox.Show("No flights available for the selected criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadAllFlights()
        {
            var flights = _flightFacade.GetAllFlights().ToList();
            var cities = _cityFacade.GetAllCities().Where(c => c.IsActive).ToList();

            var flightDisplayList = (from f in flights
                                     let route = GetRouteByFlight(f)
                                     let origin = cities.FirstOrDefault(c => c.CityId == route?.OriginCityId)
                                     let destination = cities.FirstOrDefault(c => c.CityId == route?.DestinationCityId)
                                     select new
                                     {
                                         FlightNumber = f.FlightId,
                                         OriginCity = origin?.Name ?? "N/A",
                                         DestinationCity = destination?.Name ?? "N/A",
                                         Departure = f.DepartureTime,
                                         Arrival = f.ArrivalTime,
                                         Airplane = f.AirplaneId
                                     }).ToList();

            dataGridViewFlights.DataSource = null;
            dataGridViewFlights.DataSource = flightDisplayList;
            dataGridViewFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonSelectFlight_Click(object sender, EventArgs e)
        {
            if (dataGridViewFlights.CurrentRow == null)
            {
                MessageBox.Show("Please select a flight.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedFlightId = (int)dataGridViewFlights.CurrentRow.Cells["FlightNumber"].Value;
            var flight = _flightFacade.GetFlightById(selectedFlightId);
            if (flight == null)
            {
                MessageBox.Show("Could not retrieve flight details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using var luggageForm = new LuggageSelectionForm(flight);
            if (luggageForm.ShowDialog() == DialogResult.OK)
            {
                var selectedLuggages = luggageForm.SelectedLuggages;

                using var paymentDialog = new TicketPaymentDialog();
                if (paymentDialog.ShowDialog() != DialogResult.OK)
                    return;

                // Get ticket status
                var ticketStatusFacade = new TicketStatusFacade();
                var statusCode = paymentDialog.IsPaid ? "PAID" : "PENDING";
                var status = ticketStatusFacade.GetAllTicketStatuses()
                    .FirstOrDefault(s => s.StatusCode == statusCode);

                if (status == null)
                {
                    MessageBox.Show($"Ticket status '{statusCode}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create ticket
                var ticketFacade = new TicketFacade();
                var newTicket = new Ticket
                {
                    CustomerId = _customer.UserId,
                    FlightId = flight.FlightId,
                    TicketStatusId = status.TicketStatusId,
                    Price = paymentDialog.TicketPrice,
                    AssignedSeat = paymentDialog.AssignedSeat,
                    SaleDate = DateTime.Now
                };
                ticketFacade.AddTicket(newTicket);

                // Retrieve the created ticket (assuming last inserted)
                var createdTicket = ticketFacade.GetAllTickets()
                    .OrderByDescending(t => t.TicketId)
                    .FirstOrDefault(t => t.CustomerId == _customer.UserId && t.FlightId == flight.FlightId && t.AssignedSeat == paymentDialog.AssignedSeat);

                if (createdTicket == null)
                {
                    MessageBox.Show("Ticket could not be registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Save luggages
                var luggageFacade = new LuggageFacade();
                foreach (var lug in selectedLuggages)
                {
                    lug.TicketId = createdTicket.TicketId;
                    luggageFacade.AddLuggage(lug);
                }

                MessageBox.Show("Ticket registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}