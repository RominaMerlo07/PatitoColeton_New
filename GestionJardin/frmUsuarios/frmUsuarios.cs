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
using System.Data.SqlClient;

namespace GestionJardin
{
    public partial class frmUsuarios : Form
    {
        logUsuario ObjetoUsu = new logUsuario();

        public frmUsuarios()
        {
            InitializeComponent();
        }
        /*************LOAD **************/

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dgv_UsuariosActivos.ClearSelection();
            Settooltip();
            //--
            DataTable dt = ObjetoUsu.AutocompletarenDocente(/*txtGU_Buscar*/);

            foreach (DataRow row in dt.Rows)
            {
                txtGU_Buscar.AutoCompleteCustomSource.Add(row[0].ToString()); //assuming required data is in first column
            }

            //--
            dgv_UsuariosActivos.DataSource = ObjetoUsu.MostrarUsu();
            this.dgv_UsuariosActivos.Columns["DOCENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv_UsuariosActivos.Columns["USUARIO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv_UsuariosActivos.Columns["CONTRASEÑA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_UsuariosActivos.Columns["FECHA DE ALTA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_UsuariosActivos.Columns["FECHA DE MODIFICACION"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_UsuariosActivos.Columns["ESTADO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            btnGU_Editar.IconColor = Color.Gray;
            btnGU_Editar.ForeColor = Color.Gray;
            btnGU_Eliminar.IconColor = Color.Gray;
            btnGU_Eliminar.ForeColor = Color.Gray;            
        }
        

                /******  buscar datos Grilla ******/

        private void txtGU_Buscar_ButtonClick(object sender, EventArgs e)
        {
            string docente = txtGU_Buscar.Text;
            dgv_UsuariosActivos.DataSource = ObjetoUsu.llenarGrilla(docente);
        }

        private void txtGU_Buscar_Enter(object sender, EventArgs e)
        {
            string docente = txtGU_Buscar.Text;
            dgv_UsuariosActivos.DataSource = ObjetoUsu.llenarGrilla(docente);
        }

                     /******  Filtro Grilla ******/

        private void txtGU_Buscar_TextChanged(object sender, EventArgs e)
        {
            
            if (txtGU_Buscar.Text.Length > 0)
            {
                dgv_UsuariosActivos.DataSource = ObjetoUsu.llenarGrilla(txtGU_Buscar.Text);
                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;
            }
            else
            {
                txtGU_Buscar.Clear();
                dgv_UsuariosActivos.DataSource = ObjetoUsu.MostrarUsu();
                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;
            }
        }
        /************* COLOCA LAS LETRAS EN MAYUSCULAS **************/

        private void txtGU_Buscar_Click(object sender, EventArgs e)
         {
           txtGU_Buscar.CharacterCasing = CharacterCasing.Upper;//esto me pone las letras en mayusculas siempre 
         }

        /************* Mensaje evento hover boton  **************/

        private void Settooltip()
        {
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(this.btnGU_Eliminar, "SELECCIONE UN REGISTRO PARA PODER ELIMINAR");           
            Tip.SetToolTip(this.btnGU_Editar, "SELECCIONE UN REGISTRO PARA PODER EDITAR");
        }


        
        /************* Habilitacion de botones segun seleccion de registro en grilla  **************/
       

        private void dgv_UsuariosActivos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_UsuariosActivos.SelectedRows.Count > 0)
            {
                btnGU_Editar.IconColor = Color.Cyan;
                btnGU_Editar.ForeColor = Color.Cyan;
                btnGU_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGU_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                dgv_UsuariosActivos.ClearSelection();
                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;
            }
        }

        /***************************************/
        /*************** AGREGAR ***************/
        /***************************************/

        private void btnGU_Agregar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpAgregar frmUsuariosPopUpAgregar = new frmUsuariosPopUpAgregar();
            frmUsuariosPopUpAgregar.Text = "GESTION USUARIOS / GENERAR NUEVO USUARIO";
            AddOwnedForm(frmUsuariosPopUpAgregar);

            //--
            DataTable dt = ObjetoUsu.AutocompletarAgregarDocente(/*frmUsuariosPopUpAgregar.txtSeleccionarDocente*/);


            foreach (DataRow row in dt.Rows)
            {
                frmUsuariosPopUpAgregar.txtSeleccionarDocente.AutoCompleteCustomSource.Add(row[0].ToString()); 
            }
            
            //--
            frmUsuariosPopUpAgregar.ShowDialog();

            btnGU_Editar.IconColor = Color.Gray;
            btnGU_Editar.ForeColor = Color.Gray;
            btnGU_Eliminar.IconColor = Color.Gray;
            btnGU_Eliminar.ForeColor = Color.Gray;
            dgv_UsuariosActivos.ClearSelection();
        }

        /***************************************/
        /*************** EDITAR ***************/
        /***************************************/

        private void btnGU_Editar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpEditar frmUsuariosPopUpEditar = new frmUsuariosPopUpEditar();
            frmUsuariosPopUpEditar.Text = "GESTION USUARIOS / MODIFICAR CONTRASEÑA";
            AddOwnedForm(frmUsuariosPopUpEditar);//lo declara como padre de for EU a frmUsuario
            frmUsuariosPopUpEditar.lblEditarUsu.Text = "'" + dgv_UsuariosActivos.CurrentRow.Cells[1].Value.ToString() + "'";

            if (dgv_UsuariosActivos.SelectedRows.Count > 0)
            {

                btnGU_Editar.IconColor = Color.Cyan;
                btnGU_Editar.ForeColor = Color.Cyan;
                frmUsuariosPopUpEditar.ShowDialog();

                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;
                dgv_UsuariosActivos.ClearSelection();
            }
            else
            {
                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder modificar la contraseña");
               
            }

        }


        /****************************************/
        /*************** ELIMINAR ***************/
        /****************************************/

        private void btnGU_Eliminar_Click(object sender, EventArgs e)
        {
            frmUsuariosPopUpEliminar frmUsuariosPopUpEliminar = new frmUsuariosPopUpEliminar();
            frmUsuariosPopUpEliminar.Text = "GESTION USUARIOS / ELIMINAR USUARIO";
            AddOwnedForm(frmUsuariosPopUpEliminar);
            
            if (dgv_UsuariosActivos.SelectedRows.Count > 0)
            {

                btnGU_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGU_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
                frmUsuariosPopUpEliminar.lblUSUARIOELIMINAR.Text = "'" + dgv_UsuariosActivos.CurrentRow.Cells[1].Value.ToString() + "'";
                frmUsuariosPopUpEliminar.ShowDialog();

                btnGU_Editar.IconColor = Color.Gray;
                btnGU_Editar.ForeColor = Color.Gray;
                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;
                dgv_UsuariosActivos.ClearSelection();

            }
            else
            {

                btnGU_Eliminar.IconColor = Color.Gray;
                btnGU_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder ELIMINARLO");
                
            }
        }

        private void dgv_UsuariosActivos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);


            }
        }
    }
}
