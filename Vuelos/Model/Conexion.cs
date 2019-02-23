using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Vuelos.Model
{
    class Conexion
    {
       
    
        public SqlConnection conexion = new SqlConnection("server=MARCOS;database = Vuelos; integrated security = true");

    }
}
