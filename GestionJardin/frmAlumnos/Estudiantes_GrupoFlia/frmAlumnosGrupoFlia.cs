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
using System.Data.SqlClient;

namespace GestionJardin
{
    public partial class frmAlumnosGrupoFlia : Form
    {
        string idPersona;

        public frmAlumnosGrupoFlia()
        {
            InitializeComponent();
        }

        private void frmAlumnosGrupoFlia_Load(object sender, EventArgs e)
        {
            Settooltip();
            dgvGrupoFlia.ClearSelection();
            cargar_BuscaAlumnos();

            lblBuscar.Visible = true; 

            btnGF_Eliminar.IconColor = Color.Gray;
            btnGF_Eliminar.ForeColor = Color.Gray;
            btnGF_Editar.IconColor = Color.Gray;
            btnGF_Editar.ForeColor = Color.Gray;

        }


        private void Settooltip()
        {
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(this.btnGF_Agregar, "Ingresar o dar de alta un familiar");
            Tip.SetToolTip(this.btnGF_Editar, "Visualizar y/o modificar los datos de un familiar");
            Tip.SetToolTip(this.btnGF_Eliminar, "Dar de baja un familiar");
            Tip.SetToolTip(this.btnLista, "Imprimir grupo familiar del alumno");
        }

        private void cargar_BuscaAlumnos()
        {
            //Autocompletar

            AutoCompleteStringCollection alumnos = new AutoCompleteStringCollection();
            logPersonas logPersonas = new logPersonas();

            //--
            DataTable dt = logPersonas.traerPersonasAutocompetar("2");

            foreach (DataRow row in dt.Rows)
            {
                txtGF_Buscar.AutoCompleteCustomSource.Add(row[0].ToString());
            }

            //SqlDataReader dr = logPersonas.traerPersonasAutocompetar("2");
            //while (dr.Read())
            //{
            //    alumnos.Add(dr.GetString(0));
            //};

            txtGF_Buscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtGF_Buscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtGF_Buscar.AutoCompleteCustomSource = alumnos;
            //--
        }


        private void btnGF_Agregar_Click(object sender, EventArgs e)
        {

            frmAlumnosGrupoFliaPopUpAgregar frmAlumnosGrupoFliaPopUpAgregar = new frmAlumnosGrupoFliaPopUpAgregar();
            frmAlumnosGrupoFliaPopUpAgregar.FormClosed += frmAlumnosGrupoFliaPopUpAgregar_FormClosed;
            frmAlumnosGrupoFliaPopUpAgregar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / INGRESAR";
            frmAlumnosGrupoFliaPopUpAgregar.ShowDialog();

            btnGF_Eliminar.IconColor = Color.Gray;
            btnGF_Eliminar.ForeColor = Color.Gray;
            btnGF_Editar.IconColor = Color.Gray;
            btnGF_Editar.ForeColor = Color.Gray;
        }

