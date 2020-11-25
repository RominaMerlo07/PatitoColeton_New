using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using CaLog;
using CaEnt;

namespace GestionJardin
{
    public partial class frmAlumnos : Form
    {

        private Form currentFormChild; //para almacenar el form hijo actual

        public frmAlumnos()
        {
            InitializeComponent();
        }
              

        private void OpenChildForm(Form ChildForm)
        {

            frmAlumnos fAlumnos = new frmAlumnos();

            if (currentFormChild != null)
            {
                currentFormChild.Close(); // se cierra el form actual -- permite solo un form actual
            }

            currentFormChild = ChildForm;
            ChildForm.TopLevel = false; // para indicar que no es de nivel superior --VER CON GASTON
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelContenedor_GA.Controls.Add(ChildForm); //para que controle los demas forms
            panelContenedor_GA.Tag = ChildForm; // Asociar los datos de los forms al panel
            ChildForm.BringToFront(); // se trae al frente cada form para mostrar
            ChildForm.Show();
            btn_VolverGA.Visible = true;
         //   btn_VolverGA.BringToFront();
            lbl_Ruta.Text = "Usted se encuentra en GESTION ALUMNOS / " + ChildForm.Text;

        }


        private void moverIndiceNavbar(Control btn)
        {
            panelIndiceNavbar.Width = btn.Width;
            panelIndiceNavbar.Left = btn.Left;
            panelIndiceNavbar.BackColor = btn.ForeColor;
            panelIndiceNavbar.Visible = true;
        }

    

        /*******************ESTUDIANTES***********************/
        /*****************************************************/

        private void moverIndicePnl_Estudiantes(Control btn)
        {
            Ind_PnlEstudiante.Location = new Point(0, btn.Location.Y);
            Ind_PnlEstudiante.Height = btn.Height;
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            panelEstudiantes.Visible = true;
            panelEstudiantes.BringToFront();
            moverIndiceNavbar(btnEstudiantes);
            panelAsistencia.Visible = false;
            panelInformeSemestral.Visible = false;
        }

        private void btnEstudiantes_MouseHover(object sender, EventArgs e)
        {
            panelEstudiantes.Visible = true;
            panelEstudiantes.BringToFront();
            moverIndiceNavbar(btnEstudiantes);
            panelAsistencia.Visible = false;
            panelInformeSemestral.Visible = false;
        }

        private void panelEstudiantes_MouseEnter(object sender, EventArgs e)
        {
            panelEstudiantes.Visible = true;
        }


        private void btnEst_Consultar_MouseHover(object sender, EventArgs e)
        {
            btnEst_Consultar.FlatStyle = FlatStyle.Flat;
            btnEst_Consultar.BringToFront();
            btnEst_Consultar.TextImageRelation = TextImageRelation.TextBeforeImage;
            Ind_PnlInfSemestral.Visible = false;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = true;
            moverIndicePnl_Estudiantes(btnEst_Consultar);
        }

        private void btnEst_Consultar_MouseLeave(object sender, EventArgs e)
        {
            btnEst_Consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEst_Consultar.FlatStyle = FlatStyle.Popup;
            Ind_PnlInfSemestral.Visible = false;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = false;
        }

        private void btnEst_GrupoFlia_MouseHover(object sender, EventArgs e)
        {
            btnEst_GrupoFlia.FlatStyle = FlatStyle.Flat;
            btnEst_GrupoFlia.BringToFront();
            btnEst_GrupoFlia.TextImageRelation = TextImageRelation.TextBeforeImage;
            Ind_PnlInfSemestral.Visible = false;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = true;
            moverIndicePnl_Estudiantes(btnEst_GrupoFlia);
        }

        private void btnEst_GrupoFlia_MouseLeave(object sender, EventArgs e)
        {
            btnEst_GrupoFlia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEst_GrupoFlia.FlatStyle = FlatStyle.Popup;
            Ind_PnlInfSemestral.Visible = false;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = false;
        }        

        

        private void panelEstudiantes_MouseLeave(object sender, EventArgs e)
        {
            panelEstudiantes.Visible = false;
        }

        /*******************ASISTENCIA************************/
        /*****************************************************/

