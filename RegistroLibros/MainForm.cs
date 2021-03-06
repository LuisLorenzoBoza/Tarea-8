﻿using RegistroLibros.UI.Consultas;
using RegistroLibros.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir de la aplicacion?",
                       "Consulta",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true; //Cancela el cerrado del formulario
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registroDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroLibros r = new RegistroLibros();
            r.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultaDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaLibros c = new ConsultaLibros();
            c.Show();
        }

        private void consultaDeTiposDeLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaTiposLibros c = new ConsultaTiposLibros();
            c.Show();
        }
    }
}
