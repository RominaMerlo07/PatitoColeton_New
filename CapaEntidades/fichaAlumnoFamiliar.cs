using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class fichaAlumnoFamiliar
    {

        private string p_familiar;
        public string FAMILIAR
        {
            get { return p_familiar; }
            set { p_familiar = value; }
        }

        private string p_vinculo;
        public string VINCULO
        {
            get { return p_vinculo; }
            set { p_vinculo = value; }
        }

        private Int32 p_documentoFamiliar;
        public Int32 DOCUMENTO_FAMILIAR
        {
            get { return p_documentoFamiliar; }
            set { p_documentoFamiliar = value; }
        }

        private string p_emailFamiliar;
        public string EMAIL_FAMILIAR
        {
            get { return p_emailFamiliar; }
            set { p_emailFamiliar = value; }
        }

        private string p_telefonoFamiliar;
        public string TELEFONO_FAMILIAR
        {
            get { return p_telefonoFamiliar; }
            set { p_telefonoFamiliar = value; }
        }

        private string p_celularFamiliar;
        public string CELULAR_FAMILIAR
        {
            get { return p_celularFamiliar; }
            set { p_celularFamiliar = value; }
        }

        private string p_autorizado;
        public string AUTORIZADO
        {
            get { return p_autorizado; }
            set { p_autorizado = value; }
        }

        public fichaAlumnoFamiliar()
        {

        }

        public class fichaAlumnoFamiliarColeccion : List<fichaAlumnoFamiliar>
        { }


    }
}
