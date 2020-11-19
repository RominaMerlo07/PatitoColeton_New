using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class ListaAlumnos
    {
        private string p_nombre;
        public string ALUMNO
        {
            get { return p_nombre; }
            set { p_nombre = value; }
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

        private DateTime p_fecha;
        public DateTime FECHA
        {
            get { return p_fecha; }
            set { p_fecha = value; }
        }


        public ListaAlumnos()
        {

        }

        public class ListaAlumnosColeccion : List<ListaAlumnos>
        { }


    }
}
