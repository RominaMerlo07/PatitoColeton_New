﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionJardin
{
    public partial class frmDocentes : Form
    {
        metPersonas objMetPersonas = new metPersonas();
        entPersona objPersona = new entPersona();
        metDomicilio objmetDomicilio = new metDomicilio();
        metSalas objMetSalas = new metSalas();

        AutoCompleteStringCollection traerdocente = new AutoCompleteStringCollection();
        metPersonas metPersonas = new metPersonas();

        int idPersonaBuscar;

        public frmDocentes()
        {
            InitializeComponent();           
            CargarGrilla();            
        }
        public void CargarGrilla()
        {
            dgv_Docentes.DataSource = objMetPersonas.Mostrardocente();
        }


        private void btnGD_Agregar_Click(object sender, EventArgs e)
        {
            frmDocentesPopUpAgregar frmDocentesPopUpAgregar = new frmDocentesPopUpAgregar();
            frmDocentesPopUpAgregar.Text = "GESTION DOCENTES / INGRESAR NUEVO DOCENTE";
            frmDocentesPopUpAgregar.ShowDialog();
        }

        private void btnGD_Editar_Click(object sender, EventArgs e)
        {

            entPersona personaBuscar = new entPersona();
            frmDocentesPopUpEditar frmDocentesPopUpEditar = new frmDocentesPopUpEditar();
            entDomicilio domicilioBuscar = new entDomicilio();
            entSala salaBuscar = new entSala();            
            
            if (dgv_Docentes.SelectedRows.Count > 0)
            {
                btnGD_Editar.IconColor = Color.Cyan;
                btnGD_Editar.ForeColor = Color.Cyan;


                string documento = dgv_Docentes.CurrentRow.Cells[1].Value.ToString();

                personaBuscar = objMetPersonas.BuscaDocente(documento);

                if (personaBuscar.PER_NOMBRE != null)
                {
                    frmDocentesPopUpEditar.txt_id_Docente.Text = Convert.ToString(personaBuscar.PER_ID); // se usara en el editar
                     

                    frmDocentesPopUpEditar.txtNombre.Text = personaBuscar.PER_NOMBRE;
                    frmDocentesPopUpEditar.txtApellidos.Text = personaBuscar.PER_APELLIDO;
                    frmDocentesPopUpEditar.txtDocumento.Text = documento;
                    frmDocentesPopUpEditar.dtNacimiento.Value = personaBuscar.PER_FECHA_NAC;

                    if (personaBuscar.PER_GENERO.StartsWith("M"))
                    {
                        frmDocentesPopUpEditar.cbGenero.SelectedIndex = frmDocentesPopUpEditar.cbGenero.FindStringExact("MASCULINO");
                    }
                    else
                    {
                        frmDocentesPopUpEditar.cbGenero.SelectedIndex = frmDocentesPopUpEditar.cbGenero.FindStringExact("FEMENINO");
                    }

                    domicilioBuscar = objmetDomicilio.buscarDomicilioXPersona(personaBuscar.PER_ID);

                    frmDocentesPopUpEditar.txtCalle.Text = domicilioBuscar.DOM_CALLE;
                    frmDocentesPopUpEditar.txtNumero.Text = Convert.ToString(domicilioBuscar.DOM_NUMERO);
                    frmDocentesPopUpEditar.txtCPostal.Text = Convert.ToString(domicilioBuscar.DOM_CP);
                    frmDocentesPopUpEditar.txtPiso.Text = Convert.ToString(domicilioBuscar.DOM_PISO);
                    frmDocentesPopUpEditar.txtDepto.Text = domicilioBuscar.DOM_DPTO;
                    frmDocentesPopUpEditar.txtBarrio.Text = domicilioBuscar.DOM_BARRIO;
                    frmDocentesPopUpEditar.txtTelefono.Text = personaBuscar.PER_TELEFONO;
                    frmDocentesPopUpEditar.txtCelular.Text = personaBuscar.PER_TELEFONO_2;
                    frmDocentesPopUpEditar.txtEmail.Text = personaBuscar.PER_EMAIL;


                    salaBuscar = objMetSalas.buscarSalaXPersona(personaBuscar.PER_ID);


                    if (salaBuscar.SALA_TURNO.Trim() == "TARDE")
                    {
                        frmDocentesPopUpEditar.cbTurno.SelectedIndex = frmDocentesPopUpEditar.cbTurno.FindStringExact("TARDE");
                    }
                    else
                    {
                        frmDocentesPopUpEditar.cbTurno.SelectedIndex = frmDocentesPopUpEditar.cbTurno.FindStringExact("MAÑANA");
                    }

                    string indexTurno = frmDocentesPopUpEditar.cbTurno.SelectedIndex.ToString();
                    frmDocentesPopUpEditar.cbSala.DataSource = objMetSalas.ListarSalas(indexTurno);
                    frmDocentesPopUpEditar.cbSala.DisplayMember = "SAL_NOMBRE";
                    frmDocentesPopUpEditar.cbSala.ValueMember = "SAL_ID";

                    frmDocentesPopUpEditar.cbSala.SelectedIndex = frmDocentesPopUpEditar.cbSala.FindStringExact(salaBuscar.SAL_NOMBRE);
                }

                frmDocentesPopUpEditar.Text = "GESTION DOCENTES / MODIFICAR/VISUALIZAR DATOS DEL DOCENTE";
                AddOwnedForm(frmDocentesPopUpEditar);
                frmDocentesPopUpEditar.ShowDialog();

            }
            
            else
            {
                btnGD_Editar.IconColor = Color.Gray;
                btnGD_Editar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder visualizar/modificar los datos del Docente");
            }
                                  

        }

        private void btnGD_Eliminar_Click(object sender, EventArgs e)
        {

            if (dgv_Docentes.SelectedRows.Count > 0)
            {

                btnGD_Eliminar.IconColor = Color.FromArgb(255, 128, 0);
                btnGD_Eliminar.ForeColor = Color.FromArgb(255, 128, 0);
                frmDocentesPopUpEliminar frmDocentesPopUpEliminar = new frmDocentesPopUpEliminar();
                frmDocentesPopUpEliminar.Text = "GESTION DOCENTES / ELIMINAR DOCENTE";
                frmDocentesPopUpEliminar.ShowDialog();
            }
            else
            {
                btnGD_Eliminar.IconColor = Color.Gray;
                btnGD_Eliminar.ForeColor = Color.Gray;
                MessageBox.Show("Por favor seleccione un registro/fila para poder dar de baja al Docente");
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
            }
        }

        private void txtGD_Buscar_Enter(object sender, EventArgs e)
        {
            string docente = txtGD_Buscar.Text;
            dgv_Docentes.DataSource = objMetPersonas.llenarGrilla(docente);
        }

        private void txtGD_Buscar_ButtonClick(object sender, EventArgs e)
        {
            string docente = txtGD_Buscar.Text;
            dgv_Docentes.DataSource = objMetPersonas.llenarGrilla(docente);

        }

       
    }
}
