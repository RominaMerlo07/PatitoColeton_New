using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class InformeTotalAsistencia
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

        private Int32 p_totalAsistencias;
        public Int32 TOTAL_ASISTENCIAS
        {
            get { return p_totalAsistencias; }
            set { p_totalAsistencias = value; }
        }

        private Int32 p_totalInasistencias;
        public Int32 TOTAL_INASISTENCIAS
        {
            get { return p_totalInasistencias; }
            set { p_totalInasistencias = value; }
        }

        private Int32 p_justificadas;
        public Int32 JUSTIFICADAS
        {
            get { return p_justificadas; }
            set { p_justificadas = value; }
        }

        private Int32 p_injustificadas;
        public Int32 INJUSTIFICADAS
        {
            get { return p_injustificadas; }
            set { p_injustificadas = value; }
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

        private DateTime p_fechaDesde;
        public DateTime FECHA_DESDE
        {
            get { return p_fechaDesde; }
            set { p_fechaDesde = value; }
        }

        private DateTime p_fechaHasta;
        public DateTime FECHA_HASTA
        {
            get { return p_fechaHasta; }
            set { p_fechaHasta = value; }
        }

        private DateTime p_fecha;
        public DateTime FECHA
        {
            get { return p_fecha; }
            set { p_fecha = value; }
        }


        public InformeTotalAsistencia()
        {

        }

        public class InformeTotalAsistenciaColeccion : List<InformeTotalAsistencia>
        { }





    }
}
