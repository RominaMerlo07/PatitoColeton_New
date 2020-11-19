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
        public string NOMBRE
        {
            get { return p_nombre; }
            set { p_nombre = value; }
        }

        private string p_apellido;
        public string APELLIDO
        {
            get { return p_apellido; }
            set { p_apellido = value; }
        }

        private Int32 p_documento;
        public Int32 DOCUMENTO
        {
            get { return p_documento; }
            set { p_documento = value; }
        }

        private string p_edad;
        public string EDAD
        {
            get { return p_edad; }
            set { p_edad = value; }
        }

        private DateTime p_fechaNac;
        public DateTime FECHA_NACIMIENTO
        {
            get { return p_fechaNac; }
            set { p_fechaNac = value; }
        }

        private string p_genero;
        public string GENERO
        {
            get { return p_genero; }
            set { p_genero = value; }
        }

        private string p_legajo;
        public string LEGAJO
        {
            get { return p_legajo; }
            set { p_legajo = value; }
        }

        private DateTime p_fechaAlta;
        public DateTime FECHA_ALTA
        {
            get { return p_fechaAlta; }
            set { p_fechaAlta = value; }
        }

        private DateTime p_fechaMod;
        public DateTime FECHA_MODIFICACION
        {
            get { return p_fechaMod; }
            set { p_fechaMod = value; }
        }

        private string p_email;
        public string EMAIL
        {
            get { return p_email; }
            set { p_email = value; }
        }

        private string p_calle;
        public string CALLE
        {
            get { return p_calle; }
            set { p_calle = value; }
        }

        private Int32 p_num;
        public Int32 NUMERO
        {
            get { return p_num; }
            set { p_num = value; }
        }
        
        private string p_dpto;
        public string DPTO
        {
            get { return p_dpto; }
            set { p_dpto = value; }
        }

        private Int32 p_piso;
        public Int32 PISO
        {
            get { return p_piso; }
            set { p_piso = value; }
        }

        private string p_barrio;
        public string BARRIO
        {
            get { return p_barrio; }
            set { p_barrio = value; }
        }

        private Int32 p_cp;
        public Int32 CP
        {
            get { return p_cp; }
            set { p_cp = value; }
        }

        private string p_sala;
        public string SALA
        {
            get { return p_sala; }
            set { p_sala = value; }
        }

        private string p_turno;
        public string TURNO
        {
            get { return p_turno; }
            set { p_turno = value; }
        }

        private DateTime p_fechaActual;
        public DateTime FECHA
        {
            get { return p_fechaActual; }
            set { p_fechaActual = value; }
        }

        private string p_telefono;
        public string TELEFONO
        {
            get { return p_telefono; }
            set { p_telefono = value; }
        }

        private string p_celular;
        public string CELULAR
        {
            get { return p_celular; }
            set { p_celular = value; }
        }

        private string p_cargo;
        public string CARGO
        {
            get { return p_cargo; }
            set { p_cargo = value; }
        }

        public fichaAlumno()
        {

        }

        public class fichaAlumnoColeccion : List<fichaAlumno>
        { }

    }
}
