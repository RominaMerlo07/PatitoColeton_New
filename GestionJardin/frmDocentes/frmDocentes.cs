using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CaLog;
using CaEnt;

namespace GestionJardin
{
    public partial class frmDocentes : Form
    {
        logPersonas objlogPersonas = new logPersonas();
        entPersona objPersona = new entPersona();
        logDomicilio objlogDomicilio = new logDomicilio();
        logSalas objlogSalas = new logSalas();
        AutoCompleteStringCollection traerdocente = new AutoCompleteStringCollection();
        logPersonas logPersonas = new logPersonas();
        entSala sala = new entSala();

        public frmDocentes()
        {
            InitializeComponent();            
        }
        
        private void frmDocentes_Load(object sender, EventArgs e)
        {
            dgv_Docentes.ClearSelection();
            btnGD_Editar.IconColor = Color.Gray;
            btnGD_Editar.ForeColor = Color.Gray;
            btnGD_Eliminar.IconColor = Color.Gray;
            btnGD_Eliminar.ForeColor = Color.Gray;            
            dgv_Docentes.DataSource = objlogPersonas.Mostrardocente();
            dgv_Docentes.Columns["DOCENTE"].Frozen = true;
            dgv_Docentes.Columns["DOCUMENTO"].Frozen = true;

            this.dgv_Docentes.Columns["DOCENTE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv_Docentes.Columns["DOCUMENTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv_Docentes.Columns["CELULAR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgv_Docentes.Columns["EMAIL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv_Docentes.Columns["CARGO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv_Docentes.Columns["SALA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv_Docentes.Columns["TURNO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgv_Docentes.Columns["FECHA_DE_ALTA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Docentes.Columns["FECHA_DE_MODIFICACION"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Settooltip();
        }

        private void Settooltip()
        {
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(this.btnGD_Agregar, "Ingresar o dar de alta un docente");
            Tip.SetToolTip(this.btnGD_Editar, "Visualizar y/o modificar los datos de un docente");
            Tip.SetToolTip(this.btnGD_Eliminar, "Dar de baja un docente");
            Tip.SetToolTip(this.btn_ImprimirSala, "Visualizar docentes por sala");
            Tip.SetToolTip(this.btnLista, "Imprimir listado de docentes");
        }


        /*  FUNCIONALIDAS BUSCAR, filtra la grilla */

        private void txtGD_Buscar_TextChanged_1(object sender, EventArgs e)
        {

            if (txtGD_Buscar.Text.Length > 0)
            {
                carga_grilla_filtrada();
            }
            else
            {
                txtGD_Buscar.Clear();
                dgv_Docentes.DataSource = objlogPersonas.Mostrardocente();
                dgv_Docentes.Columns["DOCENTE"].Frozen = true;
                dgv_Docentes.Columns["DNI"].Frozen = true;
                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
            }                                 


           
        }

        private void txtGD_Buscar_Click(object sender, EventArgs e)
        {            
            txtGD_Buscar.CharacterCasing = CharacterCasing.Upper;//esto me pone las letras en mayusculas siempre

            if (txtGD_Buscar.Text.Length > 0)
            {
                carga_grilla_filtrada();
            }
            else
            {
                txtGD_Buscar.Clear();
                dgv_Docentes.DataSource = objlogPersonas.Mostrardocente();
                dgv_Docentes.Columns["DOCENTE"].Frozen = true;
                dgv_Docentes.Columns["DNI"].Frozen = true;
                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
            }
                        
        }

    
        
        private void dgv_Docentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                       
            if (dgv_Docentes.SelectedRows.Count > 0)
            {
                btnGD_Editar.IconColor = Color.Cyan;
                btnGD_Editar.ForeColor = Color.Cyan;
                btnGD_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGD_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
                dgv_Docentes.ClearSelection();
            }
        }


        /***************************************************/
        /***************** AGREGAR DOCENTE *****************/
        /***************************************************/

        private void btnGD_Agregar_Click(object sender, EventArgs e)
        {
            frmDocentesPopUpAgregar frmDocentesPopUpAgregar = new frmDocentesPopUpAgregar();
            frmDocentesPopUpAgregar.Text = "GESTION DOCENTES / INGRESAR";
            frmDocentesPopUpAgregar.ShowDialog();

            dgv_Docentes.DataSource = objlogPersonas.Mostrardocente();

            btnGD_Editar.IconColor = Color.Gray;
            btnGD_Editar.ForeColor = Color.Gray;
            btnGD_Eliminar.IconColor = Color.Gray;
            btnGD_Eliminar.ForeColor = Color.Gray;
            dgv_Docentes.ClearSelection();
        }

        /**************************************************/
        /***************** EDITAR DOCENTE *****************/
        /**************************************************/

        private void btnGD_Editar_Click(object sender, EventArgs e)
        {
            entPersona personaBuscar = new entPersona();
            entDomicilio domicilioBuscar = new entDomicilio();
            entSala salaBuscar = new entSala();

            if (dgv_Docentes.SelectedRows.Count > 0)
            {
                btnGD_Editar.IconColor = Color.Cyan;
                btnGD_Editar.ForeColor = Color.Cyan;


                string documento = dgv_Docentes.CurrentRow.Cells[1].Value.ToString();
                string cargo = dgv_Docentes.CurrentRow.Cells[4].Value.ToString();

                personaBuscar = objlogPersonas.BuscaDocente(documento);

                if (personaBuscar.PER_NOMBRE != null)
                {
                    frmDocentesPopUpEditar frmDocentesPopUpEditar = new frmDocentesPopUpEditar(personaBuscar.PER_ID.ToString()); // se usara en el editar                   
                    frmDocentesPopUpEditar.Cbocargo.SelectedIndex = frmDocentesPopUpEditar.Cbocargo.FindStringExact(cargo.TrimEnd());
                    frmDocentesPopUpEditar.txt_id_Docente.Text = Convert.ToString(personaBuscar.PER_ID);
                    frmDocentesPopUpEditar.Text = "GESTION DOCENTES / MODIFICAR";
                    AddOwnedForm(frmDocentesPopUpEditar);
                    frmDocentesPopUpEditar.ShowDialog();
                }
                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
                dgv_Docentes.DataSource = objlogPersonas.Mostrardocente();
                dgv_Docentes.ClearSelection();

            }

            else
            {
                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder visualizar/modificar los datos del Docente","Información",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }



        }

        /**************************************************/
        /***************** ELIMINAR DOCENTE *****************/
        /**************************************************/

        private void btnGD_Eliminar_Click(object sender, EventArgs e)
        {
            frmDocentesPopUpEliminar frmDocentesPopUpEliminar = new frmDocentesPopUpEliminar();
            entPersona personaBuscar = new entPersona();          

            if (dgv_Docentes.SelectedRows.Count > 0)
            {

                btnGD_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGD_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

                string documento = dgv_Docentes.CurrentRow.Cells[1].Value.ToString();
                personaBuscar = objlogPersonas.BuscaDocente(documento);

                if (personaBuscar.PER_NOMBRE != null)
                {
                    frmDocentesPopUpEliminar.txt_id_Docente.Text = Convert.ToString(personaBuscar.PER_ID); // se usara en el editar                                     
                    frmDocentesPopUpEliminar.lblnombredocente.Text = "'" + dgv_Docentes.CurrentRow.Cells[0].Value.ToString() + "'";
                }

               // frmDocentesPopUpEliminar.lbldnidoc.Text =  dgv_Docentes.CurrentRow.Cells[1].Value.ToString() ;
                frmDocentesPopUpEliminar.Text = "GESTION DOCENTES / ELIMINAR";
                frmDocentesPopUpEliminar.ShowDialog();
                dgv_Docentes.DataSource = objlogPersonas.Mostrardocente();

                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
                dgv_Docentes.ClearSelection();

            }
            else
            {
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder dar de baja al Docente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
                
        }


        private void carga_grilla_filtrada()
        {
            DataTable col = new DataTable();
            logPersonas logPersonas = new logPersonas();
            col = logPersonas.Mostrardocente();
            dgv_Docentes.DataSource = col;
            string apellido_nombre = logPersonas.extraerapellido_nombre_alumno(txtGD_Buscar.Text);
            col.DefaultView.RowFilter = String.Format($"DOCENTE LIKE '{apellido_nombre}%'");

        }

        private void btn_ImprimirSala_Click(object sender, EventArgs e)
        {
            ImprimirListaSala ImprimirListaSala = new ImprimirListaSala();
            ImprimirListaSala.Show();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            ListaTotalDocentes ListaTotalDocentes = new ListaTotalDocentes();
        }
    }
}
