using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class ListaDocentes
    {

        private string p_docente;
        public string DOCENTE
        {
            get { return p_docente; }
            set { p_docente = value; }
        }

        private Int32 p_documento;
        public Int32 DOCUMENTO
        {
            get { return p_documento; }
            set { p_documento = value; }
        }

        private string p_cargo;
        public string CARGO
        {
            get { return p_cargo; }
            set { p_cargo = value; }
        }

        private string p_turno;
        public string TURNO
        {
            get { return p_turno; }
            set { p_turno = value; }
        }

        private string p_sala;
        public string SALA
        {
            get { return p_sala; }
            set { p_sala = value; }
        }

        private string p_celular;
        public string CELULAR
        {
            get { return p_celular; }
            set { p_celular = value; }
        }

        private string p_email;
        public string EMAIL
        {
            get { return p_email; }
            set { p_email = value; }
        }

        private string p_domicilio;
        public string DOMICILIO
        {
            get { return p_domicilio; }
            set { p_domicilio = value; }
        }


        private string p_fecha;
        public string FECHA
        {
            get { return p_fecha; }
            set { p_fecha = value; }
        }

        public ListaDocentes()
        {

        }

        public class ListaDocentesColeccion : List<ListaDocentes>
        { }


    }
}
