using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vuelos.WebService;

namespace Vuelos.View
{
    public partial class ClimaEstadosUnidos : Form
    {
        public ClimaEstadosUnidos()
        {
            InitializeComponent();
            lluvia.Visible = false;
            Sol.Visible = false;
            Soleado.Visible = false;
            Tormenta.Visible = false;
            string log = "-113.7578546";
            string lat = "36.2409022";
            Service servicio = new Service();
            string dato = servicio.clima(log, lat);
            string descripcion = "";
            var datos = JsonConvert.DeserializeObject<RootObject>(dato);
            foreach (var data in datos.weather)
            {
                descripcion = data.description;

            }
            des.Text = "Description: " + descripcion;
            Presion.Text = "Pressure: " + datos.main.pressure + " hpa ";
            Humedad.Text = "Humidity: " + datos.main.humidity + " %";
            double temperaturaM = double.Parse(datos.main.temp_max);
            double temperaturaMI = double.Parse(datos.main.temp_min);
            double resta = 273.15;
            double tempM = temperaturaM - resta;
            double tempI = temperaturaMI - resta;
            TemperaturaMAX.Text = "↑ " + Math.Round(tempM).ToString() + " °C";
            temperaturaMIN.Text = "↓ " + Math.Round(tempI).ToString() + " °C";
            speed.Text = "Speed: " + datos.wind.speed + " m/s";
            cloud.Text = "Clouds:" + datos.clouds.all + " %";
            double temperatura = double.Parse(datos.main.temp);
            double temp = temperatura - resta;
            Temp.Text = Math.Round(temp).ToString() + " °C";


            if (descripcion == "scattered clouds" || descripcion == "light rain" || descripcion == " moderate rain")
            {
                lluvia.Visible = true;
            }
            if (descripcion == "few clouds")
            {
                Soleado.Visible = true;
            }
            if (descripcion == "sky is clear" || descripcion == "clear sky")
            {
                Sol.Visible = true;
            }
            if (descripcion == "broken clouds" || descripcion == "overcast clouds")
            {
                Sol.Visible = true;
            }
        }

        private void Tormenta_Click(object sender, EventArgs e)
        {

        }
    }
}
