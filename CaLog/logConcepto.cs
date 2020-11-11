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
        public string ActualizarEstadoN(entConcepto conceptoEN)
        {

            return objMetConcepto.ActualizarEstadoN(conceptoEN);
        }

        // Esto solo pasaria cuando SOLO se activa un concepto inactivo y el monto no cambia
        public string ActualizarEstadoS(entConcepto conceptoES)
        {
            
            return objMetConcepto.ActualizarEstadoS(conceptoES);
        }

        //Cuando solo se modifica el monto de un concepto Activo
        public string ActualizarMonto(entConcepto conceptoM)
        {

            
            return objMetConcepto.ActualizarMonto(conceptoM);
        }

        public string nombre_concepto(string concepto)

        {
            {

                char delimitador = ('-');
                string[] nombre_concepto = concepto.Split(delimitador);
                return nombre_concepto[0];
            }                 
        }

    }
}
