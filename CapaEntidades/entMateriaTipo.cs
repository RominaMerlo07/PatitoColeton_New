using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class entMateriaTipo
    {

        private Int32 p_mt_id;
        public Int32 MT_ID
        {
            get { return p_mt_id; }
            set { p_mt_id = value; }
        }

        private string p_mt_nombre;
        public string MT_NOMBRE
        {
            get { return p_mt_nombre; }
            set { p_mt_nombre = value; }
        }

        private string p_mt_descripcion;
        public string MT_DESCRIPCION
        {
            get { return p_mt_descripcion; }
            set { p_mt_descripcion = value; }
        }

        private Int32 p_mt_materia_ano;
        public Int32 MT_MATERIA_ANO
        {
            get { return p_mt_materia_ano; }
            set { p_mt_materia_ano = value; }
        }

        private Int32 p_mt_materia_edad;
        public Int32 MT_MATERIA_EDAD
        {
            get { return p_mt_materia_edad; }
            set { p_mt_materia_edad = value; }
        }

        public entMateriaTipo()
        {

        }

        public class entMateriaTipoColeccion : List<entMateriaTipo>
        { }
    }
}
