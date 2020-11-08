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
    public class logAsistencia
    {
        metAsistencia objMetAsistencia = new metAsistencia();
        
        public DataTable GrillaAsistencia(string turno, string sala, string fecha)
        {

            return objMetAsistencia.GrillaAsistencia(turno, sala, fecha);

        }

        public void AgregarAsistencia(entAsistencia asistencia)
        {
            objMetAsistencia.AgregarAsistencia(asistencia);
        }

        public void EditarAsistencia(entAsistencia asistencia)
        {
            objMetAsistencia.EditarAsistencia(asistencia);
        }

        public string infoAusencias(string sala, string fecha)
        {
            

            return objMetAsistencia.infoAusencias(sala, fecha);
        }


        public DataTable GrillaAsistenciaConsultar(string sala, string fechaDesde, string fechaHasta)
        {
            
            return objMetAsistencia.GrillaAsistenciaConsultar(sala, fechaDesde, fechaHasta);

        }


        public DataSet InformeAsistencia(string turno, string sala, string fecha)
        {

            return objMetAsistencia.InformeAsistencia(turno, sala, fecha);
        }

    }
}
