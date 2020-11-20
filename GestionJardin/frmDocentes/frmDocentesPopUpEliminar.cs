using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CaLog;
using CaEnt;

namespace GestionJardin
{
    
    public partial class frmDocentesPopUpEliminar : Form
    {

        logPersonas objetopersona = new logPersonas();
        entPersona Docentes = new entPersona();
      //  int documento;
        int idPersonaBuscar;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);
        public frmDocentesPopUpEliminar()
        {
            InitializeComponent();
        }
              

        private void frmDocentesPopUpEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_sieliminar_Click(object sender, EventArgs e)
        {
            frmDocentes Fdocentes= Owner as frmDocentes;                        
                      
                
                idPersonaBuscar = Convert.ToInt32(txt_id_Docente.Text);
                entPersona personaEditar = new entPersona();
                personaEditar.PER_ID = idPersonaBuscar;
                
                var usumetodo = new logUsuario();
                objetopersona.EliminarDocente(personaEditar);
               // objetopersona.EliminarDocenteGrupoSala(personaEditar);

                MessageBox.Show("SE DIO DE BAJA AL DOCENTE " + lblnombredocente.Text, "Información",MessageBoxButtons.OK, MessageBoxIcon.Information);                
                this.Close();
        }

        private void btn_noeliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
