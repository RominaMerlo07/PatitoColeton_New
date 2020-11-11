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
    public partial class fichaAlumno : Form
    {
     
        logPersonas logPersonas = new logPersonas();

        public fichaAlumno(string idAlumno)
        {
            InitializeComponent();
          //  fichaAlumnoBindingSource.DataSource = logPersonas.fichaAlumno(idAlumno);
            DataSet informe = logPersonas.fichaAlumno(idAlumno);
            var reportPath = "GestionJardin.FichaAlumno.rdlc";
            
            ReportDataSource sReportDataSource = new ReportDataSource();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = reportPath;
            sReportDataSource.Name = "fichaAlumno";
            sReportDataSource.Value = informe.Tables[0];
            reportViewer1.LocalReport.DataSources.Add(sReportDataSource);
            this.reportViewer1.LocalReport.Print();
            this.reportViewer1.RefreshReport();

        }
            
    }
}
