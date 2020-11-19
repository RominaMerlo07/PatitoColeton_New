using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class CantidadAlumnosSalas
    {
        private Int32 p_cantidad;
        public Int32 CANTIDAD
        {
            get { return p_cantidad; }
            set { p_cantidad = value; }
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


        public CantidadAlumnosSalas()
        {

        }

        public class CantidadAlumnosSalasColeccion : List<CantidadAlumnosSalas>
        { }

    }
}
