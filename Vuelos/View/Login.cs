﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vuelos.Controller;

namespace Vuelos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = textBox1.Text;
            String password = textBox2.Text;

            Controller.Login enviar = new Controller.Login();
           string resivir = enviar.Pasar(usuario, password);
            if (resivir == "Exito")
            {
                MessageBox.Show("Bienvenido");
            }
            else {
                MessageBox.Show("Datos incorrectos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            String usuario = textBox1.Text;
            String password = textBox2.Text;

            Controller.Login enviar = new Controller.Login();
            string resivir = enviar.Pasar(usuario, password);
            if (resivir == "Exito")
            {
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}
