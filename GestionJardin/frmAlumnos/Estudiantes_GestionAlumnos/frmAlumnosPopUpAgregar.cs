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
    public partial class frmAlumnosPopUpAgregar : Form
    {

        frmAlumnos alumnos = new frmAlumnos();

        // Variables
        int idHmno;

        public frmAlumnosPopUpAgregar()
        {
            InitializeComponent();
        }

        private void frmAlumnosPopUpAgregar_Load(object sender, EventArgs e)
        {

            cbHrmDomicilio.Enabled = false;
            txtBuscaHmno.Enabled = false;         
            
            AutoCompleteStringCollection alumnos = new AutoCompleteStringCollection();
            logPersonas logPersonas = new logPersonas();

            //--
            DataTable dt = logPersonas.traerPersonasAutocompetar("2");

            foreach (DataRow row in dt.Rows)
            {
                txtBuscaHmno.AutoCompleteCustomSource.Add(row[0].ToString());
            }

            //SqlDataReader dr = logPersonas.traerPersonasAutocompetar("2");
            //while (dr.Read())
            //{
            //    alumnos.Add(dr.GetString(0));
            //};

            txtBuscaHmno.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscaHmno.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtBuscaHmno.AutoCompleteCustomSource = alumnos;

            //--

            lbl_panelSala.Visible = true;
            panelDatos.Visible = false;
            panelContacto.Visible = false;
            btnGuardar.Visible = false;
            btnCancelar.Visible = false;

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
            else if ((string.IsNullOrWhiteSpace(txtVacantes.Text.Trim()) == true) || (Convert.ToInt32(txtVacantes.Text) <= 0 ))
            {

                txtVacantes.Style = MetroFramework.MetroColorStyle.Red;
                txtVacantes.Focus();
                resultadoValidacion = "la Sala";

            }
            else
            {
                resultadoValidacion = "OK";
            }

            return resultadoValidacion;

        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtNombre.Style = MetroFramework.MetroColorStyle.Default;
            txtApellidos.Text = "";
            txtApellidos.Style = MetroFramework.MetroColorStyle.Default;
            txtDocumento.Text = "";
            txtDocumento.Style = MetroFramework.MetroColorStyle.Default;

            dtNacimiento.Value = dtNacimiento.MaxDate;
            cbGenero.SelectedItem = null;


            txtCalle.Text = "";
            txtCalle.Style = MetroFramework.MetroColorStyle.Default;
            txtNumero.Text = "";
            txtNumero.Style = MetroFramework.MetroColorStyle.Default;
            txtCPostal.Text = "";
            txtCPostal.Style = MetroFramework.MetroColorStyle.Default;
            txtPiso.Text = "";
            txtPiso.Style = MetroFramework.MetroColorStyle.Default;
            txtDepto.Text = "";
            txtDepto.Style = MetroFramework.MetroColorStyle.Default;
            txtBarrio.Text = "";
            txtBarrio.Style = MetroFramework.MetroColorStyle.Default;
            txtTelefono.Text = "";
            txtTelefono.Style = MetroFramework.MetroColorStyle.Default;
            txtCelular.Text = "";
            txtCelular.Style = MetroFramework.MetroColorStyle.Default;
            txtEmail.Text = "";
            txtEmail.Style = MetroFramework.MetroColorStyle.Default;


            //cbSala.SelectedItem = null;
            //cbTurno.SelectedItem = null;

            cbHrmDomicilio.Enabled = false;
            txtBuscaHmno.Enabled = false;
            //txtLegajo.Text = "--";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string validacion = validaCampos();

            if (validacion == "OK")
            {

                // Preparo la info de todos los campos

                string nombre = txtNombre.Text.Trim();
                string apellidos = txtApellidos.Text.Trim();
                string documento = txtDocumento.Text.Trim();
                DateTime nacimiento = dtNacimiento.Value.Date;
                string genero;
                if (cbGenero.SelectedItem == null)
                {
                    genero = "";
                }
                else
                {
                    genero = cbGenero.SelectedItem.ToString();
                }

                string calle = txtCalle.Text.Trim();
                string numero = txtNumero.Text.Trim();
                string cpostal = txtCPostal.Text.Trim();
                string piso = txtPiso.Text.Trim();
                string dpto = txtDepto.Text.Trim();
                string barrio = txtBarrio.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string celular = txtCelular.Text.Trim();
                string email = txtEmail.Text.Trim();

                string id_sala;
                if (cbSala.SelectedItem == null)
                {
                    id_sala = "";
                }
                else
                {
                    id_sala = cbSala.SelectedValue.ToString();
                }

                //-- Termina de preparar todos los datos

                //--- Secuenciador de Legajo
                logParametricas logParametricas = new logParametricas();
                string legajo = logParametricas.secuenciadorLegajoAlumnos(); // lo genera solo
                //--------

                entPersona personaInsert = new entPersona();

                personaInsert.PER_NOMBRE = nombre;
                personaInsert.PER_APELLIDO = apellidos;
                personaInsert.PER_DOCUMENTO = Convert.ToInt32(documento);
                personaInsert.PER_GENERO = genero; //revisar
                personaInsert.PER_FECHA_NAC = nacimiento;
                personaInsert.PER_TELEFONO = telefono;
                personaInsert.PER_TELEFONO_2 = celular;
                personaInsert.PER_EMAIL = email;
                personaInsert.PER_TPE_ID = "2";
                personaInsert.PER_LEGAJO = legajo;
                personaInsert.PER_ESTADO = "S";

                // INSERTA PERSONA
                logPersonas metPersona = new logPersonas();
                string resultado = metPersona.Insertar(personaInsert);
                // -----

                if (resultado == "OK")
                { // entra solo si inserto la persona correctamente

                    personaInsert = metPersona.BuscaPersona(nombre, apellidos, documento); // TRAE EL ID RECIEN INSERTADO
                    Int32 id_persona = personaInsert.PER_ID;

                    // INSERTA GRUPO FAMILIAR
                    string valor = cbHrmDomicilio.SelectedItem.ToString();
                    if (valor.StartsWith("SI"))
                    {
                        logGrupoFlia objGrpFlia = new logGrupoFlia();
                        string resulta3 = objGrpFlia.insertaEnGrupoFlia(Convert.ToInt32(id_persona), Convert.ToString(idHmno)); // antes se pasaba el legajo como segundo parametro, ahora pasamos el id_persona del hermano
                    }
                    else
                    {
                        logGrupoFlia objGrpFlia = new logGrupoFlia();
                        string resulta3 = objGrpFlia.insertaEnGrupoFlia(Convert.ToInt32(id_persona), Convert.ToString(id_persona));
                    }
                    // -----

                    //INSERTA DOMICILIO
                    entDomicilio domicilioInsertar = new entDomicilio();

                    domicilioInsertar.DOM_PER_ID = id_persona;
                    domicilioInsertar.DOM_CALLE = calle;
                    domicilioInsertar.DOM_NUMERO = Convert.ToInt32(numero);
                    if (string.IsNullOrWhiteSpace(piso.Trim()) == true)
                    {

                    }
                    else
                    {
                        domicilioInsertar.DOM_PISO = Convert.ToInt32(piso);
                    }

                    domicilioInsertar.DOM_DPTO = dpto;
                    domicilioInsertar.DOM_BARRIO = barrio;
                    domicilioInsertar.DOM_CP = Convert.ToInt32(cpostal);

                    logDomicilio logDomicilio = new logDomicilio();
                    resultado = logDomicilio.Insertar(domicilioInsertar);
                    // -----

                    //INSERTA GRUPO SALA 
                    
                    entGrupoSala grupoSalaInsertar = new entGrupoSala();

                    grupoSalaInsertar.GRS_PER_ID = Convert.ToInt32(id_persona);
                    grupoSalaInsertar.GRS_SAL_ID = Convert.ToInt32(id_sala);

                    logSalas logSalas = new logSalas();
                    resultado = logSalas.insertarGrupoSala(grupoSalaInsertar);
                    // -----

                    if (resultado == "OK")
                    {
                        MessageBox.Show("Se ha ingresado el registro con éxito.", "Ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        //limpiarCampos();

                    }
                }
            }
            else
            {
                MessageBox.Show("No olvide ingresar " + validacion + ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            this.Close();
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
            string id_sala;

            id_sala = cbSala.SelectedValue.ToString(); //.ToString();
            logSalas objlogSalas = new logSalas();
            DataTable gruposSalas = new DataTable();
            gruposSalas = objlogSalas.traerSalasCupo();
            DataRow[] rows = gruposSalas.Select("SAL_ID = " + id_sala);
            int CANTIDAD = Convert.ToInt16(rows[0]["CANTIDAD"].ToString());
            int MAXIMO = Convert.ToInt16(rows[0]["MAXIMO"].ToString());
            int VACANTES = MAXIMO - CANTIDAD;

            txtVacantes.Text = VACANTES.ToString();

            if (VACANTES > 0)
            {
                lbl_panelSala.Visible = false;
                panelDatos.Visible = true;
                panelContacto.Visible = true;
                btnGuardar.Visible = true;
                btnCancelar.Visible = true;
                txtDocumento.Focus(); 

            }
            else
            {
                txtVacantes.Style = MetroFramework.MetroColorStyle.Red;
                txtVacantes.Focus();
               
                MessageBox.Show("No existen vacantes para el turno y sala elegida. Por favor elija otro turno.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
        }

        private void cbHermanos_SelectedValueChanged(object sender, EventArgs e)
        {
            string valor = cbHermanos.SelectedItem.ToString();
            if (valor.StartsWith("SI"))
            {
                cbHrmDomicilio.Enabled = true;
                cbHrmDomicilio.SelectedValueChanged += new EventHandler(cbHrmDomicilio_SelectedValueChanged);
            }
            else
            {
                cbHrmDomicilio.Enabled = false;
                cbHrmDomicilio.SelectedValueChanged -= new EventHandler(cbHrmDomicilio_SelectedValueChanged);
                cbHrmDomicilio.SelectedValue = null;
                
            }
        }

        private void cbHrmDomicilio_SelectedValueChanged(object sender, EventArgs e)
        {
            string valor = cbHrmDomicilio.SelectedItem.ToString();
            if (valor.StartsWith("SI"))
            {
                txtBuscaHmno.Enabled = true;
            }
            else
            {
                txtBuscaHmno.Enabled = false;
                txtBuscaHmno.Text = null;
            }
        }

        private void txtBuscaHmno_ButtonClick(object sender, EventArgs e)
        {
            string nombreB = "";
            string apellidoB = "";
            string documentoB = "";
            int contador = 0;

            string busqueda = txtBuscaHmno.Text;

            char[] separadores = { ',', '(', ')' };
            string[] palabras = busqueda.Split(separadores);

            foreach (var palabra in palabras)
            {
                contador += 1;
                if (contador == 1)
                {
                    nombreB = palabra.Trim();
                }
                else if (contador == 2)
                {
                    apellidoB = palabra.Trim();
                }
                else if (contador == 3)
                {
                    documentoB = palabra.Trim();
                }
            }

            entPersona personaBuscar = new entPersona();
            logPersonas objlogPersonas = new logPersonas();
            logDomicilio objlogDomicilio = new logDomicilio();
            personaBuscar = objlogPersonas.BuscaPersona(nombreB, apellidoB, documentoB);
            entDomicilio domicilioBuscar = new entDomicilio();
            domicilioBuscar = objlogDomicilio.buscarDomicilioXPersona(personaBuscar.PER_ID);

            if (personaBuscar.PER_NOMBRE != null)
            {
                idHmno = personaBuscar.PER_ID; // se usara en el agregarGrupoFlia


                txtCalle.Text = domicilioBuscar.DOM_CALLE;
                txtNumero.Text = Convert.ToString(domicilioBuscar.DOM_NUMERO);
                txtCPostal.Text = Convert.ToString(domicilioBuscar.DOM_CP);
                txtPiso.Text = Convert.ToString(domicilioBuscar.DOM_PISO);
                txtDepto.Text = domicilioBuscar.DOM_DPTO;
                txtBarrio.Text = domicilioBuscar.DOM_BARRIO;
                txtTelefono.Text = personaBuscar.PER_TELEFONO;
                txtCelular.Text = personaBuscar.PER_TELEFONO_2;
                txtEmail.Text = personaBuscar.PER_EMAIL;

            }
        }

        //-- EVENTOS QUE VALIDAN DATOS INGRESADOS

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

        private void cbTurno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == true)
            {
                cbTurno.Style = MetroFramework.MetroColorStyle.Red;
                cbTurno.Focus();
                lblTurno.Visible = true;
                lblTurno.Text = "Por favor seleccione un turno";
            }
            else
            {
                lblTurno.Visible = false;
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

            if (color == "0")
            {
                lblSala.Visible = true;
                lblSala.Text = " 1 a 2 años ";

            }
            else if (color == "1")
            {
                lblSala.Visible = true;
                lblSala.Text = "3 a 4 años";
            }

            else if (color == "2")

            {
                lblSala.Visible = true;
                lblSala.Text = " 4 a 5 años ";

            }
            else
            {
                lblSala.Visible = false;
            }
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

        private void cbGenero_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbGenero.Text.Trim()) == true)
            {
                cbGenero.Style = MetroFramework.MetroColorStyle.Red;
                cbGenero.Focus();
                lblGenero.Visible = true;
                lblGenero.Text = "Por favor seleccione el género";
            }
            else
            {
                lblGenero.Visible = false;
            }
        }

        private void cbHermanos_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbHermanos.Text.Trim()) == true)
            {
                cbHermanos.Style = MetroFramework.MetroColorStyle.Red;
                cbHermanos.Focus();
                lblHermanos.Visible = true;
                lblHermanos.Text = "Por favor seleccione una opción";
            }
            else
            {
                lblHermanos.Visible = false;
            }
        }

        private void cbHrmDomicilio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbHrmDomicilio.Text.Trim()) == true)
            {
                cbHrmDomicilio.Style = MetroFramework.MetroColorStyle.Red;
                cbHrmDomicilio.Focus();
                lblDocmilio.Visible = true;
                lblDocmilio.Text = "Por favor seleccione una opción";
            }
            else
            {
                lblDocmilio.Visible = false;
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
                    lblSala.Text = " 1 a 2 años ";

                }
                else if (color == "1")
                {
                    lblSala.Visible = true;
                    lblSala.Text = "3 a 4 años";
                }

                else if (color == "2")

                {
                    lblSala.Visible = true;
                    lblSala.Text = " 4 a 5 años ";
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
                    cbSala.Focus();

                }
            }
    }
        

    }
}
