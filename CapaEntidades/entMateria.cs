using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class entMateria
    {

        private Int32 p_mat_id;
        public Int32 MAT_ID
        {
            get { return p_mat_id; }
            set { p_mat_id = value; }
        }

        private string p_mat_materia;
        public string MAT_MATERIA
        {
            get { return p_mat_materia; }
            set { p_mat_materia = value; }
        }

        private Int32 p_mat_sal_id;
        public Int32 MAT_SAL_ID
        {
            get { return p_mat_sal_id; }
            set { p_mat_sal_id = value; }
        }

        private Int32 p_mat_per_id;
        public Int32 MAT_PER_ID
        {
            get { return p_mat_per_id; }
            set { p_mat_per_id = value; }
        }

        private string p_mat_edad;
        public string MAT_EDAD
        {
            get { return p_mat_edad; }
            set { p_mat_edad = value; }
        }

        private Int32 p_mat_ano;
        public Int32 MAT_ANO
        {
            get { return p_mat_ano; }
            set { p_mat_ano = value; }
        }

        public entMateria()
        {

        }

        public class entMateriaColeccion : List<entMateria>
        { }
    }
}
