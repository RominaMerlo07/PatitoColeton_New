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
    public partial class frmInformeProgreso_GestAsig_Editar : Form
    {

        string id;
        string nombre;
        string descripcion;
        string edad;

        public frmInformeProgreso_GestAsig_Editar(string idMtMateria, string nombreMtMateria, string descripcionMtMateria, string edadMtMateria)
        {
            InitializeComponent();

            id = idMtMateria;
            nombre = nombreMtMateria;
            descripcion = descripcionMtMateria;
            edad = edadMtMateria;

            metroLabel4.Text = "APRENDIZAJES DEFINIDOS PARA SALA DE " + edad + " AÑOS";
            metroTextBox1.Text = nombre;
            metroTextBox2.Text = descripcion;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            logMaterias logMaterias = new logMaterias();

            string Nom = metroTextBox1.Text;
            string Descr = metroTextBox2.Text;
            string estado = logMaterias.editarMateria(id, Nom, Descr);

            this.Close();
        }
    }
}
