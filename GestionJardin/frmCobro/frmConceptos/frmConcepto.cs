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
    public partial class frmConcepto : Form
    {
        public frmConcepto()
        {
            InitializeComponent();
            Settooltip();
        }

        private void Settooltip()
        {
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(this.btnCon_Agregar, "Dar de alta un concepto por primera vez");
            Tip.SetToolTip(this.btnCon_Editar, "Modificar el valor de un concepto");
            Tip.SetToolTip(this.btnCon_Eliminar, "Deshabilitar un concepto");
            Tip.SetToolTip(this.btnLista, "Imprimir lista de conceptos activos");
            Tip.SetToolTip(this.btn_ImprimirConcepto, "Visualizar historial por concepto");
        }

        private void btnCon_Agregar_Click(object sender, EventArgs e)
        {
            frmConcepto_Agregar frmConcepto_Agregar = new frmConcepto_Agregar();
            frmConcepto_Agregar.FormClosed += frmConcepto_Agregar_FormClosed;
            frmConcepto_Agregar.Text = "GESTIÓN COBROS / CONCEPTOS / GESTIONAR / AGREGAR";
            frmConcepto_Agregar.ShowDialog();

            btnCon_Eliminar.IconColor = Color.Gray;
            btnCon_Eliminar.ForeColor = Color.Gray;
            btnCon_Editar.IconColor = Color.Gray;
            btnCon_Editar.ForeColor = Color.Gray;
        }

        private void frmConcepto_Agregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dgv_Conceptos();
        }

        private void btnCon_Editar_Click(object sender, EventArgs e)
        {

            if (dgvConceptos.SelectedRows.Count > 0)
            {
                btnCon_Editar.IconColor = Color.Cyan;
                btnCon_Editar.ForeColor = Color.Cyan;
                string idConceptoSelect = dgvConceptos.SelectedRows[0].Cells[0].Value.ToString();
                string NombreConceptoSelect = dgvConceptos.SelectedRows[0].Cells[1].Value.ToString();
                DateTime Fecha_InicioSelect = Convert.ToDateTime(dgvConceptos.SelectedRows[0].Cells[2].Value);
                string Valor_anteriorSelect = dgvConceptos.SelectedRows[0].Cells[5].Value.ToString();               
                string ValorActualConceptoSelect = dgvConceptos.SelectedRows[0].Cells[3].Value.ToString();               
                string EstadoConceptosSelect = dgvConceptos.SelectedRows[0].Cells[8].Value.ToString();

                frmConcepto_Editar frmConcepto_Editar = new frmConcepto_Editar(idConceptoSelect, NombreConceptoSelect, ValorActualConceptoSelect, Fecha_InicioSelect, Valor_anteriorSelect, EstadoConceptosSelect);
                frmConcepto_Editar.FormClosed += frmConcepto_Editar_FormClosed;
                frmConcepto_Editar.Text = "GESTIÓN COBROS / CONCEPTOS / GESTIONAR / EDITAR";
                frmConcepto_Editar.ShowDialog();

                btnCon_Editar.IconColor = Color.Gray;
                btnCon_Editar.ForeColor = Color.Gray;
                btnCon_Eliminar.IconColor = Color.Gray;
                btnCon_Eliminar.ForeColor = Color.Gray;
            }
            else
            {
                btnCon_Editar.IconColor = Color.Gray;
                btnCon_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder modificar el valor de un concepto","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }

        private void frmConcepto_Editar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dgv_Conceptos();
        }

        private void btnCon_Eliminar_Click(object sender, EventArgs e)
        {
            
            if (dgvConceptos.SelectedRows.Count > 0)
            {
                btnCon_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnCon_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

                string idConceptoSelect = dgvConceptos.SelectedRows[0].Cells[0].Value.ToString();
                string nombreConceptoSelect = dgvConceptos.SelectedRows[0].Cells[1].Value.ToString();
                frmConcepto_Eliminar frmConcepto_Eliminar = new frmConcepto_Eliminar(idConceptoSelect, nombreConceptoSelect);
                frmConcepto_Eliminar.FormClosed += frmConcepto_Eliminar_FormClosed;
                frmConcepto_Eliminar.Text = "GESTIÓN COBROS / CONCEPTOS / GESTIONAR / ELIMINAR";
                frmConcepto_Eliminar.ShowDialog();

                btnCon_Eliminar.IconColor = Color.Gray;
                btnCon_Eliminar.ForeColor = Color.Gray;
                btnCon_Editar.IconColor = Color.Gray;
                btnCon_Editar.ForeColor = Color.Gray;
            }
            else
            {
                btnCon_Eliminar.IconColor = Color.Gray;
                btnCon_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Debe seleccionar un registro para poder deshabilitar a un concepto", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          }

        private void frmConcepto_Eliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dgv_Conceptos();
        }

        private void frmConcepto_Load(object sender, EventArgs e)
        {
            Dgv_Conceptos();

            logConcepto objLogConcepto = new logConcepto();

            DataTable dt = objLogConcepto.autocompletarBuscar();


            foreach (DataRow row in dt.Rows)
            {
                txtCon_Buscar.AutoCompleteCustomSource.Add(row[0].ToString());
            }


            btnCon_Eliminar.IconColor = Color.Gray;
            btnCon_Eliminar.ForeColor = Color.Gray;
            btnCon_Editar.IconColor = Color.Gray;
            btnCon_Editar.ForeColor = Color.Gray;

        }
        private void Dgv_Conceptos()
        {
            DataTable dt = new DataTable();
            logConcepto objlogConcepto = new logConcepto();
            dt = objlogConcepto.Visualizar();
            dgvConceptos.DataSource = dt;
            dgvConceptos.Columns["CON_ID"].Visible = false;

            this.dgvConceptos.Columns["CONCEPTO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.dgvConceptos.Columns["VALOR ACTUAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvConceptos.Columns["VIGENTE DESDE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvConceptos.Columns["VALOR ANTERIOR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dgvConceptos.Columns["DESDE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvConceptos.Columns["HASTA"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvConceptos.Columns["ESTADO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


        }

        private void Dgv_Conceptos_Filtro()
        {
            DataTable dt = new DataTable();
            logConcepto objlogConcepto = new logConcepto();
            dt = objlogConcepto.Visualizar();
            dgvConceptos.DataSource = dt;

            string concepto = txtCon_Buscar.Text;
            string nombre_concepto = objlogConcepto.nombre_concepto(concepto);

            dt.DefaultView.RowFilter = String.Format($"CONCEPTO LIKE '{nombre_concepto}%'");

        }

        private void txtCon_Buscar_TextChanged(object sender, EventArgs e)
        {
            
                if (txtCon_Buscar.Text.Length > 0)
                {
                Dgv_Conceptos_Filtro();
                }
                else
                {
                    txtCon_Buscar.Clear();
                    Dgv_Conceptos();
                    btnCon_Editar.IconColor = Color.Gray;
                    btnCon_Editar.ForeColor = Color.Gray;
                    btnCon_Eliminar.IconColor = Color.Gray;
                    btnCon_Eliminar.ForeColor = Color.Gray;
                }
                                        
        }

            

        private void txtCon_Buscar_Click(object sender, EventArgs e)
        {
            if (dgvConceptos.SelectedRows.Count > 0)
            {
                btnCon_Editar.IconColor = Color.Cyan;
                btnCon_Editar.ForeColor = Color.Cyan;
                btnCon_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnCon_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

            }
            else
            {
                dgvConceptos.ClearSelection();
                btnCon_Editar.IconColor = Color.Gray;
                btnCon_Editar.ForeColor = Color.Gray;
                btnCon_Eliminar.IconColor = Color.Gray;
                btnCon_Eliminar.ForeColor = Color.Gray;

            }


        }

        private void dgvConceptos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string EstadoConceptosSelect = dgvConceptos.SelectedRows[0].Cells[8].Value.ToString();


            if (dgvConceptos.SelectedRows.Count > 0 && EstadoConceptosSelect == "ACTIVO")
            {
                btnCon_Editar.Text = "ACTUALIZAR";
                btnCon_Editar.IconColor = Color.Cyan;
                btnCon_Editar.ForeColor = Color.Cyan;
                btnCon_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnCon_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);

            }
            else if (dgvConceptos.SelectedRows.Count > 0 && EstadoConceptosSelect == "INACTIVO")
            {
                btnCon_Editar.Text = "HABILITAR";
                btnCon_Editar.IconColor = Color.Cyan;
                btnCon_Editar.ForeColor = Color.Cyan;
                btnCon_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnCon_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
            }
            else
            {
                dgvConceptos.ClearSelection();
                btnCon_Editar.IconColor = Color.Gray;
                btnCon_Editar.ForeColor = Color.Gray;
                btnCon_Eliminar.IconColor = Color.Gray;
                btnCon_Eliminar.ForeColor = Color.Gray;

            }

        }

        private void btnCon_Editar_TextChanged(object sender, EventArgs e)
        {
            
            string EstadoConceptosSelect = dgvConceptos.SelectedRows[0].Cells[8].Value.ToString();
            if (dgvConceptos.SelectedRows.Count > 0 && EstadoConceptosSelect == "INACTIVO")
            {
                btnCon_Editar.Text = "HABILITAR";
            
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            ListaConceptos ListaConceptos = new ListaConceptos();
        }

        private void btn_ImprimirConcepto_Click(object sender, EventArgs e)
        {
            HistorialConceptos HistorialConceptos = new HistorialConceptos();
            HistorialConceptos.Show();

        }
    }
}
