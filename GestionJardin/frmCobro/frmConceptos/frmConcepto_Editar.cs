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
    public partial class frmConcepto_Editar : Form
    {
        string id_concepto;
        string nombre_concepto;
        decimal valor_actual;
        DateTime fecha_inicio;
        decimal valor_anterior;
        string estado_concepto;



        public frmConcepto_Editar(string idConceptoSelect, string NombreConceptoSelect, string ValorActualConceptoSelect, DateTime Fecha_InicioSelect, string Valor_anteriorSelect, string EstadoConceptosSelect)
        {
            InitializeComponent();
            lbl_titulo_conceptos.Text = "ACTUALIZAR CONCEPTO : " + NombreConceptoSelect + "";
            id_concepto = idConceptoSelect;
            nombre_concepto = NombreConceptoSelect;
            valor_actual =Convert.ToDecimal(ValorActualConceptoSelect);
            valor_anterior = Convert.ToDecimal(Valor_anteriorSelect);
            fecha_inicio = Fecha_InicioSelect;
            estado_concepto = EstadoConceptosSelect;

            if (estado_concepto == "INACTIVO")
            {
                DialogResult dialogResult = MessageBox.Show("¿DESEA HABILITAR EL CONCEPTO?", "HABILITACIÓN CONCEPTO", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    logConcepto objLogConcepto = new logConcepto();
                    entConcepto ObjEntConcepto = new entConcepto();
                    ObjEntConcepto.CON_ID = Convert.ToInt32(id_concepto);

                    string rtdo_habilitacion = objLogConcepto.ActualizarEstadoS(ObjEntConcepto);
                    MessageBox.Show(rtdo_habilitacion);
                    //this.Close();
                }
                else 
                {
                    this.Close();
                                    }

            }
            }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

                    if (txt_valor_actualizar.Text == "")
                    {
                        MessageBox.Show("Debe colocar un nuevo importe");
                        txt_valor_actualizar.Focus();

                    }

                    else
                    {
                        string resultado;
                        logConcepto objlogConcepto = new logConcepto();
                        frmConcepto objfrmConcepto = new frmConcepto();
                        logHistorial objlogHistorial = new logHistorial();
                        string fecha_actualizacion = DateTime.Today.ToString(("yyyy-MM-dd"));
                        string fecha_ult_actualizacion;
                        string fecha_hasta = DateTime.Today.ToString("yyyy-MM-dd");
                        decimal valor_nuevo = Convert.ToDecimal(txt_valor_actualizar.Text);


                        if (valor_anterior == 0)
                        {
                            fecha_ult_actualizacion = fecha_inicio.ToString("yyyy - MM - dd");
                        }
                        else
                        {
                            fecha_ult_actualizacion = fecha_actualizacion;
                        }

                        entConcepto objentConcepto = new entConcepto();
                        objentConcepto.CON_ID = Convert.ToInt32(id_concepto);
                        objentConcepto.CON_FECHA_ACT = DateTime.Today;
                        objentConcepto.CON_VALOR_ANTERIOR = valor_actual;
                        objentConcepto.CON_FECHA_INI = fecha_inicio;
                        objentConcepto.CON_VALOR_ACTUAL = valor_nuevo;

                        entHistorial objentHistorial = new entHistorial();
                        objentHistorial.HIS_CON_ID = Convert.ToInt32(id_concepto);
                        objentHistorial.HIS_VALOR_ANTERIOR = valor_actual;
                        string his_desde;
                        string his_hasta;
                        if (valor_anterior == 0)
                        {
                            his_desde = fecha_inicio.ToString("yyyy - MM - dd");
                        }
                        else
                        {
                            his_desde = fecha_ult_actualizacion;
                        }

                        his_hasta = fecha_actualizacion;

                        resultado = objlogConcepto.ActualizarMonto(objentConcepto, fecha_hasta, fecha_ult_actualizacion);
                        string resultado_historial = objlogHistorial.InsertarHistorialConceptos(objentHistorial, his_hasta, his_desde);



                        MessageBox.Show(resultado);
                        MessageBox.Show(resultado_historial);


                        this.Close();
                    }
                }

            
        
       
    }
}
