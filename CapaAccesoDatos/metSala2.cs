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
    public class metSala2 : Conexion
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;

        public DataTable GrillaSalas()
        {
            con = generarConexion();
            con.Open();


            string consulta = "WITH t1 AS (" +
                                       "SELECT COUNT(*) ACTIVOS, " +
                                              "SAL_NOMBRE, " +
                                              "SAL_TURNO, " +
                                              "SAL_CANT_ALUM, " +
                                              "SAL_ID " +
                                        "FROM T_GRUPO_SALA, T_SALA, T_PERSONAS " +
                                       "WHERE GRS_SAL_ID = SAL_ID " +
                                       "AND GRS_PER_ID = PER_ID " +
                                       "AND PER_TPE_ID = 2 " +
                                       "GROUP BY SAL_NOMBRE, SAL_TURNO, SAL_CANT_ALUM, SAL_ID " +
                                       "UNION " +
                                       "SELECT 0 , " +
                                              "SAL_NOMBRE, " +
                                              "SAL_TURNO, " +
                                              "SAL_CANT_ALUM, " +
                                              "SAL_ID " +
                                       "FROM T_SALA s " +
                                       "WHERE SAL_ID not in (SELECT GRS_SAL_ID FROM T_GRUPO_SALA) " +
                                       "AND SAL_ACTIVO = 'S' " +
                                       "GROUP BY SAL_NOMBRE, SAL_TURNO, SAL_CANT_ALUM, SAL_ID) " +
                               "SELECT s.SAL_ID, " +
                                      "t1.SAL_NOMBRE NOMBRE_SALA, " +
                                      "(CASE t1.SAL_TURNO WHEN 'MANANA' THEN 'MAÑANA' ELSE 'TARDE' END) TURNO, " +
                                      "CONCAT(S.SAL_EDAD_MIN, ' años', ' - ', S.SAL_EDAD_MAX, ' años') RANGO, " +
                                      "t1.SAL_CANT_ALUM CUPO_TOTAL, " +
                                      "t1.ACTIVOS CUPOS_ACTIVOS, " +
                                      "((t1.SAL_CANT_ALUM - t1.ACTIVOS)) VACANTES " +
                                "FROM t1, T_SALA S " +
                                "WHERE T1.SAL_ID = S.SAL_ID " +
                                "AND SAL_ACTIVO = 'S' " +
                                "ORDER BY RANGO, t1.SAL_NOMBRE, t1.SAL_TURNO;";
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }

        public DataTable FiltrarSala(string sala, string turno)
        {            

            con = generarConexion();
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = this.con;
            cmd.CommandText = "WITH t1 AS (SELECT COUNT(*) ACTIVOS, " +
                                                  "SAL_NOMBRE, " +
                                                  "SAL_TURNO, " +
                                                  "SAL_CANT_ALUM, " +
                                                  "SAL_ID" +
                                           " FROM T_GRUPO_SALA, T_SALA " +
                                           "WHERE GRS_SAL_ID = SAL_ID " +
                                           "GROUP BY SAL_NOMBRE, SAL_TURNO, SAL_CANT_ALUM, SAL_ID " +
                                           "UNION " +
                                           "SELECT 0 , " +
                                           "SAL_NOMBRE, " +
                                           "SAL_TURNO, " +
                                           "SAL_CANT_ALUM, " +
                                           "SAL_ID " +
                                           "FROM T_SALA s " +
                                           "WHERE SAL_ID not in (SELECT GRS_SAL_ID " +
                                                                  "FROM T_GRUPO_SALA ) " +
                                           "GROUP BY SAL_NOMBRE, SAL_TURNO, SAL_CANT_ALUM, SAL_ID) " +
                                     "SELECT s.SAL_ID, " +
                                     "t1.SAL_NOMBRE NOMBRE_SALA, " +
                                     "(CASE t1.SAL_TURNO WHEN 'MANANA' THEN 'MAÑANA' ELSE 'TARDE' END) TURNO, " +
                                     "CONCAT(S.SAL_EDAD_MIN, ' años', ' - ', S.SAL_EDAD_MAX, ' años') RANGO, " +
                                     "t1.SAL_CANT_ALUM CUPO_TOTAL, " +
                                     "t1.ACTIVOS CUPOS_ACTIVOS, " +
                                     "((t1.SAL_CANT_ALUM - t1.ACTIVOS)) CUPOS_VACANTES " +
                                     "FROM t1, T_SALA S " +
                                     "WHERE t1.SAL_ID = S.SAL_ID " +
                                     "AND UPPER(t1.SAL_NOMBRE) LIKE UPPER('" + sala + "%') " +
                                     "AND UPPER(t1.SAL_TURNO) LIKE UPPER('" + turno + "%') " +
                                     "AND SAL_ACTIVO = 'S' " +
                                     "ORDER BY RANGO, t1.SAL_NOMBRE, t1.SAL_TURNO; ";


            dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }


        public DataTable BuscarSala()
        {
            DataTable dt = new DataTable();
            con = generarConexion();
            con.Open();

            //AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();


            string consulta = "SELECT (SAL_NOMBRE + '-' + SAL_TURNO) SALA " +
                                "FROM T_SALA " +
                               "WHERE SAL_ACTIVO = 'S';"; 


            cmd = new SqlCommand(consulta, con);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            //while (dr.Read())
            //{
            //    pbarrabuscar.AutoCompleteCustomSource.Add(dr["SALA"].ToString());
            //}
            //dr.Close();

            con.Close();

            return dt;
        }

        public string InsertarSala(entSala sala)
        {
            string result;
                       

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "INSERT INTO T_SALA " +
                                                    "(SAL_NOMBRE, " +
                                                    "SAL_TURNO, " +
                                                    "SAL_EDAD_MIN, " +
                                                    "SAL_EDAD_MAX, " +
                                                    "SAL_CANT_ALUM, " +
                                                    "SAL_ACTIVO) " +
                                           "VALUES( '"+sala.SAL_NOMBRE+"','" +
                                                    ""+sala.SALA_TURNO+"'," +
                                                    ""+sala.SAL_EDAD_MIN+"," +
                                                    ""+sala.EDAD_SALA_MAX+"," +
                                                    ""+sala.SALA_CANT_ALUM+",'" +
                                                    ""+sala.SALA_ACTIVO+"');";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch (Exception ex)
            {
                result = "ERROR";
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador. Error-" + ex.ToString());
            }

            return result;
        }

        public entSala buscarSalaXid(Int32 idSala)
        {
            entSala ent = new entSala();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT * FROM T_SALA WHERE SAL_ID = "+ idSala + ";";

                cmd = new SqlCommand(consulta, con);
                dta = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dta.Fill(dt);

                con.Close();


                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        if (dr["SAL_ID"] != DBNull.Value)
                            ent.SAL_ID = Convert.ToInt32(dr["SAL_ID"]);
                        if (dr["SAL_NOMBRE"] != DBNull.Value)
                            ent.SAL_NOMBRE = Convert.ToString(dr["SAL_NOMBRE"]);
                        if (dr["SAL_TURNO"] != DBNull.Value)
                            ent.SALA_TURNO = Convert.ToString(dr["SAL_TURNO"]);
                        if (dr["SAL_EDAD_MIN"] != DBNull.Value)
                            ent.SAL_EDAD_MIN = Convert.ToInt32(dr["SAL_EDAD_MIN"]);
                        if (dr["SAL_EDAD_MAX"] != DBNull.Value)
                            ent.EDAD_SALA_MAX = Convert.ToInt32(dr["SAL_EDAD_MAX"]);
                        if (dr["SAL_CANT_ALUM"] != DBNull.Value)
                            ent.SALA_CANT_ALUM = Convert.ToInt32(dr["SAL_CANT_ALUM"]);
                        if (dr["SAL_ACTIVO"] != DBNull.Value)
                            ent.SALA_ACTIVO = Convert.ToString(dr["SAL_ACTIVO"]);

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador. Error: " + ex.ToString());
            }

            return ent;

        }

        public string EditarSala(entSala sala)
        {
            string result;


            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "UPDATE T_SALA " +
                                  "SET SAL_NOMBRE = '" + sala.SAL_NOMBRE + "'," +
                                      "SAL_TURNO = '" + sala.SALA_TURNO + "', " +
                                      "SAL_EDAD_MIN = " + sala.SAL_EDAD_MIN + ", " +
                                      "SAL_EDAD_MAX = " + sala.EDAD_SALA_MAX + ", " +
                                      "SAL_CANT_ALUM = " + sala.SALA_CANT_ALUM + 
                                  "WHERE SAL_ID = "+ sala.SAL_ID + "; ";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch (Exception ex)
            {
                result = "ERROR";
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador. Error-" + ex.ToString());

            }

            return result;
        }

        public string EliminarSala(entSala sala)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "set dateformat dmy UPDATE T_SALA SET SAL_ACTIVO = 'N' WHERE SAL_ID = " + sala.SAL_ID + ";";
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

        public string ValidarSala(string nombre, string turno)
        {

            string result;
            con = generarConexion();
            con.Open();


            string consulta = "SELECT 1 " +
                              "FROM T_SALA " +
                              "WHERE SAL_NOMBRE = '"+nombre+"' " +
                              "AND SAL_TURNO = '"+turno+"' " +
                              "AND SAL_ACTIVO = 'S';";

            cmd = new SqlCommand(consulta, con);

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                result = "SI";
            }
            else
            {
                result = "NO";
            }

            return result;

        }

    }
}
