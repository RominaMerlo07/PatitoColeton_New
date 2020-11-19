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
    public partial class frmAlumnosPopUpEliminar : Form
    {
        string idEliminar;
        int edad5;
        //string alumno;

        public frmAlumnosPopUpEliminar(string idEliminar, string alumno, int edad)
        {
            InitializeComponent();
            //idEliminar = idEliminar;
            //alumno = alumno;
            edad5 = edad;

            label2.Text = alumno + "?";
            lblidPersona.Text = idEliminar;
        }

        private void btn_CancelarUsuNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_GuardarUsuNuevo_Click(object sender, EventArgs e)
        {
            idEliminar = lblidPersona.Text;
            entPersona eliminaPersona = new entPersona();
            logPersonas metPersona = new logPersonas();
            eliminaPersona.PER_ID = Convert.ToInt32(idEliminar);
            string resultado = metPersona.EliminarDocente(eliminaPersona);
           
            if (resultado == "OK")
            {
                if(edad5 > 5)
                {
                    string result = metPersona.EliminarDocenteGrupoSala(eliminaPersona);
                    if (result == "OK")
                    {
                        MessageBox.Show("Se dio de baja el alumno y se libero cupo en la sala de 5 años, ya que la edad del alumno es mayor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Se dio de baja el alumno", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }            


            } 

        }
    }
}
