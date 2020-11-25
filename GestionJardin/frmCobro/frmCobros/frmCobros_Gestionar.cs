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
        bool grillallena;

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
            if (txt_Buscar.Text.Equals(""))
            {
                MessageBox.Show("Ingrese alumno");
            }
            else
            {
                lblBuscar.Visible = false;
                string alumno = txt_Buscar.Text;
                dgvCobros.DataSource = objCobros.InsetarDatosCobrosenformBuscar(alumno);
            }

        }
        private void txt_Buscar_Enter(object sender, EventArgs e)
        {
            if(txt_Buscar.Text== "")
            {

            }
            else { 
            lblBuscar.Visible = false;
            string alumno = txt_Buscar.Text;
            dgvCobros.DataSource = objCobros.InsetarDatosCobrosenformBuscar(alumno);
            }
        }
        private void txt_Buscar_Click(object sender, EventArgs e)
        {
            //lblBuscar.Visible = false;
            //string alumno = txt_Buscar.Text;
            //dgvCobros.DataSource = objCobros.InsetarDatosCobrosenformBuscar(alumno);

        }

        /****** Condicional Semaforo Grilla ******/

        private void dgvCobros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           grillallena= true;
                if (this.dgvCobros.Columns[e.ColumnIndex].Name == "ESTADO")
                {

                    if (e.Value != null)
                    {
                        if (e.Value.GetType() != typeof(System.DBNull))
                        {
                            if (e.Value.ToString() == "ADEUDADA")
                            {
                                e.CellStyle.ForeColor = Color.Red;

                            }

                            if (e.Value.ToString() == "PAGADA")
                            {
                                e.CellStyle.ForeColor = Color.Green;

                            }

                        }
                    }
                }
            
        }



        private void btnCob_Agregar_Click(object sender, EventArgs e)
        {
            string fecha = "";
            string importe = "";
            string nroCuota = "";
            string nroDocumento = "";
            if (dgvCobros.Rows.Count == 0)
            {
                MessageBox.Show("No se ha ingresado alumno");
            }
            else
            {
                //Extraigo los datos de la cuota del alumno encontrado

                for (int i = 0; i < dgvCobros.Rows.Count; i++)
                {
                    fecha = dgvCobros.Rows[0].Cells[4].Value.ToString();
                    importe = dgvCobros.Rows[0].Cells[3].Value.ToString();
                    nroCuota = dgvCobros.Rows[0].Cells[2].Value.ToString();
                    nroDocumento = dgvCobros.Rows[0].Cells[1].Value.ToString();
                }
                frmCobros_Cobrar frmCobros_Cobrar = new frmCobros_Cobrar(nroCuota, fecha, importe, nroDocumento);
                frmCobros_Cobrar.Text = "GESTIÓN COBROS / COBROS / GESTIONAR / COBRAR";
                frmCobros_Cobrar.ShowDialog();
            }

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
