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
    public class logCuota
    {
        metCuota objMetCuota = new metCuota();


        public entSala.entSalaColeccion buscarSalas()
        {

            return objMetCuota.buscarSalas();

        }

        public DataTable traeConceptos(int añoEjercicio)
        {

            return objMetCuota.traeConceptos(añoEjercicio);
        }

        public string insertaCuotaFinal(string legajo, int periodoCuota, int anoCuota, string estadoCuota)
        {

            return objMetCuota.insertaCuotaFinal(legajo, periodoCuota, anoCuota, estadoCuota);
        }

        //public string InsertarCuotaDetalle(string legajo, int periodoCuota, int anoCuota, int idConcepto, int importeConcepto)
        //{

        //    return objMetCuota.InsertarCuotaDetalle(legajo, periodoCuota, anoCuota, idConcepto, importeConcepto);
        //}

        public string ActualizaMontoCuotaFinal(string legajo, int periodoCuota, int anoCuota, int importeConcepto)
        {

            return objMetCuota.ActualizaMontoCuotaFinal(legajo, periodoCuota, anoCuota, importeConcepto);
        }

        public int CuentaCuotasValidacion(string legajo, int periodoCuota, int anoCuota)
        {

            return objMetCuota.CuentaCuotasValidacion(legajo, periodoCuota, anoCuota);
        }

        public string traeLegajo(string nombre, string apellido, string documento)
        {

            return objMetCuota.traeLegajo(nombre, apellido, documento);

        }

        public DataTable traeCuotasXPersona(string legajo)
        {

            return objMetCuota.traeCuotasXPersona(legajo);

        }

        public string bajaCuotaFinal(int idCuotaFinal)
        {

            return objMetCuota.bajaCuotaFinal(idCuotaFinal);

        }

        public DataTable VisualizarAlumnosporSalaTurno(string nombre_sala, string turno_sala)
        {
            return objMetCuota.VisualizarAlumnosporSalaTurno(nombre_sala, turno_sala);
       
        }

        public DataTable traerAlumnosSala(int idSala)
        {
            return objMetCuota.traerAlumnosSala(idSala);
        }

        public decimal Monto_Cuota(int idSala)

        {
            return objMetCuota.Monto_Cuota(idSala);
        
        }

        public string GeneraraCuota(decimal monto_cuota, int id_alumno)
        {
            return objMetCuota.GeneraraCuota(monto_cuota, id_alumno);
        }

        public string InsertarCuotaDetalle(int cuo_id, int idConcepto, decimal importeConcepto)
        {
            return objMetCuota.InsertarCuotaDetalle(cuo_id, idConcepto, importeConcepto);
        }

        public int ExtraerId_concepto_Cuotas(int idSala)
        {
            return objMetCuota.ExtraerId_concepto_Cuotas(idSala);
        }

        public decimal Monto_Cargos(int ID_CARGOS)
        {
            return objMetCuota.Monto_Cargos(ID_CARGOS);
        }


        public int Id_Cargo_MatDid()
        {
            return objMetCuota.Id_Cargo_MatDid();
        }


        public int Id_Cargo_HS_Extras()
        {
            return objMetCuota.Id_Cargo_HS_Extras();
        }
    }
        
}