        private void moverIndicePnl_Asistencia(Control btn)
        {
            Ind_PnlAsistencia.Location = new Point(0, btn.Location.Y);
            Ind_PnlAsistencia.Height = btn.Height;
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            panelAsistencia.Visible = true;
            panelAsistencia.BringToFront();
            moverIndiceNavbar(btnAsistencia);
            panelEstudiantes.Visible = false;
            panelInformeSemestral.Visible = false;
        }

        private void btnAsistencia_MouseHover(object sender, EventArgs e)
        {
            panelAsistencia.Visible = true;
            panelAsistencia.BringToFront();
            moverIndiceNavbar(btnAsistencia);
            panelEstudiantes.Visible = false;
            panelInformeSemestral.Visible = false;
        }

        private void panelAsistencia_MouseEnter(object sender, EventArgs e)
        {
            panelAsistencia.Visible = true;
        }

        private void btnAsis_Agregar_MouseHover(object sender, EventArgs e)
        {
            btnAsis_Agregar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAsis_Agregar.BringToFront();
            btnAsis_Agregar.FlatStyle = FlatStyle.Flat;
            Ind_PnlInfSemestral.Visible = false;
            Ind_PnlEstudiante.Visible = false;
            Ind_PnlAsistencia.Visible = true;
            moverIndicePnl_Asistencia(btnAsis_Agregar);
        }

        private void btnAsis_Agregar_MouseLeave(object sender, EventArgs e)
        {
            btnAsis_Agregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAsis_Agregar.FlatStyle = FlatStyle.Popup;
            Ind_PnlInfSemestral.Visible = false;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = false;
        }

        private void btn_Asis_Consultar_MouseHover(object sender, EventArgs e)
        {
            btn_Asis_Consultar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Asis_Consultar.BringToFront();
            btn_Asis_Consultar.FlatStyle = FlatStyle.Flat;
            Ind_PnlInfSemestral.Visible = false;
            Ind_PnlEstudiante.Visible = false;
            Ind_PnlAsistencia.Visible = true;
            moverIndicePnl_Asistencia(btn_Asis_Consultar);
        }

        private void btn_Asis_Consultar_MouseLeave(object sender, EventArgs e)
        {
            btn_Asis_Consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Asis_Consultar.FlatStyle = FlatStyle.Popup;
            Ind_PnlInfSemestral.Visible = false;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = false;
        }

        private void panelAsistencia_MouseLeave(object sender, EventArgs e)
        {
            panelAsistencia.Visible = false;
        }


        /*******************INFORME SEMESTRAL************************/
        /************************************************************/

        private void moverIndicePnl_InformeSemestral(Control btn)
        {
            Ind_PnlInfSemestral.Location = new Point(0, btn.Location.Y);
            Ind_PnlInfSemestral.Height = btn.Height;
        }

        private void btnInformeSemestral_Click(object sender, EventArgs e)
        {
            panelInformeSemestral.Visible = true;
            panelInformeSemestral.BringToFront();
            moverIndiceNavbar(btnInformeSemestral);
            panelEstudiantes.Visible = false;
            panelAsistencia.Visible = false;
        }

        private void btnInformeSemestral_MouseHover(object sender, EventArgs e)
        {
            panelInformeSemestral.Visible = true;
            panelInformeSemestral.BringToFront();
            moverIndiceNavbar(btnInformeSemestral);
            panelEstudiantes.Visible = false;
            panelAsistencia.Visible = false;
        }

        private void panelInformeSemestral_MouseEnter(object sender, EventArgs e)
        {
            panelInformeSemestral.Visible = true;
        }

        private void panelInformeSemestral_MouseLeave(object sender, EventArgs e)
        {
            panelInformeSemestral.Visible = false;
        }

        
        private void btnIS_Generar_MouseHover(object sender, EventArgs e)
        {
            btnIS_Generar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnIS_Generar.BringToFront();
            btnIS_Generar.FlatStyle = FlatStyle.Flat;
            Ind_PnlInfSemestral.Visible = true;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = false;
            moverIndicePnl_InformeSemestral(btnIS_Generar);
        }

