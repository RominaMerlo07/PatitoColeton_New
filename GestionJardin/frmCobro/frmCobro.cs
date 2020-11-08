using System;
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
    public partial class frmCobro : Form
    {
        private Form currentFormChild; //para almacenar el form hijo actual

        public frmCobro()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form ChildForm)
        {

            frmCobro frmCobro = new frmCobro();

            if (currentFormChild != null)
            {
                currentFormChild.Close(); // se cierra el form actual -- permite solo un form actual
            }

            currentFormChild = ChildForm;
            ChildForm.TopLevel = false; // para indicar que no es de nivel superior --VER CON GASTON
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelContenedor_GC.Controls.Add(ChildForm); //para que controle los demas forms
            panelContenedor_GC.Tag = ChildForm; // Asociar los datos de los forms al panel
            ChildForm.BringToFront(); // se trae al frente cada form para mostrar
            ChildForm.Show();
            btn_VolverGA.Visible = true;
            //   btn_VolverGA.BringToFront();
            lbl_Ruta.Text = "Usted se encuentra en GESTION COBROS / " + ChildForm.Text;

        }



        private void moverIndiceNavbar(Control btn)
        {
            panelIndiceNavbar.Width = btn.Width;
            panelIndiceNavbar.Left = btn.Left;
            panelIndiceNavbar.BackColor = btn.ForeColor;
            panelIndiceNavbar.Visible = true;
        }


        /*******************************************/
        /**************** COBROS *******************/
        /*******************************************/

        private void moverIndicePnl_Cobros(Control btn)
        {
            Ind_PnlCobro.Location = new Point(0, btn.Location.Y);
            Ind_PnlCobro.Height = btn.Height;
        }

        private void btnCobros_Click(object sender, EventArgs e)
        {
            panelCobros.Visible = true;
            panelCobros.BringToFront();
            moverIndiceNavbar(btnCobros);
            panelCuotas.Visible = false;
            panelConceptos.Visible = false;
        }

        private void btnCobros_MouseHover(object sender, EventArgs e)
        {
            panelCobros.Visible = true;
            panelCobros.BringToFront();
            moverIndiceNavbar(btnCobros);
            panelCuotas.Visible = false;
            panelConceptos.Visible = false;
        }

        private void panelCobros_MouseEnter(object sender, EventArgs e)
        {
            panelCobros.Visible = true;
        }

        private void btnCob_Gestionar_MouseHover(object sender, EventArgs e)
        {
            btnCob_Gestionar.FlatStyle = FlatStyle.Flat;
            btnCob_Gestionar.BringToFront();
            btnCob_Gestionar.TextImageRelation = TextImageRelation.TextBeforeImage;
            Ind_PnlCuota.Visible = false;
            Ind_PnlConcepto.Visible = false;
            Ind_PnlCobro.Visible = true;
            moverIndicePnl_Cobros(btnCob_Gestionar);
        }

        private void btnCob_Gestionar_MouseLeave(object sender, EventArgs e)
        {
            btnCob_Gestionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCob_Gestionar.FlatStyle = FlatStyle.Popup;
            Ind_PnlCuota.Visible = false;
            Ind_PnlConcepto.Visible = false;
            Ind_PnlCobro.Visible = false;
        }

        private void btnCob_Consultar_MouseHover(object sender, EventArgs e)
        {
            btnCob_Consultar.FlatStyle = FlatStyle.Flat;
            btnCob_Consultar.BringToFront();
            btnCob_Consultar.TextImageRelation = TextImageRelation.TextBeforeImage;
            Ind_PnlCuota.Visible = false;
            Ind_PnlConcepto.Visible = false;
            Ind_PnlCobro.Visible = true;
            moverIndicePnl_Cobros(btnCob_Consultar);
        }

        private void btnCob_Consultar_MouseLeave(object sender, EventArgs e)
        {
            btnCob_Consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCob_Consultar.FlatStyle = FlatStyle.Popup;
            Ind_PnlCuota.Visible = false;
            Ind_PnlConcepto.Visible = false;
            Ind_PnlCobro.Visible = false;
        }

        private void panelCobros_MouseLeave(object sender, EventArgs e)
        {
            panelCobros.Visible = false;
        }


        /*******************************************/
        /**************** CUOTAS *******************/
        /*******************************************/

        private void moverIndicePnl_Cuotas(Control btn)
        {
            Ind_PnlCuota.Location = new Point(0, btn.Location.Y);
            Ind_PnlCuota.Height = btn.Height;
        }

        private void btnCuotas_Click(object sender, EventArgs e)
        {
            panelCuotas.Visible = true;
            panelCuotas.BringToFront();
            moverIndiceNavbar(btnCuotas);
            panelCobros.Visible = false;
            panelConceptos.Visible = false;
        }

        private void btnCuotas_MouseHover(object sender, EventArgs e)
        {
            panelCuotas.Visible = true;
            panelCuotas.BringToFront();
            moverIndiceNavbar(btnCuotas);
            panelCobros.Visible = false;
            panelConceptos.Visible = false;
        }

        private void panelCuotas_MouseHover(object sender, EventArgs e)
        {
            panelCuotas.Visible = true;
        }

        private void btnCuo_Gestionar_MouseHover(object sender, EventArgs e)
        {
            btnCuo_Gestionar.FlatStyle = FlatStyle.Flat;
            btnCuo_Gestionar.BringToFront();
            btnCuo_Gestionar.TextImageRelation = TextImageRelation.TextBeforeImage;
            Ind_PnlCobro.Visible = false;
            Ind_PnlConcepto.Visible = false;
            Ind_PnlCuota.Visible = true;
            moverIndicePnl_Cuotas(btnCuo_Gestionar);
        }

        private void btnCuo_Gestionar_MouseLeave(object sender, EventArgs e)
        {
            btnCuo_Gestionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCuo_Gestionar.FlatStyle = FlatStyle.Popup;
            Ind_PnlCuota.Visible = false;
            Ind_PnlConcepto.Visible = false;
            Ind_PnlCobro.Visible = false;
        }

        private void btnCuo_Consultar_MouseHover(object sender, EventArgs e)
        {
            btnCuo_Consultar.FlatStyle = FlatStyle.Flat;
            btnCuo_Consultar.BringToFront();
            btnCuo_Consultar.TextImageRelation = TextImageRelation.TextBeforeImage;
            Ind_PnlCobro.Visible = false;
            Ind_PnlConcepto.Visible = false;
            Ind_PnlCuota.Visible = true;
            moverIndicePnl_Cuotas(btnCuo_Consultar);
        }

        private void btnCuo_Consultar_MouseLeave(object sender, EventArgs e)
        {
            btnCuo_Consultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCuo_Consultar.FlatStyle = FlatStyle.Popup;
            Ind_PnlCuota.Visible = false;
            Ind_PnlConcepto.Visible = false;
            Ind_PnlCobro.Visible = false;
        }

        private void panelCuotas_MouseLeave(object sender, EventArgs e)
        {
            panelCuotas.Visible = false;
        }

        /**********************************************/
        /**************** CONCEPTOS *******************/
        /**********************************************/

        private void moverIndicePnl_Conceptos(Control btn)
        {
            Ind_PnlConcepto.Location = new Point(0, btn.Location.Y);
            Ind_PnlConcepto.Height = btn.Height;
        }

        private void btnConceptos_Click(object sender, EventArgs e)
        {
            panelConceptos.Visible = true;
            panelConceptos.BringToFront();
            moverIndiceNavbar(btnConceptos);
            panelCobros.Visible = false;
            panelCuotas.Visible = false;
        }

        private void btnConceptos_MouseHover(object sender, EventArgs e)
        {
            panelConceptos.Visible = true;
            panelConceptos.BringToFront();
            moverIndiceNavbar(btnConceptos);
            panelCobros.Visible = false;
            panelCuotas.Visible = false;
        }

        private void panelConceptos_MouseHover(object sender, EventArgs e)
        {
            panelConceptos.Visible = true;
        }

        private void btnCon_Gestionar_MouseHover(object sender, EventArgs e)
        {
            btnCon_Gestionar.FlatStyle = FlatStyle.Flat;
            btnCon_Gestionar.BringToFront();
            btnCon_Gestionar.TextImageRelation = TextImageRelation.TextBeforeImage;
            Ind_PnlCobro.Visible = false;
            Ind_PnlCuota.Visible = false;
            Ind_PnlConcepto.Visible = true;
            moverIndicePnl_Cuotas(btnCon_Gestionar);
        }

        private void btnCon_Gestionar_MouseLeave(object sender, EventArgs e)
        {
            btnCon_Gestionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCon_Gestionar.FlatStyle = FlatStyle.Popup;
            Ind_PnlCuota.Visible = false;
            Ind_PnlConcepto.Visible = false;
            Ind_PnlCobro.Visible = false;
        }

        private void panelConceptos_MouseLeave(object sender, EventArgs e)
        {
            panelConceptos.Visible = false;
        }

        private void panelConceptos_MouseEnter(object sender, EventArgs e)
        {
            panelConceptos.Visible = false;
        }

        private void btnCon_Gestionar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmConcepto());
            panel1.BringToFront();
            btnConceptos.Enabled = true;
            btnCuotas.Enabled = false;
            btnCobros.Enabled = false;
            btn_VolverGA.BringToFront();
            btn_VolverGA.Visible = true;
            lbl_Ruta.BringToFront();
            lbl_Ruta.Visible = true;
        }

        private void VolverGA()
        {
            btnCobros.Enabled = true;
            btnCuotas.Enabled = true;
            btnConceptos.Enabled = true;
            btn_VolverGA.Visible = false;
            lbl_Ruta.Visible = false;
            panelCuotas.Visible = false;
            panelCobros.Visible = false;
            panelConceptos.Visible = false;
        }

        private void btn_VolverGA_Click(object sender, EventArgs e)
        {
            currentFormChild.Close();
            VolverGA();
        }

        private void btnCob_Gestionar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmCobros_Gestionar());
            panel1.BringToFront();
            btnCobros.Enabled = true;
            btnConceptos.Enabled = false;
            btnCuotas.Enabled = false;
            btn_VolverGA.BringToFront();
            btn_VolverGA.Visible = true;
            lbl_Ruta.BringToFront();
            lbl_Ruta.Visible = true;
        }

        private void btnCuo_Consultar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmCuotasConsultar());
            panel1.BringToFront();
            btnCuotas.Enabled = true;
            btnCobros.Enabled = false;
            btnConceptos.Enabled = false;
            btn_VolverGA.BringToFront();
            btn_VolverGA.Visible = true;
            lbl_Ruta.BringToFront();
            lbl_Ruta.Visible = true;
        }

        private void btnCob_Consultar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmCobros_Consultar());
            panel1.BringToFront();
            btnCobros.Enabled = true;
            btnCuotas.Enabled = false;
            btnConceptos.Enabled = false;
            btn_VolverGA.BringToFront();
            btn_VolverGA.Visible = true;
            lbl_Ruta.BringToFront();
            lbl_Ruta.Visible = true;
        }

        private void btnCuo_Gestionar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GestionJardin.frmCuotasGestionar());
            panel1.BringToFront();
            btnCuotas.Enabled = true;
            btnCobros.Enabled = false;
            btnConceptos.Enabled = false;
            btn_VolverGA.BringToFront();
            btn_VolverGA.Visible = true;
            lbl_Ruta.BringToFront();
            lbl_Ruta.Visible = true;
        }
    }
}
