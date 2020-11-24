using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using System.Windows.Forms;*/ // comentar y corregir
using CaEnt;

namespace CaAD//GestionJardin
{
    public class metGrupoFlia : Conexion
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;


        public string insertaEnGrupoFlia(int idPersonaIngresada, string legajo)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "INSERT INTO T_GRUPO_FLIA " +
                                                "(GRF_PER_ID" +
                                                ", GRF_TUTOR" +
                                                ", GRF_AUTORIZADO" +
                                                ", GRF_GRUPO_LEGAJO" +
                                                ", GRF_OBSERVACION) " +
                                        "VALUES " +
                                                "('" + idPersonaIngresada + "'" +
                                                ", 'N'" +
                                                ", 'N'" +
                                                ", '" + legajo + "'" +
                                                ", NULL);";



                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch (Exception ex)
            {
                result = "ERROR";
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador." +  ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return result;
        }

        public DataTable traerPersonasXGrupoFliar(string idPersona) {
            
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select" +
                                    "(select CONCAT(p.PER_NOMBRE, ' ', p.PER_APELLIDO) from T_PERSONAS p where p.PER_ID = GF2.GRF_PER_ID) NOMBRE, " +
                                    "(select tp.TPE_NOMBRE from T_PERSONAS p, T_TIPO_PERSONA tp where tp.TPE_ID = p.PER_TPE_ID and p.PER_ID = GF2.GRF_PER_ID) RELACION " +
                                    "from T_GRUPO_FLIA gf2 " +
                                    "where gf2.GRF_GRUPO_LEGAJO in " +
                                                "(select gf.GRF_GRUPO_LEGAJO " +
                                                "from T_GRUPO_FLIA GF " +
                                                "where gf.GRF_PER_ID = " + idPersona + ");";

                
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dt = ds.Tables[0];
                con.Close();

                
            }
            catch (Exception ex)
            {
                 //MessageBox.Show("Hubo un problema. Contáctese con su administrador." + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return dt;
        }

        public DataTable traerPersonasXGrupoFliar2(string idPersona)
        {

            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "SELECT p.per_id, " +
                                  "CONCAT(P.PER_APELLIDO, ', ', P.PER_NOMBRE) AS 'NOMBRE', " +
                                  "P.PER_DOCUMENTO AS 'DOCUMENTO', " +
                                  "(CASE WHEN GF.GRF_OBSERVACION IS NULL AND P.PER_TPE_ID = 2 THEN 'ALUMNO' ELSE GF.GRF_OBSERVACION END) 'PARENTESCO', " +
                                  "(CASE gf.GRF_TUTOR WHEN 'S' THEN 'SI' WHEN 'N' THEN 'NO' END) as 'TUTOR', " +
                                  "(CASE GF.GRF_AUTORIZADO WHEN 'S' THEN 'SI' WHEN 'N' THEN 'NO' END) AS 'RETIRAR', " +
                                  "P.PER_FECHA_NAC AS 'FECHA NACIMIENTO', " +
                                  "DATEDIFF(YEAR, P.PER_FECHA_NAC, GETDATE()) AS 'EDAD', " +
                                  "CONCAT(D.DOM_CALLE, ', Nº: ', D.DOM_NUMERO, '. BARRIO: ', D.DOM_BARRIO, ', CP: ', D.DOM_CP, ' ', D.DOM_PROVINCIA) AS 'DOMICILIO', " +
                                  "P.PER_TELEFONO_2 AS 'CELULAR', " +
                                  "P.PER_TELEFONO AS 'TELEFONO' " +
                                  "FROM T_GRUPO_FLIA gf, T_PERSONAS p, T_DOMICILIOS d " +
                                  "WHERE p.PER_ID = gf.GRF_PER_ID " +
                                  "AND p.per_id = d.DOM_PER_ID " +
                                  "AND P.PER_FECHA_BAJA IS NULL " +
                                  "AND gf.GRF_GRUPO_LEGAJO = (SELECT gf2.GRF_GRUPO_LEGAJO " +
                                                               "FROM T_GRUPO_FLIA gf2 " +
                                                               "WHERE gf2.GRF_PER_ID = " + idPersona + ") " +
                                  "ORDER BY P.PER_DOCUMENTO DESC;";




                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dt = ds.Tables[0];
                con.Close();


            }
            catch (Exception ex)
            {
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador." + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return dt;
        }

