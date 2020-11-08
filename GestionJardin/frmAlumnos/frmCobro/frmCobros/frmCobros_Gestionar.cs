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
    public partial class frmCobros_Gestionar : Form
    {
        public frmCobros_Gestionar()
        {
            InitializeComponent();
        }

        private void btnCob_Agregar_Click(object sender, EventArgs e)
        {
            frmCobros_Cobrar frmCobros_Cobrar = new frmCobros_Cobrar();
            frmCobros_Cobrar.Text = "GESTIÓN COBROS / COBROS / GESTIONAR / COBRAR";
            frmCobros_Cobrar.ShowDialog();
        }

        private void btnCob_Eliminar_Click(object sender, EventArgs e)
        {
            frmCobros_Anular frmCobros_Anular = new frmCobros_Anular();
            frmCobros_Anular.Text = "GESTIÓN COBROS / COBROS / GESTIONAR / ANULAR";
            frmCobros_Anular.ShowDialog();
        }
    }
}
