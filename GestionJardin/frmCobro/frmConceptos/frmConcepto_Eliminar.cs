using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaLog;
using CaEnt;


namespace GestionJardin
{
    public partial class frmConcepto_Eliminar : Form
    {

        int id_concepto;
       

        public frmConcepto_Eliminar(string idConceptoSelect, string nombreConceptoSelect)
        {
            InitializeComponent();
            

            id_concepto =Convert.ToInt32(idConceptoSelect);
            lbl_nombre_concepto.Text = "" + nombreConceptoSelect + "?";
        }

        private void btn_deshabilitar_concepto_Click(object sender, EventArgs e)
        {
            logConcepto objlogConcepto = new logConcepto();
            entConcepto objentConcepto = new entConcepto();
            objentConcepto.CON_ID = id_concepto;
            
            string resultado =objlogConcepto.DeshabilitarConcepto(objentConcepto);

            MessageBox.Show(resultado);
            this.Close();
        }

        private void btn_canc_deshab_con_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
