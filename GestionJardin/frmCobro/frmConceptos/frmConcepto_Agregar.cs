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
    public partial class frmConcepto_Agregar : Form
    {

        

        public frmConcepto_Agregar()
        {
            InitializeComponent();
        }

        private void frmConcepto_Agregar_Load(object sender, EventArgs e)
        {
            DataTable dt_conceptos = new DataTable();
            txtOtros.Visible = true;
            logConcepto objMetConcepto = new logConcepto();
            dt_conceptos = objMetConcepto.CargaDtNombreConcepto();

           

            for (int i = 0; i < dt_conceptos.Rows.Count; i++)
            {
                string resultado_dt;

                resultado_dt = dt_conceptos.Rows[i]["CONCEPTO"].ToString();

                if (resultado_dt != null)
                {

                    cbConcepto.Items.Remove(resultado_dt);
                }

            }


        }


        private void btnGuardar_Click(object sender, EventArgs e)

        {
            if (cbConcepto.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un concepto.");
                cbConcepto.Focus();
            }
            
            else if (txt_valor.Text =="")
            {
                MessageBox.Show("Debe colocar un valor al concepto.");
                txt_valor.Focus();

            }

           
            else
            {
            string nombre_concepto = cbConcepto.SelectedItem.ToString();
            decimal valor_actual = Convert.ToDecimal(txt_valor.Text.Trim());
            DateTime fecha_inicio = DateTime.Today;
            string activo = "S";
            decimal valor_anterior = 0;
                logConcepto objlogConcepto = new logConcepto();

                entConcepto Insertar_Concepto = new entConcepto();


                Insertar_Concepto.CON_CONCEPTO = nombre_concepto;
                Insertar_Concepto.CON_VALOR_ACTUAL = valor_actual;
                Insertar_Concepto.CON_FECHA_INI = fecha_inicio;
                Insertar_Concepto.CON_ACTIVO = activo;
                Insertar_Concepto.CON_FECHA_ULT_ACT = fecha_inicio;
                Insertar_Concepto.CON_VALOR_ANTERIOR = valor_anterior;



                string resultado = objlogConcepto.InsertarConcepto(Insertar_Concepto);


                MessageBox.Show(resultado);


                
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
