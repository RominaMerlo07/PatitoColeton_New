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
    public partial class frmCuotasGestionar : Form
    {
        int sala;
        public frmCuotasGestionar()
        {
            InitializeComponent();
        }

        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == false && string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == false)
            {
                lbl_Continuar.Visible = false;
                lblInfo.Visible = true;
                dgvAlumnos.Visible = true;
                txtBuscar.Visible = true;
                btnGenerar.Visible = true;
                btnCargos.Visible = true; // se deben iniciar en gray
                btn_anular_cuota.Visible = true; // se deben iniciar en gray

                string turno = cbTurno.SelectedItem.ToString();

                if (cbTurno.SelectedItem.ToString() == "MAÑANA")
                {
                    turno = "MANANA";
                }

                sala = Convert.ToInt32(cbSala.SelectedValue.ToString());
                DataTable alu = new DataTable();
                logCuota objLogCuota = new logCuota();
                alu = objLogCuota.traerAlumnosSala(sala);
                dgvAlumnos.DataSource = alu;

            }

        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                btnCargos.IconColor = Color.FromArgb(255, 128, 0);
                
                btnCargos.ForeColor = Color.FromArgb(255, 128, 0);

                string idAlumnoSelect = dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString();
                string nombreAlumnoSelect = dgvAlumnos.SelectedRows[0].Cells[1].Value.ToString();
                string docAlumnoSelect = dgvAlumnos.SelectedRows[0].Cells[2].Value.ToString();
                string nCuotaSelect = dgvAlumnos.SelectedRows[0].Cells[3].Value.ToString();
                string importeCuotaSelect = dgvAlumnos.SelectedRows[0].Cells[4].Value.ToString();
                string fechaVenciSelect = dgvAlumnos.SelectedRows[0].Cells[6].Value.ToString();

                frmCuotasGestionar_Agregar frmCuotasGestionar_Agregar = new frmCuotasGestionar_Agregar(idAlumnoSelect, nombreAlumnoSelect, docAlumnoSelect, nCuotaSelect, importeCuotaSelect, fechaVenciSelect);
                
            frmCuotasGestionar_Agregar.Text = "GESTIÓN COBROS / CUOTAS / GESTIONAR / APLICAR CARGOS";
            frmCuotasGestionar_Agregar.ShowDialog();
            }

            else 
            {
                btn_anular_cuota.IconColor = Color.Gray;
                btn_anular_cuota.ForeColor = Color.Gray;

            }
                
        }

       

        private void cargar_cbSala()
        {

            cbSala.SelectedValueChanged -= new EventHandler(cbSala_SelectedValueChanged);


            string indexTurno = cbTurno.SelectedIndex.ToString();
            logSalas objlogSalas = new logSalas();
            DataTable Tabla = new DataTable();
            Tabla = objlogSalas.ListarSalas(indexTurno);

            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";
            cbSala.DataSource = Tabla;
            cbSala.SelectedItem = null;
            cbSala.Enabled = true;

            cbSala.SelectedValueChanged += new EventHandler(cbSala_SelectedValueChanged);

        }

        private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            cargar_cbSala();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int sala = Convert.ToInt32(cbSala.SelectedValue.ToString());
            logCuota objLogCuota = new logCuota();
            decimal monto_cuota = objLogCuota.Monto_Cuota(sala);
            int id_alumno;


            
            for (int i = 0; i < dgvAlumnos.Rows.Count; i++)
            {
                
                id_alumno = Convert.ToInt32( dgvAlumnos.Rows[i].Cells[0].Value);
                int cuo_id = Convert.ToInt32( objLogCuota.GeneraraCuota(monto_cuota, id_alumno));
                int idConcepto = objLogCuota.ExtraerId_concepto_Cuotas(sala);
                objLogCuota.InsertarCuotaDetalle(cuo_id, idConcepto, monto_cuota);
               
                DataTable alu = new DataTable();
                alu = objLogCuota.traerAlumnosSala(sala);
                dgvAlumnos.DataSource = alu;

            }

        }

        private void btn_anular_cuota_Click(object sender, EventArgs e)
        {
            frmCuotasGestionar_Anular frmCuotasGestionar_Anular = new frmCuotasGestionar_Anular();
            frmCuotasGestionar_Anular.Text = "GESTIÓN COBROS / CUOTAS / GESTIONAR / ANULAR";
            frmCuotasGestionar_Anular.ShowDialog();
        }
    }
}
