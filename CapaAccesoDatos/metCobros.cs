﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using System.Windows.Forms;*/ // comentar y corregir
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using CaEnt;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;
namespace CaAD//GestionJardin
{
    public class metCobros : Conexion

    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;


        public DataTable AutocompletarenCobros()
        {
            DataTable dt = new DataTable();
            con = generarConexion();

            con.Open();


            string consulta = "SELECT CONCAT(PER_NOMBRE, ', ', PER_APELLIDO, ' (', PER_DOCUMENTO, ')') NOMBRE  " +
                              "FROM T_PERSONAS " +
                              "WHERE PER_TPE_ID = 2";

            cmd = new SqlCommand(consulta, con);

            dr = cmd.ExecuteReader();
            dt.Load(dr);

            //while (dr.Read())
            //{
            //    pbarrabuscar.AutoCompleteCustomSource.Add(dr["NOMBRE"].ToString());

            //}
            //dr.Close();

            con.Close();
            return dt;



        }

        //public string ExtraerDni(MetroFramework.Controls.MetroTextBox pbarrabuscao)

        //{


        //    string info = pbarrabuscao.Text;
        //    string[] extraccion = info.Split('(', ')');

        //    return extraccion[1];

        //}



        public DataTable InsetarDatosCobrosenformBuscar(string pbarrabuscao/*, MetroFramework.Controls.MetroTextBox pnomyapell, MetroFramework.Controls.MetroTextBox pdni, MetroFramework.Controls.MetroTextBox plegajo, MetroFramework.Controls.MetroComboBox pcuotas,*/ /*MetroFramework.Controls.MetroTextBox pimporte,*/ /*MetroFramework.Controls.MetroDateTime pfechacobro,*/ /*MetroFramework.Controls.MetroComboBox pformapago*/)


        {
            DataTable dt = new DataTable();

            con = generarConexion();
            con.Open();

            metCobros ObjmetCobro = new metCobros();
            //ObjmetCobro.ExtraerDni(pbarrabuscao);

            string dniencontrado = pbarrabuscao;
            string consulta= "SELECT(PER_NOMBRE + ' ' + PER_APELLIDO) ALUMNO,"+
                               "PER_DOCUMENTO DOCUMENTO,"+
                               "CUO_NUMERO 'NUMERO DE CUOTA',"+
	                           "CUO_IMPORTE AS IMPORTE,"+
	                           "CUO_FECHA_VENC AS VENCIMIENTO,"+
	                           "CUO_ESTADO AS ESTADO "+
                               "FROM T_CUOTA_FINAL, T_PERSONAS "+
                               "WHERE PER_ID = CUO_PER_ID "+
                               "AND PER_DOCUMENTO = '"+ dniencontrado +"'"; 

            cmd = new SqlCommand(consulta, con);



            dr = cmd.ExecuteReader();
            dt.Load(dr);

            //if (dr.Read() == true)
            //{
                

                //pnomyapell.Text = dr["NOMBRE_APELLIDO"].ToString();
                //pdni.Text = dr["PER_DOCUMENTO"].ToString();
                //plegajo.Text = dr["PER_LEGAJO"].ToString();



            //}
            //else

            //{
            //    MessageBox.Show("El alumno ingresado no tiene registros de cuotas abonadas");
            //}


            con.Close();

            //con = generarConexion();
            //con.Open();
            //cmd = new SqlCommand(consulta, con);
            //dta = new SqlDataAdapter(cmd);
            //dt = new DataTable("INFO_CUOTA");
            //dta.Fill(dt);


            //pcuotas.DataSource = dt;
            //pcuotas.DisplayMember = "INFO_CUOTA";
            //pcuotas.ValueMember = "COB_ID";
            //pcuotas.SelectedItem = null;



            //con.Close();

            return dt;


        }

        //public string ExtraerImporte(MetroFramework.Controls.MetroComboBox pcuotas)

        //{
        //    string infocuota = pcuotas.Text;
        //    string[] extraer = infocuota.Split(' ');
        //    return extraer[0];

        //}

        public DataTable InsertarDatosCobrosenformAgregar(String pbarrabuscao/*, MetroFramework.Controls.MetroTextBox pnomyapell, MetroFramework.Controls.MetroTextBox pdni, MetroFramework.Controls.MetroTextBox plegajo, MetroFramework.Controls.MetroComboBox pcuotas*//*, MetroFramework.Controls.MetroTextBox pimporte,*/ /*MetroFramework.Controls.MetroDateTime pfechacobro,*/ /*MetroFramework.Controls.MetroComboBox pformapago*/)


