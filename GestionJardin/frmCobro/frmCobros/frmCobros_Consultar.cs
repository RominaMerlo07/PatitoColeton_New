using CaLog;
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
        logCobros objCobros = new logCobros();

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
            if (txtCob_Buscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese alumno");
            }
            else
            {
                lblBuscar.Visible = false;
                string alumno = txtCob_Buscar.Text;
                dgvCobros.DataSource = objCobros.InsetarDatosCobrosenformBuscar(alumno);
            }
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
            DataTable dt = objCobros.AutocompletarenCobros();
            foreach (DataRow row in dt.Rows)
            {
                txtCob_Buscar.AutoCompleteCustomSource.Add(row[0].ToString());
            }
        }

        
    }
}
