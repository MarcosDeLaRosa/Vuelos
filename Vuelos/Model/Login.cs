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
            SqlCommand cmd = new SqlCommand("Select * from Empleado where Usuario =  '"+ usuario + "' and Pass='"+ password + "' ",conexion);

            conexion.Open();
            SqlDataReader Respuesta = cmd.ExecuteReader();
            if (Respuesta.Read() == true)
            {
                retornar = "Exito";
            }
            else {
                retornar = "Datos Incorrectos";
            }


            conexion.Close();
            return retornar;
        }

    }
}