        {

            con = generarConexion();
            con.Open();

            metCobros ObjmetCobro = new metCobros();
            //ObjmetCobro.ExtraerDni(pbarrabuscao);

            string dniencontrado = pbarrabuscao;



            string consulta = "SELECT DISTINCT (p.PER_NOMBRE + ',' + p.PER_APELLIDO)NOMBRE_APELLIDO, " +
                                                "p.PER_DOCUMENTO, " +
                                                "p.PER_LEGAJO, " +
                                                "c.CUO_FECHA_VENC, " +
                                                "CONCAT( CONCAT ('$', c.CUO_IMPORTE) ,  '  ' , c.CUO_FECHA_VENC, '  ', '(' , c.CUO_ESTADO , ')')INFO_CUOTA " +
                              "FROM T_PERSONAS p , T_CUOTA_FINAL c " +
                              "WHERE p.PER_LEGAJO = c.CUO_PER_LEGAJO " +
                              "AND p.PER_DOCUMENTO = '" + dniencontrado + "' " +
                              "AND c.CUO_ESTADO = 'ADEUDADA' ";

            cmd = new SqlCommand(consulta, con);



            dr = cmd.ExecuteReader();
            dt.Load(dr);

            //if (dr.Read() == true)
            //{


            //    pnomyapell.Text = dr["NOMBRE_APELLIDO"].ToString();
            //    pdni.Text = dr["PER_DOCUMENTO"].ToString();
            //    plegajo.Text = dr["PER_LEGAJO"].ToString();



            //}

            //else

            //{
            //    MessageBox.Show("El alumno ingresado no tiene registros de cuotas pendientes de cobro");
            //}


            con.Close();

            //con = generarConexion();
            //con.Open();
            //cmd = new SqlCommand(consulta, con);
            //dta = new SqlDataAdapter(cmd);
            //dt = new DataTable("INFO_CUOTA");
            //dta.Fill(dt);


            //pcuotas.DataSource = dt;
            //pcuotas.DisplayMember = "INFO_CUOTA";
            //pcuotas.SelectedItem = null;
            ////pcuotas.SelectedIndex = 0;



            //con.Close();

            return dt;


        }

        //public string ExtraerFechaVenc(MetroFramework.Controls.MetroComboBox pcuotas)

        //{
        //    string infocuota = pcuotas.Text;
        //    string[] extraer = infocuota.Split(' ');
        //    return extraer[2];

        //}

        public DataTable ModificarEstadoCuota(string pcuotas, string plegajo, string pbarrabuscao)

        {
            con = generarConexion();
            con.Open();
            metCobros ObjMetCobros = new metCobros();
            //ObjMetCobros.ExtraerFechaVenc(pcuotas);

            string FechaVencEncontrada = pcuotas;
            Convert.ToDateTime(FechaVencEncontrada).ToString("yyyy-MM-dd");

            string nlegajo = plegajo;
            string consulta = "UPDATE T_CUOTA_FINAL " +
                              "SET CUO_ESTADO = 'PAGADA' " +
                              "WHERE CUO_FECHA_VENC =  '" + FechaVencEncontrada + "' " +
                              "AND CUO_PER_LEGAJO = '" + nlegajo + "'";

            cmd = new SqlCommand(consulta, con);
            cmd.ExecuteNonQuery();

            con.Close();


            con = generarConexion();
            con.Open();
            metCobros ObjMetCobro = new metCobros();
            //ObjMetCobro.ExtraerDni(pbarrabuscao);

            string dniencontrado = pbarrabuscao;

            string consulta1 = "SELECT DISTINCT (p.PER_NOMBRE + ',' + p.PER_APELLIDO)NOMBRE_APELLIDO, " +
                                                "p.PER_DOCUMENTO, " +
                                                "p.PER_LEGAJO, " +
                                                "c.CUO_FECHA_VENC, " +
                                                "CONCAT( CONCAT ('$', c.CUO_IMPORTE) ,  '  ' , c.CUO_FECHA_VENC, '  ', '(' , c.CUO_ESTADO , ')')INFO_CUOTA " +
                                                "FROM T_PERSONAS p , T_CUOTA_FINAL c " +
                                                "WHERE p.PER_LEGAJO = c.CUO_PER_LEGAJO " +
                                                "AND p.PER_DOCUMENTO = '" + dniencontrado + "' " +
                                                "AND c.CUO_ESTADO = 'ADEUDADA' ";
            cmd = new SqlCommand(consulta1, con);
            dta = new SqlDataAdapter(cmd);
            dt = new DataTable("INFO_CUOTA");
            dta.Fill(dt);


            //pcuotas.DataSource = dt;
            //pcuotas.DisplayMember = "INFO_CUOTA";

            //pcuotas.SelectedItem = null;


            con.Close();

            return dt;
        }

