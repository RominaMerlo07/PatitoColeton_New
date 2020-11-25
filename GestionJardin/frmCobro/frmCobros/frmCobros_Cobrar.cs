using CaLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionJardin
{
    public partial class frmCobros_Cobrar : Form
    {
        logCobros objCobros = new logCobros();
        logPersonas objPersonas = new logPersonas();
        logCuota objCuotas = new logCuota();
        public frmCobros_Cobrar(string nroCuota, string fechaVenc, string importe, string nroDocumento)
        {
            InitializeComponent();
            txt_Numcuota.Text = nroCuota.ToString();
            txtImporte.Text = importe.ToString();
            txtFechaVenc.Text = fechaVenc.ToString();
            double interes = objCobros.ObtenerInteresActual() / 100;
            double interesPorMora = double.Parse(importe) * interes;
            txtInteres.Text = interesPorMora.ToString();
            if (interes == 0)
            {
                txtTotalCobro.Text = "0";
            }
            else
            {
                txtTotalCobro.Text = (double.Parse(importe) + interesPorMora).ToString();
            }
            txtNroDoc.Text = nroDocumento;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Este boton genera un nuevo cobro y setea el estado de la cuota
            int nroDoc = int.Parse(txtNroDoc.Text);
            int idAlumno = objPersonas.idAlumno(nroDoc); //Recupero el id de alumno con su dni

            // Datos del cobro
            int nroCuota = Convert.ToInt32(txt_Numcuota.Text);
            int idCuota = objCuotas.obtenerIdCuota(idAlumno, nroCuota);
            double importe = double.Parse(txtTotalCobro.Text);
            string fechaActual = obtenerFechaActual(); //Para COB_fecha


            bool resultado = cobrar(idCuota, importe, DateTime.Parse(fechaActual), "EFECTIVO");
            if (resultado)
            {
                MessageBox.Show("Cuota pagada con exito");
            }
            else
            {
                MessageBox.Show("Error al realizar cobro");
            }
        }
        private string obtenerFechaActual()
        {
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string año = DateTime.Now.Year.ToString();

            return dia + "/" + mes + "/" + año;
        }
        private bool cobrar(int idCuota, double importe, DateTime fecha, string formaPago)
        {
            bool resultado1 = objCobros.insertarNuevoCobro(idCuota, importe, fecha, formaPago);


            if (resultado1)
            {
                bool resultado2 = objCuotas.setEstadoCuota(idCuota);//Se inserto el cobro
                if (resultado2)
                {
                    //Transacción realizada correctamente
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                //Fallo el cobro 
                return false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }   
}
