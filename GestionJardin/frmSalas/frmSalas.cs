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
    public partial class frmSalas : Form
    {
        //prueba 481523156
        logSala2 metSala = new logSala2();

        public frmSalas()
        {
            InitializeComponent();           
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {
            dgv_Salas.ClearSelection();          
            dgv_Salas.DataSource = metSala.GrillaSalas();
            dgv_Salas.Columns["SAL_ID"].Visible = false;

            
            DataTable dt = metSala.BuscarSala();
            
            foreach (DataRow row in dt.Rows)
            {
                txtGS_Buscar.AutoCompleteCustomSource.Add(row[0].ToString());
            }
            //-
            

            btnGS_Editar.IconColor = Color.Gray;
            btnGS_Editar.ForeColor = Color.Gray;
            btnGS_Eliminar.IconColor = Color.Gray;
            btnGS_Eliminar.ForeColor = Color.Gray;
        }

        private void btnGS_Editar_Click(object sender, EventArgs e)
        {
            if (dgv_Salas.SelectedRows.Count > 0)
            {
                btnGS_Editar.IconColor = Color.Cyan;
                btnGS_Editar.ForeColor = Color.Cyan;
                string idSalaSelect = dgv_Salas.SelectedRows[0].Cells[0].Value.ToString();
                frmSalasPopUpEditar frmSalasPopUpEditar = new frmSalasPopUpEditar(idSalaSelect);
                frmSalasPopUpEditar.Text = "GESTIÓN SALAS / EDITAR Y/O VISUALIZAR DATOS DE UNA SALA";
                frmSalasPopUpEditar.ShowDialog();

                dgv_Salas.DataSource = metSala.GrillaSalas();
                dgv_Salas.Columns["SAL_ID"].Visible = false;

                btnGS_Editar.IconColor = Color.Gray;
                btnGS_Editar.ForeColor = Color.Gray;
                btnGS_Eliminar.IconColor = Color.Gray;
                btnGS_Eliminar.ForeColor = Color.Gray;

            }
            else
            {
                btnGS_Editar.IconColor = Color.Gray;
                btnGS_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder visualizar y/o editar los datos de la sala", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

     
        private void dgv_Salas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Salas.SelectedRows.Count > 0)
            {
                btnGS_Editar.IconColor = Color.Cyan;
                btnGS_Editar.ForeColor = Color.Cyan;
                btnGS_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGS_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

            }
            else
            {
                dgv_Salas.ClearSelection();
                btnGS_Editar.IconColor = Color.Gray;
                btnGS_Editar.ForeColor = Color.Gray;
                btnGS_Eliminar.IconColor = Color.Gray;
                btnGS_Eliminar.ForeColor = Color.Gray;                
            }
        }

        private void btnGS_Eliminar_Click(object sender, EventArgs e)
        {            
            if (dgv_Salas.SelectedRows.Count > 0)
            {
                btnGS_Eliminar.IconColor = Color.FromArgb(255,128,0);
                btnGS_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

                string idSalaSelect = dgv_Salas.SelectedRows[0].Cells[0].Value.ToString();
                string nombreSala= dgv_Salas.SelectedRows[0].Cells[1].Value.ToString();
                frmSalasPopUpEliminar frmSalasPopUpEliminar = new frmSalasPopUpEliminar(idSalaSelect, nombreSala);
                frmSalasPopUpEliminar.Text = "GESTIÓN SALAS / ELIMINAR SALA";
                frmSalasPopUpEliminar.ShowDialog();

                dgv_Salas.DataSource = metSala.GrillaSalas();
                dgv_Salas.Columns["SAL_ID"].Visible = false;

                btnGS_Editar.IconColor = Color.Gray;
                btnGS_Editar.ForeColor = Color.Gray;
                btnGS_Eliminar.IconColor = Color.Gray;
                btnGS_Eliminar.ForeColor = Color.Gray;
            }
            else
            {             
                btnGS_Eliminar.IconColor = Color.Gray;
                btnGS_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder visualizar y/o editar los datos de la sala", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtGS_Buscar_TextChanged(object sender, EventArgs e)
        {
            string sala = "";
            string turno = "";            
            int contador = 0;
                        
            string busqueda = txtGS_Buscar.Text;

            char[] separadores = {'-', ' '};
            string[] palabras = busqueda.Split(separadores);

            foreach (var palabra in palabras)
            {
                contador += 1;
                if (contador == 1)
                {
                    sala = palabra.Trim();
                }
                else if (contador == 2)
                {
                    turno = palabra.Trim();
                }

            }                    

            if (txtGS_Buscar.Text.Length > 0)
            {
                dgv_Salas.DataSource = metSala.FiltrarSala(sala, turno);
                dgv_Salas.Columns["SAL_ID"].Visible = false;

                btnGS_Editar.IconColor = Color.Gray;
                btnGS_Editar.ForeColor = Color.Gray;
                btnGS_Eliminar.IconColor = Color.Gray;
                btnGS_Eliminar.ForeColor = Color.Gray;
            }
            else
            {
                txtGS_Buscar.Clear();                            
                dgv_Salas.DataSource = metSala.GrillaSalas();
                dgv_Salas.Columns["SAL_ID"].Visible = false;

                btnGS_Editar.IconColor = Color.Gray;
                btnGS_Editar.ForeColor = Color.Gray;
                btnGS_Eliminar.IconColor = Color.Gray;
                btnGS_Eliminar.ForeColor = Color.Gray;
            }
        }

        private void btnGS_Agregar_Click(object sender, EventArgs e)
        {
            frmSalasPopUpAgregar frmSalasPopUpAgregar = new frmSalasPopUpAgregar();
            frmSalasPopUpAgregar.Text = "GESTIÓN SALAS / CREAR NUEVA SALA";
            frmSalasPopUpAgregar.ShowDialog();            

            dgv_Salas.DataSource = metSala.GrillaSalas();
            dgv_Salas.Columns["SAL_ID"].Visible = false;

            btnGS_Editar.IconColor = Color.Gray;
            btnGS_Editar.ForeColor = Color.Gray;
            btnGS_Eliminar.IconColor = Color.Gray;
            btnGS_Eliminar.ForeColor = Color.Gray;

        }

        
    }
}
