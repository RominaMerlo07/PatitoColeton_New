﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace GestionJardin
{
    public class metPersonas : Conexion
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt;
        SqlDataReader dr;
        DataTable cardoc;


        public AutoCompleteStringCollection traerPersonasAutocompetar(string tipo_persona) //FILTRA POR TIPO DE PERSONA. "0" TRAE TODOS. 
        {
            string tipoPersona;

            if (tipo_persona == "0")
            {
                tipoPersona = ";";

            }
            else
            {
                tipoPersona = "WHERE PER_TPE_ID = " + tipo_persona + "ORDER BY 1;";
            }

            con = generarConexion();

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            con.Open();


            string consulta = "SELECT CONCAT(PER_NOMBRE, ', ', PER_APELLIDO, ' (', PER_DOCUMENTO, ')') FROM T_PERSONAS " + tipoPersona;

            //"SELECT CONCAT(PER_NOMBRE, ', ', PER_APELLIDO, ' (', PER_DOCUMENTO, ')') FROM T_PERSONAS P " + tipoPersona;
            cmd = new SqlCommand(consulta, con);

            dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                autoComplete.Add(dr.GetString(0));
            }
            dr.Close();

            con.Close();
            return autoComplete;

        }

        public DataTable TraerAlumnos()
        //public entPersona BuscaAlumnos(string nombre, string apellido, string documento)
        {
            entPersona.entPersonaColeccion col = new entPersona.entPersonaColeccion();
            DataTable dt = new DataTable();
            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT P.PER_ID, " +
                                        "CONCAT(P.PER_APELLIDO, ', ', P.PER_NOMBRE) AS 'ALUMNO', " +
                                        "P.PER_DOCUMENTO AS 'DOCUMENTO', " +
                                        "P.PER_FECHA_NAC AS 'FECHA NACIMIENTO', " +
                                        "DATEDIFF(YEAR, P.PER_FECHA_NAC, GETDATE()) AS 'EDAD', " +
                                        "CONCAT(D.DOM_CALLE, ', Nº: ', D.DOM_NUMERO, '. BARRIO: ', D.DOM_BARRIO, ', CP: ', D.DOM_CP, ' ', D.DOM_PROVINCIA) AS 'DOMICILIO', " +
                                        "P.PER_TELEFONO AS 'TELEFONO', " +
                                        "P.PER_TELEFONO_2 AS 'TELEFONO 2', " +
                                        "(CASE WHEN S.SAL_TURNO = 'MANANA' THEN 'MAÑANA' ELSE 'TARDE' END ) AS 'TURNO', " +
                                        "S.SAL_NOMBRE AS 'SALA' " +
                                    "FROM T_PERSONAS P, T_DOMICILIOS D, T_GRUPO_SALA GS, T_SALA S " +
                                    "WHERE D.DOM_PER_ID = P.PER_ID " +
                                        "AND P.PER_ID = GS.GRS_PER_ID " +
                                        "AND S.SAL_ID = GS.GRS_SAL_ID " +
                                        "AND P.PER_TPE_ID = 2 " +
                                        "AND P.PER_ESTADO = 'S' " + //ver con GASTON como esta definido, por en mi base tengo 'S'  (Romi)
                                        ";";

                cmd = new SqlCommand(consulta, con);
                dta = new SqlDataAdapter(cmd);

                dta.Fill(dt);
                con.Close();

            }
            catch(Exception ex)
            {
                //result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador. Error: " + ex.ToString());


            }

            return dt;

        }

        public entPersona BuscaPersonaxID(string idPersona)
        {

            entPersona ent = new entPersona();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT * FROM T_PERSONAS P WHERE P.PER_ID = '" + idPersona + "';";


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


                        if (dr["PER_ID"] != DBNull.Value)
                            ent.PER_ID = Convert.ToInt32(dr["PER_ID"]);
                        if (dr["PER_NOMBRE"] != DBNull.Value)
                            ent.PER_NOMBRE = Convert.ToString(dr["PER_NOMBRE"]);
                        if (dr["PER_APELLIDO"] != DBNull.Value)
                            ent.PER_APELLIDO = Convert.ToString(dr["PER_APELLIDO"]);
                        if (dr["PER_DOCUMENTO"] != DBNull.Value)
                            ent.PER_DOCUMENTO = Convert.ToInt32(dr["PER_DOCUMENTO"]);
                        if (dr["PER_GENERO"] != DBNull.Value)
                            ent.PER_GENERO = Convert.ToString(dr["PER_GENERO"]);
                        if (dr["PER_FECHA_NAC"] != DBNull.Value)
                            ent.PER_FECHA_NAC = Convert.ToDateTime(dr["PER_FECHA_NAC"]);
                        if (dr["PER_TELEFONO"] != DBNull.Value)
                            ent.PER_TELEFONO = Convert.ToString(dr["PER_TELEFONO"]);
                        if (dr["PER_TELEFONO_2"] != DBNull.Value)
                            ent.PER_TELEFONO_2 = Convert.ToString(dr["PER_TELEFONO_2"]);
                        if (dr["PER_EMAIL"] != DBNull.Value)
                            ent.PER_EMAIL = Convert.ToString(dr["PER_EMAIL"]);
                        if (dr["PER_TPE_ID"] != DBNull.Value)
                            ent.PER_TPE_ID = Convert.ToString(dr["PER_TPE_ID"]);
                        if (dr["PER_LEGAJO"] != DBNull.Value)
                            ent.PER_LEGAJO = Convert.ToString(dr["PER_LEGAJO"]);

                    }
                }



            }
            catch
            {
                //result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            return ent;

        }


        /*****************************************************************/
        /************ METODOS COMUNES PARA TODAS LAS PERSONAS ************/
        /*****************************************************************/

        /************************************************* INSERTAR UNA PERSONA ***************************************************/

        public string Insertar(entPersona persona)
        {
            string result;

            DateTime nacimiento = persona.PER_FECHA_NAC;
            string nacimiento2 = nacimiento.ToString("yyyy-MM-dd");

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "INSERT INTO T_PERSONAS " +
                                                "(PER_NOMBRE, " +
                                                "PER_APELLIDO, " +
                                                "PER_DOCUMENTO, " +
                                                "PER_GENERO, " +
                                                " PER_FECHA_NAC," +
                                                "PER_TELEFONO, " +
                                                "PER_TELEFONO_2, " +
                                                "PER_EMAIL," +
                                                "PER_TPE_ID," +
                                                "PER_LEGAJO," +
                                                "PER_ESTADO," +
                                                "PER_FECHA_ALTA," +
                                                "PER_FECHA_MOD," +
                                                "PER_FECHA_BAJA) " +
                                        "VALUES " +
                                                "('" + persona.PER_NOMBRE + "'" +
                                                ", '" + persona.PER_APELLIDO + "'" +
                                                ", '" + persona.PER_DOCUMENTO + "'" +
                                                ", '" + persona.PER_GENERO + "'" +
                                                ",CAST('" + nacimiento2 + "' AS Date)" +
                                                ", '" + persona.PER_TELEFONO + "'" +
                                                ", '" + persona.PER_TELEFONO_2 + "'" +
                                                ", '" + persona.PER_EMAIL + "'" +
                                                ", " + persona.PER_TPE_ID +
                                                ", '" + persona.PER_LEGAJO + "'" +
                                                ", '" + persona.PER_ESTADO + "'" +
                                                ", GETDATE()" +
                                                ", NULL " +
                                                ", NULL);";


                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch (Exception ex)
            {
                result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador. Error-" + ex.ToString());

            }

            return result;
        }
              

        /************************************************* EDITAR UNA PERSONA ***************************************************/

        public string editarPersona(entPersona personaEditar)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();

                string consulta = "UPDATE T_PERSONAS SET " +
                                                "PER_NOMBRE = " + "'" + personaEditar.PER_NOMBRE + "'" +
                                                ", PER_APELLIDO = " + "'" + personaEditar.PER_APELLIDO + "'" +
                                                ", PER_DOCUMENTO = " + "'" + personaEditar.PER_DOCUMENTO + "'" +
                                                ", PER_GENERO = " + "'" + personaEditar.PER_GENERO + "'" +
                                                ", PER_FECHA_NAC = " + "'" + personaEditar.PER_FECHA_NAC + "'" +
                                                ", PER_TELEFONO = " + "'" + personaEditar.PER_TELEFONO + "'" +
                                                ", PER_TELEFONO_2 = " + "'" + personaEditar.PER_TELEFONO_2 + "'" +
                                                ", PER_EMAIL = " + "'" + personaEditar.PER_EMAIL + "'" +
                                                " " +
                                        "WHERE PER_ID = " + "'" + personaEditar.PER_ID + "'" +
                                                ";";

                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch
            {
                result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return result;
        }

        // Devuelve la entidad persona luego de buscar una persona, el de docente tiene su propio metodo

        public entPersona BuscaPersona(string nombre, string apellido, string documento)
        {

            entPersona ent = new entPersona();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT * FROM T_PERSONAS P WHERE P.PER_NOMBRE = '" + nombre + "' AND P.PER_APELLIDO = '" + apellido + "' AND P.PER_DOCUMENTO = '" + documento + "';";


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


                        if (dr["PER_ID"] != DBNull.Value)
                            ent.PER_ID = Convert.ToInt32(dr["PER_ID"]);
                        if (dr["PER_NOMBRE"] != DBNull.Value)
                            ent.PER_NOMBRE = Convert.ToString(dr["PER_NOMBRE"]);
                        if (dr["PER_APELLIDO"] != DBNull.Value)
                            ent.PER_APELLIDO = Convert.ToString(dr["PER_APELLIDO"]);
                        if (dr["PER_DOCUMENTO"] != DBNull.Value)
                            ent.PER_DOCUMENTO = Convert.ToInt32(dr["PER_DOCUMENTO"]);
                        if (dr["PER_GENERO"] != DBNull.Value)
                            ent.PER_GENERO = Convert.ToString(dr["PER_GENERO"]);
                        if (dr["PER_FECHA_NAC"] != DBNull.Value)
                            ent.PER_FECHA_NAC = Convert.ToDateTime(dr["PER_FECHA_NAC"]);
                        if (dr["PER_TELEFONO"] != DBNull.Value)
                            ent.PER_TELEFONO = Convert.ToString(dr["PER_TELEFONO"]);
                        if (dr["PER_TELEFONO_2"] != DBNull.Value)
                            ent.PER_TELEFONO_2 = Convert.ToString(dr["PER_TELEFONO_2"]);
                        if (dr["PER_EMAIL"] != DBNull.Value)
                            ent.PER_EMAIL = Convert.ToString(dr["PER_EMAIL"]);
                        if (dr["PER_TPE_ID"] != DBNull.Value)
                            ent.PER_TPE_ID = Convert.ToString(dr["PER_TPE_ID"]);
                        if (dr["PER_LEGAJO"] != DBNull.Value)
                            ent.PER_LEGAJO = Convert.ToString(dr["PER_LEGAJO"]);

                    }
                }



            }
            catch
            {
                //result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            return ent;

        }

        // Valida que el dni no se encuentre repetido

        public string ValidarDni(string pDNI)
        {
            con = generarConexion();
            con.Open();


            string consulta = "SELECT PER_DOCUMENTO FROM T_PERSONAS WHERE PER_DOCUMENTO = '" + pDNI + "'"; /*******************************
                             VER SI SE FILTRA POR ACTIVO PARA QUE PERMITA INGRESA UN NUEVO DNI O COMO SE RESUELVE EL ELMINAR UNA PERSONA */
                                         
            cmd = new SqlCommand(consulta, con);

            dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                MessageBox.Show("La persona ya se encuentra registrada").ToString();
            }

            return pDNI;


        }

        // Valida que EL MAIL sea ingresado con su estructura correcta

        public bool ValidarEmail(String pEmail)
        {
            String validar;
            validar = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(pEmail, validar))

            {
                if (Regex.Replace(pEmail, validar, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }

        }



        /**************************************************/
        /******************** DOCENTES ********************/
        /**************************************************/

        //Muestra datos en la grilla de DOCENTES

        public DataTable Mostrardocente()
        {
            con = generarConexion();
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            string CargarDocente = "SELECT  PER_NOMBRE + ' ' + PER_APELLIDO DOCENTE, " +
                                           "PER_DOCUMENTO 'DOCUMENTO', " +
                                           "PER_TELEFONO_2 'CELULAR', " +
                                           "PER_TELEFONO 'TELEFONO', " +
                                           "PER_EMAIL 'EMAIL', " +
                                           "CASE SAL_TURNO WHEN 'MANANA' THEN 'MAÑANA' ELSE 'TARDE' END 'TURNO', " +
                                           "SAL_NOMBRE 'SALA', " +
                                           "PER_FECHA_ALTA FECHA_DE_ALTA, " +
                                           "PER_FECHA_MOD FECHA_DE_MODIFICACION, " +
                                           "PER_FECHA_BAJA FECHA_DE_BAJA " +
                                     "FROM T_PERSONAS, T_GRUPO_SALA, T_SALA " +
                                    "WHERE PER_ID = GRS_PER_ID " +
                                      "AND GRS_SAL_ID = SAL_ID " +
                                      "AND PER_TPE_ID = 1 " +
                                      "AND PER_ESTADO = 'S' " +
                                      "UNION " +
                                   "SELECT  PER_NOMBRE + ' ' + PER_APELLIDO DOCENTE, " +
                                           "PER_DOCUMENTO, " +
                                           "PER_TELEFONO_2 'CELULAR', " +
                                           "PER_TELEFONO, " +
                                           "PER_EMAIL, " +
                                           "'', " +
                                           "'', " +
                                           "PER_FECHA_ALTA, " +
                                           "PER_FECHA_MOD, " +
                                           "PER_FECHA_BAJA " +
                                     "FROM T_PERSONAS " +
                                    "WHERE PER_TPE_ID = 1 " +
                                      "AND PER_ID not in (SELECT GRS_PER_ID FROM T_GRUPO_SALA) " +
                                      "AND PER_ESTADO = 'S' ";


            com = new SqlCommand(CargarDocente, con);
            cardoc = new DataTable();
            dta = new SqlDataAdapter(com);
            dta.Fill(cardoc);
            con.Close();
            return cardoc;
        }

        // UPDATEA EL ESTADO DEL DOCENTE

        public string EliminarDocente(entPersona eli_Docente)
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "set dateformat dmy UPDATE T_PERSONAS set per_fecha_baja = convert(varchar, GETDATE(), 103)," +
                                                            "PER_FECHA_MOD = convert(varchar, GETDATE(), 103)," +
                                                            "PER_ESTADO = 'N' " +
                                                            "WHERE PER_ID = " + eli_Docente.PER_ID + ";";
                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch
            {
                result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return result;

        }

        // ELIMINA EL DOCENTE DE LA GRUPO_SALAS

        public string EliminarDocenteGrupoSala(entPersona eli_Docente)//metodo que elimina docente, le coloca fecha de baja no elimina de la base 
        {
            string result;

            try
            {
                con = generarConexion();
                con.Open();
                string consulta = "set dateformat dmy DELETE FROM T_GRUPO_SALA WHERE GRS_PER_ID = " + eli_Docente.PER_ID + ";";
                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch
            {
                result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return result;

        }

        //Llena el buscar de docentes

        public string traerdocente(MetroFramework.Controls.MetroTextBox pbarrabuscar)
        {
            con = generarConexion();
            con.Open();

            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();


            string consulta = "SELECT PER_NOMBRE+' '+ PER_APELLIDO 'DOCENTE' " +
                              "FROM t_personas " +
                              "WHERE PER_TPE_ID =1 " +
                              "AND PER_ESTADO = 'S' " +
                              "ORDER BY 1"; //se suma per_estado como activo pero falta sumar DNI, ver con Alvaro !!! *************************


            cmd = new SqlCommand(consulta, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                pbarrabuscar.AutoCompleteCustomSource.Add(dr["DOCENTE"].ToString());
            }
            dr.Close();

            con.Close();

            return consulta;


        }


        //Llena el cbo_salas en el form Docentes

        public string Llenar_Combo_Salas(MetroFramework.Controls.MetroComboBox pcomboboxturno, MetroFramework.Controls.MetroComboBox pcomboboxsalas)

        {
            con = generarConexion();
            con.Open();

            if (pcomboboxturno.SelectedIndex == 0)
            {
                string consulta = "SELECT SAL_NOMBRE, SAL_ID FROM T_SALA WHERE SAL_TURNO = 'MANANA';";

                cmd = new SqlCommand(consulta, con);
                dta = new SqlDataAdapter(cmd);
                dt = new DataTable("SAL_NOMBRE");
                dta.Fill(dt);


                pcomboboxsalas.DataSource = dt;
                pcomboboxsalas.DisplayMember = "SAL_NOMBRE";
                pcomboboxsalas.ValueMember = "SAL_ID";
                // pcomboboxsalas.SelectedItem = 0;


            }
            else
            {
                if (pcomboboxturno.SelectedIndex == 1)
                {

                    string consulta = "SELECT SAL_NOMBRE, SAL_ID FROM T_SALA WHERE SAL_TURNO = 'TARDE';";

                    cmd = new SqlCommand(consulta, con);
                    dta = new SqlDataAdapter(cmd);
                    dt = new DataTable("SAL_NOMBRE");
                    dta.Fill(dt);
                    pcomboboxsalas.DataSource = dt;
                    pcomboboxsalas.DisplayMember = "SAL_NOMBRE";
                    pcomboboxsalas.ValueMember = "SAL_ID";
                    //     pcomboboxsalas.SelectedItem = 0;


                }
                else
                {
                    pcomboboxsalas.Enabled = false;
                }
            }

            con.Close();

            return "OK"; // CONSULTAR CON BHETA PORQUE SOLO TENEMOS EL RETURN POR FUERA??? ********************************************
            // ANALIZAR SI SE AGREGA EL TIPO DE DOCENTE EN PERSONAS O COMO TRABAJAR EL DOCENTE SIN SALA  ******************************

        }

        // Permite el filtro en en la grilla de docentes

        public DataTable llenarGrilla(string docente) 
        { 

            con = generarConexion();
            con.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = this.con;
            cmd.CommandText = "WITH t1 AS(SELECT PER_NOMBRE +' ' + PER_APELLIDO 'DOCENTE', " +
                                                "PER_DOCUMENTO 'DOCUMENTO', " +
                                                "PER_TELEFONO_2 'CELULAR', " +
                                                "PER_TELEFONO 'TELEFONO', " +
                                                "PER_EMAIL 'EMAIL', " +
                                                "SAL_NOMBRE 'SALA', " +
                                                "SAL_TURNO 'TURNO', " +
                                                "PER_FECHA_ALTA 'FECHA_DE_ALTA', " +
                                                "PER_FECHA_MOD 'FECHA_DE_MODIFICACION', " +
                                                "PER_FECHA_BAJA 'FECHA_DE_BAJA' " +
                                          "FROM T_PERSONAS, T_GRUPO_SALA, T_SALA " +
                                         "WHERE PER_ID = GRS_PER_ID " +
                                                "AND GRS_SAL_ID = SAL_ID " +
                                                "AND PER_TPE_ID = 1 " +
                                                "AND PER_ESTADO = 'S' " +
                                   "UNION " +
                                          "SELECT  PER_NOMBRE + ' ' + PER_APELLIDO DOCENTE, " +
                                                  "PER_DOCUMENTO, " +
                                                  "PER_TELEFONO_2 'CELULAR', " +
                                                  "PER_TELEFONO, " +
                                                  "PER_EMAIL, " +
                                                  "'', " +
                                                  "'', " +
                                                  "PER_FECHA_ALTA, " +
                                                  "PER_FECHA_MOD, " +
                                                  "PER_FECHA_BAJA " +
                                            "FROM T_PERSONAS " +
                                           "WHERE PER_TPE_ID = 1 " +
                                           "AND PER_ID not in (SELECT GRS_PER_ID FROM T_GRUPO_SALA ) " +
                                           "AND PER_ESTADO = 'S') " +
                                           "SELECT t1.DOCENTE, " +
                                           "t1.DOCUMENTO, " +
                                           "T1.CELULAR, " +
                                           "t1.TELEFONO, " +
                                           "t1.EMAIL, " +
                                           "CASE t1.TURNO WHEN 'MANANA' THEN 'MAÑANA' " +
                                                         "WHEN 'TARDE' THEN 'TARDE' " +
                                                         "ELSE '' " +
                                                    "END TURNO, " +
                                           "t1.SALA, " +
                                           "t1.FECHA_DE_ALTA, " +
                                           "t1.FECHA_DE_BAJA, " +
                                           "t1.FECHA_DE_MODIFICACION " +
                                   "FROM t1 " +
                                  "WHERE UPPER(t1.DOCENTE) LIKE UPPER('" + docente + "%'); ";


            dr = cmd.ExecuteReader();
            dt.Load(dr);
            return dt;
        }

        //Metodo que devuelve la entidad Persona para un docente permitiendo pasar los datos de la grilla a los form editar y eliminar


        public entPersona BuscaDocente(string documento)
        {

            entPersona ent = new entPersona();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT * FROM T_PERSONAS P WHERE P.PER_DOCUMENTO = '" + documento + "';";


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


                        if (dr["PER_ID"] != DBNull.Value)
                            ent.PER_ID = Convert.ToInt32(dr["PER_ID"]);
                        if (dr["PER_NOMBRE"] != DBNull.Value)
                            ent.PER_NOMBRE = Convert.ToString(dr["PER_NOMBRE"]);
                        if (dr["PER_APELLIDO"] != DBNull.Value)
                            ent.PER_APELLIDO = Convert.ToString(dr["PER_APELLIDO"]);
                        if (dr["PER_DOCUMENTO"] != DBNull.Value)
                            ent.PER_DOCUMENTO = Convert.ToInt32(dr["PER_DOCUMENTO"]);
                        if (dr["PER_GENERO"] != DBNull.Value)
                            ent.PER_GENERO = Convert.ToString(dr["PER_GENERO"]);
                        if (dr["PER_FECHA_NAC"] != DBNull.Value)
                            ent.PER_FECHA_NAC = Convert.ToDateTime(dr["PER_FECHA_NAC"]);
                        if (dr["PER_TELEFONO"] != DBNull.Value)
                            ent.PER_TELEFONO = Convert.ToString(dr["PER_TELEFONO"]);
                        if (dr["PER_TELEFONO_2"] != DBNull.Value)
                            ent.PER_TELEFONO_2 = Convert.ToString(dr["PER_TELEFONO_2"]);
                        if (dr["PER_EMAIL"] != DBNull.Value)
                            ent.PER_EMAIL = Convert.ToString(dr["PER_EMAIL"]);
                        if (dr["PER_TPE_ID"] != DBNull.Value)
                            ent.PER_TPE_ID = Convert.ToString(dr["PER_TPE_ID"]);
                        if (dr["PER_LEGAJO"] != DBNull.Value)
                            ent.PER_LEGAJO = Convert.ToString(dr["PER_LEGAJO"]);

                    }
                }



            }
            catch (Exception ex)
            {                
                MessageBox.Show("Hubo un problema. Contáctese con su administrador. Error :" + ex.ToString());                
            }

            return ent;
        }


        // Validacion edad form docente agregar y editar

        public int EdadDocente(DateTime pfechaNacimiento)

        {
            DateTime FechaActual = DateTime.Today;


            int Edad_D = FechaActual.Year - pfechaNacimiento.Year;
            if (FechaActual < pfechaNacimiento.AddYears(Edad_D))
                Edad_D--;

            if (Edad_D < 18)
            {
                MessageBox.Show("Este docente tiene menos de 18 años. No puede ser registrado.");

            }
            return Edad_D;

        }

        public entPersona BuscaPersonaxID(string idPersona)
        {

            entPersona ent = new entPersona();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT * FROM T_PERSONAS P WHERE P.PER_ID = '" + idPersona + "';";


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


                        if (dr["PER_ID"] != DBNull.Value)
                            ent.PER_ID = Convert.ToInt32(dr["PER_ID"]);
                        if (dr["PER_NOMBRE"] != DBNull.Value)
                            ent.PER_NOMBRE = Convert.ToString(dr["PER_NOMBRE"]);
                        if (dr["PER_APELLIDO"] != DBNull.Value)
                            ent.PER_APELLIDO = Convert.ToString(dr["PER_APELLIDO"]);
                        if (dr["PER_DOCUMENTO"] != DBNull.Value)
                            ent.PER_DOCUMENTO = Convert.ToInt32(dr["PER_DOCUMENTO"]);
                        if (dr["PER_GENERO"] != DBNull.Value)
                            ent.PER_GENERO = Convert.ToString(dr["PER_GENERO"]);
                        if (dr["PER_FECHA_NAC"] != DBNull.Value)
                            ent.PER_FECHA_NAC = Convert.ToDateTime(dr["PER_FECHA_NAC"]);
                        if (dr["PER_TELEFONO"] != DBNull.Value)
                            ent.PER_TELEFONO = Convert.ToString(dr["PER_TELEFONO"]);
                        if (dr["PER_TELEFONO_2"] != DBNull.Value)
                            ent.PER_TELEFONO_2 = Convert.ToString(dr["PER_TELEFONO_2"]);
                        if (dr["PER_EMAIL"] != DBNull.Value)
                            ent.PER_EMAIL = Convert.ToString(dr["PER_EMAIL"]);
                        if (dr["PER_TPE_ID"] != DBNull.Value)
                            ent.PER_TPE_ID = Convert.ToString(dr["PER_TPE_ID"]);
                        if (dr["PER_LEGAJO"] != DBNull.Value)
                            ent.PER_LEGAJO = Convert.ToString(dr["PER_LEGAJO"]);

                    }
                }



            }
            catch
            {
                //result = "ERROR";
                MessageBox.Show("Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            return ent;

        }
    }
}
