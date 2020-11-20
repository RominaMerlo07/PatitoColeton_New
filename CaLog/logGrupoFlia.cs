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
    public class logGrupoFlia
    {

        metGrupoFlia objMetGrupoFlia = new metGrupoFlia();

        public string insertaEnGrupoFlia(int idPersonaIngresada, string legajo)
        {

            return objMetGrupoFlia.insertaEnGrupoFlia(idPersonaIngresada, legajo);
        }

        public DataTable traerPersonasXGrupoFliar(string idPersona)
        {
            
            return objMetGrupoFlia.traerPersonasXGrupoFliar(idPersona);
        }

        public DataTable traerPersonasXGrupoFliar2(string idPersona)
        {

            return objMetGrupoFlia.traerPersonasXGrupoFliar2(idPersona);
        }

        public string insertaEnGrupoFlia2(entGrupoFlia grpFlia)
        {
            

            return objMetGrupoFlia.insertaEnGrupoFlia2(grpFlia);
        }

        public entGrupoFlia traerGrpFlia(int idPersona)
        {
            

            return objMetGrupoFlia.traerGrpFlia(idPersona);
        }

        public string editaGrFlia(entGrupoFlia grupoFlia)
        {

            return objMetGrupoFlia.editaGrFlia(grupoFlia);

        }

        public DataSet listaGrupoFlia(string idPersona)
        {
            return objMetGrupoFlia.listaGrupoFlia(idPersona);
        }

    }
}
