﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaEnt;

namespace CaAD
{
    public class metMaterias : Conexion
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;

        public DataTable buscaAlumnosXMateria(string sala)
        {
            con = generarConexion();
            con.Open();


            string consulta = "select P.PER_ID, " +
                                    "S.SAL_ID, " +
                                    "GS.GRS_ID, " +
                                    "PER_NOMBRE AS 'NOMBRE', " +
                                    "P.PER_APELLIDO AS 'APELLIDO', " +
                                    "P.PER_DOCUMENTO AS 'DOCUMENTO', " +
                                    "P.PER_LEGAJO AS 'LEGAJO' " +
                                "from T_SALA S, T_GRUPO_SALA GS, T_PERSONAS P " +
                                "WHERE S.SAL_ID = GS.GRS_SAL_ID " +
                                "AND P.PER_ID = GS.GRS_PER_ID " +
                                "AND S.SAL_ID = '"+ sala + "' " +
                                "AND P.PER_TPE_ID = 2 " +
                                "AND P.PER_FECHA_BAJA IS NULL " +
                                ";";

            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }

        public DataTable buscaProgreso(string sala_id, string edad, string etapa, string per_id)
        {
            con = generarConexion();
            con.Open();

            string consulta = "select mt_id," +
                                    "mt_nombre," +
                                    "mt_descripcion," +
                                        "( select concat(c.CAL_ID, ' - ', c.cal_progreso) " +
                                        "from T_CALIFICACIONES c " +
                                        "where c.CAL_MAT_ID = mt.MT_ID " +
                                        "and c.CAL_PER_ID = " + per_id + " " +
                                        "and c.CAL_SEMESTRE = " + etapa + " " +
                                        ") as 'calificacion' " +
                                "from T_MATERIAS m, T_MATERIA_TIPO mt " +
                                "where m.MAT_MATERIA = mt.MT_ID " +
                                "and MT_MATERIA_EDAD = " + edad + " " +
                                "and m.MAT_SAL_ID = " + sala_id + " " +
                                "AND MT_MATERIA_ANO = YEAR(GETDATE()) " +
                                ";";


            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }

        public string EditarCalificacion(string id_calificacion, string nueva_observacion)
        {
            string estado = "ERROR";

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "UPDATE T_CALIFICACIONES " +
                    "SET CAL_PROGRESO = '" + nueva_observacion + "' " +
                    "WHERE CAL_ID = " + id_calificacion + " " +
                    ";";



                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                estado = "OK";

            }
            catch
            {
                estado = "ERROR";
                
            }

