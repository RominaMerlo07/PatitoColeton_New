using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaEnt;
using System.Data;
using System.Data.SqlClient;

namespace CaAD
{
  public class metHistorial : Conexion


    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;
        public string InsertarHistorialConceptos(entHistorial historial, string phis_hasta,string phis_desde )

        {
            con = generarConexion();
            string result;

            try
            {

                con.Open();

                cmd = new SqlCommand("INSERT INTO T_HISTORIAL" +
                                       "(HIS_HASTA," +
                                       "HIS_CON_ID, " +
                                       "HIS_DESDE, " + 
                                       " HIS_VALOR_ANTERIOR)" +
                                       "VALUES" +
                                       "(CAST ('"+phis_hasta+"' AS DATE), "+historial.HIS_CON_ID +",CAST('"+phis_hasta+"' AS DATE),"+ 
                                       "" + historial.HIS_VALOR_ANTERIOR.ToString().Replace(",", ".") + " )", con);

                cmd.ExecuteNonQuery();

                result = "SE CARGÓ HISTORIAL";


            }
            catch (Exception ex)
            {
                result = "NO SE PUDO CARGAR EL HISTORIAL " + ex.ToString();
                con.Close();
            }


            return result;

        }

    }
}
