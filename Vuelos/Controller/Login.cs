using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vuelos.Model;
namespace Vuelos.Controller
{
    class Login
    {

        public string Pasar(string usuario, string password) {

            Model.Login login = new Model.Login();
            login.Verificar(usuario, password);
            return login.Verificar(usuario, password);
        }

    }
}
