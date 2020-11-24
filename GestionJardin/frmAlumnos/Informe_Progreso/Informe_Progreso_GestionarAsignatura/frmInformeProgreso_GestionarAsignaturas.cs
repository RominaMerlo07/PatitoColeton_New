using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaEnt;
using CaLog;
using System.Text.RegularExpressions;

namespace GestionJardin
{
    public partial class frmInformeProgreso_AgregarMateria : Form
    {
              
        public frmInformeProgreso_AgregarMateria()
        {
            InitializeComponent();
        }

        private void frmInformeProgreso_AgregarMateria_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        string edad;

        private void Inicializar()
        {
            //cbTurno.SelectedIndex = -1;
         
            cbSala.SelectedIndex = -1;            
            lbl_panelInforme.Visible = true;         
            lblSala.Visible = false;
            txtGA_Buscar.Visible = false;
            dgvAsignatura.Visible = false;
            lblInfoAsignatura.Visible = false;
            btn_Agregar.Visible = false;
            btn_Editar.Visible = false;
            btn_Eliminar.Visible = false;            
        }               
        

        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == false)
            { 

                lbl_panelInforme.Visible = false;             
                txtGA_Buscar.Visible = true;
                dgvAsignatura.Visible = true;
                lblInfoAsignatura.Visible = true;
                btn_Agregar.Visible = true;
                btn_Editar.Visible = true;
                btn_Eliminar.Visible = true;

                lblSala.Visible = false;


                //-- MUESTRA MATERIAS CARGADAS POR EDAD
                edad = cbSala.SelectedItem.ToString();
                string resultString = Regex.Match(edad, @"\d+").Value;


                logMaterias logMaterias = new logMaterias();
                DataTable dt = logMaterias.buscaMateriaXEdad(resultString); // turno no hace falta (se saca de la sala) //etapa no hace falta, se usa para determinar qué informe se carga o edita

                dgvAsignatura.DataSource = dt;
                dgvAsignatura.Columns["MT_ID"].Visible = false;
                dgvAsignatura.Columns["MT_MATERIA_ANO"].Visible = false;
                //dgvAsignatura.Columns[""].Visible = false;

                //--

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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            //string edadMtMateria = "1";//dgvAsignatura.SelectedRows[0].Cells[4].Value.ToString();
            string edadMtMateria = cbSala.SelectedItem.ToString();

            switch (edadMtMateria)
            {
                case "1 y 2 AÑOS":
                    edadMtMateria = "1";
                    break;
                case "3 AÑOS":
                    edadMtMateria = "3";
                    break;
                case "4 AÑOS":
                    edadMtMateria = "4";
                    break;
                case "5 AÑOS":
                    edadMtMateria = "5";
                    break;
            }


            frmInformeProgreso_GestAsig_Agregar frmInformeProgreso_GestAsig_Agregar = new frmInformeProgreso_GestAsig_Agregar(edadMtMateria);

            frmInformeProgreso_GestAsig_Agregar.FormClosed += frmInformeProgreso_GestAsig_Agregar_FormClosed;
            frmInformeProgreso_GestAsig_Agregar.Text = "GESTIÓN ALUMNOS / INFORME DE PROGRESO / GESTIONAR CRITERIO DE APRENDIZAJE / AGREGAR ";
            frmInformeProgreso_GestAsig_Agregar.ShowDialog();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            string idMtMateria = dgvAsignatura.SelectedRows[0].Cells[0].Value.ToString();
            string nombreMtMateria = dgvAsignatura.SelectedRows[0].Cells[1].Value.ToString();
            string descripcionMtMateria = dgvAsignatura.SelectedRows[0].Cells[2].Value.ToString();
            string edadMtMateria = dgvAsignatura.SelectedRows[0].Cells[4].Value.ToString();          

            frmInformeProgreso_GestAsig_Editar frmInformeProgreso_GestAsig_Editar = new frmInformeProgreso_GestAsig_Editar(idMtMateria, nombreMtMateria, descripcionMtMateria, edadMtMateria);

            frmInformeProgreso_GestAsig_Editar.FormClosed += frmInformeProgreso_GestAsig_Editar_FormClosed;
            frmInformeProgreso_GestAsig_Editar.Text = "GESTIÓN ALUMNOS / INFORME DE PROGRESO / GESTIONAR CRITERIO DE APRENDIZAJE / MODIFICAR ";
            frmInformeProgreso_GestAsig_Editar.ShowDialog();


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            string idMtMateria = dgvAsignatura.SelectedRows[0].Cells[0].Value.ToString();
            string nombreMtMateria = dgvAsignatura.SelectedRows[0].Cells[1].Value.ToString();

            frmInformeProgreso_GestAsig_Eliminar frmInformeProgreso_GestAsig_Eliminar = new frmInformeProgreso_GestAsig_Eliminar(idMtMateria, nombreMtMateria);

            frmInformeProgreso_GestAsig_Eliminar.FormClosed += frmInformeProgreso_GestAsig_Eliminar_FormClosed;
            frmInformeProgreso_GestAsig_Eliminar.Text = "GESTIÓN ALUMNOS / INFORME DE PROGRESO / GESTIONAR CRITERIO DE APRENDIZAJE / ELIMINAR ";
            frmInformeProgreso_GestAsig_Eliminar.ShowDialog();
        }

        private void frmInformeProgreso_GestAsig_Agregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            edad = cbSala.SelectedItem.ToString();
            string resultString = Regex.Match(edad, @"\d+").Value;


            logMaterias logMaterias = new logMaterias();
            DataTable dt = logMaterias.buscaMateriaXEdad(resultString); // turno no hace falta (se saca de la sala) //etapa no hace falta, se usa para determinar qué informe se carga o edita

            dgvAsignatura.DataSource = dt;
            dgvAsignatura.Columns["MT_ID"].Visible = false;
            dgvAsignatura.Columns["MT_MATERIA_ANO"].Visible = false;
        }

        private void frmInformeProgreso_GestAsig_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            edad = cbSala.SelectedItem.ToString();
            string resultString = Regex.Match(edad, @"\d+").Value;


            logMaterias logMaterias = new logMaterias();
            DataTable dt = logMaterias.buscaMateriaXEdad(resultString); // turno no hace falta (se saca de la sala) //etapa no hace falta, se usa para determinar qué informe se carga o edita

            dgvAsignatura.DataSource = dt;
            dgvAsignatura.Columns["MT_ID"].Visible = false;
            dgvAsignatura.Columns["MT_MATERIA_ANO"].Visible = false;
        }

        private void frmInformeProgreso_GestAsig_Eliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            edad = cbSala.SelectedItem.ToString();
            string resultString = Regex.Match(edad, @"\d+").Value;


            logMaterias logMaterias = new logMaterias();
            DataTable dt = logMaterias.buscaMateriaXEdad(resultString); // turno no hace falta (se saca de la sala) //etapa no hace falta, se usa para determinar qué informe se carga o edita

            dgvAsignatura.DataSource = dt;
            dgvAsignatura.Columns["MT_ID"].Visible = false;
            dgvAsignatura.Columns["MT_MATERIA_ANO"].Visible = false;
        }

        

        

    }
}
