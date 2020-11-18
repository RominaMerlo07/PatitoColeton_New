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
    public partial class frmAlumnosPopUpEditar : Form
    {
        string idPersonaSelect;
        entPersona persona = new entPersona();
        entDomicilio domicilio = new entDomicilio();
        entSala sala = new entSala();
        logPersonas metPers = new logPersonas();
        logDomicilio metDomic = new logDomicilio();
        logSalas metSala = new logSalas();



        public frmAlumnosPopUpEditar(string idPersonaSelect2)
        {
            InitializeComponent();
            Settooltip();
            idPersonaSelect = idPersonaSelect2;

            persona = metPers.BuscaPersonaxID(idPersonaSelect);
            domicilio = metDomic.buscarDomicilioXPersona(Convert.ToInt32(idPersonaSelect));
            sala = metSala.buscarSalaXPersona(Convert.ToInt32(idPersonaSelect));

            cargarCampos(persona, domicilio, sala);
            onOffCampos(false);

        }


        private void Settooltip()
        {
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(this.btnBloqueo, "Permite la edición de los campos del formulario");
            Tip.SetToolTip(this.btnInforme, "Imprimir ficha del alumno");

        }


        private void cargarCampos(entPersona persona, entDomicilio domicilio, entSala sala)
        {
            idPersonaSelect = Convert.ToString(persona.PER_ID); // se usara en el editar

            txtNombre.Text = persona.PER_NOMBRE;
            txtApellidos.Text = persona.PER_APELLIDO;
            txtDocumento.Text = Convert.ToString(persona.PER_DOCUMENTO);

            dtNacimiento.Value = persona.PER_FECHA_NAC;


            if (persona.PER_GENERO.StartsWith("MASCULINO"))
            {
                cbGenero.SelectedIndex = cbGenero.FindStringExact("MASCULINO");
            }
            else
            {
                cbGenero.SelectedIndex = cbGenero.FindStringExact("FEMENINO");
            }


            txtCalle.Text = domicilio.DOM_CALLE;
            txtNumero.Text = Convert.ToString(domicilio.DOM_NUMERO);
            txtCPostal.Text = Convert.ToString(domicilio.DOM_CP);
            txtPiso.Text = Convert.ToString(domicilio.DOM_PISO);
            txtDepto.Text = domicilio.DOM_DPTO;
            txtBarrio.Text = domicilio.DOM_BARRIO;
            txtTelefono.Text = persona.PER_TELEFONO;
            txtCelular.Text = persona.PER_TELEFONO_2;
            txtEmail.Text = persona.PER_EMAIL;

            if (sala.SALA_TURNO.Trim() == "TARDE")
            {
                cbTurno.SelectedIndex = cbTurno.FindStringExact("TARDE");
            }
            else
            {
                cbTurno.SelectedIndex = cbTurno.FindStringExact("MAÑANA");
            }

            string indexTurno = cbTurno.SelectedIndex.ToString();
            cbSala.DataSource = metSala.ListarSalas(indexTurno);
            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";

            cbSala.SelectedIndex = cbSala.FindStringExact(sala.SAL_NOMBRE);
            //txtLegajo.Text = persona.PER_LEGAJO;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onOffCampos(bool onOff)
        {

            txtNombre.Enabled = onOff;
            txtApellidos.Enabled = onOff;
            txtDocumento.Enabled = onOff;

            dtNacimiento.Enabled = onOff;
            cbGenero.Enabled = onOff;

            txtCalle.Enabled = onOff;
            txtNumero.Enabled = onOff;
            txtCPostal.Enabled = onOff;
            txtPiso.Enabled = onOff;
            txtDepto.Enabled = onOff;
            txtBarrio.Enabled = onOff;
            txtTelefono.Enabled = onOff;
            txtCelular.Enabled = onOff;
            txtEmail.Enabled = onOff;

            cbSala.Enabled = onOff;
            cbTurno.Enabled = onOff;
            //txtLegajo.Enabled = onOff;
        }

        private void btnBloqueo_Click(object sender, EventArgs e)
        {
            if (this.btnBloqueo.IconChar == FontAwesome.Sharp.IconChar.Lock)
            {
                this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Unlock;
                onOffCampos(true);
                btnInforme.Visible = false;
            }
            else
            {
                this.btnBloqueo.IconChar = FontAwesome.Sharp.IconChar.Lock;
                onOffCampos(false);
            }
        }

        private string validaCampos()
        {
            string resultadoValidacion = "";


            if (string.IsNullOrWhiteSpace(txtDocumento.Text.Trim()) == true)
            {
                txtDocumento.Style = MetroFramework.MetroColorStyle.Red;
                txtDocumento.Focus();
                resultadoValidacion = "el Documento";

            }
            else if (string.IsNullOrWhiteSpace(txtNombre.Text.Trim()) == true)
            {
                txtNombre.Style = MetroFramework.MetroColorStyle.Red;
                txtNombre.Focus();
                resultadoValidacion = "el Nombre";

            }
            else if (string.IsNullOrWhiteSpace(txtApellidos.Text.Trim()) == true)
            {
                txtApellidos.Style = MetroFramework.MetroColorStyle.Red;
                txtApellidos.Focus();
                resultadoValidacion = "el Apellido";

            }
            else if (string.IsNullOrWhiteSpace(txtCalle.Text.Trim()) == true)
            {
                txtCalle.Style = MetroFramework.MetroColorStyle.Red;
                txtCalle.Focus();
                resultadoValidacion = "la Calle del domicilio";

            }
            else if (string.IsNullOrWhiteSpace(txtCalle.Text.Trim()) == true)
            {
                txtCalle.Style = MetroFramework.MetroColorStyle.Red;
                txtCalle.Focus();
                resultadoValidacion = "la Calle del domicilio";

            }
            else if (string.IsNullOrWhiteSpace(txtNumero.Text.Trim()) == true)
            {
                txtNumero.Style = MetroFramework.MetroColorStyle.Red;
                txtNumero.Focus();
                resultadoValidacion = "el Numero del domicilio";

            }
            else if (string.IsNullOrWhiteSpace(txtCPostal.Text.Trim()) == true)
            {
                txtCPostal.Style = MetroFramework.MetroColorStyle.Red;
                txtCPostal.Focus();
                resultadoValidacion = "el Código Postal";

            }
            else if (string.IsNullOrWhiteSpace(txtBarrio.Text.Trim()) == true)
            {
                txtBarrio.Style = MetroFramework.MetroColorStyle.Red;
                txtBarrio.Focus();
                resultadoValidacion = "el Barrio";

            }
            else if (string.IsNullOrWhiteSpace(txtCelular.Text.Trim()) == true)
            {
                txtCelular.Style = MetroFramework.MetroColorStyle.Red;
                txtCelular.Focus();
                resultadoValidacion = "un Celular de contacto";

            }
            else if ((string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) == true) || (validarEmail() == false))
            {
                txtEmail.Style = MetroFramework.MetroColorStyle.Red;
                txtEmail.Focus();
                resultadoValidacion = "el E-mail";

            }
            else
            {
                resultadoValidacion = "OK";
            }

            return resultadoValidacion;

        }

        private bool validarEmail()
        {
            logPersonas ObjlogPersonas = new logPersonas();
            bool resultado = true;

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {

            }
            else
            {
                resultado = ObjlogPersonas.ValidarEmail(txtEmail.Text);
            }
            return resultado;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string id_salaE = cbSala.SelectedValue.ToString();
            string turno = cbTurno.SelectedItem.ToString();
            DateTime dt_nac = dtNacimiento.Value;
            string validacion = validaCampos();
            logPersonas logPersonas = new logPersonas();

            string resultado_val_salas = logPersonas.Validar_Salas(dt_nac, id_salaE, turno);

            if (validacion == "OK" && resultado_val_salas == "OK")
            {

                //-------- EDITA PERSONA

                string nombreE = txtNombre.Text.Trim();
                string apellidosE = txtApellidos.Text.Trim();
                string documentoE = txtDocumento.Text.Trim();
                DateTime nacimientoE = dtNacimiento.Value.Date;


                string calleE = txtCalle.Text.Trim();
                string numeroE = txtNumero.Text.Trim();
                string cpostalE = txtCPostal.Text.Trim();
                string pisoE = txtPiso.Text.Trim();
                string dptoE = txtDepto.Text.Trim();
                string barrioE = txtBarrio.Text.Trim();
                string telefonoE = txtTelefono.Text.Trim();
                string celularE = txtCelular.Text.Trim();
                string emailE = txtEmail.Text.Trim();
                
                
                entPersona personaEditar = new entPersona();

                string genero;

                if (cbGenero.SelectedItem == null)
                {
                    genero = "";
                }
                else
                {
                    genero = cbGenero.SelectedItem.ToString();
                }


                personaEditar.PER_ID = Convert.ToInt32(idPersonaSelect);
                personaEditar.PER_NOMBRE = nombreE;
                personaEditar.PER_APELLIDO = apellidosE;
                personaEditar.PER_DOCUMENTO = Convert.ToInt32(documentoE);
                personaEditar.PER_GENERO = genero;//cbGenero.SelectedValue.ToString(); //revisar
                personaEditar.PER_FECHA_NAC = nacimientoE;
                personaEditar.PER_TELEFONO = telefonoE;
                personaEditar.PER_TELEFONO_2 = celularE;
                personaEditar.PER_EMAIL = emailE;


                int vacante = Convert.ToInt32(txtLegajo.Text);
                if (vacante == 0)
                {
                    txtLegajo.Style = MetroFramework.MetroColorStyle.Red;
                    txtLegajo.Focus();

                    MessageBox.Show("No existen vacantes para el turno y sala elegida. Por favor elija otro turno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {                
                    
                    string resultadoE = metPers.editarPersona(personaEditar);

                    //-------- EDITA DOMICILIO
                    entDomicilio domicilioEditar = new entDomicilio();

                    domicilioEditar.DOM_PER_ID = Convert.ToInt32(idPersonaSelect);
                    domicilioEditar.DOM_CALLE = calleE;
                    domicilioEditar.DOM_NUMERO = Convert.ToInt32(numeroE);
                    if (string.IsNullOrWhiteSpace(pisoE.Trim()) == true)
                    {

                    }
                    else
                    {
                        domicilioEditar.DOM_PISO = Convert.ToInt32(pisoE);
                    }


                    domicilioEditar.DOM_DPTO = dptoE;
                    domicilioEditar.DOM_BARRIO = barrioE;
                    domicilioEditar.DOM_CP = Convert.ToInt32(cpostalE);

                    resultadoE = metDomic.editarDomicilio(domicilioEditar);

                    //-------- EDITA SALA

                    entGrupoSala grupoSalaEditar = new entGrupoSala();

                    grupoSalaEditar.GRS_PER_ID = Convert.ToInt32(idPersonaSelect);
                    grupoSalaEditar.GRS_SAL_ID = Convert.ToInt32(id_salaE);

                    resultadoE = metSala.editarGrupoSala(grupoSalaEditar);

                    if (resultadoE == "OK")
                    {
                        MessageBox.Show("Se han editado los datos con éxito.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else if (resultado_val_salas != "OK")
            {
                MessageBox.Show(resultado_val_salas);
                cbSala.SelectedIndex = -1;
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Text = "Por favor, seleccione una sala";
                lblSala.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("No olvide ingresar " + validacion + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbTurno_SelectedValueChanged_1(object sender, EventArgs e)
        {
            cargar_cbSala();
        }

        private void cargar_cbSala()
        {
            cbSala.SelectedValueChanged -= new EventHandler(cbSala_SelectedValueChanged);

            string indexTurno = cbTurno.SelectedIndex.ToString();
            logSalas objlogSalas = new logSalas();
            DataTable Tabla = new DataTable();
            Tabla = objlogSalas.ListarSalas(indexTurno);

            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";
            cbSala.DataSource = Tabla;
            cbSala.SelectedItem = null;
            cbSala.Enabled = true;

            cbSala.SelectedValueChanged += new EventHandler(cbSala_SelectedValueChanged);
        }

        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {
            string id_sala;

            if (cbSala.SelectedValue != null)
            {
                id_sala = cbSala.SelectedValue.ToString(); //.ToString();
                logSalas objlogSalas = new logSalas();
                DataTable gruposSalas = new DataTable();
                gruposSalas = objlogSalas.traerSalasCupo();
                DataRow[] rows = gruposSalas.Select("SAL_ID = " + id_sala);
                int CANTIDAD = Convert.ToInt16(rows[0]["CANTIDAD"].ToString());
                int MAXIMO = Convert.ToInt16(rows[0]["MAXIMO"].ToString());
                int VACANTES = MAXIMO - CANTIDAD;
                txtLegajo.Text = VACANTES.ToString();

                string color = cbSala.SelectedIndex.ToString();                                             

                if (color == "0")
                {
                    lblSala.Visible = true;
                    lblSala.Font = new Font(lblSala.Font.Name, 12);
                    lblSala.ForeColor = Color.Gainsboro;
                    lblSala.Text = " 1 a 2 años ";


                }
                else if (color == "1")
                {
                    lblSala.Visible = true;
                    lblSala.Font = new Font(lblSala.Font.Name, 12);
                    lblSala.ForeColor = Color.Gainsboro;
                    lblSala.Text = "3 a 4 años";
                }

                else if (color == "2")

                {
                    lblSala.Visible = true;
                    lblSala.Font = new Font(lblSala.Font.Name, 12);
                    lblSala.ForeColor = Color.Gainsboro;
                    lblSala.Text = " 4 a 5 años ";

                }
                else
                {
                    lblSala.Visible = false;
                }


            }
            else
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Text = "Por favor, seleccione una sala";
                lblSala.ForeColor = Color.Red;
            }


        }


        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void soloLetras(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);

        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
            string dni = txtDocumento.Text;
            logPersonas ObjlogPersonas = new logPersonas();
            string resultado = ObjlogPersonas.ValidarDni(dni);
            if (resultado == "SI")
            {
                txtDocumento.Style = MetroFramework.MetroColorStyle.Red;
                txtDocumento.Focus();
                MessageBox.Show("El alumno ya se encuentra registrado. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtCPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDocumento.Text.Trim()) == true)
            {
                txtDocumento.Style = MetroFramework.MetroColorStyle.Red;
                txtDocumento.Focus();
                lblDni.Visible = true;
                lblDni.Text = "Por favor ingrese el Documento";

            }
            else
            {
                lblDni.Visible = false;
                string dni = txtDocumento.Text;
                logPersonas ObjlogPersonas = new logPersonas();
                string resultado = ObjlogPersonas.ValidarDni(dni);
                if (resultado == "SI")
                {
                    txtDocumento.Style = MetroFramework.MetroColorStyle.Red;
                    txtDocumento.Focus();
                    MessageBox.Show("El alumno ya se encuentra registrado. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            logPersonas objlogPersonas = new logPersonas();
            objlogPersonas.ValidarEmail(email);


            bool resultado = true;//= ObjlogPersonas.ValidarEmail(txtEmail.Text);

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {

            }
            else
            {
                resultado = objlogPersonas.ValidarEmail(email);
            }

            if (resultado == false)
            {
                MessageBox.Show("Ingrese un Email Válido");
                txtEmail.Clear();
                txtEmail.Focus();

            }
        }                  
            

        private void txtCalle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCalle.Text.Trim()) == true)
            {
                txtCalle.Style = MetroFramework.MetroColorStyle.Red;
                txtCalle.Focus();
                lblCalle.Visible = true;
                lblCalle.Text = "Por favor ingrese calle";
            }
            else
            {
                lblCalle.Visible = false;
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumero.Text.Trim()) == true)
            {
                txtNumero.Style = MetroFramework.MetroColorStyle.Red;
                txtNumero.Focus();
                lblNumero.Visible = true;
                lblNumero.Text = "Por favor ingrese numero";
            }
            else
            {
                lblNumero.Visible = false;
            }
        }

        private void txtCPostal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCPostal.Text.Trim()) == true)
            {
                txtCPostal.Style = MetroFramework.MetroColorStyle.Red;
                txtCPostal.Focus();
                lblCp.Visible = true;
                lblCp.Text = "Por favor ingrese codigo postal";
            }
            else
            {
                lblCp.Visible = false;
            }
        }

        private void txtBarrio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarrio.Text.Trim()) == true)
            {
                txtBarrio.Style = MetroFramework.MetroColorStyle.Red;
                txtBarrio.Focus();
                lblBarrio.Visible = true;
                lblBarrio.Text = "Por favor ingrese barrio";
            }
            else
            {
                lblBarrio.Visible = false;
            }
        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCelular.Text.Trim()) == true)
            {
                txtCelular.Style = MetroFramework.MetroColorStyle.Red;
                txtCelular.Focus();
                lblCelular.Visible = true;
                lblCelular.Text = "Por favor ingrese celular";
            }
            else
            {
                lblCelular.Visible = false;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text.Trim()) == true)
            {
                txtNombre.Style = MetroFramework.MetroColorStyle.Red;
                txtNombre.Focus();
                lblNombre.Visible = true;
                lblNombre.Text = "Por favor ingrese nombre";
            }
            else
            {
                lblNombre.Visible = false;
            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApellidos.Text.Trim()) == true)
            {
                txtApellidos.Style = MetroFramework.MetroColorStyle.Red;
                txtApellidos.Focus();
                lblApellido.Visible = true;
                lblApellido.Text = "Por favor ingrese apellido";
            }
            else
            {
                lblApellido.Visible = false;
            }
        }


        private void cbSala_Leave(object sender, EventArgs e)
        {
            string color = cbSala.SelectedIndex.ToString();

            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == true)
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Visible = true;
                lblSala.Text = "Por favor, seleccione una sala";
            }

            if (color == "-1")
            {
                cbSala.Focus();
                lblSala.Visible = true;
                lblSala.Text = "Por favor, seleccione una sala";

            }

            else if (color == "0")
            {
                lblSala.Visible = true;
                lblSala.Font = new Font(lblSala.Font.Name, 12);
                lblSala.ForeColor = Color.Gainsboro;
                lblSala.Text = " 1 a 2 años ";


            }
            else if (color == "1")
            {
                lblSala.Visible = true;
                lblSala.Font = new Font(lblSala.Font.Name, 12);
                lblSala.ForeColor = Color.Gainsboro;
                lblSala.Text = "3 a 4 años";
            }

            else if (color == "2")

            {
                lblSala.Visible = true;
                lblSala.Font = new Font(lblSala.Font.Name, 12);
                lblSala.ForeColor = Color.Gainsboro;
                lblSala.Text = " 4 a 5 años ";

            }
            else
            {
                lblSala.Visible = false;
            }
        }

        private void dtNacimiento_Leave(object sender, EventArgs e)
        {
            string salas;
            string turno;
            DateTime fecha_nacimineto = dtNacimiento.Value;
            string color;


            if (cbSala.SelectedValue == null)
            {
                lblSala.Visible = true;
                lblSala.Text = "Por favor, seleccione una sala";

            }
            else
            {

                salas = cbSala.SelectedValue.ToString();
                turno = cbTurno.SelectedItem.ToString();

                color = cbSala.SelectedIndex.ToString();

                if (color == "0")
                {
                    lblSala.Visible = true;
                    lblSala.Font = new Font(lblSala.Font.Name, 12);
                    lblSala.ForeColor = Color.Gainsboro;
                    lblSala.Text = " 1 a 2 años ";

                }
                else if (color == "1")
                {
                    lblSala.Visible = true;
                    lblSala.Font = new Font(lblSala.Font.Name, 12);
                    lblSala.ForeColor = Color.Gainsboro;
                    lblSala.Text = " 3 a 4 años ";
                }

                else if (color == "2")

                {
                    lblSala.Visible = true;
                    lblSala.Text = " 4 a 5 años ";
                    lblSala.Font = new Font(lblSala.Font.Name, 12);
                    lblSala.ForeColor = Color.Gainsboro;
                    lblSala.ForeColor = Color.Gainsboro;

                }
                else
                {
                    lblSala.Visible = false;
                }                

                logPersonas objlogpersonas = new logPersonas();
                string resultado = objlogpersonas.Validar_Salas(fecha_nacimineto, salas, turno);


                if (resultado != "OK")

                {
                    MessageBox.Show(resultado);
                    cbSala.SelectedIndex = -1;
                    cbSala.Style = MetroFramework.MetroColorStyle.Red;
                    cbSala.Focus();
                    lblSala.Text = "Por favor, seleccione una sala";
                    lblSala.ForeColor = Color.Red;

                }
            }
    }

        private void btn_Informe_Click(object sender, EventArgs e)
        {
            InformeFichaAlumno InformeFichaAlumno = new InformeFichaAlumno(idPersonaSelect);            
        }
    }
}
