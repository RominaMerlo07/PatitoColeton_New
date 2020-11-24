using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class historialConceptos
    {
        private string p_concepto;
        public string CONCEPTO
        {
            get { return p_concepto; }
            set { p_concepto = value; }
        }

        private string p_valor_actual;
        public string VALOR_ACTUAL
        {
            get { return p_valor_actual; }
            set { p_valor_actual = value; }
        }

        private DateTime p_fecha_alta;
        public DateTime FECHA_ALTA
        {
            get { return p_fecha_alta; }
            set { p_fecha_alta = value; }
        }

        private DateTime p_fecha_desde;
        public DateTime FECHA_DESDE
        {
            get { return p_fecha_desde; }
            set { p_fecha_desde = value; }
        }

        private DateTime p_fecha_hasta;
        public DateTime FECHA_HASTA
        {
            get { return p_fecha_hasta; }
            set { p_fecha_hasta = value; }
        }

        private DateTime p_fecha;
        public DateTime FECHA
        {
            get { return p_fecha; }
            set { p_fecha = value; }
        }

        public historialConceptos()
        {

        }

        public class historialConceptosColeccion : List<historialConceptos>
        { }

    }
}
