using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
/*using System.Windows.Forms;*/ // comentar y corregir
using System.Drawing;
using CaEnt;


namespace CaAD//GestionJardin
{
    public class metConcepto : Conexion
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;


        //************************************************************
        //METODO QUE INSERTA LOS DATOS EN LA T_CONCEPTOS
        //************************************************************
        public string InsertarConcepto(entConcepto concepto)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("INSERT INTO T_CONCEPTOS " +
                                                            "(CON_CONCEPTO ," +
                                                            " CON_VALOR_ACTUAL, " +
                                                            " CON_FECHA_INI, " +
                                                            " CON_ACTIVO, " +
                                                            "CON_FECHA_ACT,"+
                                                            "CON_VALOR_ANTERIOR)"+
                                                            "VALUES " +
                                                        "('" + concepto.CON_CONCEPTO + "', " +
                                                        " " + concepto.CON_VALOR_ACTUAL.ToString().Replace(",",".") + "," +
                                                        " GETDATE(), " +
                                                        "'" + concepto.CON_ACTIVO +"',"+
                                                        "GETDATE(), " +
                                                        "'" +concepto.CON_VALOR_ANTERIOR.ToString().Replace(",", ".") + "')", con);
                cmd.ExecuteNonQuery();
                result = "SE INSERTO EL CONCEPTO: " + concepto.CON_CONCEPTO;


            }
            catch (Exception ex)
            {
                result = "NO SE INSERTO EL CONCEPTO: " + ex.ToString();
                con.Close();
            }
            return result;
        }

        public int Extraer_ultimo_idConcepto()
        {
            int id_concepto;
            con = generarConexion();
            con.Open();

            cmd = new SqlCommand("Select TOP 1 (CON_ID) FROM T_CONCEPTOS ORDER BY CON_ID DESC", con);
            
            cmd.ExecuteNonQuery();

            
            id_concepto = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return id_concepto ;

        }


        //************************************************************
        //METODO QUE VALIDA QUE LOS DATOS A INGRESAR EN LA T_CONCEPTOS NO ESTEN REPETIDOS
        //************************************************************

        public int ValidarConcepto(string p_CON_CONCEPTO, int p_CON_PERIODO)
        {
            con = generarConexion();
            con.Open();

            int result = 1;
            try
            {

                cmd = new SqlCommand("SELECT COUNT(*) CANTIDAD " +
                                     " FROM T_CONCEPTOS WHERE CON_CONCEPTO = '" + p_CON_CONCEPTO + 
                                     "' AND CON_PERIODO  = " + p_CON_PERIODO + ";", con);
          

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

                        if (dr["CANTIDAD"] != DBNull.Value)
                            result = Convert.ToInt32(dr["CANTIDAD"]);


                    }
                }
            }
            catch (Exception ex)
            {
                result = 1;
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            return result;
        }


        
        /*
        PARA BUSCAR LOS CONCEPTOS POR NOMBRE
            */
        public DataTable autocompletarBuscar()
        {
            SqlDataReader dr2;
            DataTable dt = new DataTable();
            //AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

            con = generarConexion();
            con.Open();     


                
            string consulta = "SELECT CONCAT(CON_CONCEPTO, '-', " +
                                            "CON_PERIODO, ' (', " +
                                            "CASE CON_ACTIVO " +
                                                    "WHEN 'S' THEN 'ACTIVO' " +
                                                    "WHEN 'N' THEN 'INACTIVO' " +
                                            "END, ')') AS CONCEPTO " +
                                "FROM T_CONCEPTOS; ";

            cmd = new SqlCommand(consulta, con);

            dr2 = cmd.ExecuteReader();
            dt.Load(dr2);

            
            return dt;
    

        }


        public entConcepto BuscaConcepto(string concepto, string anio, string estado)
        {
            //string result = "";
            entConcepto ent = new entConcepto();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT * " +
                                    "FROM T_CONCEPTOS " +
                                   "WHERE CON_CONCEPTO = '"+ concepto + "' " +
                                     "AND CON_PERIODO = '"+ anio + "' " +                                  
                                     "AND CON_ACTIVO = '" + estado + "' ";
              

                cmd = new SqlCommand(consulta, con);
                dta = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dta.Fill(dt);

                con.Close();


                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        //result = Convert.ToString(dr["PER_ID"]);

                        if (dr["CON_ID"] != DBNull.Value)
                            ent.CON_ID = Convert.ToInt32(dr["CON_ID"]);
                        if (dr["CON_CONCEPTO"] != DBNull.Value)
                            ent.CON_CONCEPTO = Convert.ToString(dr["CON_CONCEPTO"]);
                        if (dr["CON_VALOR_ACTUAL"] != DBNull.Value)
                            ent.CON_VALOR_ACTUAL = Convert.ToDecimal(dr["CON_VALOR_ACTUAL"]);
                        if (dr["CON_FECHA_INI"] != DBNull.Value)
                            ent.CON_FECHA_INI = Convert.ToDateTime(dr["CON_FECHA_INI"]);
                        if (dr["CON_FECHA_FIN"] != DBNull.Value)
                            ent.CON_FECHA_FIN = Convert.ToDateTime(dr["CON_FECHA_FIN"]);
                        if (dr["CON_FECHA_ACT"] != DBNull.Value)
                            ent.CON_FECHA_ACT = Convert.ToDateTime(dr["CON_FECHA_ACT"]);
                        if (dr["CON_ACTIVO"] != DBNull.Value)
                            ent.CON_ACTIVO = Convert.ToString(dr["CON_ACTIVO"]);
                        if (dr["CON_PERIODO"] != DBNull.Value)
                            ent.CON_PERIODO = Convert.ToInt32(dr["CON_PERIODO"]);
                        if (dr["CON_VALOR_ANTERIOR"] != DBNull.Value)
                            ent.CON_VALOR_ANTERIOR = Convert.ToDecimal(dr["CON_VALOR_ANTERIOR"]);

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
        

        /*
         PARA VISUALIZAR DETOS EN LA GRILLA DE MANERA GENERAL 
             */
        public DataTable Visualizar()
        {
            con = generarConexion();
            con.Open();


            string consulta = "SELECT CON_ID 'CON_ID' ," +
                                     "CON_CONCEPTO as 'CONCEPTO', " +
                                     "CON_VALOR_ACTUAL as 'VALOR ACTUAL', " +
                                     "CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_ACT, 103) as 'DESDE', " +
                                     "CON_VALOR_ANTERIOR 'VALOR ANTERIOR',  " +
                                     "CON_FECHA_ULT_ACT AS 'DESDE',"+
                                     "CON_FECHA_ACT 'HASTA',"+
                                     "CONVERT(VARCHAR(10), T_CONCEPTOS.CON_FECHA_INI, 103) as 'ALTA', " +                                     
                                     "(CASE CON_ACTIVO " +
                                        "WHEN 'S' THEN 'ACTIVO' " +
                                        "WHEN 'N' THEN 'INACTIVO' " +
                                      "END) ESTADO " +
                               "FROM T_CONCEPTOS " +
                               "ORDER BY 1,8;";
            cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            con.Close();

            return dt;

        }



        public DataTable CargaDtNombreConcepto()

        {
                       
            con = generarConexion();
            con.Open();

            cmd = new SqlCommand("SELECT CON_CONCEPTO 'CONCEPTO' from t_conceptos", con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);
            con.Close();

               return dt;
            
        }

        public decimal Extraer_Valor_Anterior_Concepto(entConcepto concepto)
        {
            con = generarConexion();
            con.Open();

            cmd = new SqlCommand("Select CON_VALOR_ACTUAL FROM T_CONCEPTOS WHERE CON_ID = " + concepto.CON_ID + "", con);

            decimal valor_actual_concepto = Convert.ToDecimal(cmd.ExecuteScalar());
            con.Close();

            return valor_actual_concepto;
        
        }
        
        
        
        // Esto solo pasaria cuando se activa un inactivo y ademas cambia el monto
       

       public string ActualizarMontoEstado(entConcepto conceptoME)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("UPDATE T_CONCEPTOS SET CON_FECHA_ACT = '"+ conceptoME.CON_FECHA_ACT+"', " +
                                                            "CON_ACTIVO = 'S', " +
                                                            "CON_VALOR_ACTUAL = "+ conceptoME.CON_VALOR_ACTUAL.ToString().Replace(",", ".") + "," +
                                                            "CON_VALOR_ANTERIOR = "+ conceptoME.CON_VALOR_ANTERIOR.ToString().Replace(",", ".") + ", " +
                                                            "CON_FECHA_FIN = '"+ conceptoME.CON_FECHA_FIN +"' " +
                                                            "WHERE CON_ID = " + conceptoME.CON_ID+"; ", con);
                cmd.ExecuteNonQuery();
                result = "SE ACTUALIZO MONTO Y ESTADO DEL CONCEPTO";


            }
            catch (Exception ex)
            {
                result = "NO SE PUDO ACTUALIZAR EL CONCEPTO: " + ex.ToString();
                con.Close();
            }
            return result;
        }

        // Esto solo pasaria cuando se inactiva un concepto activo. El monto no deberia cambiar
        public string DeshabilitarConcepto(entConcepto conceptoEN)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("UPDATE T_CONCEPTOS SET CON_FECHA_ACT = GETDATE(), " +
                                                            "CON_ACTIVO = 'N'," +
                                                            "CON_FECHA_FIN = GETDATE()" +
                                                            "WHERE CON_ID = "+ conceptoEN.CON_ID +";", con);
                cmd.ExecuteNonQuery();
                result = "SE DESHABILITO EL CONCEPTO";

            }
            catch (Exception ex)
            {
                result = "NO SE PUDO DESHABILITAR EL CONCEPTO: " + ex.ToString();
                con.Close();
            }
            return result;
        }

        // Esto solo pasaria cuando SOLO se activa un concepto inactivo y el monto no cambia
        public string ActualizarEstadoS(entConcepto conceptoES)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("UPDATE T_CONCEPTOS SET CON_FECHA_ACT = GETDATE(), " +
                                                            "CON_ACTIVO = 'S', " +
                                                            "CON_FECHA_FIN =  GETDATE()" +
                                                            "WHERE CON_ID = " + conceptoES.CON_ID + ";", con);
                cmd.ExecuteNonQuery();
                result = "SE HABILITO EL CONCEPTO";


            }
            catch (Exception ex)
            {
                result = "NO SE PUDO HABILITAR EL CONCEPTO: " + ex.ToString();
                con.Close();
            }
            return result;
        }

        //Cuando solo se modifica el monto de un concepto Activo
        public string ActualizarMonto(entConcepto conceptoM, string p_fecha_hasta,string p_fecha_ult_act)
        {

            con = generarConexion();
            string result;

            try
            {

                con.Open();
                //el SqlCommand se usa para realizar consultas a la base
                cmd = new SqlCommand("UPDATE T_CONCEPTOS SET CON_FECHA_ACT = GETDATE()," +
                                                            "CON_VALOR_ACTUAL = " + conceptoM.CON_VALOR_ACTUAL.ToString().Replace(",", ".") + ", " +
                                                             "CON_VALOR_ANTERIOR = " + conceptoM.CON_VALOR_ANTERIOR.ToString().Replace(",", ".") + ", " +
                                                             "CON_FECHA_ULT_ACT = CAST('" + p_fecha_ult_act+"'AS DATE), " +
                                                             "CON_FECHA_HASTA = CAST ('" + p_fecha_hasta + "'AS DATE)" +
                                                             "WHERE CON_ID = " + conceptoM.CON_ID + "; ", con);

                cmd.ExecuteNonQuery();


                
                cmd.ExecuteNonQuery();
                
                result = "SE ACTUALIZO EL MONTO DEL CONCEPTO";


            }
            catch (Exception ex)
            {
                result = "NO SE PUDO ACTUALIZAR EL MONTO DEL CONCEPTO: " + ex.ToString();
                con.Close();
            }
            return result;
        }

       



    }
}
