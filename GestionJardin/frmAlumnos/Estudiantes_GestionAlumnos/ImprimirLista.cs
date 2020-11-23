using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Drawing.Imaging;
using System.IO;

using CaLog;


namespace GestionJardin
{
    public partial class ImprimirLista : Form
    {
        string id_sala;
        logPersonas logPersonas = new logPersonas();
        logSalas LogSalas = new logSalas();

        public ImprimirLista()
        {
            InitializeComponent();
        }

        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {
            id_sala = cbSala.SelectedValue.ToString();
            btnImprimir.Visible = true;
            dgvAlumnosSala.Visible = true;
            lblInfo.Visible = false;
            dgvAlumnosSala.DataSource = logPersonas.AlumnosSalas(id_sala);

            this.dgvAlumnosSala.Columns["ALUMNO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvAlumnosSala.Columns["DOCUMENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvAlumnosSala.Columns["EDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            reportViewer1.Visible = true;

            DataSet informe = LogSalas.CantidadAlumnosSalas();
            var reportPath = "GestionJardin.Reporte.Alumnos.CantidadAlumnosSala.rdlc";

            ReportDataSource sReportDataSource = new ReportDataSource();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
            sReportDataSource.Name = "CantidadAlumnosSala";
            sReportDataSource.Value = informe.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(sReportDataSource);
            this.reportViewer1.RefreshReport();            
        }


       

        private void cargar_cbSala()
        {

            cbSala.SelectedValueChanged -= new EventHandler(cbSala_SelectedValueChanged);


            string indexTurno = cbTurno.SelectedIndex.ToString();
            logSalas objlogSalas = new logSalas();
            DataTable Tabla = new DataTable();
            Tabla = objlogSalas.ListarSalas(indexTurno);

            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";
            cbSala.DataSource = Tabla;
            cbSala.SelectedItem = null;
            cbSala.Enabled = true;

            cbSala.SelectedValueChanged += new EventHandler(cbSala_SelectedValueChanged);

        }

        private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            cargar_cbSala();      
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ListaAlumnos ListaAlumnos = new ListaAlumnos(id_sala);           

        }

        private void cbTurno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == true)
            {
                cbTurno.Style = MetroFramework.MetroColorStyle.Red;
                cbTurno.Focus();
                lblTurno.Visible = true;
                lblTurno.Text = "Por favor seleccione un turno";
            }
            else
            {
                lblTurno.Visible = false;
            }
        }

        private void cbSala_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == true)
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Visible = true;
                lblSala.Text = "Por favor seleccione una sala";
            }
            else
            {
                lblSala.Visible = false;
            }
        }

        
    }
}
