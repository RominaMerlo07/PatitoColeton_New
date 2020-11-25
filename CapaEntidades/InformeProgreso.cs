using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class InformeProgreso
    {
        private string p_alumno;
        public string ALUMNO
        {
            get { return p_alumno; }
            set { p_alumno = value; }
        }

        private Int32 p_documento;
        public Int32 DOCUMENTO
        {
            get { return p_documento; }
            set { p_documento = value; }
        }

        private Int32 p_edad;
        public Int32 EDAD
        {
            get { return p_edad; }
            set { p_edad = value; }
        }

        private Int32 p_anio;
        public Int32 ANIO
        {
            get { return p_anio; }
            set { p_anio = value; }
        }

        private string p_identidad_y_convivencia;
        public string IDENTIDAD_Y_CONVIVENCIA
        {
            get { return p_identidad_y_convivencia; }
            set { p_identidad_y_convivencia = value; }
        }

        private string p_descripcion;
        public string DESCRIPCION
        {
            get { return p_descripcion; }
            set { p_descripcion = value; }
        }

        private string p_PROGRESO;
        public string PROGRESO
        {
            get { return p_PROGRESO; }
            set { p_PROGRESO = value; }

        }

        private string p_semestre;
        public string SEMESTRE
        {
            get { return p_semestre; }
            set { p_semestre = value; }
        }

        private string p_lenguaje_y_literatura;
        public string LENGUAJE_Y_LITERATURA
        {
            get { return p_lenguaje_y_literatura; }
            set { p_lenguaje_y_literatura = value; }
        }

        private string p_DESCRIPCION_LYL;
        public string DESCRIPCION_LYL
        {
            get { return p_DESCRIPCION_LYL; }
            set { p_DESCRIPCION_LYL = value; }
        }      

        private string p_PROGRESO_LYL;
        public string PROGRESO_LYL
        {
            get { return p_PROGRESO_LYL; }
            set { p_PROGRESO_LYL = value; }
        }

        private string p_MATEMATICA;
        public string MATEMATICA
        {
            get { return p_MATEMATICA; }
            set { p_MATEMATICA = value; }
        }

        private string p_DESCRIPCION_MATEMATICA;
        public string DESCRIPCION_MATEMATICA
        {
            get { return p_DESCRIPCION_MATEMATICA; }
            set { p_DESCRIPCION_MATEMATICA = value; }
        }

        private string p_PROGRESO_MATEMATICA;
        public string PROGRESO_MATEMATICA
        {
            get { return p_PROGRESO_MATEMATICA; }
            set { p_PROGRESO_MATEMATICA = value; }
        }

        private string p_CIENCIAS;
        public string CIENCIAS
        {
            get { return p_CIENCIAS; }
            set { p_CIENCIAS = value; }
        }

        private string p_DESCRIPCION_CIENCIAS;
        public string DESCRIPCION_CIENCIAS
        {
            get { return p_DESCRIPCION_CIENCIAS; }
            set { p_DESCRIPCION_CIENCIAS = value; }
        }

        private string p_PROGRESO_CIENCIAS;
        public string PROGRESO_CIENCIAS
        {
            get { return p_PROGRESO_CIENCIAS; }
            set { p_PROGRESO_CIENCIAS = value; }
        }

        private string p_ARTISTICA;
        public string ARTISTICA
        {
            get { return p_ARTISTICA; }
            set { p_ARTISTICA = value; }
        }

        private string p_DESCRIPCION_ARTISTICA;
        public string DESCRIPCION_ARTISTICA
        {
            get { return p_DESCRIPCION_ARTISTICA; }
            set { p_DESCRIPCION_ARTISTICA = value; }
        }

        private string p_PROGRESO_ARTISTICA;
        public string PROGRESO_ARTISTICA
        {
            get { return p_PROGRESO_ARTISTICA; }
            set { p_PROGRESO_ARTISTICA = value; }
        }

        private string p_EDFISICA;
        public string EDFISICA
        {
            get { return p_EDFISICA; }
            set { p_EDFISICA = value; }
        }

        private string p_DESCRIPCION_EDFISICA;
        public string DESCRIPCION_EDFISICA
        {
            get { return p_DESCRIPCION_EDFISICA; }
            set { p_DESCRIPCION_EDFISICA = value; }
        }

        private string p_PROGRESO_EDFISICA;
        public string PROGRESO_EDFISICA
        {
            get { return p_PROGRESO_EDFISICA; }
            set { p_PROGRESO_EDFISICA = value; }
        }


        private DateTime p_fecha;
        public DateTime FECHA
        {
            get { return p_fecha; }
            set { p_fecha = value; }
        }


        public InformeProgreso()
        {

        }

        public class InformeProgresoColeccion : List<InformeProgreso>
        { }

    }
}
