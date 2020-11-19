using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CaAD;
using CaEnt;

namespace CaLog
{
    public class logSalas
    {
        metSalas objMetSalas = new metSalas();

        public DataTable ListarSalas(string turno)
        {
            
            return objMetSalas.ListarSalas(turno);

        }

        public string insertarGrupoSala(entGrupoSala grupoSala)
        {            

            return objMetSalas.insertarGrupoSala(grupoSala);
        }

        public entSala buscarSalaXPersona(Int32 idPersona)
        {
            

            return objMetSalas.buscarSalaXPersona(idPersona);
        }

        public string editarGrupoSala(entGrupoSala grupoSalaEditar)
        {
            
            return objMetSalas.editarGrupoSala(grupoSalaEditar);
        }

        public DataTable traerPersonasXSala(Int32 idSala)

        {
            
            return objMetSalas.traerPersonasXSala(idSala);
        }

        public DataTable traerSalasCupo()
        {
            
            return objMetSalas.traerSalasCupo();
        }

        public string cantdoc_sal(int sala, int per_id, string turno)
        {
            
            return objMetSalas.cantdoc_sal(sala, per_id, turno);
        }


        public int ValidarDocSala(string id_sala, string turno)
        {           

            return objMetSalas.ValidarDocSala(id_sala, turno);
        }

        public DataSet CantidadAlumnosSalas()
        {
            return objMetSalas.CantidadAlumnosSalas();
        }
    }
}
