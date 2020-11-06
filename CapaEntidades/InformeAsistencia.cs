using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class InformeAsistencia
    {
        private string p_nombre;
        public string nombre
        {
            get { return p_nombre; }
            set { p_nombre = value; }
        }

        private string p_documento;
        public string documento
        {
            get { return p_documento; }
            set { p_documento = value; }
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

        private DateTime p_fecha;
        public DateTime fecha
        {
            get { return p_fecha; }
            set { p_fecha = value; }
        }

        private string p_asistencia;
        public string asistencia
        {
            get { return p_asistencia; }
            set { p_asistencia = value; }
        }

        private string p_justificado;
        public string justificado
        {
            get { return p_justificado; }
            set { p_justificado = value; }
        }
                                


        public InformeAsistencia()
        {

        }

        public class InformeAsistenciaColeccion : List<InformeAsistencia>
        { }

    }
}
