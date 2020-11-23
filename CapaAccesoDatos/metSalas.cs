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
    public class metSalas : Conexion
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection con;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter dta;
        // private Conexion Conexion = new Conexion();
        //private SqlCommand Comando = new SqlCommand();
        //private SqlDataReader leerFilas;

        public DataTable ListarSalas(string turno)

        {
            con = generarConexion();
            string turnoR;

            DataTable Tabla = new DataTable();
            con.Open();

            string consulta = "SELECT * FROM T_SALA S WHERE S.SAL_TURNO = @turnoSala AND S.SAL_ACTIVO = 'S'";
            cmd = new SqlCommand(consulta, con);

            if (turno == "0")
            {
                turnoR = "MANANA";
            }
            else
            {
                turnoR = "TARDE";
            }

            cmd.Parameters.Add(new SqlParameter("@turnoSala", turnoR));
            //cmd = new SqlCommand(consulta, con);
            dta = new SqlDataAdapter(cmd);
            //dta = cmd.ExecuteReader();
            dta.Fill(Tabla);
            //dr.Close();

            con.Close();
            return Tabla;

        }

        public string insertarGrupoSala(entGrupoSala grupoSala)
        {
            string result = "";
            try
            {

                con = generarConexion();
                con.Open();

                string consulta = "INSERT INTO T_GRUPO_SALA " +
                                                "(GRS_SAL_ID" +
                                                ", GRS_PER_ID" +
                                                ", GRS_CARGO )" +
                "VALUES " +
                           "(" + grupoSala.GRS_SAL_ID + " " +
                            "," + grupoSala.GRS_PER_ID + "" +
                             ", '" + grupoSala.GRS_CARGO + "')";


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

        public entSala buscarSalaXPersona(Int32 idPersona)
        {
            entSala ent = new entSala();

            try
            {
                con = generarConexion();
                con.Open();


                string consulta = "SELECT S.* " +
                                        "FROM T_SALA S, T_GRUPO_SALA GS " +
                                        "WHERE S.SAL_ID = GS.GRS_SAL_ID " +
                                        "AND GS.GRS_PER_ID = " + idPersona + ";";

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

                    }
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador. Error: " + ex.ToString() );
            }

            return ent;

        }

        public string editarGrupoSala(entGrupoSala grupoSalaEditar)
        {
            string result = "";
            try
            {

                con = generarConexion();
                con.Open();

                //string consulta = "UPDATE T_GRUPO_SALA SET" +
                //                     " GRS_CARGO = '" + grupoSalaEditar.GRS_CARGO + "' " +
                //                     ", GRS_PER_ID = '" + grupoSalaEditar.GRS_PER_ID + "' " +
                //                   "WHERE GRS_SAL_ID = '" + grupoSalaEditar.GRS_SAL_ID + "';";
                string consulta = "UPDATE T_GRUPO_SALA SET " +
                                    "GRS_CARGO = '" + grupoSalaEditar.GRS_CARGO + "' " +
                                    ", GRS_SAL_ID = '" + grupoSalaEditar.GRS_SAL_ID + "' " +
                                    "WHERE GRS_PER_ID = '" + grupoSalaEditar.GRS_PER_ID + "';";



                cmd = new SqlCommand(consulta, con);
                cmd.ExecuteNonQuery();
                con.Close();

                result = "OK";

            }
            catch
            {
                result = "ERROR";

            }


            return result;

        }

        public DataTable traerPersonasXSala(Int32 idSala)
        {

            //entPersona.entPersonaColeccion colPers = new entPersona.entPersonaColeccion();
            con = generarConexion();

            DataTable dt = new DataTable();
            con.Open();

            string consulta = "select P.PER_ID, P.PER_NOMBRE NOMBRE, P.PER_APELLIDO APELLIDO, P.PER_TELEFONO TELEFONO, P.PER_TELEFONO_2 CELULAR, P.PER_EMAIL EMAIL, P.PER_LEGAJO LEGAJO from T_GRUPO_SALA GS, T_PERSONAS P WHERE P.PER_ID = GS.GRS_PER_ID AND GS.GRS_SAL_ID = @salaID AND P.PER_TPE_ID = 2 ;";
            cmd = new SqlCommand(consulta, con);

            cmd.Parameters.Add(new SqlParameter("@salaID", idSala));

            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();

            con.Close();
            return dt; //colPers;

        }

        public DataTable traerSalasCupo()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = generarConexion();
                con.Open();

                SqlCommand com = new SqlCommand();
                com.Connection = con;

                com.CommandText = "select s.SAL_ID, " +
                                        "s.SAL_NOMBRE SALA, " +
                                        "s.SAL_TURNO TURNO, " +
                                        "ISNULL((select count(gs.GRS_SAL_ID) from T_GRUPO_SALA GS where gs.GRS_SAL_ID = s.SAL_ID GROUP BY gs.GRS_SAL_ID), 0) CANTIDAD, " +
                                        "s.SAL_CANT_ALUM MAXIMO " +
                                        "from T_SALA S;";

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

        public string cantdoc_sal(int sala, int per_id, string turno)
        {
            string result;
            con = generarConexion();
            con.Open();

            string consulta = "SELECT PER_ID" +
                               "SAL_ID" +
                               "SAL_TURNO" +
                               "FROM T_PERSONAS" +
                               "WHERE PER_ID = GRS_PER_ID" +
                               "AND GRS_SAL_ID= SAL_ID" +
                               "AND PER_TPE_ID = 1 " +
                               "AND PER_ESTADO= 'S'" +
                               "AND SAL_ACTIVO= 'S'" +
                               "AND PER_ID=  '" + per_id + "' " +
                               "AND SAL_ID=  '" + sala + "' " +
                               "AND SAL_TURNO= '" + turno + "' ";

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


        public int ValidarDocSala(string id_sala, string turno)
        {
            con = generarConexion();
            con.Open();

            int result = 2;
            try
            {

                cmd = new SqlCommand("SELECT COUNT(*) CANTIDAD " +
                                     "FROM T_PERSONAS, T_GRUPO_SALA, T_SALA " +
                                     "WHERE PER_ID = GRS_PER_ID " +
                                     "AND GRS_SAL_ID = SAL_ID " +
                                     "AND PER_TPE_ID = 1 " +
                                     "AND PER_ESTADO = 'S' " +
                                     "AND SAL_ACTIVO = 'S' " +
                                     "AND SAL_ID = '"+ id_sala + "' " +
                                     "AND SAL_TURNO = '"+ turno + "'; ", con);


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
                result = 2;
                //MessageBox.Show("Hubo un problema. Contáctese con su administrador. Error " + ex.ToString());

            }


            return result;
        }

        public DataSet CantidadAlumnosSalas()
        {

            DataSet dset = new DataSet();

            con = generarConexion();
            con.Open();

            try
            {
                string consulta = "SELECT COUNT(*) CANTIDAD, " +
                                         "SAL_NOMBRE SALA, " +
                                         "CASE SAL_TURNO " +
                                            "WHEN 'MANANA' THEN 'MAÑANA' " +
                                            "ELSE 'TARDE' " +
                                         "END TURNO, SAL_ID " +
                                    "FROM T_PERSONAS, T_GRUPO_SALA, T_SALA " +
                                   "WHERE PER_ID = GRS_PER_ID " +
                                     "AND SAL_ID = GRS_SAL_ID " +
                                     "AND PER_TPE_ID = 2 " +
                                     "AND PER_ESTADO = 'S' " +
                                   "GROUP BY SAL_NOMBRE, SAL_TURNO,SAL_ID " +
                                   "ORDER BY SAL_TURNO, SAL_ID;";

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
