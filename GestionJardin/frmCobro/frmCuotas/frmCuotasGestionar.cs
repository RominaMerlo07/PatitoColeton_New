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
    public partial class frmCuotasGestionar : Form
    {
        public frmCuotasGestionar()
        {
            InitializeComponent();
        }

        private void btnMasivo_Click(object sender, EventArgs e)
        {
            BtnActivo();
          
            txtMatriculados.Visible = false;
            cboOpcionMasivo.Visible = true;            
        }

        private void btnParticular_Click(object sender, EventArgs e)
        {
           
            cboOpcionMasivo.Visible = false;
            txtMatriculados.Visible = true;
         
        }  

        private void Inicializar()
        {
           
            panelGrilla.Visible = false;
            panelConceptos.Visible = false;
            cboOpcionMasivo.Visible = false;
            txtMatriculados.Visible = false;
            btnEliminar.Visible = false;
            btnAplicarIntereses.Visible = false;
            btnGenerar.Visible = false;           
            cbSalas.SelectedIndex = -1;
        
        }

        private void BtnActivo()
        {
           

        }

        private void cbSalas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSalas.SelectedItem != null)
            {
                panelGrilla.Visible = true;
                panelConceptos.Visible = true;
                panelConceptos.Enabled = false;
                lblConceptos.ForeColor = Color.Gray;
            }
        }

        private void cboOpcionMasivo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboOpcionMasivo.SelectedItem != null)
            {
                if (cboOpcionMasivo.SelectedIndex == 0)
                {
                    panelConceptos.Enabled = true;
                    lblConceptos.ForeColor = Color.Aqua;
                    btnEliminar.Visible = true;
                    btnAplicarIntereses.Visible = true;
                    btnGenerar.Visible = true;                 


                }
                else
                {
                    panelConceptos.Enabled = false;
                    lblConceptos.ForeColor = Color.Gray;
                    btnEliminar.Visible = true;
                    btnAplicarIntereses.Visible = true;
                    btnGenerar.Visible = true;                   

                }

            }
        }
        
    }
}
