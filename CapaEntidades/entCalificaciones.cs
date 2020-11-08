using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class entCalificaciones
    {

        private Int32 p_cal_id;
        public Int32 CAL_ID
        {
            get { return p_cal_id; }
            set { p_cal_id = value; }
        }

        private Int32 p_cal_mat_id;
        public Int32 CAL_MAT_ID
        {
            get { return p_cal_mat_id; }
            set { p_cal_mat_id = value; }
        }

        private string p_cal_progreso;
        public string CAL_PROGRESO
        {
            get { return p_cal_progreso; }
            set { p_cal_progreso = value; }
        }

        private string p_cal_observaciones;
        public string CAL_OBSERVACIONES
        {
            get { return p_cal_observaciones; }
            set { p_cal_observaciones = value; }
        }

        private Int32 p_cal_per_id;
        public Int32 CAL_PER_ID
        {
            get { return p_cal_per_id; }
            set { p_cal_per_id = value; }
        }

        private Int32 p_cal_semestre;
        public Int32 CAL_SEMESTRE
        {
            get { return p_cal_semestre; }
            set { p_cal_semestre = value; }
        }


        public entCalificaciones()
        {

        }

        public class entCalificacionesColeccion : List<entCalificaciones>
        { }
    }
}
