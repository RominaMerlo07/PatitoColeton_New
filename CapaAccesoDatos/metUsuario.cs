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
    public class metUsuario : Conexion
    {
        SqlDataReader dr;
        DataTable tablaUsu;
        SqlCommand comando;
        SqlConnection con;
        SqlDataAdapter dta;
        public DataTable buscarUsuario(entUsuario usuario)
        {

            DataTable dt = new DataTable();

            try
            {
               SqlConnection con = generarConexion();

                con.Open();                         // abro conexion

                SqlCommand com = new SqlCommand();  //inicializo el comando
                com.Connection = con;               //asigno conexion al comando
                com.CommandText = "select * " +
                                    "from t_usuarios u " +
                                    "where u.usu_usuario = @usuario " +
                                    ";";               //asigno la búsqueda sql al comando

                com.Parameters.Add(new SqlParameter("@usuario", usuario.USU_USUARIO));

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex + "Hubo un problema. Contáctese con su administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return dt;

        }

        public bool ingresar(string usuario, string contrasena)
        {            
                bool valido = new bool();

                entUsuario usr = new entUsuario();
                usr.USU_USUARIO = usuario;

                DataTable t_usuario = buscarUsuario(usr);

                if (t_usuario.Rows.Count == 0)
                {
                    valido = false;

                }
            else if (t_usuario.Rows[0][8].ToString() == "INACTIVO")
            {
                valido = false;
            }

            else if (t_usuario.Rows[0]["USU_CLAVE"].ToString() == contrasena)

                {
                    valido = true;
                }
                else
                {
                    valido = false;
                }


                return valido;
            }

        public bool Permisos(string usuario, string contrasena)
        {
            entUsuario usr = new entUsuario();
            usr.USU_USUARIO = usuario;
            DataTable t_usuario = buscarUsuario(usr);
            bool rol = new bool();
            if (t_usuario.Rows[0][4].ToString() == "1")
            {
                rol = true;
            }
            else if (t_usuario.Rows[0][4].ToString() == "2")
            {

                rol = false;
            }
            
            return rol;
        }

            public DataTable MostrarUsu()
        {
            con = generarConexion();
            con.Open();
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            string CargarUsu = "SELECT D.PER_NOMBRE +' ' + D.PER_APELLIDO DOCENTE," +
                               " USU.USU_USUARIO USUARIO," +
                               "USU.USU_CLAVE CONTRASEÑA," +
                                "USU.USU_FECHA_ALTA 'FECHA DE ALTA' ," +
                                "USU.USU_FECHA_MOD 'FECHA DE MODIFICACION' " +
                                "FROM T_PERSONAS AS D, T_USUARIOS AS USU " +
                                "WHERE USU.USU_PER_ID = D.PER_ID AND USU.USU_ESTADO = 'ACTIVO'";

            comando = new SqlCommand(CargarUsu, con);
            tablaUsu = new DataTable();
            dta = new SqlDataAdapter(comando);
            dta.Fill(tablaUsu);
            con.Close();
            return tablaUsu;
        }

        public void EditarUsuario(entUsuario Usuario)
        {
            con = generarConexion();
            con.Open();
            try
            {

                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "set dateformat dmy UPDATE T_USUARIOS set USU_FECHA_MOD= convert (varchar, GETDATE(),103) " + ", " +
                    "USU_CLAVE= '" + Usuario.USU_CLAVE + "' " +
                    "WHERE USU_USUARIO = " + Usuario.USU_USUARIO;
                com.ExecuteNonQuery();
                com.Parameters.Clear();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

            }
        }

        public void EliminarUsuario(entUsuario Usuario)
        {
            con = generarConexion();
            con.Open();
            try
            {
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = "set dateformat dmy UPDATE T_USUARIOS set USU_FECHA_MOD = convert (varchar, GETDATE(),103), " +
                     " USU_FECHA_BAJA = convert (varchar, GETDATE(),103), " +
                    " USU_ESTADO=  'INACTIVO' " +
                    "WHERE USU_USUARIO = " + Usuario.USU_USUARIO;
                com.ExecuteNonQuery();
                com.Parameters.Clear();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);

            }
        }
        public DataTable AutocompletarAgregarDocente()
        {
            DataTable dt = new DataTable();
            con = generarConexion();
            con.Open();
            string consultadocente = "SELECT CONCAT  (PER_NOMBRE, ' ', PER_APELLIDO,  ' ' , '(' , PER_DOCUMENTO, ')' ) DOCENTE , PER_ID FROM T_PERSONAS " +
                                    "WHERE PER_TPE_ID = 1 AND PER_ID NOT IN (SELECT DISTINCT PER_ID FROM T_PERSONAS , T_USUARIOS  where PER_ID = USU_PER_ID)";
            //"SELECT [PER_NOMBRE] +' ' +  [PER_APELLIDO ] 'DOCENTE',PER_ID FROM T_PERSONAS " +
            //                 "WHERE PER_TPE_ID = 1  "; ESTA CONSULTA TRAE A TODOS LOS DOCENTES, PERONECESITÁBAMOS A AQUELLOS QUE NO TENÍAN USUARIO.

            comando = new SqlCommand(consultadocente, con);
            dr = comando.ExecuteReader();
            dt.Load(dr);
            //while (dr.Read())
            //{
            //    pbarrabuscar.AutoCompleteCustomSource.Add(dr["DOCENTE"].ToString());

            //    /*barrabuscar.AutoCompleteCustomSource.Add(dr["DOCENTE"].ToString());*/
            //}
            //dr.Close();
            con.Close();
            return dt;
        }

        public string ExtraerNombre(string pbarrabuscar)
        {
            string info = pbarrabuscar;
            string[] extraccion = info.Split(' ');
            return extraccion[0];
        }

        public string ExtraerDni(string pbarrabuscar)
        {
            string info = pbarrabuscar;
            string[] extraccion = info.Split('(', ')');
            return extraccion[1];
        }


        public string ExtraerApellido(string dni)
        {

            con = generarConexion();
            con.Open();
            string Dni = ExtraerDni(dni);
            string consulta = "SELECT PER_APELLIDO FROM T_PERSONAS WHERE PER_DOCUMENTO = '" + Dni + "' ";
            comando = new SqlCommand(consulta, con);
            dr = comando.ExecuteReader();

            if (dr.Read() == true)

            {
                string Apellido = dr["PER_APELLIDO"].ToString();
                char delimitador = (' ');
                string[] primer_apellido = Apellido.Split(delimitador);
                return primer_apellido[0];
            }
            return "yes";

        }
        //string[] extraccion = consulta.Split(' ');
        //return extraccion[0];

        public string CrearUsuario(string nombreApe/*pbarrabuscar*//*, MetroFramework.Controls.MetroTextBox newuser*/)
        {

            string Nombre = ExtraerNombre(nombreApe);
            Nombre = Nombre.ToLower();

            string Apellido = ExtraerApellido(nombreApe);

            Apellido = Apellido.ToLower(); //lo convierto en minúscula
            string letra_nombre = Nombre.Substring(0, 1); //saco la letra del nomnbre
            string nombre_usuario = string.Concat(letra_nombre, Apellido);//concateno, pero me queda un espacio
            nombre_usuario = nombre_usuario.Replace(" ", string.Empty);//saco el espacio de la concatenación Y LISTO!! =)

            con = generarConexion();
            con.Open();

            string consulta = "Select count (USU_USUARIO) as 'CANTIDAD' from T_USUARIOS where USU_USUARIO LIKE '%" + nombre_usuario + "%';";
            SqlCommand com = new SqlCommand(consulta, con);
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                int contador = Convert.ToInt32(dr["CANTIDAD"]);

                int acumulador = contador;
                if (contador == 0)

                {

                    //newuser.Text = nombre_usuario;
                    //nombre_usuario = nombre_usuario;

                }
                else
                {
                    //newuser.Text = nombre_usuario + acumulador;
                    nombre_usuario = nombre_usuario + acumulador;
                }
            }

            dr.Close();
            con.Close();
            
            return nombre_usuario;

        }

        public DataTable AutocompletarenDocente(/*MetroFramework.Controls.MetroTextBox pbarrabuscar*/)
        {
            DataTable dt = new DataTable();
            con = generarConexion();
            con.Open();
            //AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

            //string consulta = "SELECT CONCAT  (PER_NOMBRE, ' ', PER_APELLIDO,  ' ' , '(' , PER_DOCUMENTO, ')' ) DOCENTE , PER_ID FROM T_PERSONAS " +
            //                        "WHERE PER_TPE_ID = 1 AND PER_ID NOT IN (SELECT DISTINCT PER_ID FROM T_PERSONAS , T_USUARIOS  where PER_ID = USU_PER_ID )";

            string consulta = "SELECT DISTINCT [PER_NOMBRE] +' ' +  [PER_APELLIDO ] 'DOCENTE' " +
                              "FROM T_PERSONAS p, T_USUARIOS u " +
                              "WHERE  p.PER_ID = u.USU_PER_ID " +
                              "AND u.USU_ESTADO = 'ACTIVO' " +
                              "AND p.PER_TPE_ID = 1 ";
            comando = new SqlCommand(consulta, con);
            dr = comando.ExecuteReader();
            dt.Load(dr);
            //while (dr.Read())
            //{
            //    pbarrabuscar.AutoCompleteCustomSource.Add(dr["DOCENTE"].ToString());
            //}
            //dr.Close();

            con.Close();

            return dt;
        }

        public DataTable llenarGrilla(string docente)
        {
            con = generarConexion();
            con.Open();
            DataTable dt = new DataTable();
            comando = new SqlCommand();
            comando.Connection = this.con;
            comando.CommandText = "WITH t1 AS(SELECT D.PER_NOMBRE +' ' + D.PER_APELLIDO DOCENTE," +
                                "USU.USU_USUARIO USUARIO," +
                                "USU.USU_CLAVE CONTRASEÑA," +
                                "USU.USU_FECHA_ALTA 'FECHA DE ALTA'," +
                                "USU.USU_FECHA_MOD 'FECHA DE MODIFICACION'," +
                                "USU.USU_ESTADO ESTADO FROM T_PERSONAS AS D, T_USUARIOS AS USU " +
                                "WHERE USU.USU_PER_ID = D.PER_ID AND USU.USU_ESTADO = 'ACTIVO')" +
                                "SELECT t1.*FROM t1 " +
                                "WHERE UPPER(t1.DOCENTE)  like UPPER('" + docente + "%') ";
            dr = comando.ExecuteReader();
            dt.Load(dr);
            return dt;
        }


        public string Ingresar_Usuario(string pbarrabuscar, string ptextbox, string ptextbox2)
        {

            con = generarConexion();
            con.Open();

            string Dni = pbarrabuscar; // ExtraerDni(pbarrabuscar);
            string nombre_usuario = ptextbox;
            string clave_usuario = ptextbox2;

            string consulta = "INSERT INTO T_USUARIOS (USU_PER_ID, USU_USUARIO, USU_CLAVE, USU_ROL_ID, USU_FECHA_ALTA," +
                                 " USU_ESTADO) VALUES ((SELECT PER_ID FROM T_PERSONAS WHERE PER_DOCUMENTO = " + Dni + "), ' " + nombre_usuario + "', '" + clave_usuario + "' , 2 , GETDATE(), 'ACTIVO');";

            comando = new SqlCommand(consulta, con);
            comando.ExecuteNonQuery();
            con.Close();

            return "OK";
        }

    }
}
