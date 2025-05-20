using System;
using System.Linq;
using System.Windows.Forms;
using Airline.core.AirlineEntities;
using Airline.core.AirlineFacade;

namespace Airline.UI
{
    public partial class EmployeeMenuForm : Form
    {
        private readonly User _employee;
        private readonly EmployeeFlightFacade _employeeFlightFacade = new();
        private readonly FlightFacade _flightFacade = new();

        public EmployeeMenuForm(User employee)
        {
            _employee = employee;
            InitializeComponent();
            labelWelcome.Text = $"Welcome, {_employee.FirstName} {_employee.FirstLastName}";
            LoadEmployeeFlights();
        }

        private void LoadEmployeeFlights()
        {
            // Obtiene los vuelos asociados al empleado
            var employeeFlights = _employeeFlightFacade.GetAllEmployeeFlights()
                .Where(ef => ef.EmployeeId == _employee.UserId)
                .ToList();

            // Obtiene los detalles de los vuelos
            var flights = _flightFacade.GetAllFlights().ToList();

            var display = employeeFlights
                .Join(flights, ef => ef.FlightId, f => f.FlightId, (ef, f) => new
                {
                    f.FlightId,
                    f.AirplaneId,
                    f.RouteId,
                    f.DepartureTime,
                    f.ArrivalTime
                })
                .ToList();

            dataGridViewFlights.DataSource = null;
            dataGridViewFlights.DataSource = display;
            dataGridViewFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}