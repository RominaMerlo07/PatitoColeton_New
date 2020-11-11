using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class fichaAlumno
    {

        private string p_nombre;
        public string nombre
        {
            get { return p_nombre; }
            set { p_nombre = value; }
        }


        private string p_apellido;
        public string apellido
        {
            get { return p_apellido; }
            set { p_apellido = value; }
        }

        private string p_documento;
        public string documento
        {
            get { return p_documento; }
            set { p_documento = value; }
        }

        private DateTime p_perFechaNac;
        public DateTime PER_FECHA_NAC
        {
            get { return p_perFechaNac; }
            set { p_perFechaNac = value; }
        }

        private String p_perGenero;
        public String PER_GENERO
        {
            get { return p_perGenero; }
            set { p_perGenero = value; }
        }

        private String p_perTelefono;
        public String PER_TELEFONO
        {
            get { return p_perTelefono; }
            set { p_perTelefono = value; }
        }


        private String p_perEmail;
        public String PER_EMAIL
        {
            get { return p_perEmail; }
            set { p_perEmail = value; }
        }

        private DateTime p_perFechaAlta;
        public DateTime PER_FECHA_ALTA
        {
            get { return p_perFechaAlta; }
            set { p_perFechaAlta = value; }
        }
        
        private string p_perLegajo;
        public string PER_LEGAJO
        {
            get { return p_perLegajo; }
            set { p_perLegajo = value; }
        }

        private string p_sala;
        public string sala
        {
            get { return p_sala; }
            set { p_sala = value; }
        }

        private string p_turno;
        public string turno
        {
            get { return p_turno; }
            set { p_turno = value; }
        }


        private string p_domCalle;
        public string DOM_CALLE
        {
            get { return p_domCalle; }
            set { p_domCalle = value; }
        }

        private Int32 p_domNumero;
        public Int32 DOM_NUMERO
        {
            get { return p_domNumero; }
            set { p_domNumero = value; }
        }

        private Int32 p_domPiso;
        public Int32 DOM_PISO
        {
            get { return p_domPiso; }
            set { p_domPiso = value; }
        }

        private string p_domDpto;
        public string DOM_DPTO
        {
            get { return p_domDpto; }
            set { p_domDpto = value; }
        }

        private string p_domBarrio;
        public string DOM_BARRIO
        {
            get { return p_domBarrio; }
            set { p_domBarrio = value; }
        }

        private Int32 p_domCP;
        public Int32 DOM_CP
        {
            get { return p_domCP; }
            set { p_domCP = value; }
        }

        private Int32 p_edad;
        public Int32 edad
        {
            get { return p_edad; }
            set { p_edad = value; }
        }

        private DateTime p_fecha;
        public DateTime fecha
        {
            get { return p_fecha; }
            set { p_fecha = value; }
        }


        public fichaAlumno()
        {

        }

        public class fichaAlumnoColeccion : List<fichaAlumno>
        { }

    }
}