        public string insertaEnGrupoFlia2(entGrupoFlia grpFlia)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "INSERT INTO T_GRUPO_FLIA " +
                                                "(GRF_PER_ID" +
                                                ", GRF_TUTOR" +
                                                ", GRF_AUTORIZADO" +
                                                ", GRF_GRUPO_LEGAJO" +
                                                ", GRF_OBSERVACION) " +
                                        "VALUES " +
                                                "('" + grpFlia.GRF_PER_ID + "'" +
                                                ", '" + grpFlia.GRF_TUTOR + "'" +
                                                ", '" + grpFlia.GRF_AUTORIZADO + "'" +
                                                ", '" + grpFlia.GRF_PER_LEGAJO + "'" +
                                                ", '" + grpFlia.GRF_OBSERVACION + "');";



                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch (Exception ex)
            {
                result = "ERROR";
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador." + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return result;
        }

        public entGrupoFlia traerGrpFlia(int idPersona)
        {
            entGrupoFlia ent = new entGrupoFlia();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "select * from T_GRUPO_FLIA gf where gf.GRF_PER_ID = '" + idPersona + "';";

                cmd = new SqlCommand(consulta, con);
                dta = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dta.Fill(dt);

                con.Close();


                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["GRF_ID"] != DBNull.Value)
                            ent.GRF_ID = Convert.ToInt32(dr["GRF_ID"]);
                        if (dr["GRF_PER_ID"] != DBNull.Value)
                            ent.GRF_PER_ID = Convert.ToInt32(dr["GRF_PER_ID"]);
                        if (dr["GRF_AUTORIZADO"] != DBNull.Value)
                            ent.GRF_AUTORIZADO = Convert.ToString(dr["GRF_AUTORIZADO"]);
                        if (dr["GRF_OBSERVACION"] != DBNull.Value)
                            ent.GRF_OBSERVACION = Convert.ToString(dr["GRF_OBSERVACION"]);
                        if (dr["GRF_TUTOR"] != DBNull.Value)
                            ent.GRF_TUTOR = Convert.ToString(dr["GRF_TUTOR"]);
                        if (dr["GRF_GRUPO_LEGAJO"] != DBNull.Value)
                            ent.GRF_PER_LEGAJO = Convert.ToString(dr["GRF_GRUPO_LEGAJO"]);
                    }
                }

            }
            catch
            {
                //result = "ERROR";
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return ent;
        }

        public string editaGrFlia(entGrupoFlia grupoFlia)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "update T_GRUPO_FLIA " +
                    "set grf_tutor = '" + grupoFlia.GRF_TUTOR + "', " +
                    "grf_autorizado = '" + grupoFlia.GRF_AUTORIZADO + "', " +
                    "grf_observacion = '" + grupoFlia.GRF_OBSERVACION + "' " +
                    "where grf_id = " + grupoFlia.GRF_ID + 
                    ";";

                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }

            catch
            {
                result = "ERROR";
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;

        }

        public DataSet listaGrupoFlia(string idPersona)
        {

            DataSet dset = new DataSet();

            con = generarConexion();
            con.Open();

            try
            {
                string consulta = "SELECT (PER_NOMBRE + ' '+ PER_APELLIDO) NOMBRE, " +
                                          "PER_DOCUMENTO DOCUMENTO, " +
                                          "(CASE WHEN GRF_OBSERVACION IS NULL AND PER_TPE_ID = 2 THEN 'ALUMNO' ELSE GRF_OBSERVACION END) PARENTESCO, " +
                                          "CASE GRF_TUTOR WHEN 'N' THEN 'NO' ELSE 'SI' END TUTOR, " +
                                          "CASE GRF_AUTORIZADO WHEN 'N' THEN 'NO' ELSE 'SI' END AUTORIZADO, " +
                                          "PER_TELEFONO_2 CELULAR, " +
                                          "PER_TELEFONO TELEFONO, " +
                                          "PER_EMAIL EMAIL, " +
                                          "GETDATE() FECHA " +
                                    "FROM T_PERSONAS, T_GRUPO_FLIA " +
                                   "WHERE PER_ID = GRF_PER_ID " +
                                     "AND GRF_GRUPO_LEGAJO = '"+idPersona+"'" +
                                     "ORDER BY PER_DOCUMENTO DESC;";

                cmd = new SqlCommand(consulta, con);
                dta = new SqlDataAdapter(cmd);
                dta.Fill(dset);

                con.Close();


                return dset;
            }
            catch (Exception ex)
            {

            }
            return dset;

        }

    }
}