        public string AnularCobro(int idCobro)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "UPDATE T_COBRO " +
                                  "SET COB_ESTADO = 'BAJA' " +
                                  "WHERE COB_ID = " + idCobro + ";";


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

            if (result == "OK")
            {
                result = ActualizaAnuladoEnCuota(idCobro);
            } else
            {
                result = "ERROR2";
            }


            return result;

        }

        public string ActualizaAnuladoEnCuota(int idCobro)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "UPDATE T_CUOTA_FINAL " +
                                  "SET CUO_ESTADO = 'ADEUDADA' " +
                                  "WHERE CUO_ID = ( SELECT CF.CUO_ID " +
                                                     "FROM T_COBRO C, T_CUOTA_FINAL CF " +
                                                     "WHERE C.COB_CUO_ID = CF.CUO_ID " +
                                                     "AND C.COB_ID = " + idCobro + " );";


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

        public string ExtraercoutaId(string pcuotas, string plegajo)
        {
            con = generarConexion();

            con.Open();

            metCobros ObjMetCobros = new metCobros();
            //ObjMetCobros.ExtraerFechaVenc(pcuotas);

            string nlegajo = plegajo;

            string FechaVencEncontrada = pcuotas;
            DateTime fecha = Convert.ToDateTime(FechaVencEncontrada);

            string consulta = "SELECT  c.CUO_ID CUOTA_ID " +
                              "FROM T_CUOTA_FINAL c  " +
                              "WHERE  c.CUO_FECHA_VENC = '" + FechaVencEncontrada + "' " +
                              "AND c.CUO_PER_LEGAJO = '" + nlegajo + "' " +
                              "AND c.CUO_ESTADO = 'ADEUDADA' ";
            cmd = new SqlCommand(consulta, con);
           

            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            string extraer = "";

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["CUOTA_ID"] != DBNull.Value)
                        extraer = Convert.ToString(dr["CUOTA_ID"]);
                }
            }


            con.Close();
            return extraer;



        }

        public string InsertarenTCobros(string cuoId)

        {
            string result;

            try
            {
                SqlConnection con1;
                con1 = generarConexion();
                con1.Open();


                //string cuoId = ExtraercoutaId(pcuotas, plegajo);

                string consulta = "INSERT INTO T_COBRO ( COB_CUO_ID, COB_ESTADO, COB_IMPORTE, COB_FECHA, COB_FORMA_PAGO ) " +
                                              "VALUES ( " + cuoId + ", 'TOTAL', (SELECT cf.CUO_IMPORTE FROM T_CUOTA_FINAL cf WHERE cf.CUO_ID = " + cuoId + "), GETDATE(), 'EFECTIVO');";

                cmd = new SqlCommand(consulta, con1);
                cmd.ExecuteNonQuery();
                con1.Close();

                result = "OK";

            }
            catch
            {
               result = "ERROR";
               //MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return result;
        }
        public string buscarInteresActual() // Obtengo el el interes actual 
        {
            con = generarConexion();

            con.Open();

            metCobros ObjMetCobros = new metCobros();


            string consulta = "SELECT CON_VALOR_ACTUAL from T_CONCEPTOS WHERE CON_ID = 7";
            cmd = new SqlCommand(consulta, con);


            dta = new SqlDataAdapter(cmd);
            dt = new DataTable();
            dta.Fill(dt);

            string resultado = "0";
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["CON_VALOR_ACTUAL"] != DBNull.Value)
                            resultado = Convert.ToString(dr["CON_VALOR_ACTUAL"]);
                    }
                }
            }
            con.Close();

            return resultado;
        }

        public bool insertarNuevoCobro(int idCuota, double importe, DateTime fecha, string formaPago)
        {


            try
            {
                SqlConnection con1;
                con1 = generarConexion();
                con1.Open();


                //string cuoId = ExtraercoutaId(pcuotas, plegajo);

                string consulta = "INSERT INTO T_COBRO ( COB_CUO_ID, COB_IMPORTE, COB_FECHA, COB_FORMA_PAGO) " +
                                              "VALUES ( " + idCuota + "," + importe + "," + fecha + ",'" + formaPago + "');";

                cmd = new SqlCommand(consulta, con1);
                cmd.ExecuteNonQuery();
                con1.Close();

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return false;
            }



        }
    }
}
