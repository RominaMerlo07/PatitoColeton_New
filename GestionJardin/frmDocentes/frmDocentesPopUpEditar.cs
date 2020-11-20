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
    public partial class frmDocentesPopUpEditar : Form
    {
        logPersonas objlogPersonas = new logPersonas();
        entPersona objPersona = new entPersona();
        logDomicilio objlogDomicilio = new logDomicilio();
        logSalas objlogSalas = new logSalas();
        entGrupoSala objGrupoSala = new entGrupoSala();

        string resultadoValidacion;
        int idPersonaBuscar;
        string idPersonaSelect;

        entDomicilio domicilio = new entDomicilio();
        entSala sala = new entSala();


        public frmDocentesPopUpEditar(string idPersonaSelect2)
        {
            InitializeComponent();
            Settooltip();
            idPersonaSelect = idPersonaSelect2;

            objPersona = objlogPersonas.BuscaPersonaxID(idPersonaSelect);
            domicilio = objlogDomicilio.buscarDomicilioXPersona(Convert.ToInt32(idPersonaSelect));
            sala = objlogSalas.buscarSalaXPersona(Convert.ToInt32(idPersonaSelect));

            cargarCampos(objPersona, domicilio, sala);
            onOffCampos(false);

        }

        private void Settooltip()
        {
            ToolTip Tip = new ToolTip();
            Tip.SetToolTip(this.btnBloqueo, "Permite la edición de los campos del formulario");
            Tip.SetToolTip(this.btnInforme, "Imprimir ficha del docente");

        }

        private void cargarCampos(entPersona objPersona, entDomicilio domicilio, entSala sala)
        {
            idPersonaSelect = Convert.ToString(objPersona.PER_ID); // se usara en el editar
                     
            txtNombre.Text = objPersona.PER_NOMBRE;
            txtApellidos.Text = objPersona.PER_APELLIDO;
            txtDocumento.Text = Convert.ToString(objPersona.PER_DOCUMENTO);

            dtNacimiento.Value = objPersona.PER_FECHA_NAC;


            if (objPersona.PER_GENERO.StartsWith("MASCULINO"))
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
            txtTelefono.Text = objPersona.PER_TELEFONO;
            txtCelular.Text = objPersona.PER_TELEFONO_2;
            txtEmail.Text = objPersona.PER_EMAIL;

            if (sala.SALA_TURNO.Trim() == "TARDE")
            {
                cbTurno.SelectedIndex = cbTurno.FindStringExact("TARDE");
            }
            else
            {
                cbTurno.SelectedIndex = cbTurno.FindStringExact("MAÑANA");
            }

            ////if (Cbocargo.SelectedItem.ToString() == "TITULAR")
            ////{
            ////    Cbocargo.SelectedIndex = cbTurno.FindStringExact("TITULAR");
            ////}
            ////else
            ////{
            ////    Cbocargo.SelectedIndex = cbTurno.FindStringExact("SUPLENTE");
            ////}

            string indexTurno = cbTurno.SelectedIndex.ToString();
            cbSala.DataSource = objlogSalas.ListarSalas(indexTurno);
            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";

            cbSala.SelectedIndex = cbSala.FindStringExact(sala.SAL_NOMBRE);
            //txtLegajo.Text = persona.PER_LEGAJO;
        }

        private void frmDocentesPopUpEditar_Load(object sender, EventArgs e)
        {
            onOffCampos(false);
        }

       

        /*********************************/
        /*********GUARDAR EDITAR**********/
        /*********************************/

        private void btnguardar_Click(object sender, EventArgs e)
        {

            frmDocentes Docentes = Owner as frmDocentes;

            objlogPersonas.EdadDocente(dtNacimiento.Value);

            string validacionE = validaCampos();
            if (validacionE == "OK")

            {
                idPersonaBuscar = Convert.ToInt32(txt_id_Docente.Text);

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

                personaEditar.PER_ID = Convert.ToInt32(idPersonaBuscar);
                personaEditar.PER_NOMBRE = nombreE;
                personaEditar.PER_APELLIDO = apellidosE;
                personaEditar.PER_DOCUMENTO = Convert.ToInt32(documentoE);
                personaEditar.PER_GENERO = genero;
                personaEditar.PER_FECHA_NAC = nacimientoE;
                personaEditar.PER_TELEFONO = telefonoE;
                personaEditar.PER_TELEFONO_2 = celularE;
                personaEditar.PER_EMAIL = emailE;

                string resultadoE = objlogPersonas.editarPersona(personaEditar);

                entDomicilio domicilioEditar = new entDomicilio();

                domicilioEditar.DOM_PER_ID = idPersonaBuscar;
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

                resultadoE = objlogDomicilio.editarDomicilio(domicilioEditar);

                if (resultadoE == "OK")
                {
                    string CARGO;

                    if (Cbocargo.SelectedItem == null)
                    {
                        CARGO = "";
                    }
                    else
                    {
                        CARGO = Cbocargo.SelectedItem.ToString();
                        if (CARGO == "TITULAR")
                        {
                            CARGO = "TITULAR";
                        }
                        else
                        {
                            CARGO = "SUPLENTE";
                        }
                    }

                    string turno;

                    if (cbTurno.SelectedItem == null)
                    {
                        turno = "";
                    }
                    else
                    {
                        turno = cbTurno.SelectedItem.ToString();

                        if (turno == "MAÑANA")
                        {
                            turno = "MANANA";
                        }
                        else
                        {
                            turno = "TARDE";
                        }

                    }
                    string id_sala;

                    if (cbSala.SelectedItem == null)
                    {
                        id_sala = "";
                    }
                    else
                    {
                        id_sala = cbSala.SelectedValue.ToString();
                    }

                    if (turno == cbTurno.Text && id_sala == cbSala.Text)
                    {
                        MessageBox.Show("Se ha ingresado el registro con éxito.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    //else
                    //{
                    else if (objlogSalas.ValidarDocSala(id_sala, turno) <= 1)

                    {
                        entGrupoSala grupoSalaEditar = new entGrupoSala();
                        grupoSalaEditar.GRS_PER_ID = Convert.ToInt32(idPersonaBuscar);
                        grupoSalaEditar.GRS_SAL_ID = Convert.ToInt32(id_sala);
                        grupoSalaEditar.GRS_CARGO = CARGO.ToString();
                        resultadoE = objlogSalas.editarGrupoSala(grupoSalaEditar);

                        if (resultadoE == "OK")
                        {
                            MessageBox.Show("Se actualizado ok el registro.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("El cupo de docente en la sala y turno seleccionados ya esta completo", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbTurno.SelectedIndex = -1;
                        cbSala.SelectedIndex = -1;

                    }
                    //}
                }

                else
                {
                    MessageBox.Show("NO OLVIDE INGRESAR " + validacionE + ".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /* Validacion General */
        
        private string validaCampos()
        {
            logPersonas ObjMetOersonas = new logPersonas();
            objlogPersonas.EdadDocente(dtNacimiento.Value);

            resultadoValidacion = "";

            if (string.IsNullOrWhiteSpace(txtNombre.Text.Trim()) == true)
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
            else if (string.IsNullOrWhiteSpace(txtDocumento.Text.Trim()) == true)
            {
                txtDocumento.Style = MetroFramework.MetroColorStyle.Red;
                txtDocumento.Focus();
                resultadoValidacion = "el Documento";
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
                resultadoValidacion = "un celular de contacto";
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) == true)
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


        /* Validaciones Particulares */
              
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solonumeros(sender, e);
            string dni = txtDocumento.Text;
            logPersonas ObjlogPersonas = new logPersonas();
            string resultado = ObjlogPersonas.ValidarDni(dni);
            if (resultado == "SI")
            {
                txtDocumento.Style = MetroFramework.MetroColorStyle.Red;
                txtDocumento.Focus();
                MessageBox.Show("El docente ya se encuentra registrado. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solonumeros(sender, e);
        }
        private void txtCPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solonumeros(sender, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solonumeros(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Solonumeros(sender, e);
        }
        
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void dtNacimiento_Leave(object sender, EventArgs e)
        {
            logPersonas ObjMetOersonas = new logPersonas();
            objlogPersonas.EdadDocente(dtNacimiento.Value);
            int Edad = objlogPersonas.EdadDocente(dtNacimiento.Value);
            if (Edad < 18)
            {
                MessageBox.Show("La Persona que esta ingresando es menor de edad!", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtNacimiento.Focus();
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;

            logPersonas objlogPersonas = new logPersonas();
            objlogPersonas.ValidarEmail(email);


            bool resultado = true;//= ObjlogPersonas.ValidarEmail(txtEmail.Text);

            if (string.IsNullOrWhiteSpace(txtEmail.Text.Trim()) == true)
            {
                txtEmail.Style = MetroFramework.MetroColorStyle.Red;
                txtEmail.Focus();
                lblEmail.Visible = true;
                lblEmail.Text = "Por favor ingrese email";
            }
            else
            {
                resultado = objlogPersonas.ValidarEmail(email);
                lblEmail.Visible = false;
            }

            if (resultado == false)
            {
                MessageBox.Show("Ingrese un Email Válido");
                txtEmail.Clear();
                txtEmail.Focus();

            }
        }

        /* Metodos tipeo */

        private void Solonumeros(object sender, KeyPressEventArgs e)
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

        /*************************************/
        /********* GUARDAR CANCELAR **********/
        /*************************************/

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        /* Boton Candado Editar */

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
            Cbocargo.Enabled = onOff;

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
                    MessageBox.Show("El docente ya se encuentra registrado. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
        //{
            
        //}

        private void cbTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            logPersonas ObjlogPersonas = new logPersonas();

            DataTable dt = ObjlogPersonas.Llenar_Combo_Salas(cbTurno.SelectedIndex/*, cbSala*/);
            cbSala.DataSource = dt;
            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text.Trim()) == true)
            {
                txtNombre.Style = MetroFramework.MetroColorStyle.Red;
                txtNombre.Focus();
                lblNombre.Visible = true;
                lblNombre.Text = "Por favor ingrese el nombre";
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
                lblApellido.Text = "Por favor ingrese el apellido";
            }
            else
            {
                lblApellido.Visible = false;
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
                lblNumero.Text = "Por favor ingrese número";
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
                lblCp.Text = "Por favor ingrese código postal";
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

        private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
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
            
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            fichaDocente fichaDocente = new fichaDocente(idPersonaSelect);
        }
    }
}
