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
    public partial class frmConcepto_Agregar : Form
    {

        

        public frmConcepto_Agregar()
        {
            InitializeComponent();
        }

        private void frmConcepto_Agregar_Load(object sender, EventArgs e)
        {
            txtOtros.Visible = false;
        }

        private void cbConcepto_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbConcepto.SelectedItem.ToString() == "OTROS")
            {
                txtOtros.Visible = true;            
            }
            else
            {
                txtOtros.Visible = false;
            }
        }

    }
}
