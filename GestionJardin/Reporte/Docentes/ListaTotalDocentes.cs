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
    public partial class ListaTotalDocentes : Form
    {
        logPersonas logPersonas = new logPersonas();

        public ListaTotalDocentes()
        {
            InitializeComponent();
            DataSet informe = logPersonas.listaTotalDocentes();
            var reportPath = "GestionJardin.Reporte.Docentes.ListaTotalDocentes.rdlc";

            ReportDataSource sReportDataSource = new ReportDataSource();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
            sReportDataSource.Name = "ListaDocSala";
            sReportDataSource.Value = informe.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(sReportDataSource);
            this.reportViewer1.LocalReport.Print();
            this.reportViewer1.RefreshReport();
        }

       
    }
}
