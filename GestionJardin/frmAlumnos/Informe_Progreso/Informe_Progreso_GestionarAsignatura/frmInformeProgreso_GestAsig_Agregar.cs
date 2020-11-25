using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaEnt;
using CaLog;

namespace GestionJardin
{
    public partial class frmInformeProgreso_GestAsig_Agregar : Form
    {

        string edad;

        public frmInformeProgreso_GestAsig_Agregar(string edadMateria)
        {
            InitializeComponent();

            edad = edadMateria;
            metroLabel4.Text = "APRENDIZAJES DEFINIDOS PARA SALA DE " + edad + " AÑOS";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreAsing.Text;
            string descripcion = txtDescrApr.Text;

            logMaterias logMaterias = new logMaterias();
            string estado = logMaterias.agregarMateria(nombre, descripcion, edad);

            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
