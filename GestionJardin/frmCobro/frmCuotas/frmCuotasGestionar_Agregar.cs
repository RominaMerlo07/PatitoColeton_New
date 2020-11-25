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
    public partial class frmCuotasGestionar_Agregar : Form
    {
        string id_alumno;
        string nombre_alumno;
        string importe_cuota;
        string dni_alumno;
        string fecha_vencimiento;
        string n_cuota;

        DataTable dtCargos = new DataTable();
        logCuota objlogCuota = new logCuota();
       
        public frmCuotasGestionar_Agregar(string idAlumnoSelect, string nombreAlumnoSelect, string docAlumnoSelect, string nCuotaSelect, string importeCuotaSelect, string fechaVenciSelect)
        {
            InitializeComponent();
            n_cuota = nCuotaSelect;
            nombre_alumno = nombreAlumnoSelect;
            dni_alumno = docAlumnoSelect;
            importe_cuota = importeCuotaSelect;
            fecha_vencimiento = fechaVenciSelect;

            lblCargos.Text = "CUOTA N°: " + n_cuota + "   ALUMNO: " + nombre_alumno + "    DNI: " + dni_alumno + "";
            txt_importe_sala.Text = "" + importe_cuota + " ";
            txt_fecha_venc.Text = "" + fecha_vencimiento + "";


        }

        private void CargarDgvCargos()
        {   
            
            dgvCargos.DataSource = dtCargos;

            dtCargos.Columns.Add("NOMBRE CONCEPTO");
            dtCargos.Columns.Add("IMPORTE UNITARIO");
            dtCargos.Columns.Add("IMPORTE TOTAL");

            

        }

        private void frmCuotasGestionar_Agregar_Load(object sender, EventArgs e)
        {
            CargarDgvCargos();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DataRow row = dtCargos.NewRow();

            ObtenerTotalCuota();

                if (cbCargos.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un concepto.");

                }
                else if (cbCargos.SelectedItem.ToString() == "HORAS EXTRAS")
                {
                    lbHorasExtras.Visible = true;
                    txtCantHsEx.Visible = true;
                    decimal cant_horas = Convert.ToDecimal(txtCantHsEx.Text);
                    int id_Hs_Ex = objlogCuota.Id_Cargo_HS_Extras();

                    row["NOMBRE CONCEPTO"] = cbCargos.SelectedItem.ToString();
                    row["IMPORTE UNITARIO"] = objlogCuota.Monto_Cargos(id_Hs_Ex);
                    row["IMPORTE TOTAL"] = objlogCuota.Monto_Cargos(id_Hs_Ex) * cant_horas;
                    dtCargos.Rows.Add(row);
                

                }
                else
                {
                    lbHorasExtras.Visible = false;
                    txtCantHsEx.Visible = false;
                    int id_Mat_Did = objlogCuota.Id_Cargo_MatDid();

                    row["NOMBRE CONCEPTO"] = cbCargos.SelectedItem.ToString();
                    row["IMPORTE UNITARIO"] = objlogCuota.Monto_Cargos(id_Mat_Did);
                    row["IMPORTE TOTAL"] = objlogCuota.Monto_Cargos(id_Mat_Did);
                    dtCargos.Rows.Add(row);

                }

               
            }

        private void ObtenerTotalCuota()
        {
            int suma = 0;
            foreach (DataRow dr in dtCargos.Rows)
            {
                suma += Convert.ToInt32(dr[2]);
            }

            
            char patron = '$';
            string [] importe = txt_importe_sala.Text.Split(patron);
            string monto_sala = importe[1];
            
            int  cuota_total = Convert.ToInt32 (monto_sala) + suma;
            txtTotal.Text = cuota_total.ToString(); 
        }

        private void cbCargos_SelectedValueChanged(object sender, EventArgs e)

        {
            if (cbCargos.SelectedItem.ToString() == "HORAS EXTRAS")
            {
                lbHorasExtras.Visible = true;
                txtCantHsEx.Visible = true;
            }
            else
            {
                lbHorasExtras.Visible = false;
                txtCantHsEx.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObtenerTotalCuota();
        }
    }
        }
        
    
