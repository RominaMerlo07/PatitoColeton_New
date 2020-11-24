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
                btnCon_Eliminar.Visible = true; // se deben iniciar en gray

                string turno = cbTurno.SelectedItem.ToString();

                if (cbTurno.SelectedItem.ToString() == "MAÑANA")
                {
                    turno = "MANANA";
                }

                int sala = Convert.ToInt32(cbSala.SelectedValue.ToString());
                DataTable alu = new DataTable();
                logCuota objLogCuota = new logCuota();
                alu = objLogCuota.traerAlumnosSala(sala);
                dgvAlumnos.DataSource = alu;

            }

        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            frmCuotasGestionar_Agregar frmCuotasGestionar_Agregar = new frmCuotasGestionar_Agregar();
            frmCuotasGestionar_Agregar.Text = "GESTIÓN COBROS / CUOTAS / GESTIONAR / APLICAR CARGOS";
            frmCuotasGestionar_Agregar.ShowDialog();
        }

        private void btnCon_Eliminar_Click(object sender, EventArgs e)
        {
            frmCuotasGestionar_Anular frmCuotasGestionar_Anular = new frmCuotasGestionar_Anular();
            frmCuotasGestionar_Anular.Text = "GESTIÓN COBROS / CUOTAS / GESTIONAR / ANULAR";
            frmCuotasGestionar_Anular.ShowDialog();
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

        //public void Carga_grilla_AlumnosCuotas()
        //{
        //    string turno=cbTurno.SelectedItem.ToString();

        //    if (cbTurno.SelectedItem.ToString() == "MAÑANA")
        //    {
        //        turno = "MANANA";
        //    }

        //    string sala = cbSala.SelectedItem.ToString();
        //    DataTable alu = new DataTable();
        //    logCuota objLogCuota = new logCuota();
        //    alu = objLogCuota.VisualizarAlumnosporSalaTurno("TARDE", "ROSA"/*turno, sala*/);
        //    dgvAlumnos.DataSource = alu;



        //}


    }
}
