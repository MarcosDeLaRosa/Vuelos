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
    public partial class ClimaCanada : Form
    {
        public ClimaCanada()
        {
            InitializeComponent();
            lluvia.Visible = false;
            Sol.Visible = false;
            Soleado.Visible = false;
            Tormenta.Visible = false;
            string log = "-157.7946161";
            string lat = "35.1959054";
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


            if (descripcion == "scattered clouds" || descripcion == "light rain" || descripcion == " moderate rain") {
                lluvia.Visible = true;
            }
            if  (descripcion == "few clouds")
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClimaCanada_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox171_Click(object sender, EventArgs e)
        {

        }
    }
}
