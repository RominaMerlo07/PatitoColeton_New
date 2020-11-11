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
    public partial class frmCuotasGestionar : Form
    {
        public frmCuotasGestionar()
        {
            InitializeComponent();
        }              

        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == false && string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == false)
            {
                lbl_Continuar.Visible = false;
                lblInfo.Visible = true;
                dgvAlumnos.Visible = true;
                txtBuscar.Visible = true;
                btnGenerar.Visible = true;
                btnCargos.Visible = true; // se deben iniciar en gray
                btnCon_Eliminar.Visible = true; // se deben iniciar en gray
            }
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            frmCuotasGestionar_Agregar frmCuotasGestionar_Agregar = new frmCuotasGestionar_Agregar();
            frmCuotasGestionar_Agregar.Text = "GESTIÓN COBROS / CUOTAS / GESTIONAR / APLICAR CARGOS";
            frmCuotasGestionar_Agregar.ShowDialog();
        }

        private void btnCon_Eliminar_Click(object sender, EventArgs e)
        {
            frmCuotasGestionar_Anular frmCuotasGestionar_Anular = new frmCuotasGestionar_Anular();
            frmCuotasGestionar_Anular.Text = "GESTIÓN COBROS / CUOTAS / GESTIONAR / ANULAR";
            frmCuotasGestionar_Anular.ShowDialog();
        }
    }
}
