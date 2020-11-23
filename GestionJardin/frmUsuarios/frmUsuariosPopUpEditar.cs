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
    public partial class frmUsuariosPopUpEditar : Form
    {
        logUsuario ObjetoUsu = new logUsuario();
        entUsuario Usuario = new entUsuario();
        public frmUsuariosPopUpEditar()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);

                /*************LOAD **************/

        private void frmUsuariosPopUpEditar_Load(object sender, EventArgs e)
        {
            frmUsuarios U = Owner as frmUsuarios;
            metroTextBoxContrasenaEdit.UseSystemPasswordChar = true;         
          

        }
            /************* PERMITE MOVER EL FORM **************/

        private void frmUsuariosPopUpEditar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        /************* VALIDACIONES TEXTBOXCONTRASEÑA **************/

        private void metroTextBoxContrasenaEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            { e.Handled = false; }

            else if (char.IsSeparator(e.KeyChar))//no dejaq escriba espacios
            {
                e.Handled = true;
                MessageBox.Show("No puede ingresar espacios! ");
            }
            else if (char.IsControl(e.KeyChar))//permite q pueda borrar 
            {
                e.Handled = false;
            }
            else if (char.IsNumber(e.KeyChar)) //permite numeros
            {
                e.Handled = false;
            }
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar.ToString() == "ñ") || (e.KeyChar.ToString() == "Ñ"))
                {
                    e.Handled = true;
                    MessageBox.Show("Solo se permiten letras y numeros y caracteres especiales @, *, & !", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
               
                else if (!char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
            }
        }

                    /***************************************/
                    /*************** AGREGAR ***************/
                    /***************************************/
        private void btn_GuardarUsuMod_Click(object sender, EventArgs e)
        {
            frmUsuarios U = Owner as frmUsuarios;//esto me indica q es el padre frmUsuarios y me deja usar sus metodos
            var usu = new entUsuario();
            if (metroTextBoxContrasenaEdit.Text == " ")
            {
                MessageBox.Show("ingrese contraseña!");
            }
            if (metroTextBoxContrasenaEdit.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña! ");
                metroTextBoxContrasenaEdit.Focus();
            }
            else
            {
                usu.USU_USUARIO = lblEditarUsu.Text;
                usu.USU_CLAVE = metroTextBoxContrasenaEdit.Text;
                var usumetodo = new logUsuario();
                usumetodo.EditarUsuario(usu);
                MessageBox.Show("SE MODIFICO LA CONTRASEÑA DEL USUARIO :  " + lblEditarUsu.Text);
                U.dgv_UsuariosActivos.DataSource = ObjetoUsu.MostrarUsu();
                ObjetoUsu.MostrarUsu();
                this.Close();

            }
        }
                    /***************************************/
                    /*************** CANCELAR ***************/
                    /***************************************/
        private void btn_CancelarUsuMod_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Seguro desea salir?", "salir", MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);

            if ((resp == DialogResult.Yes))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Escriba una contraseña");
            }
        }

                private void btnBloqueo_Click(object sender, EventArgs e)
        {
            if (this.btnBloqueo.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                metroTextBoxContrasenaEdit.UseSystemPasswordChar = false;

            }
            else
            {

                this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Eye;
                metroTextBoxContrasenaEdit.UseSystemPasswordChar = true;

            }
        }
    }
}
