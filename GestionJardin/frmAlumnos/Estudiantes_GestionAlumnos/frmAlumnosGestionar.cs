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
    public partial class frmAlumnosGestionar : Form
    {
        logPersonas logPersonas = new logPersonas();
        public frmAlumnosGestionar()
        {
            InitializeComponent();
        }
               
        private void frmAlumnosGestionar_Load(object sender, EventArgs e)
        {

            dgvAlumnos.ClearSelection();           
            cargar_dgvAlumnos();


            btnGA_Eliminar.IconColor = Color.Gray;
            btnGA_Eliminar.ForeColor = Color.Gray;
            btnGA_Editar.IconColor = Color.Gray;
            btnGA_Editar.ForeColor = Color.Gray;

            Settooltip();



        }

        private void Settooltip()
        {
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(this.btnGA_Agregar,"Ingresar o dar de alta un alumno");
            Tip.SetToolTip(this.btnGA_Editar, "Visualizar y/o modificar los datos de un alumno");
            Tip.SetToolTip(this.btnGA_Eliminar, "Dar de baja un alumno");
        }

        private void carga_grilla_filtrada()
        {
            DataTable col = new DataTable();
            logPersonas logPersonas = new logPersonas();
            col = logPersonas.TraerAlumnos();
            dgvAlumnos.DataSource = col;
            string apellido_nombre = logPersonas.extraerapellido_nombre_alumno(txtGA_Buscar.Text);

            col.DefaultView.RowFilter = String.Format($"ALUMNO LIKE '{apellido_nombre}%'");

        }


        private void btnGA_Agregar_Click(object sender, EventArgs e)
        {
            frmAlumnosPopUpAgregar frmAlumnosPopUpAgregar = new frmAlumnosPopUpAgregar();
            frmAlumnosPopUpAgregar.FormClosed += frmAlumnosPopUpAgregar_FormClosed;
            frmAlumnosPopUpAgregar.Text = "GESTION ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS / INGRESAR";
            frmAlumnosPopUpAgregar.ShowDialog();

            btnGA_Eliminar.IconColor = Color.Gray;
            btnGA_Eliminar.ForeColor = Color.Gray;
            btnGA_Editar.IconColor = Color.Gray;
            btnGA_Editar.ForeColor = Color.Gray;
        }

        private void btnGA_Editar_Click(object sender, EventArgs e)
        {

            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                btnGA_Editar.IconColor = Color.Cyan;
                btnGA_Editar.ForeColor = Color.Cyan;
                string idPersonaSelect = dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString();
                frmAlumnosPopUpEditar frmAlumnosPopUpEditar = new frmAlumnosPopUpEditar(idPersonaSelect);
                frmAlumnosPopUpEditar.FormClosed += frmAlumnosPopUpEditar_FormClosed;
                frmAlumnosPopUpEditar.Text = "GESTION ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS / MODIFICAR";
                frmAlumnosPopUpEditar.ShowDialog();

                btnGA_Eliminar.IconColor = Color.Gray;
                btnGA_Eliminar.ForeColor = Color.Gray;
                btnGA_Editar.IconColor = Color.Gray;
                btnGA_Editar.ForeColor = Color.Gray;
            }
            else
            {
                btnGA_Editar.IconColor = Color.Gray;
                btnGA_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder visualizar y/o editar los datos de un alumno", "Información",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void btnGA_Eliminar_Click(object sender, EventArgs e)
        {

            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                btnGA_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGA_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

                string idPersonaSelect = dgvAlumnos.SelectedRows[0].Cells[0].Value.ToString();
                string nombreAlumno = dgvAlumnos.SelectedRows[0].Cells[1].Value.ToString();
                int edad = Convert.ToInt32(dgvAlumnos.SelectedRows[0].Cells[4].Value.ToString());


                frmAlumnosPopUpEliminar frmAlumnoPopUpEliminar = new frmAlumnosPopUpEliminar(idPersonaSelect, nombreAlumno,edad);
                frmAlumnoPopUpEliminar.FormClosed += frmAlumnoPopUpEliminar_FormClosed;
                frmAlumnoPopUpEliminar.Text = "GESTION ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS / PROCESAR BAJA";
                frmAlumnoPopUpEliminar.ShowDialog();

                btnGA_Eliminar.IconColor = Color.Gray;
                btnGA_Eliminar.ForeColor = Color.Gray;
                btnGA_Editar.IconColor = Color.Gray;
                btnGA_Editar.ForeColor = Color.Gray;
            }
            else
            {
                btnGA_Eliminar.IconColor = Color.Gray;
                btnGA_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder dar de baja a un alumno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          
            }

        }         

        private void btnGA_Pdf_Click(object sender, EventArgs e)
        {
            DataTable col = new DataTable();
            logPersonas logPersonas = new logPersonas();
            col = logPersonas.TraerAlumnos();
            dgvAlumnos.DataSource = col;
            dgvAlumnos.Columns["PER_ID"].Visible = false;
        }
               

        private void cargar_dgvAlumnos()
        {
            DataTable col = new DataTable();
            logPersonas logPersonas = new logPersonas();
            col = logPersonas.TraerAlumnos();
            dgvAlumnos.DataSource = col;
            dgvAlumnos.Columns["PER_ID"].Visible = false;
            dgvAlumnos.Columns["PER_ID"].Frozen = true;
            dgvAlumnos.Columns["ALUMNO"].Frozen = true;
            dgvAlumnos.Columns["DOCUMENTO"].Frozen = true;
                                   
            this.dgvAlumnos.Columns["DOCUMENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvAlumnos.Columns["FECHA NACIMIENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvAlumnos.Columns["EDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvAlumnos.Columns["TELEFONO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvAlumnos.Columns["CELULAR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;    

        }     

        private void frmAlumnosPopUpEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar_dgvAlumnos();
        }

        private void frmAlumnoPopUpEliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar_dgvAlumnos();
        }

        private void frmAlumnosPopUpAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            cargar_dgvAlumnos();
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlumnos.SelectedRows.Count > 0)
            {
                btnGA_Editar.IconColor = Color.Cyan;
                btnGA_Editar.ForeColor = Color.Cyan;
                btnGA_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGA_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

            }
            else
            {
                dgvAlumnos.ClearSelection();
                btnGA_Editar.IconColor = Color.Gray;
                btnGA_Editar.ForeColor = Color.Gray;
                btnGA_Eliminar.IconColor = Color.Gray;
                btnGA_Eliminar.ForeColor = Color.Gray;
                
            }
        }

        private void txtGA_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txtGA_Buscar.Text.Length > 0)
            {
                carga_grilla_filtrada();
            }
            else
            {
                txtGA_Buscar.Clear();
                cargar_dgvAlumnos();
                btnGA_Editar.IconColor = Color.Gray;
                btnGA_Editar.ForeColor = Color.Gray;
                btnGA_Eliminar.IconColor = Color.Gray;
                btnGA_Eliminar.ForeColor = Color.Gray;
            }
        }

        private void txtGA_Buscar_Click(object sender, EventArgs e)
        {
            if (txtGA_Buscar.Text.Length > 0)
            {
                carga_grilla_filtrada();

            }
            else
            {
                txtGA_Buscar.Clear();
                cargar_dgvAlumnos();
                btnGA_Editar.IconColor = Color.Gray;
                btnGA_Editar.ForeColor = Color.Gray;
                btnGA_Eliminar.IconColor = Color.Gray;
                btnGA_Eliminar.ForeColor = Color.Gray;
            }
        }
    }
}
