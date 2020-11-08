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
    public partial class frmInformeSemestral_Generar : Form
    {
        public frmInformeSemestral_Generar()
        {
            InitializeComponent();
        }

        string id_sala;

        logAsistencia logAsistencia = new logAsistencia(); // ver si es necesario generar uno nuevo por informe??

        string sala;
        string edad;
        string etapa;

        private void frmInformeSemestral_Generar_Load(object sender, EventArgs e)
        {
            Inicializar();
            btnGInf_Editar.IconColor = Color.Gray; //SpringGreen
            btnGInf_Editar.ForeColor = Color.Gray; //SpringGreen
            btnGInf_Editar.Enabled = false;
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

        private void Inicializar()
        {
            cbTurno.Focus();
            cbTurno.SelectedIndex = -1;
            cbSala.SelectedIndex = -1;
            cbEtapa.SelectedIndex = -1;
            cbEdad.SelectedIndex = -1;
            lbl_panelInforme.Visible = true;
            txtGInf_Buscar.Visible = false;
            dgv_Informe.Visible = false;
            lblInformeEdit.Visible = false;
            btnGInf_Editar.Visible = false;
            lblTurno.Visible = false;
            lblSala.Visible = false;
            lblEtapa.Visible = false;
            lblEdad.Visible = false;
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

        private void cbEdad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbEdad.Text.Trim()) == true)
            {
                cbEdad.Style = MetroFramework.MetroColorStyle.Red;
                cbEdad.Focus();
                lblEdad.Visible = true;
                lblEdad.Text = "Por favor seleccione una edad";
            }
            else
            {
                lblEdad.Visible = false;
            }
        }

        private void cbEtapa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbEtapa.Text.Trim()) == true)
            {
                cbEtapa.Style = MetroFramework.MetroColorStyle.Red;
                cbEtapa.Focus();
                lblEtapa.Visible = true;
                lblEtapa.Text = "Por favor seleccione una etapa";
            }
            else
            {
                lblEtapa.Visible = false;
            }
        }

        private void cbEtapa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == false && string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == false && string.IsNullOrWhiteSpace(cbEdad.Text.Trim()) == false  && string.IsNullOrWhiteSpace(cbEtapa.Text.Trim()) == false)
            {
                lbl_panelInforme.Visible = false;
                txtGInf_Buscar.Visible = true;
                dgv_Informe.Visible = true;
                lblInformeEdit.Visible = true;
                btnGInf_Editar.Visible = true;

                //traer todos los datos

                sala = cbSala.SelectedValue.ToString();
                string turno = cbTurno.SelectedItem.ToString();
                edad = cbEdad.SelectedItem.ToString();
                etapa = cbEtapa.SelectedItem.ToString();


                //--
                logMaterias logMaterias = new logMaterias();
                DataTable dt = logMaterias.buscaAlumnosXMateria(sala); // turno no hace falta (se saca de la sala) //etapa no hace falta, se usa para determinar qué informe se carga o edita

                dgv_Informe.DataSource = dt;
                dgv_Informe.Columns["PER_ID"].Visible = false;
                dgv_Informe.Columns["SAL_ID"].Visible = false;
                dgv_Informe.Columns["GRS_ID"].Visible = false;

                //--
            } else
            {
                lbl_panelInforme.Visible = true;
                txtGInf_Buscar.Visible = false;
                dgv_Informe.Visible = false;
                lblInformeEdit.Visible = false;
                btnGInf_Editar.Visible = false;
            }
        }

        private void btnGInf_Editar_Click(object sender, EventArgs e)
        {
            string per_id = dgv_Informe.SelectedRows[0].Cells[0].Value.ToString();
            string sala_id = dgv_Informe.SelectedRows[0].Cells[1].Value.ToString();
            string nombre = dgv_Informe.SelectedRows[0].Cells[3].Value.ToString(); ;
            string apellido = dgv_Informe.SelectedRows[0].Cells[4].Value.ToString();
            string documento = dgv_Informe.SelectedRows[0].Cells[5].Value.ToString();
            string nomape = nombre + " " + apellido;

            frmInformeProgreso_Nuevo frmInformeProgreso_Nuevo = new frmInformeProgreso_Nuevo(sala_id, edad, etapa, per_id, nomape, documento);
            frmInformeProgreso_Nuevo.Text = "GESTIÓN ALUMNOS / INFORME DE PROGRESO / REDACTAR INFORME ";
            frmInformeProgreso_Nuevo.ShowDialog();
        }

        private void carga_grilla_filtrada()
        {

            logMaterias logMaterias = new logMaterias();
            logPersonas logPersonas = new logPersonas();
            DataTable dt = logMaterias.buscaAlumnosXMateria(sala);
            dgv_Informe.DataSource = dt;
            string apellido_nombre = logPersonas.extraerapellido_nombre_alumno(txtGInf_Buscar.Text);
            dt.DefaultView.RowFilter = String.Format($"NOMBRE LIKE '{apellido_nombre}%'");
        }


        private void txtGInf_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txtGInf_Buscar.Text.Length > 0)
            {
                carga_grilla_filtrada();
            }
            else
            {

                txtGInf_Buscar.Clear();
                logMaterias logMaterias = new logMaterias();
                DataTable dt = logMaterias.buscaAlumnosXMateria(sala);
                dgv_Informe.DataSource = dt;

            }
        }

        private void dgv_Informe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Informe.SelectedRows.Count > 0)
            {

                btnGInf_Editar.IconColor = Color.SpringGreen;
                btnGInf_Editar.ForeColor = Color.SpringGreen;
                btnGInf_Editar.Enabled = true;

            }
            else
            {
                dgv_Informe.ClearSelection();
                btnGInf_Editar.IconColor = Color.Gray;
                btnGInf_Editar.ForeColor = Color.Gray;
                btnGInf_Editar.Enabled = false;

            }
        }
    }
}
