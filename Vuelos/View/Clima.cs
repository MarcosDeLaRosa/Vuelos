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
using Newtonsoft.Json;
using Vuelos.View;

namespace Vuelos.View
{
    public partial class Clima : Form
    {
        public Clima()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ClimaAustralia Australia = new ClimaAustralia();
            Australia.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Canada_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClimaCanada canada = new ClimaCanada();
            canada.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClimaPortugal portugal = new ClimaPortugal();
            portugal.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ClimaEstadosUnidos USA = new ClimaEstadosUnidos();
            USA.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ClimaCoreaDelSur corea = new ClimaCoreaDelSur();
            corea.Show();
        }
    } 
}
