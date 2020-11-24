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

namespace GestionJardin
{
    public partial class frmInformeProgreso_GestAsig_Eliminar : Form
    {
        string mat_id;

        public frmInformeProgreso_GestAsig_Eliminar(string id, string nombre)
        {
            InitializeComponent();

            mat_id = id;
            label2.Text = nombre + "?";

        }

        private void btn_CancelarUsuNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GuardarUsuNuevo_Click(object sender, EventArgs e)
        {
            logMaterias logMaterias = new logMaterias();
            string estado = logMaterias.EliminarMateria(mat_id);

            this.Close();
        }
    }
}
