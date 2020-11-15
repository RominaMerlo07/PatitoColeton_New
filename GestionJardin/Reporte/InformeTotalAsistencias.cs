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
    public partial class InformeTotalAsistencias : Form
    {

        logAsistencia logAsistencia = new logAsistencia();
        public InformeTotalAsistencias(string idSala, string fechaDesde, string fechaHasta)
        {
            InitializeComponent();
            DataSet informe = logAsistencia.InformeTotalAsistencias(idSala, fechaDesde, fechaHasta);
            var reportPath = "GestionJardin.InformeTotalAsistencias.rdlc";

            ReportDataSource sReportDataSource = new ReportDataSource();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
            sReportDataSource.Name = "DataSet1";
            sReportDataSource.Value = informe.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(sReportDataSource);
            this.reportViewer1.LocalReport.Print();
            this.reportViewer1.RefreshReport();
        }

        //private void InformeTotalAsistencias_Load(object sender, EventArgs e)
        //{

        //    this.reportViewer1.RefreshReport();
        //}
    }
}
