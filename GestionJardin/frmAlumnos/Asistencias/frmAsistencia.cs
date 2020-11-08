//using CapaAccesoDatos;
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
    public partial class frmAsistencia : Form
    {
        DateTime fechaCalendar;
        string id_sala;
        string turno;

        logAsistencia logAsistencia = new logAsistencia();       
        

        public frmAsistencia()
        {
            InitializeComponent();

            var weekends = GetDaysBetween(DateTime.Today.AddMonths(-12), DateTime.Today.AddMonths(12))
            .Where(d => d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday).ToArray();

            calFecha.RemoveAllBoldedDates();
            calFecha.BoldedDates = weekends;

        }

        IEnumerable<DateTime> GetDaysBetween(DateTime start, DateTime end)
        {
            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                yield return i;
            }
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {           
            Inicializar();
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
            id_sala = cbSala.SelectedValue.ToString(); //.ToString();            
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


        private string ValidaCampos()
        {
            string result = "";

            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == true)
            {
                cbTurno.Style = MetroFramework.MetroColorStyle.Red;
                cbTurno.Focus();
                lblTurno.Visible = true;
                result = "Por favor seleccione un turno";
                lblTurno.Text = result;
                lblFecha.Visible = true;
            }
            else if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == true)
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Visible = true;
                result = "Por favor seleccione una sala";
                lblSala.Text = result;
                lblFecha.Visible = true;
            }          
            else
            {
                result = "OK";
            }

            return result;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblAsistencia.ForeColor = Color.Gray;
            lblJustificado.ForeColor = Color.Gray;

            cboJustificado.Enabled = false;

            string validacion = ValidaCampos();         

            fechaCalendar = calFecha.SelectionStart.Date;

            if (fechaCalendar.DayOfWeek == DayOfWeek.Saturday || fechaCalendar.DayOfWeek == DayOfWeek.Sunday)
            {
               MessageBox.Show("Por favor seleccione un dia habil. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               lblFecha.Visible = false;
            }
            else
            {

                if (cbTurno.SelectedItem != null && cbSala.SelectedItem != null)
                {

                    fechaCalendar.ToShortDateString();
                    lblFecha.Text = fechaCalendar.ToString();

                    if (lblFecha.Text.Length > 0)
                    {
                        if (validacion == "OK")
                        {
                            dgv_Alumnos.Visible = true;
                            txtGAs_Buscar.Visible = true;
                            lblAsistencia.Visible = true;
                            cboAsistencia.Visible = true;
                            lblJustificado.Visible = true;
                            cboJustificado.Visible = true;
                            btnguardar.Visible = true;
                            btncancelar.Visible = true;
                            lblInfo.Visible = true;
                            btn_Informe.Visible = true;
                            dgv_Alumnos.ClearSelection();

                            labelFechError.Visible = false;
                            lblFecha.Visible = true;


                            turno = cbTurno.SelectedItem.ToString();

                            if (turno == "MAÑANA")
                            {
                                turno = "MANANA";
                            }
                            else
                            {
                                turno = "TARDE";
                            }

                            dgv_Alumnos.DataSource = logAsistencia.GrillaAsistencia(turno, id_sala, lblFecha.Text);

                            dgv_Alumnos.Columns["PER_ID"].Visible = false;
                            dgv_Alumnos.Columns["AS_ID"].Visible = false;

                            lblAusencias.Visible = true;
                            lblAusencias.Text = logAsistencia.infoAusencias(id_sala, lblFecha.Text);

                        }

                    }
                }
                else
                {
                    lblFecha.Visible = false;
                    MessageBox.Show("Por favor verifique los datos ingresados: ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }

            //  MessageBox.Show("Por favor verifique los datos ingresados: ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void cboAsistencia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboAsistencia.Text.Trim()) == true)
            {
                cboAsistencia.Style = MetroFramework.MetroColorStyle.Red;
                cboAsistencia.Focus();
                lbl_ErrorAsistencia.Visible = true;
                lbl_ErrorAsistencia.Text = "Seleccione un valor para asistencia";

            }
            else
            {
                lbl_ErrorAsistencia.Visible = false;
                if(cboAsistencia.SelectedItem.ToString() == "PRESENTE")
                {
                    cboJustificado.Enabled = false;
                    lblJustificado.ForeColor = Color.Gray;
                }
                else
                {
                    cboJustificado.Enabled = true;
                    lblJustificado.ForeColor = Color.Aqua;
                }

            }
        }

        private void cboJustificado_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboJustificado.Text.Trim()) == true)
            {
                cboJustificado.Style = MetroFramework.MetroColorStyle.Red;
                cboJustificado.Focus();
                lblErrorJustificado.Visible = true;
                lblErrorJustificado.Text = "Seleccione un valor para justificado";

            }
            else
            {
                lblErrorJustificado.Visible = false;
            }
        }

        private string validaCamposGuardar()
        { 
            string resultado = "OK";

            if (string.IsNullOrWhiteSpace(cboAsistencia.Text.Trim()) == true)
            {
                cboAsistencia.Style = MetroFramework.MetroColorStyle.Red;
                cboAsistencia.Focus();
                lbl_ErrorAsistencia.Visible = true;
                resultado = "Seleccione un valor para asistencia";
                lbl_ErrorAsistencia.Text = resultado;

            }
            else if (string.IsNullOrWhiteSpace(cboAsistencia.Text.Trim()) == false)
            {
                if (cboAsistencia.SelectedItem.ToString() == "PRESENTE")
                {
                    lbl_ErrorAsistencia.Visible = false;
                    cboJustificado.Enabled = false;
                    lblJustificado.ForeColor = Color.Gray;
                }
                else
                {
                    cboJustificado.Enabled = true;
                    lblJustificado.ForeColor = Color.Aqua;
                }
            }
            else if (string.IsNullOrWhiteSpace(cboJustificado.Text.Trim()) == true)
            {
                cboJustificado.Style = MetroFramework.MetroColorStyle.Red;
                cboJustificado.Focus();
                lblErrorJustificado.Visible = true;
                resultado = "Seleccione un valor para justificado";
                lblErrorJustificado.Text = resultado;
            }
            else
            {
                resultado = "OK";
            }

            return resultado;

        }

        private void cboAsistencia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboAsistencia.SelectedItem.ToString() == "PRESENTE")
            {
                lbl_ErrorAsistencia.Visible = false;
                cboJustificado.Enabled = false;
                lblJustificado.ForeColor = Color.Gray;
            }
            else
            {
                cboJustificado.Enabled = true;
                lblJustificado.ForeColor = Color.Aqua;
            }
        }

        private void carga_grilla_filtrada()
        {
            DataTable col = new DataTable();
            logPersonas logPersonas = new logPersonas();
            col = logAsistencia.GrillaAsistencia(turno, id_sala, lblFecha.Text);
            dgv_Alumnos.DataSource = col;
            string apellido_nombre = logPersonas.extraerapellido_nombre_alumno(txtGAs_Buscar.Text);
            col.DefaultView.RowFilter = String.Format($"ALUMNO LIKE '{apellido_nombre}%'");
        }


        private void txtGAs_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txtGAs_Buscar.Text.Length > 0)
            {
                carga_grilla_filtrada();
            }
            else
            {

                txtGAs_Buscar.Clear();
                dgv_Alumnos.DataSource = logAsistencia.GrillaAsistencia(turno, id_sala, lblFecha.Text);

            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_Alumnos.SelectedRows.Count; i++) { 

                string idPersonaSelect = dgv_Alumnos.SelectedRows[i].Cells[0].Value.ToString();
                Int32 id_asistencia = Convert.ToInt32(dgv_Alumnos.SelectedRows[i].Cells[1].Value.ToString());
                entAsistencia asist = new entAsistencia();

                
                asist.AS_PER_ID = Convert.ToInt32(idPersonaSelect);
                asist.AS_SAL_ID = Convert.ToInt32(id_sala);
                asist.AS_ASISTENCIA = cboAsistencia.SelectedIndex.ToString(); // 0 presente - 1 ausente

                /*Se modifica codigo para que si ingresa un presente no envie nada a justificado*/

                string asist_justificado;
                if (asist.AS_ASISTENCIA == "0" && cboJustificado.SelectedItem == null)
                {
                    asist.AS_JUSTIFICADO = null;
                }
                else
                {
                    asist_justificado = cboJustificado.SelectedIndex.ToString();
                    if (asist_justificado == "0")
                    {
                        asist.AS_JUSTIFICADO = "0";
                    }
                    else if (asist_justificado == "1")
                    {
                        asist.AS_JUSTIFICADO = "1";
                    }
                }                               

                DateTime asist_fecha = Convert.ToDateTime(calFecha.SelectionRange.Start.ToString());
                asist.AS_FECHA = Convert.ToDateTime(calFecha.SelectionRange.Start.ToString());
                Int32 asist_ano = Convert.ToInt32(asist_fecha.Year.ToString());
                asist.AS_ANO = asist_ano;
                Int32 asist_mes = Convert.ToInt32(asist_fecha.Month.ToString());
                asist.AS_SEMESTRE = asist_mes > 6 ? 2 : 1; //condicional ternario

                //
                if (id_asistencia != 0)
                {
                    asist.AS_ID = id_asistencia;                                        
                    logAsistencia.EditarAsistencia(asist);              
       
                    MessageBox.Show("Se actualizaron las asistencias", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblAusencias.Text = logAsistencia.infoAusencias(id_sala, lblFecha.Text);

                } else
                { 
                    logAsistencia.AgregarAsistencia(asist);
                    MessageBox.Show("Se registraron las asistencias", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblAusencias.Text = logAsistencia.infoAusencias(id_sala, lblFecha.Text);
                }

            }

            txtGAs_Buscar.Clear();
            dgv_Alumnos.DataSource = logAsistencia.GrillaAsistencia(turno, id_sala, lblFecha.Text);

        }

        private void Inicializar()
        {
            txtGAs_Buscar.Visible = false;
            dgv_Alumnos.Visible = false;

            labelFechError.Visible = false;
            lblTurno.Visible = false;
            lblSala.Visible = false;
            lblFecha.Visible = false;
            lblAsistencia.Visible = false;
            cboAsistencia.Visible = false;
            lblJustificado.Visible = false;
            cboJustificado.Visible = false;
            lblAusencias.Visible = false;
            lblErrorJustificado.Visible = false;
            lblInfo.Visible = false;
            btn_Informe.Visible = false;

            

            btnguardar.Visible = false;
            btncancelar.Visible = false;
            dgv_Alumnos.ClearSelection();
            cbTurno.Focus();
            cbTurno.SelectedIndex = -1;
            cbSala.SelectedIndex = -1;

            calFecha.MaxSelectionCount = 1;
            calFecha.MaxDate = DateTime.Today;
            calFecha.SetDate(DateTime.Today);
            calFecha.FirstDayOfWeek = Day.Sunday;
            cboAsistencia.Enabled = false;

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void calFecha_Leave(object sender, EventArgs e)
        {
            if (lblFecha.Text.Length != 0)
            { 
                labelFechError.Visible = false;                
            }
            else
            {
                labelFechError.Visible = true;
                labelFechError.Text = "Por favor selecciones una fecha";
            }
        }

        private void dgv_Alumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Alumnos.SelectedRows.Count > 0)
            {
                cboAsistencia.Enabled = true;
                lblAsistencia.ForeColor = Color.Aqua;
            }
            else
            {
                cboAsistencia.Enabled = false;
                lblAsistencia.ForeColor = Color.Gray;
                dgv_Alumnos.ClearSelection();
            }
        }

        private void btn_Informe_Click(object sender, EventArgs e)
        {
            InformeAsistencia frmInformeAsistencia = new InformeAsistencia(id_sala,turno,fechaCalendar); 
           // frmInformeAsistencia.Show();

        }
    }
}
