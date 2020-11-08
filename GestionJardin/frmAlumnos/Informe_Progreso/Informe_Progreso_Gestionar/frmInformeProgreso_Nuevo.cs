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
    public partial class frmInformeProgreso_Nuevo : Form
    {
        DataTable materia;
        string v_sala_id;
        string v_edad;
        string v_etapa;
        string v_per_id;
        Int32 mat_id;
        string id_calificacion;
        logMaterias logMaterias = new logMaterias();

        public frmInformeProgreso_Nuevo(string sala_id, string edad, string etapa, string per_id, string nomape, string documento)
        {
            InitializeComponent();

            metroLabel4.Text = "Informe de progreso del ALUMNO: " + nomape + " - DNI: " + documento + " - EDAD: " + edad + " AÑOS";

            switch (edad)
            {
                case "1 y 2 AÑOS":
                    edad = "1";
                    break;
                case "3 AÑOS":
                    edad = "3";
                    break;
                case "4 AÑOS":
                    edad = "4";
                    break;
                case "5 AÑOS":
                    edad = "5";
                    break;
            }

            switch (etapa)
            {
                case "PRIMERA":
                    etapa = "1";
                    break;
                case "SEGUNDA":
                    etapa = "2";
                    break;
            }

            

            v_sala_id = sala_id;
            v_edad = edad;
            v_etapa = etapa;
            v_per_id = per_id;

            DataTable dt = logMaterias.buscaProgreso(sala_id, edad, etapa, per_id);

            cargar_cbAsignatura(dt);

        }

        private void cargar_cbAsignatura(DataTable Tabla)
        {

            cbAsignatura.SelectedValueChanged -= new EventHandler(cbAsignatura_SelectedValueChanged);


            cbAsignatura.DisplayMember = "mt_nombre";
            cbAsignatura.ValueMember = "mt_id";
            cbAsignatura.DataSource = Tabla;
            cbAsignatura.SelectedItem = null;
            cbAsignatura.Enabled = true;

            materia = Tabla;

            cbAsignatura.SelectedValueChanged += new EventHandler(cbAsignatura_SelectedValueChanged);

        }

        private void frmInformeProgreso_Nuevo_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void cbAsignatura_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbAsignatura.Text.Trim()) == false)
            {
                lblEstado.Visible = true;
                panelDescripcion.Visible = true;
                
                txtObservacion.Visible = true;
                btnguardar.Visible = true;
                btncancelar.Visible = true;
                btnBloqueo.Visible = false;

                mat_id = Convert.ToInt32(cbAsignatura.SelectedValue.ToString());

                DataRow[] dr = materia.Select("mt_id = " + mat_id);

                lblDescripcion.Text = dr[0].ItemArray[2].ToString(); /*ESTO SE DEBE MODIFICAR POR LO QUE HOY TENGA EL JARDIN*/
                                                                     /*ROMI, va consultar a mi madrina dicha info o se la pediremos a Cristian Farias*/

                string columna = dr[0].ItemArray[3].ToString();

                string[] col = columna.Split('-');

                string observacion = "";

                if (col.Length > 1) { 
                    id_calificacion = col[0].Trim();
                    observacion = col[1].Trim();
                }

                if (observacion.Length > 0)
                {
                    txtObservacion.Text = observacion;
                    lblEstado.Text = "CARGADO";
                } else
                {
                    txtObservacion.Text = "TEXTO A INGRESAR POR PROFESOR";
                    lblEstado.Text = "PENDIENTE";
                }

                
            }

        }

        private void Inicializar()
        {
            lblEstado.Visible = false;
            panelDescripcion.Visible = false;
            txtObservacion.Visible = false;
            btnguardar.Visible = false;
            btncancelar.Visible = false;
            btnBloqueo.Visible = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nueva_observacion = txtObservacion.Text.Trim();

            if (lblEstado.Text == "CARGADO")
            {
                //EDITAR REGISTRO

                string estado = logMaterias.EditarCalificacion(id_calificacion, nueva_observacion);
                this.Close(); 

            } else
            {
                // INSERTAR REGISTRO
                string estado = logMaterias.InsertarCalificacion(mat_id, nueva_observacion, v_per_id, v_etapa);
                this.Close();
            }
        }
    }
}