            return estado;
        }

        public string InsertarCalificacion(Int32 mat_id, string nueva_observacion, string v_per_id, string v_etapa)
        {
            string estado = "ERROR";

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "INSERT INTO T_CALIFICACIONES VALUES( " +
                                    "" + Convert.ToString(mat_id) + ", " +
                                    "'" + nueva_observacion + "', " +
                                    "NULL," +
                                    "" + v_per_id + ", " +
                                    "" + v_etapa + " " +
                                    ");";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                estado = "OK";

            }
            catch
            {
                estado = "ERROR";
                
            }

            return estado;
        }

        public DataTable buscaMateriaXEdad(string edad)
        {
            con = generarConexion();
            con.Open();

            //string consulta = "SELECT * " +
            //    "FROM T_MATERIA_TIPO MT " +
            //    "WHERE MT.MT_MATERIA_ANO = YEAR(GETDATE()) " +
            //    "AND MT.MT_MATERIA_EDAD = " + edad + " " +
            //    ";";


            string consulta = "SELECT MT_ID ID, " +
                                     "MT_NOMBRE APRENDIZAJE, " +
                                     "MT_DESCRIPCION DESCRIPCIÓN, " +
                                     "MT_MATERIA_ANO ANIO, " +
                                     "MT_MATERIA_EDAD EDAD " +
                                "FROM T_MATERIA_TIPO MT " +
                               "WHERE MT.MT_MATERIA_ANO = YEAR(GETDATE()) " +
                                 "AND MT.MT_MATERIA_EDAD = " + edad + ";";


            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;
        }

        public string editarMateria(string id, string Nom, string Descr)
        {
            string estado = "ERROR";

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "update T_MATERIA_TIPO " +
                                    "set MT_NOMBRE = '" + Nom + "' " +
                                    ", MT_DESCRIPCION = '" + Descr + "' " +
                                    "where mt_id = " + id + " " +
                                   ";";



                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                estado = "OK";

            }
            catch
            {
                estado = "ERROR";

            }

            return estado;
        }

        public string EliminarMateria(string mat_id)
        {
            string estado = "ERROR";

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "delete from T_MATERIA_TIPO " +
                                    "where mt_id = " + mat_id + " " +
                                   ";";



                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                estado = "OK";

            }
            catch
            {
                estado = "ERROR";

            }

            return estado;
        }

        public string AgregarMateria(string nombre, string descripcion, string edad)
        {
            string result = "";
            con = generarConexion();
            con.Open();

            con = generarConexion();
            con.Open();

            string consulta = "INSERT INTO T_MATERIA_TIPO output INSERTED.MT_ID VALUES( " +
                                "'" + nombre + "', " +
                                "'" + descripcion + "', " +
                                "YEAR(GETDATE()), " +
                                "" + edad + ") ";


            cmd = new SqlCommand(consulta , con);

            Int32 devolver = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            
            con.Open();
            string consulta2 = "SELECT S.SAL_ID " +
                                "FROM T_SALA S " +
                                "WHERE " + edad + " BETWEEN S.SAL_EDAD_MIN AND S.SAL_EDAD_MAX;";


            cmd = new SqlCommand(consulta2, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);


            con.Close();

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string sala_id = "";
                    if (dr["SAL_ID"] != DBNull.Value)
                        sala_id = Convert.ToString(dr["SAL_ID"]);

                    con.Open();

                    string consulta3 = "INSERT INTO T_MATERIAS VALUES ( " +
                                        "" + devolver + ", " +
                                        "" + sala_id + ", " +
                                        "NULL, " +
                                        "NULL, " +
                                        "YEAR(GETDATE()) " +
                                        "); ";


                    cmd = new SqlCommand(consulta3, con);

                    Int32 devolver2 = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();

                }
            }


            return result;
        }


        public DataSet InformeProgreso(int idPersona, int etapa)
        {

            DataSet dset = new DataSet();

            con = generarConexion();
            con.Open();

            try
            {
                string consulta = "SELECT (PER_NOMBRE +' ' + PER_APELLIDO) ALUMNO, " +
                                         "PER_DOCUMENTO DOCUMENTO, " +
                                         "MT_MATERIA_EDAD EDAD, " +
                                         "MT_MATERIA_ANO ANIO, " +
                                         "MT_NOMBRE IDENTIDAD_Y_CONVIVENCIA, " +
                                         "MT_DESCRIPCION DESCRIPCION, " +
                                         "CAL_PROGRESO PROGRESO, " +
                                         "CAL_SEMESTRE SEMESTRE, " +
                                         "b.APRENDIZAJE LENGUAJE_Y_LITERATURA, " +
                                         "b.DESCRIPCION DESCRIPCION_LYL, " +
                                         "b.PROGRESO PROGRESO_LYL, " +
                                         "c.APRENDIZAJE MATEMATICA, " +
                                         "c.DESCRIPCION DESCRIPCION_MATEMATICA, " +
                                         "c.PROGRESO PROGRESO_MATEMATICA, " +
                                         "d.APRENDIZAJE CIENCIAS, " +
                                         "d.DESCRIPCION DESCRIPCION_CIENCIAS, " +
                                         "d.PROGRESO PROGRESO_CIENCIAS, " +
                                         "e.APRENDIZAJE ARTISTICA, " +
                                         "e.DESCRIPCION DESCRIPCION_ARTISTICA, " +
                                         "e.PROGRESO PROGRESO_ARTISTICA, " +
                                         "f.APRENDIZAJE EDFISICA, " +
                                         "f.DESCRIPCION DESCRIPCION_EDFISICA, " +
                                         "f.PROGRESO PROGRESO_EDFISICA, " +
                                         "GETDATE() FECHA " +
                                    "FROM T_CALIFICACIONES, " +
                                         "T_MATERIAS, " +
                                         "T_PERSONAS, " +
                                         "T_MATERIA_TIPO, " +
                                         "(SELECT MT_NOMBRE APRENDIZAJE, " +
                                                 "MT_DESCRIPCION DESCRIPCION, " +
                                                 "CAL_PROGRESO PROGRESO " +
                                           "FROM T_CALIFICACIONES, T_MATERIAS, T_PERSONAS, T_MATERIA_TIPO " +
                                          "WHERE PER_ID = CAL_PER_ID " +
                                          "AND CAL_MAT_ID = MAT_ID " +
                                          "AND MT_ID = MAT_ID " +
                                          "AND CAL_PER_ID = " + idPersona + " "+
                                          "AND CAL_SEMESTRE = " + etapa + " " +
                                          "AND MT_NOMBRE = 'LENGUAJE Y LITERATURA') b, " +
                                          "(SELECT MT_NOMBRE APRENDIZAJE, " +
                                                  "MT_DESCRIPCION DESCRIPCION, " +
                                                  "CAL_PROGRESO PROGRESO " +
                                            "FROM T_CALIFICACIONES, T_MATERIAS, T_PERSONAS, T_MATERIA_TIPO " +
                                           "WHERE PER_ID = CAL_PER_ID " +
                                             "AND CAL_MAT_ID = MAT_ID " +
                                             "AND MT_ID = MAT_ID " +
                                             "AND CAL_PER_ID = " + idPersona + " " +
                                             "AND CAL_SEMESTRE = " + etapa + " " +
                                             "AND MT_NOMBRE = 'MATEMÁTICA') c, " +
                                          "(SELECT MT_NOMBRE APRENDIZAJE, " +
                                                  "MT_DESCRIPCION DESCRIPCION, " +
                                                  "CAL_PROGRESO PROGRESO " +
                                            "FROM T_CALIFICACIONES, T_MATERIAS, T_PERSONAS, T_MATERIA_TIPO " +
                                           "WHERE PER_ID = CAL_PER_ID " +
                                             "AND CAL_MAT_ID = MAT_ID " +
                                             "AND MT_ID = MAT_ID " +
                                             "AND CAL_PER_ID = " + idPersona + " " +
                                             "AND CAL_SEMESTRE = " + etapa + " " +
                                             "AND MT_NOMBRE = 'CIENCIAS SOCIALES, CIENCIAS NATURALES Y TECNOLOGÍA') d, " +
                                         "(SELECT MT_NOMBRE APRENDIZAJE, " +
                                                 "MT_DESCRIPCION DESCRIPCION, " +
                                                 "CAL_PROGRESO PROGRESO " +
                                            "FROM T_CALIFICACIONES, T_MATERIAS, T_PERSONAS, T_MATERIA_TIPO " +
                                          "WHERE PER_ID = CAL_PER_ID " +
                                            "AND CAL_MAT_ID = MAT_ID " +
                                            "AND MT_ID = MAT_ID " +
                                            "AND CAL_PER_ID = " + idPersona + " " +
                                            "AND CAL_SEMESTRE = " + etapa + " " +
                                            "AND MT_NOMBRE = 'EDUCACIÓN ARTÍSTICA') e, " +
                                        "(SELECT MT_NOMBRE APRENDIZAJE, " +
                                                "MT_DESCRIPCION DESCRIPCION, " +
                                                "CAL_PROGRESO PROGRESO " +
                                          "FROM T_CALIFICACIONES, T_MATERIAS, T_PERSONAS, T_MATERIA_TIPO " +
                                         "WHERE PER_ID = CAL_PER_ID " +
                                           "AND CAL_MAT_ID = MAT_ID " +
                                           "AND MT_ID = MAT_ID " +
                                           "AND CAL_PER_ID = " + idPersona + " " +
                                           "AND CAL_SEMESTRE = " + etapa + " " +
                                           "AND MT_NOMBRE = 'EDUCACIÓN FÍSICA') f " +
                                     "WHERE PER_ID = CAL_PER_ID " +
                                       "AND CAL_MAT_ID = MAT_ID " +
                                       "AND MT_ID = MAT_ID " +
                                       "AND CAL_PER_ID = " + idPersona + " " +
                                       "AND CAL_SEMESTRE = " + etapa + " " +
                                       "AND MT_NOMBRE = 'IDENTIDAD Y CONVIVENCIA';";

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
