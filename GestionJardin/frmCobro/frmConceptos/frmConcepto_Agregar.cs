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
            if (cbConcepto.SelectedItem != null && txt_valor.Text.Length != 0)
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

                MessageBox.Show(resultado, "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbConcepto_Leave(object sender, EventArgs e)
        {
            
             if (string.IsNullOrWhiteSpace(cbConcepto.Text.Trim()) == true)
             {
                  cbConcepto.Style = MetroFramework.MetroColorStyle.Red;
                  cbConcepto.Focus();
                  lblConcepto.Visible = true;
                  lblConcepto.Text = "Por favor seleccione un concepto";
             }
             else
             {
                    lblConcepto.Visible = false;
             }
            
        }

        private void txt_valor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_valor.Text.Trim()) == true)
            {
                txt_valor.Style = MetroFramework.MetroColorStyle.Red;
                txt_valor.Focus();
                lblValor.Visible = true;
                lblValor.Text = "Por favor ingrese un valor";
            }
            else
            {
                lblValor.Visible = false;
            }
        }
    }
}
