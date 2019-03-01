using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Vuelos.Model
{
    class Login : Conexion
    {

         public string Verificar(string usuario, string password)
        {
            string retornar = "";
            SqlCommand cmdGerente = new SqlCommand("Select * from Empleado where Usuario =  '"+ usuario + "' and Pass='"+ password + "' and Rol='1' ",conexion);
            SqlCommand cmdVendedor = new SqlCommand("Select * from Empleado where Usuario =  '" + usuario + "' and Pass='" + password + "' and Rol='2' ", conexion);

            conexion.Open();
            SqlDataReader RespuestaG = cmdGerente.ExecuteReader();
            if (RespuestaG.Read() == true)
            {
                retornar = "Gerente";
            }
            conexion.Close();

            conexion.Open();
            SqlDataReader RespuestaV = cmdVendedor.ExecuteReader();
            if (RespuestaV.Read() == true) {
                retornar = "Vendedor";
            }
            conexion.Close();
            return retornar;
        }

    }
}
