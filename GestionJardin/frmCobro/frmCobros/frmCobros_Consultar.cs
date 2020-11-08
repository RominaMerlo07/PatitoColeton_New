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
    public partial class frmCobros_Consultar : Form
    {
        public frmCobros_Consultar()
        {
            InitializeComponent();
        }

        private void txtCob_Buscar_ButtonClick(object sender, EventArgs e)
        {
            lblBuscar.Visible = false;
            lblDesde.Visible = true;
            dt_FechaDesde.Visible = true;
            lblHasta.Visible = true;
            dt_FechaHasta.Visible = true;
            btnFiltro.Visible = true;
            lblFiltro.Visible = true;
            lblInfo.Visible = true;
        }

        private void txtCob_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txtCob_Buscar.Text.Length == 0)
            {
                lblBuscar.Visible = true;
                dgvCobros.DataSource = null;
                dgvCobros.Refresh();
                lblDesde.Visible = false;
                dt_FechaDesde.Visible = false;
                lblHasta.Visible = false;
                dt_FechaHasta.Visible = false;
                btnFiltro.Visible = false;
                lblFiltro.Visible = false;
                lblInfo.Visible = false;
            }
        }

        private void frmCobros_Consultar_Load(object sender, EventArgs e)
        {
            lblBuscar.Visible = true;
            dgvCobros.DataSource = null;
            dgvCobros.Refresh();           
        }

        
    }
}
