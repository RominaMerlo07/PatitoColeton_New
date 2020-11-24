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

namespace GestionJardin
{
    public partial class frmCobros_Gestionar : Form
    {
        logCobros objCobros = new logCobros();


        public frmCobros_Gestionar()
        {
            InitializeComponent();

        }
        /*************LOAD **************/
    
        private void frmCobros_Gestionar_Load(object sender, EventArgs e)
        {
              lblBuscar.Visible = true;
              dgvCobros.DataSource = null;
              dgvCobros.Refresh();

              DataTable dt = objCobros.AutocompletarenCobros();
              foreach (DataRow row in dt.Rows)
              {
                txt_Buscar.AutoCompleteCustomSource.Add(row[0].ToString()); 
              }

              
         }

        /******  buscar datos Grilla ******/
        private void txtCob_Buscar_ButtonClick(object sender, EventArgs e)
        {
            lblBuscar.Visible = false;
            string alumno= txt_Buscar.Text;
            dgvCobros.DataSource = objCobros.InsetarDatosCobrosenformBuscar(alumno);         
                     
        }

        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            //lblBuscar.Visible = false;
            //string alumno = txt_Buscar.Text;
            //dgvCobros.DataSource = objCobros.InsetarDatosCobrosenformBuscar(alumno);
        }

        /****** Condicional Semaforo Grilla ******/

        private void dgvCobros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int dia = DateTime.Today.Day;
            int mes = DateTime.Today.Month;

            if (this.dgvCobros.Columns[e.ColumnIndex].Name == "ESTADO")
            {
            
                string valor = Convert.ToString(e.Value);             

                if (valor.Trim() == "ADEUDADA" && dia > 10 && (mes >=11 && mes <= 12))
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Red;                  
                   
                }
                else if (valor.Trim() == "PAGADA")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Green;               

                }
                else if (valor.Trim() == "ANULADA")
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Gray;               

                }
                else if (valor.Trim() == "ADEUDADA" && dia <= 10 && mes == 11)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Yellow;

                }
                else 
                {
                  
                }

            }
        }


        private void btnCob_Agregar_Click(object sender, EventArgs e)
        {
            frmCobros_Cobrar frmCobros_Cobrar = new frmCobros_Cobrar();
            frmCobros_Cobrar.Text = "GESTIÓN COBROS / COBROS / GESTIONAR / COBRAR";
            frmCobros_Cobrar.ShowDialog();
        }

        private void btnCob_Eliminar_Click(object sender, EventArgs e)
        {
            frmCobros_Anular frmCobros_Anular = new frmCobros_Anular();
            frmCobros_Anular.Text = "GESTIÓN COBROS / COBROS / GESTIONAR / ANULAR";
            frmCobros_Anular.ShowDialog();
        }

       

       

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text.Length == 0)
            {
                lblBuscar.Visible = true;
                dgvCobros.DataSource = null;
                dgvCobros.Refresh();
            }
        }

        
    }
}
