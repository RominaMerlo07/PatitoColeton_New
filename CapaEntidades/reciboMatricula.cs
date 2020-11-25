using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
    public class reciboMatricula
    {
        private string p_alumno;
        public string ALUMNO
        {
            get { return p_alumno; }
            set { p_alumno = value; }
        }

        private Int32 p_DOCUMENTO;
        public Int32 DOCUMENTO
        {
            get { return p_DOCUMENTO; }
            set { p_DOCUMENTO = value; }
        }

        private string p_CONCEPTO;
        public string CONCEPTO
        {
            get { return p_CONCEPTO; }
            set { p_CONCEPTO = value; }
        }

        private string p_IMPORTE;
        public string IMPORTE
        {
            get { return p_IMPORTE; }
            set { p_IMPORTE = value; }
        }
        
        private DateTime p_FECHA_VENCIMIENTO;
        public DateTime FECHA_VENCIMIENTO
        {
            get { return p_FECHA_VENCIMIENTO; }
            set { p_FECHA_VENCIMIENTO = value; }
        }

        private DateTime p_FECHA_EMISION;
        public DateTime FECHA_EMISION
        {
            get { return p_FECHA_EMISION; }
            set { p_FECHA_EMISION = value; }
        }

        private DateTime p_FECHA;
        public DateTime FECHA
        {
            get { return p_FECHA; }
            set { p_FECHA = value; }
        }
        
        private string p_ESTADO;
        public string ESTADO
        {
            get { return p_ESTADO; }
            set { p_ESTADO = value; }
        }


        private Int32 p_NUMERO;
        public Int32 NUMERO
        {
            get { return p_NUMERO; }
            set { p_NUMERO = value; }
        }

        public reciboMatricula()
        {

        }

        public class reciboMatriculaColeccion : List<reciboMatricula>
        { }


    }
}
