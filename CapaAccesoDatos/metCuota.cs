﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using System.Windows.Forms;*/ //comentar y corregir
using CaEnt;

namespace CaAD//GestionJardin
{
    public class metCuota : Conexion
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;

        public entSala.entSalaColeccion buscarSalas()
        {
            entSala.entSalaColeccion SalaCol = new entSala.entSalaColeccion();

            try
            {

                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select CONCAT(u.SAL_NOMBRE, ' ', u.SAL_TURNO) NOMBRE, u.* " +
                                    "from T_SALA u " +
                                    ";";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                da.Fill(ds, "T_SALA");
                dt = ds.Tables[0];
                con.Close();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        entSala ent = new entSala();
                        if (dr["SAL_ID"] != DBNull.Value)
                            ent.SAL_ID = Convert.ToInt32(dr["SAL_ID"]);
                        if (dr["SAL_NOMBRE"] != DBNull.Value)
                            ent.SAL_NOMBRE = Convert.ToString(dr["SAL_NOMBRE"]);
                        if (dr["SAL_EDAD_MIN"] != DBNull.Value)
                            ent.SAL_EDAD_MIN = Convert.ToInt32(dr["SAL_EDAD_MIN"]);
                        if (dr["SAL_EDAD_MAX"] != DBNull.Value)
                            ent.EDAD_SALA_MAX = Convert.ToInt32(dr["SAL_EDAD_MAX"]);
                        if (dr["SAL_CANT_ALUM"] != DBNull.Value)
                            ent.SALA_CANT_ALUM = Convert.ToInt32(dr["SAL_CANT_ALUM"]);
                        if (dr["SAL_TURNO"] != DBNull.Value)
                            if (Convert.ToString(dr["SAL_TURNO"]) == "MANANA    ") {

                                ent.SALA_TURNO = "MAÑANA";

                            } else
                            {
                                ent.SALA_TURNO = "TARDE";
                            }

                        if (dr["SAL_ACTIVO"] != DBNull.Value)
                            ent.SALA_ACTIVO = Convert.ToString(dr["SAL_ACTIVO"]);

                        ent.SAL_NOMBRE = ent.SAL_NOMBRE + " " + ent.SALA_TURNO;

                        SalaCol.Add(ent);
                    }
                }


            }
            catch (Exception ex)
            {

                //MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return SalaCol;

        }

        public DataTable traeConceptos(int añoEjercicio)
        {
            SqlConnection con = generarConexion();
            con.Open();

            SqlCommand com = new SqlCommand();
            com.Connection = con;

            com.CommandText = "SELECT C.CON_ID ID, C.CON_CONCEPTO CONCEPTO, C.CON_VALOR_ACTUAL VALOR " +
                                "FROM T_CONCEPTOS C " +
                                "WHERE C.CON_ACTIVO = 'S' " +
                                "AND C.CON_PERIODO = " + añoEjercicio + ";";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            da.Fill(ds, "T_CONCEPTOS");
            dt = ds.Tables[0];
            con.Close();

            return dt;
        }

        public string insertaCuotaFinal(string legajo, int periodoCuota, int anoCuota, string estadoCuota)
        {
            string result;

            try
            {
                DateTime fechaVenc;
                string consulta;

                if (periodoCuota == 0) {

                    consulta = "INSERT INTO T_CUOTA_FINAL" +
                                        "(CUO_PER_LEGAJO" +
                                        ", CUO_NUMERO" +
                                        ", CUO_ANO_CUOTA" +
                                        ", CUO_ESTADO" +
                                        ", CUO_FECHA_EMISION)" +
                                    "VALUES " +
                                        "('" + legajo + "'" +
                                        ", '" + periodoCuota + "'" +
                                        ", '" + anoCuota + "'" +
                                        ", '" + estadoCuota + "'" +
                                        ", GETDATE()" +
                                        ");";

                } else
                {
                    string mes = Convert.ToString(periodoCuota + 2);
                    mes.PadLeft(2, '0');
                    fechaVenc = Convert.ToDateTime("10/" + mes + "/2020");

                    consulta = "INSERT INTO T_CUOTA_FINAL" +
                                        "(CUO_PER_LEGAJO" +
                                        ", CUO_NUMERO" +
                                        ", CUO_ANO_CUOTA" +
                                        ", CUO_ESTADO" +
                                        ", CUO_FECHA_VENC" +
                                        ", CUO_FECHA_EMISION)" +
                                    "VALUES " +
                                        "('" + legajo + "'" +
                                        ", '" + periodoCuota + "'" +
                                        ", '" + anoCuota + "'" +
                                        ", '" + estadoCuota + "'" +
                                        ", '" + fechaVenc + "'" +
                                        ", GETDATE()" +
                                        ");";
                }

                con = generarConexion();
                con.Open();

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

        public string InsertarCuotaDetalle(int cuo_id, int idConcepto, decimal importeConcepto)
        {
            string result;

            try
            {


                con = generarConexion();
                con.Open();
                string consulta = "INSERT INTO T_CUOTA_DETALLE" +
                                        "(DET_CUO_ID" +
                                        ", DET_CON_ID" +
                                        ", DET_IMPORTE" +
                                        ", DET_CANTIDAD" +
                                        ", DET_ACTIVO)" +
                                    "VALUES " +
                                        "("+cuo_id+" " +
                                        ", "+idConcepto+" " +
                                        ", "+ importeConcepto.ToString().Replace(",", ".")+ " "+
                                        ", 1" +
                                        ", 'S'" +
                                        ");";


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

        public string ActualizaMontoCuotaFinal(string legajo, int periodoCuota, int anoCuota, int importeConcepto)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "UPDATE T_CUOTA_FINAL SET CUO_IMPORTE = " + importeConcepto + " WHERE CUO_PER_LEGAJO = '" + legajo + "' AND CUO_ANO_CUOTA = " + anoCuota + " AND CUO_NUMERO = " + periodoCuota + " AND CUO_ESTADO = 'ADEUDADA';";


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

        public int CuentaCuotasValidacion(string legajo, int periodoCuota, int anoCuota)
        {
            int result = 1;

            try
            {
                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "SELECT COUNT(*) CUENTA FROM T_CUOTA_FINAL CF WHERE CF.CUO_ANO_CUOTA = " + anoCuota + " AND CF.CUO_PER_LEGAJO = '" + legajo + "' AND CF.CUO_NUMERO = " + periodoCuota + " AND CUO_ESTADO <> 'BAJA' AND CF.CUO_NUMERO <> 99; ";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dt = ds.Tables[0];
                con.Close();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        if (dr["CUENTA"] != DBNull.Value)
                            result = Convert.ToInt32(dr["CUENTA"]);


                    }
                }

            }
            catch
            {
                result = 1;
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return result;
        }

        public string traeLegajo(string nombre, string apellido, string documento)
        {
            string legajo = "";

            try
            {
                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select p.PER_LEGAJO LEGAJO " +
                                    "from T_PERSONAS p " +
                                    "where p.PER_NOMBRE = '" + nombre + "' " +
                                    "and p.PER_APELLIDO = '" + apellido + "' " +
                                    "and p.PER_DOCUMENTO = '" + documento + "' " +
                                    "; ";

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dt = ds.Tables[0];
                con.Close();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        if (dr["LEGAJO"] != DBNull.Value)
                            legajo = Convert.ToString(dr["LEGAJO"]);


                    }
                }


            }
            catch
            {
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return legajo;
        }

        public DataTable traeCuotasXPersona(string legajo)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select cf.CUO_ID ID, cf.CUO_PER_LEGAJO LEGAJO, cf.CUO_NUMERO NUMERO, cf.CUO_ANO_CUOTA EJERCICIO, cf.CUO_ESTADO ESTADO, cf.CUO_IMPORTE IMPORTE, cf.CUO_FECHA_VENC VENCIMIENTO " +
                                    "from T_CUOTA_FINAL cf " +
                                    "where cf.CUO_PER_LEGAJO = '" + legajo + "' " +
                                    "and cf.CUO_ESTADO <> 'BAJA' " +
                                    "order by cf.CUO_NUMERO, cf.CUO_ANO_CUOTA desc; ";


                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dt = ds.Tables[0];
                con.Close();


            }
            catch
            {
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return dt;

        }

        public string bajaCuotaFinal(int idCuotaFinal)
        {
            string result = "";
            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "UPDATE T_CUOTA_FINAL SET CUO_ESTADO = 'BAJA' WHERE CUO_ID = '" + idCuotaFinal + "';";


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

        public DataTable VisualizarAlumnosporSalaTurno(string nombre_sala, string turno_sala)
        {


            con = generarConexion();
            con.Open();

            cmd = new SqlCommand("SELECT distinct p.PER_ID AS 'PER_ID'," +
                                     "CONCAT(p.PER_APELLIDO , p.PER_NOMBRE) AS 'ALUMNO', " +
                                     "p.PER_DOCUMENTO AS 'DOCUMENTO'" +
                                      "from T_PERSONAS p, T_SALA s," +
                                     " T_GRUPO_SALA g WHERE g.GRS_PER_ID = p.PER_ID and" +
                                     " g.GRS_SAL_ID = s.SAL_ID AND s.SAL_NOMBRE= '" + nombre_sala + "' and " +
                                     "s.SAL_TURNO ='" + turno_sala + "' AND p.PER_TPE_ID = 2" +
                                     " AND p.PER_ESTADO = 'S';", con);

            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);
            con.Close();

            return dt;
        }

        public DataTable traerAlumnosSala(int idSala)
        {
            con = generarConexion();

            DataTable dt = new DataTable();
            con.Open();

            string consulta = "SELECT DISTINCT PER_ID, " +
                                     "CONCAT(PER_APELLIDO, ', ', PER_NOMBRE) ALUMNO, " +
                                     "PER_DOCUMENTO 'DOCUMENTO' , " +
                                     "CUO_NUMERO 'CUOTA N°', CONCAT('$', CUO_IMPORTE)'IMPORTE CUOTA', " +
                                     "CUO_FECHA_EMISION 'FECHA EMISION', " +
                                     "CUO_FECHA_VENC 'FECHA VENCIMIENTO'," +
                                     "CUO_ESTADO 'ESTADO' " +
                                "FROM T_GRUPO_SALA, T_PERSONAS, T_CUOTA_FINAL " +
                               "WHERE PER_ID = GRS_PER_ID " +
                                 "AND CUO_PER_ID = PER_ID " +
                                 "AND GRS_SAL_ID = @salaID " +
                                 "AND PER_TPE_ID = 2 " +
                                 "AND PER_ESTADO = 'S' " +
                                 "AND MONTH(CUO_FECHA_EMISION) = MONTH(GETDATE()) " +
                               "UNION " +
                              "SELECT DISTINCT PER_ID, CONCAT(PER_APELLIDO, ', ', PER_NOMBRE) ALUMNO, " +
                                     "PER_DOCUMENTO 'DOCUMENTO', " +
                                     "NULL 'CUOTA N°', " +
                                     "NULL 'IMPORTE CUOTA', " +
                                     "NULL 'FECHA EMISION', " +
                                     "NULL 'FECHA VENCIMIENTO'," +
                                     "NULL 'ESTADO' " +
                               "FROM T_GRUPO_SALA, T_PERSONAS " +
                              "WHERE PER_ID = GRS_PER_ID " +
                                "AND GRS_SAL_ID = @salaID " +
                                "AND PER_TPE_ID = 2 " +
                                "AND PER_ESTADO = 'S' " +
                                "AND PER_ID NOT IN(SELECT CUO_PER_ID FROM T_CUOTA_FINAL);";

            cmd = new SqlCommand(consulta, con);

            cmd.Parameters.Add(new SqlParameter("@salaID", idSala));

            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();

            con.Close();
            return dt;

        }


        public decimal Monto_Cuota(int idSala)

        {
            con = generarConexion();
            con.Open();

            string consulta = "SELECT CON_VALOR_ACTUAL FROM T_CONCEPTOS, T_SALA WHERE CON_ID = @salaID +1";
            cmd = new SqlCommand(consulta, con);

            cmd.Parameters.Add(new SqlParameter("@salaID", idSala));

            decimal monto_cuota = Convert.ToDecimal(cmd.ExecuteScalar());
            con.Close();

            return monto_cuota;

        }


        public int ExtraerId_concepto_Cuotas (int idSala)
            {
            con = generarConexion();
            con.Open();

             string consulta = "SELECT CON_ID FROM T_CONCEPTOS, T_SALA WHERE CON_ID = @salaID +1";
             cmd = new SqlCommand(consulta, con);
             cmd.Parameters.Add(new SqlParameter("@salaID", idSala));
          
            int id_concepto_cuota = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return id_concepto_cuota;
            }


        public string GeneraraCuota(decimal monto_cuota, int id_alumno )
        {
            string id_cuota;
            string RESULTADO;
            DateTime fecha = DateTime.Today;
            string fecha_emision = DateTime.Today.ToString("yyyy-MM-dd");
            int numero_cuota = Convert.ToInt32(fecha.Month.ToString())- 2;


            int dia = 10;

            string fecha_vencimiento = fecha.AddDays(-fecha.Day).AddDays(dia).ToString("yyyy-MM-dd");

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "INSERT INTO T_CUOTA_FINAL " +
                                                         "(CUO_NUMERO, " +
                                                         "CUO_ANO_CUOTA, " +
                                                         "CUO_ESTADO, " +
                                                         "CUO_IMPORTE, " +
                                                         "CUO_FECHA_VENC, " +
                                                         "CUO_FECHA_EMISION, " +
                                                         "CUO_PER_ID) " +
                                               "VALUES " +
                                                         "(" + numero_cuota + "," +
                                                            "2020, " +
                                                            "'ADEUDADA', " +
                                                            "" + monto_cuota.ToString().Replace(",", ".") + ", " +
                                                            "CAST('" + fecha_vencimiento + "' AS DATE), " +
                                                            "CAST ('" + fecha_emision + "' AS DATE), " +
                                                            "" + id_alumno + "); SELECT SCOPE_IDENTITY();"; 


                cmd = new SqlCommand(consulta, con);
               // cmd.ExecuteNonQuery();
                id_cuota =cmd.ExecuteScalar().ToString();
                con.Close();

                RESULTADO = id_cuota;
            }

            catch (Exception ex)
            {
                                
                RESULTADO = "CUOTA NO GENERADA" + ex.ToString(); 
                con.Close();
            }

            return RESULTADO; 
        }


        public string GeneraraMatricula(decimal monto_cuota, int id_alumno)
        {
            string id_cuota;
            string RESULTADO;           
            string fecha_emision = DateTime.Today.ToString("yyyy-MM-dd");
            int numero_cuota = 0;
           

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "INSERT INTO T_CUOTA_FINAL " +
                                                         "(CUO_NUMERO, " +
                                                         "CUO_ANO_CUOTA, " +
                                                         "CUO_ESTADO, " +
                                                         "CUO_IMPORTE, " +
                                                         "CUO_FECHA_VENC, " +
                                                         "CUO_FECHA_EMISION, " +
                                                         "CUO_PER_ID) " +
                                               "VALUES " +
                                                         "(" + numero_cuota + "," +
                                                            "2020, " +
                                                            "'ADEUDADA', " +
                                                            "" + monto_cuota.ToString().Replace(",", ".") + ", " +
                                                            "CAST('" + fecha_emision + "' AS DATE), " +
                                                            "CAST ('" + fecha_emision + "' AS DATE), " +
                                                            "" + id_alumno + ");";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
               // id_cuota = cmd.ExecuteScalar().ToString();
                con.Close();

                RESULTADO = "OK";
            }

            catch (Exception ex)
            {

                RESULTADO = "MATRICULA NO GENERADA" + ex.ToString();
                con.Close();
            }

            return RESULTADO;
        }


        public decimal Monto_Matricula()
        {
            con = generarConexion();
            con.Open();

            string consulta = "SELECT CON_VALOR_ACTUAL FROM T_CONCEPTOS WHERE CON_ID = 1";
            cmd = new SqlCommand(consulta, con);                     

            decimal monto_matricula = Convert.ToDecimal(cmd.ExecuteScalar());
            con.Close();

            return monto_matricula;

        }

        public int cuoId(int perId)
        {
            con = generarConexion();
            con.Open();

            int result = 2;
            try
            {

                cmd = new SqlCommand("SELECT CUO_ID " +
                                       "FROM T_CUOTA_FINAL " +
                                      "WHERE CUO_NUMERO = (SELECT TOP 1 CUO_NUMERO FROM T_CUOTA_FINAL WHERE CUO_PER_ID = "+ perId + " " +
                                                           "ORDER BY CUO_FECHA_EMISION ASC) " +
                                        "AND CUO_PER_ID = " + perId + ";", con);


                dt = new DataTable();
                dta = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                dta.Fill(ds);
                dt = ds.Tables[0];
                con.Close();

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {

                        if (dr["CUO_ID"] != DBNull.Value)
                            result = Convert.ToInt32(dr["CUO_ID"]);


                    }
                }
            }
            catch (Exception ex)
            {
                result = 2;
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador. Error " + ex.ToString());

            }


            return result;
        }

        public DataSet reciboMatricula(int per_id)
        {

            DataSet dset = new DataSet();

            con = generarConexion();
            con.Open();

            try
            {
                string consulta = "SELECT PER_NOMBRE + ' ' + PER_APELLIDO ALUMNO, " +
                                         "PER_DOCUMENTO DOCUMENTO, " +
                                         "CON_CONCEPTO CONCEPTO, " +
                                         "CONCAT('$',' ', CUO_IMPORTE) IMPORTE, " +
                                         "CUO_FECHA_VENC FECHA_VENCIMIENTO, " +
                                         "CUO_FECHA_EMISION FECHA_EMISION, " +
                                         "CUO_ESTADO ESTADO, " +
                                         "CUO_NUMERO NUMERO, " +
                                         "GETDATE() FECHA " +
                                    "FROM T_CUOTA_FINAL, T_CUOTA_DETALLE, T_CONCEPTOS, T_PERSONAS " +
                                   "WHERE CUO_ID = DET_CUO_ID " +
                                     "AND DET_CON_ID = CON_ID " +
                                     "AND CUO_PER_ID = PER_ID " +
                                     "AND CUO_PER_ID = "+ per_id + "; ";

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
