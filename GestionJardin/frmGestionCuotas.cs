﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionJardin
{
    public partial class frmGestionCuotas : Form
    {

        metPersonas metPersonas = new metPersonas();

        //metro colors https://www.w3schools.com/colors/colors_metro.asp
        public frmGestionCuotas()
        {
            InitializeComponent();
        }

        private void frmGestionCuotas_Load(object sender, EventArgs e)
        {
            

            //cargar combo Salas
            metCuota metCobro = new metCuota();
            entSala.entSalaColeccion salas = metCobro.buscarSalas();

            cbSalas.DataSource = new BindingSource(salas, null);
            cbSalas.ValueMember = "SAL_ID";
            cbSalas.DisplayMember = "SAL_NOMBRE";
            cbSalas.SelectedItem = null;

            // oculta los paneles

            panelBusqueda.Hide();
            panelGeneracion.Hide();
            listConceptos.Hide();

        }

        private void btnParticular_Click(object sender, EventArgs e)
        {
            //agregar funcion para limpiar controles

            panelGeneracion.Hide();
            panelBusqueda.Show();
            lblAyuda.Text = "Ingrese el apellido del matriculado.";
        }

        private void btnMasivo_Click(object sender, EventArgs e)
        {
            //agregar funcion para limpiar controles


            panelGeneracion.Show();
            panelBusqueda.Hide();
            lblAyuda.Text = "Complete los Datos de la Cuota.";
        }

        private void cbSalas_SelectedValueChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(cbSalas.SelectedValue);  // prueba

            listConceptos.Show();



        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            AutoCompleteStringCollection alumnos = new AutoCompleteStringCollection();
            
            alumnos = metPersonas.traerPersonasAutocompetar("2");

            txt_Matriculado.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_Matriculado.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_Matriculado.AutoCompleteCustomSource = alumnos;
        }
    }
}
