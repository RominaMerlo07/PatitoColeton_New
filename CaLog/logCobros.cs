using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CaAD;
using CaEnt;

namespace CaLog
{
    public class logCobros
    {

        metCobros objMetCobros = new metCobros();


        public DataTable AutocompletarenCobros()
        {

            return objMetCobros.AutocompletarenCobros();

        }

        public string ExtraerDni(string pbarrabuscao)
        {

            string info = pbarrabuscao;
            string[] extraccion = info.Split('(', ')');

            return extraccion[1];

        }



        public DataTable InsetarDatosCobrosenformBuscar(String pbarrabuscao/*, MetroFramework.Controls.MetroTextBox pnomyapell, MetroFramework.Controls.MetroTextBox pdni, MetroFramework.Controls.MetroTextBox plegajo, MetroFramework.Controls.MetroComboBox pcuotas*//*, MetroFramework.Controls.MetroTextBox pimporte,*/ /*MetroFramework.Controls.MetroDateTime pfechacobro,*/ /*MetroFramework.Controls.MetroComboBox pformapago*/)
        {
            pbarrabuscao = ExtraerDni(pbarrabuscao);

            return objMetCobros.InsetarDatosCobrosenformBuscar(pbarrabuscao/*, pnomyapell, pdni, plegajo, pcuotas*//*, pimporte,*/ /*MetroFramework.Controls.MetroDateTime pfechacobro,*/ /*pformapago*/);

        }

        public string ExtraerImporte(string pcuotas)
        {
            string infocuota = pcuotas;
            string[] extraer = infocuota.Split(' ');
            return extraer[0];
            //return objMetCobros.ExtraerImporte(pcuotas);

        }

        public DataTable InsertarDatosCobrosenformAgregar(String pbarrabuscao/*, MetroFramework.Controls.MetroTextBox pnomyapell, MetroFramework.Controls.MetroTextBox pdni, MetroFramework.Controls.MetroTextBox plegajo, MetroFramework.Controls.MetroComboBox pcuotas, MetroFramework.Controls.MetroTextBox pimporte,*/ /*MetroFramework.Controls.MetroDateTime pfechacobro,*/ /*MetroFramework.Controls.MetroComboBox pformapago*/)
        {
            pbarrabuscao = ExtraerDni(pbarrabuscao);

            return objMetCobros.InsertarDatosCobrosenformAgregar(pbarrabuscao/*, pnomyapell, pdni, plegajo, pcuotas, pimporte,*/ /*MetroFramework.Controls.MetroDateTime pfechacobro,*/ /*pformapago*/);

        }

        public string ExtraerFechaVenc(String pcuotas)
        {
            string infocuota = pcuotas;
            string[] extraer = infocuota.Split(' ');
            return extraer[2];
            //return objMetCobros.ExtraerFechaVenc(pcuotas);
        }

        public DataTable ModificarEstadoCuota(string pcuotas, string plegajo, string pbarrabuscao)
        {

            pcuotas = ExtraerFechaVenc(pcuotas);
            pbarrabuscao = ExtraerDni(pbarrabuscao);

            return objMetCobros.ModificarEstadoCuota(pcuotas, plegajo, pbarrabuscao);

        }

        public string AnularCobro(int idCobro)
        {

            return objMetCobros.AnularCobro(idCobro);

        }

        public string ActualizaAnuladoEnCuota(int idCobro)
        {

            return objMetCobros.ActualizaAnuladoEnCuota(idCobro);

        }

        public string ExtraercoutaId(string pcuotas, string plegajo)
        {
            
            return objMetCobros.ExtraercoutaId(pcuotas, plegajo);

        }

        public string InsertarenTCobros(string cuoId)

        {
            
            return objMetCobros.InsertarenTCobros(cuoId);
        }

        public double ObtenerInteresActual()
        {
            double interes = double.Parse(objMetCobros.buscarInteresActual());
            return interes;
        }
        public bool insertarNuevoCobro(int idCuota, double importe, DateTime fecha, string formaPago)
        {
            bool resultado = objMetCobros.insertarNuevoCobro(idCuota, importe, fecha, formaPago);
            if (resultado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
