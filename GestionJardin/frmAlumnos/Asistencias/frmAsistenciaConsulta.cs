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
    public partial class frmAsistenciaConsulta : Form
    {
        DateTime fechaDesde;
        DateTime fechaHasta;
        string id_sala;
        string id_persona;

        logAsistencia logAsistencia = new logAsistencia();

        public frmAsistenciaConsulta()
        {
            InitializeComponent();
        }

        private void frmAsistenciaConsulta_Load(object sender, EventArgs e)
        {
            Inicializar();
            Settooltip();
        }

        private void Settooltip()
        {
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(this.btn_Informe, "Aquí puede imprimir la lista de asistencias e inasistencias acumuladas");
            Tip.SetToolTip(this.btnGraficoAusencias, "Aquí puede visualizar graficamente el total de asistencias e inasistencias acumuladas");
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

        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {
            id_sala = cbSala.SelectedValue.ToString();
        }

        private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            cargar_cbSala();
        }

        private void cbTurno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == true)
            {
                cbTurno.Style = MetroFramework.MetroColorStyle.Red;
                cbTurno.Focus();
                lblTurno.Visible = true;
                lblTurno.Text = "Por favor seleccione un turno";
            }
            else
            {
                lblTurno.Visible = false;
            }
        }


        private void cbSala_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == true)
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Visible = true;
                lblSala.Text = "Por favor seleccione una sala";
            }
            else
            {
                lblSala.Visible = false;
            }
        }

        private void dtp_FechaHasta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dtp_FechaHasta.Text.Trim()) == false)
            {
                if (dtp_FechaDesde.Value > dtp_FechaHasta.Value)
                {
                    dtp_FechaHasta.Value = DateTime.Today;
                    dtp_FechaDesde.Value = DateTime.Today;
                    dtp_FechaDesde.Focus();
                    MessageBox.Show("La fecha 'DESDE' no puede ser mayor a la fecha 'HASTA'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }           
        }


        private string ValidaCampos()
        {
            string result = "OK";

            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == true)
            {
                cbTurno.Style = MetroFramework.MetroColorStyle.Red;
                cbTurno.Focus();
                lblTurno.Visible = true;
                result = "Por favor seleccione un turno";
                lblTurno.Text = result;

            }
            else if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == true)
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Visible = true;
                result = "Por favor seleccione una sala";
                lblSala.Text = result;

            }
            else if (string.IsNullOrWhiteSpace(dtp_FechaHasta.Text.Trim()) == false)
            {
                if (dtp_FechaDesde.Value > dtp_FechaHasta.Value)
                {
                    result = "La fecha desde no puede ser mayor a la fecha hasta";
                    MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtp_FechaDesde.Focus();
                    dtp_FechaDesde.Value = DateTime.Today;
                    dtp_FechaHasta.Value = DateTime.Today;
                }

            }
            else
            {
                result = "OK";
            }

            return result;
        }


        private void Inicializar()
        {
            txtGAs_Buscar.Visible = false;
            dgv_Alumnos.Visible = false;

            lblTurno.Visible = false;
            lblSala.Visible = false;
            btn_Informe.Visible = false;

            dgv_Alumnos.ClearSelection();
            cbTurno.Focus();
            cbTurno.SelectedIndex = -1;
            cbSala.SelectedIndex = -1;

            dtp_FechaDesde.Value = DateTime.Today;
            dtp_FechaDesde.MaxDate = DateTime.Today;
            dtp_FechaHasta.Value = DateTime.Today;
            dtp_FechaHasta.MaxDate = DateTime.Today;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string validacion = ValidaCampos();
            if(validacion == "OK")
            {
                fechaDesde = dtp_FechaDesde.Value;
                fechaHasta = dtp_FechaHasta.Value;
                txtGAs_Buscar.Visible = true;
                dgv_Alumnos.Visible = true;
                btn_Informe.Visible = true;
                btnGraficoAusencias.Visible = true;
                dgv_Alumnos.ClearSelection();

                dgv_Alumnos.DataSource = logAsistencia.GrillaAsistenciaConsultar(id_sala, fechaDesde.ToShortDateString(), fechaHasta.ToShortDateString());
                dgv_Alumnos.Columns["PER_ID"].Visible = false;
                dgv_Alumnos.Columns["PER_ID"].Frozen = true;
                dgv_Alumnos.Columns["ALUMNO"].Frozen = true;
                dgv_Alumnos.Columns["DOCUMENTO"].Frozen = true;
            }
            else
            {
                MessageBox.Show("Por favor verifique los datos ingresados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void carga_grilla_filtrada()
        {
            DataTable col = new DataTable();
            logPersonas logPersonas = new logPersonas();
            col = logAsistencia.GrillaAsistenciaConsultar(id_sala, fechaDesde.ToShortDateString(), fechaHasta.ToShortDateString());
            dgv_Alumnos.DataSource = col;
            string apellido_nombre = logPersonas.extraerapellido_nombre_alumno(txtGAs_Buscar.Text);
            col.DefaultView.RowFilter = String.Format($"ALUMNO LIKE '{apellido_nombre}%'");
        }

        private void txtGAs_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txtGAs_Buscar.Text.Length > 0)
            {
                carga_grilla_filtrada();
                dgv_Alumnos.Columns["PER_ID"].Frozen = true;
                dgv_Alumnos.Columns["ALUMNO"].Frozen = true;
                dgv_Alumnos.Columns["DOCUMENTO"].Frozen = true;
            }
            else
            {

                txtGAs_Buscar.Clear();
                dgv_Alumnos.DataSource = logAsistencia.GrillaAsistenciaConsultar(id_sala, fechaDesde.ToShortDateString(), fechaHasta.ToShortDateString());
                dgv_Alumnos.Columns["ALUMNO"].Frozen = true;
                dgv_Alumnos.Columns["DOCUMENTO"].Frozen = true;
            }
        }

        private void btn_Informe_Click(object sender, EventArgs e)
        {
            InformeTotalAsistencias InformeTotalAsistencias = new InformeTotalAsistencias(id_sala, fechaDesde.ToShortDateString(),fechaHasta.ToShortDateString());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            informeTotalAusencias informeTotalAusencias = new informeTotalAusencias(id_sala, fechaDesde.ToShortDateString(), fechaHasta.ToShortDateString());
            informeTotalAusencias.Show();
        }
    }
}