using System;
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
    public partial class frmConcepto : Form
    {
        public frmConcepto()
        {
            InitializeComponent();
        }

        private void btnCon_Agregar_Click(object sender, EventArgs e)
        {
            frmConcepto_Agregar frmConcepto_Agregar = new frmConcepto_Agregar();
            frmConcepto_Agregar.Text = "GESTIÓN COBROS / CONCEPTOS / GESTIONAR / AGREGAR";
            frmConcepto_Agregar.ShowDialog();
        }

        private void btnCon_Editar_Click(object sender, EventArgs e)
        {
            frmConcepto_Editar frmConcepto_Editar = new frmConcepto_Editar();
            frmConcepto_Editar.Text = "GESTIÓN COBROS / CONCEPTOS / GESTIONAR / EDITAR";
            frmConcepto_Editar.ShowDialog();
        }

        private void btnCon_Eliminar_Click(object sender, EventArgs e)
        {
            frmConcepto_Eliminar frmConcepto_Eliminar = new frmConcepto_Eliminar();
            frmConcepto_Eliminar.Text = "GESTIÓN COBROS / CONCEPTOS / GESTIONAR / ELIMINAR";
            frmConcepto_Eliminar.ShowDialog();
        }

       
    }
}
