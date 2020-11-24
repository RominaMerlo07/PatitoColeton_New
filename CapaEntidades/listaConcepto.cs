using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class listaConcepto
    {

        private string p_concepto;
        public string CONCEPTO
        {
            get { return p_concepto; }
            set { p_concepto = value; }
        }

        private DateTime p_fecha_de_alta;
        public DateTime FECHA_DE_ALTA
        {
            get { return p_fecha_de_alta; }
            set { p_fecha_de_alta = value; }
        }

        private string p_valor_actual;
        public string VALOR_ACTUAL
        {
            get { return p_valor_actual; }
            set { p_valor_actual = value; }
        }

        private DateTime p_vigente_desde;
        public DateTime VIGENTE_DESDE
        {
            get { return p_vigente_desde; }
            set { p_vigente_desde = value; }
        }

        private string p_valor_anterior;
        public string VALOR_ANTERIOR
        {
            get { return p_valor_anterior; }
            set { p_valor_anterior = value; }
        }

        private DateTime p_desde;
        public DateTime DESDE
        {
            get { return p_desde; }
            set { p_desde = value; }
        }

        private DateTime p_hasta;
        public DateTime HASTA
        {
            get { return p_hasta; }
            set { p_hasta = value; }
        }

        private string p_estado;
        public string ESTADO
        {
            get { return p_estado; }
            set { p_estado = value; }
        }

        private DateTime p_fecha;
        public DateTime FECHA
        {
            get { return p_fecha; }
            set { p_fecha = value; }
        }

        public listaConcepto()
        {

        }

        public class listaConceptoColeccion : List<listaConcepto>
        { }

    }
}