        private void btnIS_Generar_MouseLeave(object sender, EventArgs e)
        {
            btnIS_Generar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIS_Generar.FlatStyle = FlatStyle.Popup;
            Ind_PnlInfSemestral.Visible = false;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = false;
        }

        private void btnIS_Consultar_MouseHover(object sender, EventArgs e)
        {
            btnIS_Consultar.TextImageRelation = TextImageRelation.TextBeforeImage;
            Ind_PnlInfSemestral.Visible = true;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = false;
            btnIS_Consultar.FlatStyle = FlatStyle.Flat;
            btnIS_Consultar.BringToFront();
            moverIndicePnl_InformeSemestral(btnIS_Consultar);
        }

        private void btnIS_Consultar_MouseLeave(object sender, EventArgs e)
        {
            btnIS_Consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIS_Consultar.FlatStyle = FlatStyle.Popup;
            Ind_PnlInfSemestral.Visible = false;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = false;
        }

        private void btnIS_Materia_MouseHover(object sender, EventArgs e)
        {
            btnIS_Materia.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnIS_Materia.BringToFront();
            btnIS_Materia.FlatStyle = FlatStyle.Flat;
            Ind_PnlInfSemestral.Visible = true;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = false;
            moverIndicePnl_InformeSemestral(btnIS_Materia);
        }

        private void btnIS_Materia_MouseLeave(object sender, EventArgs e)
        {
            btnIS_Materia.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIS_Materia.FlatStyle = FlatStyle.Popup;
            Ind_PnlInfSemestral.Visible = false;
            Ind_PnlAsistencia.Visible = false;
            Ind_PnlEstudiante.Visible = false;
        }

        private void VolverGA()
        {
            btnEstudiantes.Enabled = true;
            btnAsistencia.Enabled = true;
            btnInformeSemestral.Enabled = true;
            btn_VolverGA.Visible = false;
            lbl_Ruta.Visible = false;

        }

        private void btn_VolverGA_Click(object sender, EventArgs e)
        {
            currentFormChild.Close();
            VolverGA();
        }

        private void btnEst_Consultar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmAlumnosGestionar());
            btnEstudiantes.Enabled = true;
            btnAsistencia.Enabled = false;
            btnInformeSemestral.Enabled = false;
            btn_VolverGA.Visible = true;
            lbl_Ruta.Visible = true;           
            
        }

        private void btnEst_GrupoFlia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmAlumnosGrupoFlia());
            btnEstudiantes.Enabled = true;
            btnAsistencia.Enabled = false;
            btnInformeSemestral.Enabled = false;
            btn_VolverGA.Visible = true;
            lbl_Ruta.Visible = true;
        }

        private void btnAsis_Agregar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmAsistencia());
            btnAsistencia.Enabled = true;
            btnInformeSemestral.Enabled = false;
            btnEstudiantes.Enabled = false;
            btn_VolverGA.Visible = true;
            lbl_Ruta.Visible = true;
        }

        private void btn_Asis_Consultar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmAsistenciaConsulta());
            btnAsistencia.Enabled = true;
            btnInformeSemestral.Enabled = false;
            btnEstudiantes.Enabled = false;
            btn_VolverGA.Visible = true;
            lbl_Ruta.Visible = true;
        }

        private void btnIS_Generar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmInformeSemestral_Generar());
            btnInformeSemestral.Enabled = true;
            btnAsistencia.Enabled = false;
            btnEstudiantes.Enabled = false;
            btn_VolverGA.Visible = true;
            lbl_Ruta.Visible = true;
        }

        private void btnIS_Materia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmInformeProgreso_AgregarMateria());
            btnInformeSemestral.Enabled = true;
            btnAsistencia.Enabled = false;
            btnEstudiantes.Enabled = false;
            btn_VolverGA.Visible = true;
            lbl_Ruta.Visible = true;
        }

        private void btnIS_Consultar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmInformeProgreso_Consultar());
            btnInformeSemestral.Enabled = true;
            btnAsistencia.Enabled = false;
            btnEstudiantes.Enabled = false;
            btn_VolverGA.Visible = true;
            lbl_Ruta.Visible = true;
        }
    }
}
