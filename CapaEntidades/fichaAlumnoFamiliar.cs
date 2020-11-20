using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class fichaAlumnoFamiliar
    {

        private string p_nombre;
        public string NOMBRE
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

        private string p_parentesco;
        public string PARENTESCO
        {
            get { return p_parentesco; }
            set { p_parentesco = value; }
        }

        private string p_tutor;
        public string TUTOR
        {
            get { return p_tutor; }
            set { p_tutor = value; }
        }

        private string p_autorizado;
        public string AUTORIZADO
        {
            get { return p_autorizado; }
            set { p_autorizado = value; }
        }

        private string p_celular;
        public string CELULAR
        {
            get { return p_celular; }
            set { p_celular = value; }
        }

        private string p_telefono;
        public string TELEFONO
        {
            get { return p_telefono; }
            set { p_telefono = value; }
        }

        private string p_email;
        public string EMAIL
        {
            get { return p_email; }
            set { p_email = value; }
        }

        private DateTime p_fecha;
        public DateTime FECHA
        {
            get { return p_fecha; }
            set { p_fecha = value; }
        }



        public fichaAlumnoFamiliar()
        {

        }

        public class fichaAlumnoFamiliarColeccion : List<fichaAlumnoFamiliar>
        { }


    }
}
