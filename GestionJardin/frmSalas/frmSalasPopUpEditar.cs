﻿using System;
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
    public partial class frmSalasPopUpEditar : Form
    {

        string idSalaSelect;
        entSala sala = new entSala();
        logSala2 metSala = new logSala2();
        string salaActual;

        public frmSalasPopUpEditar()
        {
            InitializeComponent();
        }

        /*Se obtiene el id de la sala elegida en la grilla*/

        public frmSalasPopUpEditar(string idSalaSelect2)
        {
            InitializeComponent();
            idSalaSelect = idSalaSelect2;
            sala = metSala.buscarSalaXid(Convert.ToInt32(idSalaSelect));            
            cargarCampos(sala);
            onOffCampos(false);
            lblSala.Visible = false;
            lblTurno.Visible = false;
            lblEMax.Visible = false;
            lblEMin.Visible = false;
            lblCantA.Visible = false;
        }

        /*Se cargan los datos en el form editar sala segun sala elegida en la grilla*/

        private void cargarCampos(entSala sala)
        {
            idSalaSelect = Convert.ToString(sala.SAL_ID); // se usara en el editar

            txtSala.Text = sala.SAL_NOMBRE;
            salaActual = sala.SAL_NOMBRE;
            txtCantMax.Text = Convert.ToString(sala.SALA_CANT_ALUM);

            if (sala.SALA_TURNO.Trim() == "TARDE")
            {
                cboTurno.SelectedIndex = cboTurno.FindStringExact("TARDE");
            }
            else
            {
                cboTurno.SelectedIndex = cboTurno.FindStringExact("MAÑANA");
            }

            if (sala.SAL_EDAD_MIN == 1)
            {
                cboEdadMin.SelectedIndex = cboEdadMin.FindStringExact("1");
            }
            else if (sala.SAL_EDAD_MIN == 2)
            {
                cboEdadMin.SelectedIndex = cboEdadMin.FindStringExact("2");
            }
            else if (sala.SAL_EDAD_MIN == 3)
            {
                cboEdadMin.SelectedIndex = cboEdadMin.FindStringExact("3");
            }
            else if (sala.SAL_EDAD_MIN == 4)
            {
                cboEdadMin.SelectedIndex = cboEdadMin.FindStringExact("4");
            }
            else
            {
                cboEdadMin.SelectedIndex = cboEdadMin.FindStringExact("5");
            }
            
            if (sala.EDAD_SALA_MAX == 1)
            {
                cboEdadMax.SelectedIndex = cboEdadMax.FindStringExact("1");
            }
            else if (sala.EDAD_SALA_MAX == 2)
            {
                cboEdadMax.SelectedIndex = cboEdadMax.FindStringExact("2");
            }
            else if (sala.EDAD_SALA_MAX == 3)
            {
                cboEdadMax.SelectedIndex = cboEdadMax.FindStringExact("3");
            }
            else if (sala.EDAD_SALA_MAX == 4)
            {
                cboEdadMax.SelectedIndex = cboEdadMax.FindStringExact("4");
            }
            else
            {
                cboEdadMax.SelectedIndex = cboEdadMax.FindStringExact("5");
            }
        }


        /* Habilita la modificacion de los datos en el form */

        private void btnBloqueo_Click_1(object sender, EventArgs e)
        {
            if (this.btnBloqueo.IconChar == FontAwesome.Sharp.IconChar.Lock)
            {
                this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Unlock;
                onOffCampos(true);
            }
            else
            {
                this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Lock;
                onOffCampos(false);
            }
        }

        /*Metodos Validacion */

        private void soloLetras(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void onOffCampos(bool onOff)
        {

            txtSala.Enabled = onOff;
            cboTurno.Enabled = onOff;
            cboEdadMin.Enabled = onOff;
            cboEdadMax.Enabled = onOff;
            txtCantMax.Enabled = onOff;            
        }              

        private void txtSala_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtCantMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        /*******************/
        /** BOTON GUARDAR **/
        /*******************/


        private void btnguardar_Click(object sender, EventArgs e)
        {
            string validacion = validaCampos();

            if (validacion == "OK")
            {
                string turno;
                sala.SALA_ACTIVO = "S";
                sala.SAL_NOMBRE = txtSala.Text;
                turno = cboTurno.SelectedItem.ToString();

                if (turno == "MAÑANA")
                {
                    sala.SALA_TURNO = "MANANA";
                }
                else
                {
                    sala.SALA_TURNO = "TARDE";
                }

                sala.SAL_EDAD_MIN = Convert.ToInt32(cboEdadMin.SelectedItem);
                sala.EDAD_SALA_MAX = Convert.ToInt32(cboEdadMax.SelectedItem);
                sala.SALA_CANT_ALUM = Convert.ToInt32(txtCantMax.Text);

                string result = metSala.EditarSala(sala);
                if (result == "OK")
                {
                    MessageBox.Show("Se modificaron correctamente los datos de la sala: " + sala.SAL_NOMBRE, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("NO se pudo modificar la información de la sala: " + sala.SAL_NOMBRE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor verifique los datos ingresados: ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /********************/
        /** BOTON CANCELAR **/
        /********************/

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtSala_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSala.Text.Trim()) == true)
            {
                txtSala.Style = MetroFramework.MetroColorStyle.Red;
                txtSala.Focus();
                lblSala.Visible = true;
                lblSala.Text = "Por favor ingrese el nombre de la sala. Por ejemplo: 'AZUL'";
             
            }
            else
            {
                lblSala.Visible = false;
            }
        }

        private void cboTurno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTurno.Text.Trim()) == true)
            {
                cboTurno.Style = MetroFramework.MetroColorStyle.Red;
                cboTurno.Focus();
                lblTurno.Visible = true;
                lblTurno.Text = "Por favor seleccione un turno";
                
            }
            else
            {
                lblTurno.Visible = false;
                string turno;

                turno = cboTurno.SelectedItem.ToString();

                if (turno == "MAÑANA")
                {
                    turno = "MANANA";

                }
                else
                {
                    turno = "TARDE";

                }


                if (salaActual != txtSala.Text)
                {
                    string result = metSala.ValidarSala(txtSala.Text, turno);

                    if (result == "SI")
                    {
                        txtSala.Clear();
                        txtSala.Style = MetroFramework.MetroColorStyle.Red;
                        txtSala.Focus();
                        MessageBox.Show("El nombre de la sala ingresado ya se encuentra registrado en el turno " + turno, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
        }

        private void cboEdadMin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboEdadMin.Text.Trim()) == true)
            {
                cboEdadMin.Style = MetroFramework.MetroColorStyle.Red;
                cboEdadMin.Focus();
                lblEMin.Visible = true;
                lblEMin.Text = "Por favor seleccione un valor para edad mínima";
               
            }
            else
            {
                lblEMin.Visible = false;
            }
        }

        private void cboEdadMax_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboEdadMax.Text.Trim()) == true)
            {
                cboEdadMax.Style = MetroFramework.MetroColorStyle.Red;
                cboEdadMax.Focus();
                lblEMax.Visible = true;
                lblEMax.Text = " Por favor seleccione un valor para edad máxima";
              
            }
            else if (Convert.ToInt32(cboEdadMax.SelectedItem) < Convert.ToInt32(cboEdadMin.SelectedItem))
            {
                lblEMax.Visible = false;
                cboEdadMin.SelectedIndex = -1;
                cboEdadMin.Style = MetroFramework.MetroColorStyle.Red;
                cboEdadMin.Focus();
                MessageBox.Show(" La edad máxima no puede ser menor a la edad minima", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEdadMax.SelectedIndex = -1;
            }
        }

        private void txtCantMax_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantMax.Text.Trim()) == true)
            {
                txtCantMax.Style = MetroFramework.MetroColorStyle.Red;
                txtCantMax.Focus();
                lblCantA.Visible = true;
                lblCantA.Text = "Por favor ingrese un valor para Cantidad máxima de alumnos.\nEl mismo debe ser entre 1 y 30 alumnos";
               
            }
            else if (Convert.ToInt32(txtCantMax.Text) == 0 || Convert.ToInt32(txtCantMax.Text) > 30)
            {
                lblCantA.Visible = false;
                txtCantMax.Style = MetroFramework.MetroColorStyle.Red;
                txtCantMax.Focus();
                MessageBox.Show("La 'Cantidad de alumnos máxima' debe tener un valor mayor a 0 y no superar los 30 alumnos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string validaCampos()
        {
            string resultado = "OK";

            if (string.IsNullOrWhiteSpace(cboEdadMin.Text.Trim()) == true)
            {
                cboEdadMin.Style = MetroFramework.MetroColorStyle.Red;
                cboEdadMin.Focus();
                lblEMin.Visible = true;
                resultado = "Por favor seleccione un valor para edad mínima";
                lblEMin.Text = resultado;
            }
            else if (string.IsNullOrWhiteSpace(cboTurno.Text.Trim()) == true)
            {
                cboTurno.Style = MetroFramework.MetroColorStyle.Red;
                cboTurno.Focus();
                lblTurno.Visible = true;
                resultado = "Por favor seleccione un turno";
                lblTurno.Text = resultado;
            }
            else if (string.IsNullOrWhiteSpace(cboEdadMax.Text.Trim()) == true)
            {
                cboEdadMax.Style = MetroFramework.MetroColorStyle.Red;
                cboEdadMax.Focus();
                lblEMax.Visible = true;
                resultado = "Por favor seleccione un valor para edad mínima";
                lblEMax.Text = resultado;
            }           
            else if (string.IsNullOrWhiteSpace(txtCantMax.Text.Trim()) == true)
            {
                txtCantMax.Style = MetroFramework.MetroColorStyle.Red;
                txtCantMax.Focus();
                lblCantA.Visible = true;
                resultado = "Por favor ingrese un valor para Cantidad máxima de alumnos.\nEl mismo debe ser entre 1 y 30 alumnos";
                lblCantA.Text = resultado;
            }
            
            else if (string.IsNullOrWhiteSpace(cboEdadMin.Text.Trim()) == false && string.IsNullOrWhiteSpace(cboEdadMax.Text.Trim()) == false)
            {
                if (Convert.ToInt32(cboEdadMin.SelectedItem) > Convert.ToInt32(cboEdadMax.SelectedItem))
                {
                    lblEMin.Visible = false;
                    cboEdadMin.SelectedIndex = -1;
                    cboEdadMax.SelectedIndex = -1;
                    cboEdadMin.Style = MetroFramework.MetroColorStyle.Red;
                    cboEdadMin.Focus();
                    resultado = " La edad máxima no puede ser menor a la edad minima";
                    MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrWhiteSpace(txtCantMax.Text.Trim()) == false)
            {
                if (Convert.ToInt32(txtCantMax.Text) == 0 || Convert.ToInt32(txtCantMax.Text) > 30)
                {
                    lblCantA.Visible = false;
                    txtCantMax.Style = MetroFramework.MetroColorStyle.Red;
                    txtCantMax.Focus();
                    resultado = "La 'Cantidad de alumnos máxima' debe tener un valor mayor a 0 y no superar los 30 alumnos";
                    MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrWhiteSpace(cboEdadMin.Text.Trim()) == false && string.IsNullOrWhiteSpace(cboTurno.Text.Trim()) == false)
            {
                lblTurno.Visible = false;

                string turno;

                turno = cboTurno.SelectedItem.ToString();

                if (turno == "MAÑANA")
                {
                    turno = "MANANA";

                }
                else
                {
                    turno = "TARDE";

                }

                if (salaActual != txtSala.Text)
                {
                    string result = metSala.ValidarSala(txtSala.Text, turno);

                    if (result == "SI")
                    {
                        txtSala.Clear();
                        txtSala.Style = MetroFramework.MetroColorStyle.Red;
                        txtSala.Focus();
                        resultado = "El nombre de la sala ingresado ya se encuentra registrado en el turno " + turno;
                        MessageBox.Show(resultado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                resultado = "OK";
            }

            return resultado;
        }

        private void cboEdadMin_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cboEdadMin.SelectedItem) > Convert.ToInt32(cboEdadMax.SelectedItem))
            {

                lblEMin.Visible = true;
                cboEdadMin.Style = MetroFramework.MetroColorStyle.Red;
                cboEdadMin.Focus();
                lblEMin.Text = " La edad minima no puede ser mayor a la edad máxima";
                //MessageBox.Show(lblEMax.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblEMin.Visible = false;
            }

        }


    }
    
}
