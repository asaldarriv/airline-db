using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline.core.AirlineManager;

namespace Airline.core.AirlineFacade
{
    public class FacadeLogin
    {
        public bool ValidarLogin(string usuario, string contrasena) {
            AirlineManager.ManagerLogin managerLogin = new AirlineManager.ManagerLogin();
            return managerLogin.ValidarLogin(usuario, contrasena);
        }
    }
}