        private void btnGF_Editar_Click(object sender, EventArgs e)
        {
            if (dgvGrupoFlia.SelectedRows.Count > 0) {


                if (dgvGrupoFlia.SelectedRows[0].Cells[3].Value.ToString() == "ALUMNO")
                {                                    

                    btnGF_Editar.IconColor = Color.Gray;
                    btnGF_Editar.ForeColor = Color.Gray;
                    btnGF_Eliminar.IconColor = Color.Gray;
                    btnGF_Eliminar.ForeColor = Color.Gray;

                    MessageBox.Show("Aqui solamente se pueden editar los datos de familiares, para modificar los datos de un alumno debe dirigirse a GESTIÓN ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                } 
                else
                { 

                btnGF_Editar.IconColor = Color.Cyan;
                btnGF_Editar.ForeColor = Color.Cyan;

                string idPersonaSelect = dgvGrupoFlia.SelectedRows[0].Cells[0].Value.ToString();
                frmAlumnosGrupoFliaPopUpEditar frmAlumnosGrupoFliaPopUpEditar = new frmAlumnosGrupoFliaPopUpEditar(idPersonaSelect);
                frmAlumnosGrupoFliaPopUpEditar.FormClosed += frmAlumnosGrupoFliaPopUpEditar_FormClosed;
                frmAlumnosGrupoFliaPopUpEditar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / MODIFICAR";
                frmAlumnosGrupoFliaPopUpEditar.ShowDialog();

                }

                btnGF_Eliminar.IconColor = Color.Gray;
                btnGF_Eliminar.ForeColor = Color.Gray;
                btnGF_Editar.IconColor = Color.Gray;
                btnGF_Editar.ForeColor = Color.Gray;

            }
            else
            {
                btnGF_Editar.IconColor = Color.Gray;
                btnGF_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Para modificar/visualizar los datos de familiares debe seleccionar un registro. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGF_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvGrupoFlia.SelectedRows.Count > 0)
            {
                if (dgvGrupoFlia.SelectedRows[0].Cells[3].Value.ToString() == "ALUMNO")
                {
                    btnGF_Editar.IconColor = Color.Gray;
                    btnGF_Editar.ForeColor = Color.Gray;
                    btnGF_Eliminar.IconColor = Color.Gray;
                    btnGF_Eliminar.ForeColor = Color.Gray;

                    MessageBox.Show("Aqui solamente se pueden eliminar los datos de familiares, para eliminar los datos de un alumno debe dirigirse a GESTIÓN ALUMNOS / ESTUDIANTES / GESTIONAR ALUMNOS. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {

                    btnGF_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                    btnGF_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

                    string idPersonaSelect = dgvGrupoFlia.SelectedRows[0].Cells[0].Value.ToString();
                    string nombreAlumno = dgvGrupoFlia.SelectedRows[0].Cells[1].Value.ToString();
                    frmAlumnosGrupoFliaPopUpEliminar frmAlumnosGrupoFliaPopUpEliminar = new frmAlumnosGrupoFliaPopUpEliminar(idPersonaSelect, nombreAlumno);
                    frmAlumnosGrupoFliaPopUpEliminar.FormClosed += frmAlumnosGrupoFliaPopUpEliminar_FormClosed;
                    frmAlumnosGrupoFliaPopUpEliminar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / PROCESAR BAJA";
                    frmAlumnosGrupoFliaPopUpEliminar.ShowDialog();

                    btnGF_Eliminar.IconColor = Color.Gray;
                    btnGF_Eliminar.ForeColor = Color.Gray;
                    btnGF_Editar.IconColor = Color.Gray;
                    btnGF_Editar.ForeColor = Color.Gray;
                }

            }
            else
            {
                btnGF_Eliminar.IconColor = Color.Gray;
                btnGF_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Para eliminar un familiar debe seleccionar un registro. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmAlumnosGrupoFliaPopUpAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvGrupoFlia.DataSource = null;
            dgvGrupoFlia.Refresh();
        }

        private void frmAlumnosGrupoFliaPopUpEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvGrupoFlia.DataSource = null;
            dgvGrupoFlia.Refresh();
        }

        private void frmAlumnosGrupoFliaPopUpEliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvGrupoFlia.DataSource = null;
            dgvGrupoFlia.Refresh();
        }     

        private void txtGF_Buscar_ButtonClick(object sender, EventArgs e)
        {
            lblBuscar.Visible = false;
            lblInfo.Visible = true;
            btnLista.Visible = true;

            string nombreB = "";
            string apellidoB = "";
            string documentoB = "";
            int contador = 0;

            string busqueda = txtGF_Buscar.Text;

            char[] separadores = { ',', '(', ')' };
            string[] palabras = busqueda.Split(separadores);

            foreach (var palabra in palabras)
            {
                contador += 1;
                if (contador == 1)
                {
                    nombreB = palabra.Trim();
                }
                else if (contador == 2)
                {
                    apellidoB = palabra.Trim();
                }
                else if (contador == 3)
                {
                    documentoB = palabra.Trim();
                }
            }

            entPersona personaBuscar = new entPersona();
            logPersonas objlogPersonas = new logPersonas();
            personaBuscar = objlogPersonas.BuscaPersona(nombreB, apellidoB, documentoB);

            String id_persona = Convert.ToString(personaBuscar.PER_ID);
            idPersona = Convert.ToString(personaBuscar.PER_ID);

            //rellenar dgv
            dgvGrupoFlia.Refresh();
            DataTable grupoFlia = new DataTable();
            logGrupoFlia objGrupoFlia = new logGrupoFlia();
            grupoFlia = objGrupoFlia.traerPersonasXGrupoFliar2(id_persona);
            
            if (grupoFlia.Rows.Count > 0)
            {              
                dgvGrupoFlia.DataSource = grupoFlia;
                dgvGrupoFlia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvGrupoFlia.Columns["PER_ID"].Visible = false;
                dgvGrupoFlia.Columns["PER_ID"].Frozen = true;
                dgvGrupoFlia.Columns["NOMBRE"].Frozen = true;
                dgvGrupoFlia.Columns["DOCUMENTO"].Frozen = true;
                dgvGrupoFlia.Columns["PARENTESCO"].Frozen = true;

                this.dgvGrupoFlia.Columns["NOMBRE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.dgvGrupoFlia.Columns["DOCUMENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dgvGrupoFlia.Columns["PARENTESCO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.dgvGrupoFlia.Columns["TUTOR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.dgvGrupoFlia.Columns["RETIRAR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.dgvGrupoFlia.Columns["FECHA NACIMIENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.dgvGrupoFlia.Columns["EDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dgvGrupoFlia.Columns["DOMICILIO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.dgvGrupoFlia.Columns["CELULAR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.dgvGrupoFlia.Columns["TELEFONO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


                dgvGrupoFlia.ClearSelection();
               

                int c = dgvGrupoFlia.Rows.Count;
                for(int i = 0; i < c; i++)
                {
                    if(dgvGrupoFlia.Rows[i].Cells[3].Value.ToString() == "ALUMNO")
                    {
                        dgvGrupoFlia.Rows[i].DefaultCellStyle.ForeColor = Color.WhiteSmoke;
                        dgvGrupoFlia.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                        dgvGrupoFlia.Rows[i].DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
                        dgvGrupoFlia.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Gray;
                    }
                }

                //dgvGrupoFlia.Visible = true;
            
            }
        }

        private void dgvGrupoFlia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrupoFlia.SelectedRows.Count > 0)
            {                
                if (dgvGrupoFlia.SelectedRows[0].Cells[3].Value.ToString() == "ALUMNO")
                {
                    btnGF_Editar.IconColor = Color.Gray;
                    btnGF_Editar.ForeColor = Color.Gray;
                    btnGF_Eliminar.IconColor = Color.Gray;
                    btnGF_Eliminar.ForeColor = Color.Gray;                    
                }
                else
                {
                    btnGF_Editar.IconColor = Color.Cyan;
                    btnGF_Editar.ForeColor = Color.Cyan;
                    btnGF_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                    btnGF_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
                }

            }
            else
            {
                dgvGrupoFlia.ClearSelection();
                btnGF_Editar.IconColor = Color.Gray;
                btnGF_Editar.ForeColor = Color.Gray;
                btnGF_Eliminar.IconColor = Color.Gray;
                btnGF_Eliminar.ForeColor = Color.Gray;

            }
        }

        private void txtGF_Buscar_TextChanged(object sender, EventArgs e)
        {
            if( txtGF_Buscar.Text.Length == 0 )
            {
                lblBuscar.Visible = true;
                lblInfo.Visible = false;
                btnLista.Visible = false;
                dgvGrupoFlia.DataSource = null;
                dgvGrupoFlia.Refresh();
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            ListaGrupoFlia ListaGrupoFlia = new ListaGrupoFlia(idPersona);
        }
    }
}
