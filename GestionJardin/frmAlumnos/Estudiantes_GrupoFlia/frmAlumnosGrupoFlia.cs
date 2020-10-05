﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionJardin
{
    public partial class frmAlumnosGrupoFlia : Form
    {
        public frmAlumnosGrupoFlia()
        {
            InitializeComponent();
        }

        private void frmAlumnosGrupoFlia_Load(object sender, EventArgs e)
        {
            dgvGrupoFlia.ClearSelection();
            cargar_BuscaAlumnos();           
            
            btnGF_Eliminar.IconColor = Color.Gray;
            btnGF_Eliminar.ForeColor = Color.Gray;
            btnGF_Editar.IconColor = Color.Gray;
            btnGF_Editar.ForeColor = Color.Gray;

        }

        private void cargar_BuscaAlumnos()
        {
            //Autocompletar

            AutoCompleteStringCollection alumnos = new AutoCompleteStringCollection();
            metPersonas metPersonas = new metPersonas();
            alumnos = metPersonas.traerPersonasAutocompetar("2");

            txtGF_Buscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtGF_Buscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtGF_Buscar.AutoCompleteCustomSource = alumnos;
            
        }


        private void btnGF_Agregar_Click(object sender, EventArgs e)
        {

            frmAlumnosGrupoFliaPopUpAgregar frmAlumnosGrupoFliaPopUpAgregar = new frmAlumnosGrupoFliaPopUpAgregar();
            frmAlumnosGrupoFliaPopUpAgregar.FormClosed += frmAlumnosGrupoFliaPopUpAgregar_FormClosed;
            frmAlumnosGrupoFliaPopUpAgregar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / INGRESAR FAMILIAR";
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
                frmAlumnosGrupoFliaPopUpEditar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / EDITAR O VISUALIZAR DATOS DEL FAMILIAR";
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
                    frmAlumnosGrupoFliaPopUpEliminar.Text = "GESTION ALUMNOS / ESTUDIANTES / GRUPO FAMILIAR / ELIMINAR FAMILIAR";
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
            metPersonas objMetPersonas = new metPersonas();
            personaBuscar = objMetPersonas.BuscaPersona(nombreB, apellidoB, documentoB);

            String id_persona = Convert.ToString(personaBuscar.PER_ID);

            //rellenar dgv
            dgvGrupoFlia.Refresh();
            DataTable grupoFlia = new DataTable();
            metGrupoFlia objGrupoFlia = new metGrupoFlia();
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
    }
}
