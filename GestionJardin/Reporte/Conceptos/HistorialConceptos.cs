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
    public partial class HistorialConceptos : Form
    {
        logConcepto logConcepto = new logConcepto();
        int idConcepto;

        public HistorialConceptos()
        {
            InitializeComponent();
        }

        private void cbConcepto_SelectedValueChanged(object sender, EventArgs e)
        {
            string concepto;

            concepto = cbConcepto.SelectedItem.ToString();

            idConcepto = logConcepto.idConcepto(concepto);
        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            dgv_Concepto.Visible = true;
            btnImprimir.Visible = true;

            dgv_Concepto.DataSource = logConcepto.TablaPorConceptos(idConcepto, dtDesde.Value, dtHasta.Value);
                                 
            dgv_Concepto.Columns["HIS_ID"].Visible = false;
            dgv_Concepto.Columns["FECHA"].Visible = false;

            this.dgv_Concepto.Columns["CONCEPTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv_Concepto.Columns["FECHA ALTA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Concepto.Columns["VALOR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv_Concepto.Columns["FECHA DESDE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Concepto.Columns["FECHA HASTA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            HistConceptos HistConceptos = new HistConceptos(idConcepto,dtDesde.Value,dtHasta.Value);
        }
    }
}
