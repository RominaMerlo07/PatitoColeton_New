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

            btn_Eliminar.IconColor = Color.Gray;
            btn_Eliminar.ForeColor = Color.Gray;
            btn_Editar.IconColor = Color.Gray;
            btn_Editar.ForeColor = Color.Gray;

            Settooltip();

        }

        string edad;

        private void Inicializar()
        {
            //cbTurno.SelectedIndex = -1;
         
            cbSala.SelectedIndex = -1;            
            lbl_panelInforme.Visible = true;         
            lblSala.Visible = false;           
            dgvAsignatura.Visible = false;
            lblInfoAsignatura.Visible = false;
            btn_Agregar.Visible = false;
            btn_Editar.Visible = false;
            btn_Eliminar.Visible = false;            
        }

        private void Settooltip()
        {
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(this.btn_Agregar, "Ingresar o dar de alta un aprendizaje");
            Tip.SetToolTip(this.btn_Editar, "Visualizar y/o modificar la descripción de un aprendizaje");
            Tip.SetToolTip(this.btn_Eliminar, "Dar de baja un aprendizaje");            
        }



        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {
        
            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == false)
            { 

                lbl_panelInforme.Visible = false;                             
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
                dgvAsignatura.Columns["ID"].Visible = false;
                dgvAsignatura.Columns["ANIO"].Visible = false;
                //dgvAsignatura.Columns[""].Visible = false;

                this.dgvAsignatura.Columns["APRENDIZAJE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.dgvAsignatura.Columns["DESCRIPCIÓN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.dgvAsignatura.Columns["EDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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
            if (dgvAsignatura.SelectedRows.Count > 0)
            {
                btn_Editar.IconColor = Color.Cyan;
                btn_Editar.ForeColor = Color.Cyan;

                string idMtMateria = dgvAsignatura.SelectedRows[0].Cells[0].Value.ToString();
                string nombreMtMateria = dgvAsignatura.SelectedRows[0].Cells[1].Value.ToString();
                string descripcionMtMateria = dgvAsignatura.SelectedRows[0].Cells[2].Value.ToString();
                string edadMtMateria = dgvAsignatura.SelectedRows[0].Cells[4].Value.ToString();

                frmInformeProgreso_GestAsig_Editar frmInformeProgreso_GestAsig_Editar = new frmInformeProgreso_GestAsig_Editar(idMtMateria, nombreMtMateria, descripcionMtMateria, edadMtMateria);

                frmInformeProgreso_GestAsig_Editar.FormClosed += frmInformeProgreso_GestAsig_Editar_FormClosed;
                frmInformeProgreso_GestAsig_Editar.Text = "GESTIÓN ALUMNOS / INFORME DE PROGRESO / GESTIONAR CRITERIO DE APRENDIZAJE / MODIFICAR ";
                frmInformeProgreso_GestAsig_Editar.ShowDialog();

                btn_Editar.IconColor = Color.Gray;
                btn_Editar.ForeColor = Color.Gray;
                btn_Eliminar.IconColor = Color.Gray;
                btn_Eliminar.ForeColor = Color.Gray;
            }
            else
            {
                btn_Editar.IconColor = Color.Gray;
                btn_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder visualizar y/o editar los datos de un aprendizaje", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvAsignatura.SelectedRows.Count > 0)
            {
                btn_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btn_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

                string idMtMateria = dgvAsignatura.SelectedRows[0].Cells[0].Value.ToString();
                string nombreMtMateria = dgvAsignatura.SelectedRows[0].Cells[1].Value.ToString();

                frmInformeProgreso_GestAsig_Eliminar frmInformeProgreso_GestAsig_Eliminar = new frmInformeProgreso_GestAsig_Eliminar(idMtMateria, nombreMtMateria);

                frmInformeProgreso_GestAsig_Eliminar.FormClosed += frmInformeProgreso_GestAsig_Eliminar_FormClosed;
                frmInformeProgreso_GestAsig_Eliminar.Text = "GESTIÓN ALUMNOS / INFORME DE PROGRESO / GESTIONAR CRITERIO DE APRENDIZAJE / ELIMINAR ";
                frmInformeProgreso_GestAsig_Eliminar.ShowDialog();

                btn_Editar.IconColor = Color.Gray;
                btn_Editar.ForeColor = Color.Gray;
                btn_Eliminar.IconColor = Color.Gray;
                btn_Eliminar.ForeColor = Color.Gray;
            }
            else
            {
                btn_Eliminar.IconColor = Color.Gray;
                btn_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder eliminar un aprendizaje", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void frmInformeProgreso_GestAsig_Agregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            edad = cbSala.SelectedItem.ToString();
            string resultString = Regex.Match(edad, @"\d+").Value;


            logMaterias logMaterias = new logMaterias();
            DataTable dt = logMaterias.buscaMateriaXEdad(resultString); // turno no hace falta (se saca de la sala) //etapa no hace falta, se usa para determinar qué informe se carga o edita

            dgvAsignatura.DataSource = dt;
            dgvAsignatura.Columns["ID"].Visible = false;
            dgvAsignatura.Columns["ANIO"].Visible = false;
        }

        private void frmInformeProgreso_GestAsig_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            edad = cbSala.SelectedItem.ToString();
            string resultString = Regex.Match(edad, @"\d+").Value;


            logMaterias logMaterias = new logMaterias();
            DataTable dt = logMaterias.buscaMateriaXEdad(resultString); // turno no hace falta (se saca de la sala) //etapa no hace falta, se usa para determinar qué informe se carga o edita

            dgvAsignatura.DataSource = dt;
            dgvAsignatura.Columns["ID"].Visible = false;
            dgvAsignatura.Columns["ANIO"].Visible = false;
        }

        private void frmInformeProgreso_GestAsig_Eliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            edad = cbSala.SelectedItem.ToString();
            string resultString = Regex.Match(edad, @"\d+").Value;


            logMaterias logMaterias = new logMaterias();
            DataTable dt = logMaterias.buscaMateriaXEdad(resultString); // turno no hace falta (se saca de la sala) //etapa no hace falta, se usa para determinar qué informe se carga o edita

            dgvAsignatura.DataSource = dt;
            dgvAsignatura.Columns["ID"].Visible = false;
            dgvAsignatura.Columns["ANIO"].Visible = false;
        }

        private void dgvAsignatura_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
                if (dgvAsignatura.SelectedRows.Count > 0)
                {
                    btn_Editar.IconColor = Color.Cyan;
                    btn_Editar.ForeColor = Color.Cyan;
                    btn_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                    btn_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

                }
                else
                {
                    dgvAsignatura.ClearSelection();
                    btn_Editar.IconColor = Color.Gray;
                    btn_Editar .ForeColor = Color.Gray;
                    btn_Eliminar.IconColor = Color.Gray;
                    btn_Eliminar.ForeColor = Color.Gray;

                }
            
        }
    }
}
