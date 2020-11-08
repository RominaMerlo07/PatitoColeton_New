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
    public partial class frmCuotasConsultar : Form
    {
        public frmCuotasConsultar()
        {
            InitializeComponent();
        }

        private void txtCob_Buscar_ButtonClick(object sender, EventArgs e)
        {
            lblBuscar.Visible = false;
            lblInfo.Visible = true; ;
        }

        private void frmCuotasConsultar_Load(object sender, EventArgs e)
        {
            lblBuscar.Visible = true;
            dgvCuotas.DataSource = null;
            dgvCuotas.Refresh();
        }

        private void txtCob_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text.Length == 0)
            {
                lblBuscar.Visible = true;
                lblInfo.Visible = false;
                dgvCuotas.DataSource = null;
                dgvCuotas.Refresh();
            }
        }
    }
}
