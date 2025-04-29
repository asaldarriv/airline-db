using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.core.AirlineManager
{
    class ManagerLogin
    {
        internal bool ValidarLogin(string usuario, string contrasena)
        {

            AirlineBroker.BrokerLogin brokerLogin = new AirlineBroker.BrokerLogin();
            return brokerLogin.ValidarLogin(usuario, contrasena);

        }
    }
}
