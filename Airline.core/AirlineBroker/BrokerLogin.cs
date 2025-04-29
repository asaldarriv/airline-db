using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.core.AirlineBroker
{
    class BrokerLogin
    {

        internal bool ValidarLogin(string usuario, string contrasena)
        {
            if (usuario == contrasena)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
