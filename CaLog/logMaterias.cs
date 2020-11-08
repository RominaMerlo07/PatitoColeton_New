using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CaAD;
using CaEnt;


namespace CaLog
{
    public class logMaterias
    {

        metMaterias objMetMaterias = new metMaterias();

        public DataTable buscaAlumnosXMateria(string sala)
        {
            DataTable dt = objMetMaterias.buscaAlumnosXMateria(sala);
            return dt;
        }

       
        public DataTable buscaProgreso(string sala_id, string edad, string etapa, string per_id)
        {
            DataTable dt = objMetMaterias.buscaProgreso(sala_id, edad, etapa, per_id);
            return dt;
        }

        public string EditarCalificacion(string id_calificacion, string nueva_observacion)
        {

            string estado = objMetMaterias.EditarCalificacion(id_calificacion, nueva_observacion);
            return estado;
        }

        public string InsertarCalificacion(Int32 mat_id, string nueva_observacion, string v_per_id, string v_etapa)
        {

            string estado = objMetMaterias.InsertarCalificacion(mat_id, nueva_observacion, v_per_id, v_etapa);
            return estado;
        }

    }
}
