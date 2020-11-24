using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CaAD;
using CaEnt;
namespace CaLog
{
   public class logHistorial


    {
        metHistorial objHistorial = new metHistorial();


        public string InsertarHistorialConceptos(entHistorial historial, string phis_hasta, string phis_desd)
        {
           return objHistorial.InsertarHistorialConceptos(historial, phis_hasta, phis_desd);
        }


    }
}
