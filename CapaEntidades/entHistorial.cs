using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaEnt
{
   public class entHistorial
    { 
        private DateTime p_His_Id;
    public DateTime HIS_ID

        {
            get { return p_His_Id; }
            set { p_His_Id = value; }

        }

        private DateTime p_His_Desde;
        public DateTime HIS_DESDE
        {
            get { return p_His_Desde; }
            set { p_His_Desde = value; }
        }
        private DateTime p_His_Hasta;
            public DateTime HIS_HASTA

        {
            get { return p_His_Hasta; }
            set { p_His_Hasta = value; }
        
        }

        private DateTime p_His_Fecha_Baja;

        public DateTime HIS_FECHA_BAJA
        {

            get { return p_His_Fecha_Baja; }
            set { p_His_Fecha_Baja = value; }
        
                    
        }

        private int p_His_Con_Id;
        public int HIS_CON_ID
        {
            get { return p_His_Con_Id; }
            set { p_His_Con_Id = value; }
        
        }

        private decimal p_His_Valor_Anterior;
        public decimal HIS_VALOR_ANTERIOR
        {
            get { return p_His_Valor_Anterior; }
            set { p_His_Valor_Anterior = value; }
        
        }

        public entHistorial()
        {

        }

        public class entHistorialColeccion : List<entHistorial>
        { }
    }


}


    

