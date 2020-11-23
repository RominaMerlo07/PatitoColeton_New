using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using System.Data;
using CaAD;
using CaEnt;

namespace CaLog
{
    public class logConcepto
    {
        metConcepto objMetConcepto = new metConcepto();

        //************************************************************
        //METODO QUE INSERTA LOS DATOS EN LA T_CONCEPTOS
        //************************************************************
        public string InsertarConcepto(entConcepto concepto)
        {

            return objMetConcepto.InsertarConcepto(concepto);
        }

        public int Extraer_ultimo_idConcepto()
        {
            return objMetConcepto.Extraer_ultimo_idConcepto();
        }

        public DataTable CargaDtNombreConcepto()
        {
            return objMetConcepto.CargaDtNombreConcepto();
        }
        public decimal Extraer_Valor_Anterior_Concepto(entConcepto concepto)
        {
            return objMetConcepto.Extraer_Valor_Anterior_Concepto(concepto);
        }

        //************************************************************
        //METODO QUE VALIDA QUE LOS DATOS A INGRESAR EN LA T_CONCEPTOS NO ESTEN REPETIDOS
        //************************************************************
        public int ValidarConcepto(string p_CON_CONCEPTO, int p_CON_PERIODO)
        {

            return objMetConcepto.ValidarConcepto(p_CON_CONCEPTO, p_CON_PERIODO);
        }

        /*
        PARA BUSCAR LOS CONCEPTOS POR NOMBRE
        */
        public DataTable autocompletarBuscar()
        {

            return objMetConcepto.autocompletarBuscar();
        }


        public entConcepto BuscaConcepto(string concepto, string anio, string estado)
        {
            
            return objMetConcepto.BuscaConcepto(concepto, anio, estado);

        }

        /*
         PARA VISUALIZAR DETOS EN LA GRILLA DE MANERA GENERAL 
        */
        public DataTable Visualizar()
        {

            return objMetConcepto.Visualizar();

        }

        // Esto solo pasaria cuando se activa un inactivo y ademas cambia el monto
        public string ActualizarMontoEstado(entConcepto conceptoME)
        {

            return objMetConcepto.ActualizarMontoEstado(conceptoME);
        }

        // Esto solo pasaria cuando se inactiva un concepto activo. El monto no deberia cambiar
        public string DeshabilitarConcepto(entConcepto conceptoEN)
        {

            return objMetConcepto.DeshabilitarConcepto(conceptoEN);
        }

        // Esto solo pasaria cuando SOLO se activa un concepto inactivo y el monto no cambia
        public string ActualizarEstadoS(entConcepto conceptoES)
        {
            
            return objMetConcepto.ActualizarEstadoS(conceptoES);
        }

        //Cuando solo se modifica el monto de un concepto Activo
        public string ActualizarMonto(entConcepto conceptoM, string p_fecha_hasta, string p_fecha_ult_act)
        {

            return objMetConcepto.ActualizarMonto(conceptoM, p_fecha_hasta,p_fecha_ult_act);
        }

        public string nombre_concepto(string concepto)

        {
            {

                char delimitador = ('-');
                string[] nombre_concepto = concepto.Split(delimitador);
                return nombre_concepto[0];
            }                 
        }

        public string ExtraerData()
        {
            string fecha = DateTime.Today.ToShortDateString();
            string[] solo_dma = fecha.Split(' ');

            return solo_dma[0];

        }

    }
}
