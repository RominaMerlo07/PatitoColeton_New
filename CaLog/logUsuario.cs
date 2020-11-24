using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CaAD;
using CaEnt;
//using System.Data.SqlClient;

namespace CaLog
{
    public class logUsuario
    {
        metUsuario objMetUsuario = new metUsuario();

        public DataTable buscarUsuario(entUsuario usuario)
        {            

            return objMetUsuario.buscarUsuario(usuario);
        }
        public bool Permisos(string usuario, string contrasena)
        {
            return objMetUsuario.Permisos(usuario, contrasena);

        }
        public bool Inactivo(string usuario, string contrasena)
        {
            return objMetUsuario.Permisos(usuario, contrasena);

        }

        public bool ingresar(string usuario, string contrasena)
        {
            
            return objMetUsuario.ingresar(usuario, contrasena);
        }

        public DataTable MostrarUsu()
        {
            
            return objMetUsuario.MostrarUsu();
        }

        public void EditarUsuario(entUsuario Usuario)
        {
            objMetUsuario.EditarUsuario(Usuario);
        }

        public void EliminarUsuario(entUsuario Usuario)
        {
            objMetUsuario.EliminarUsuario(Usuario);
        }
        public DataTable AutocompletarAgregarDocente()
        {
            
            return objMetUsuario.AutocompletarAgregarDocente();
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


        public string ExtraerApellido(string pbarrabuscar)
        {
            string dni = ExtraerDni(pbarrabuscar);

            return objMetUsuario.ExtraerApellido(dni);
        }

        public string CrearUsuario(String pbarrabuscar/*, String newuser*/)
        {

            return objMetUsuario.CrearUsuario(pbarrabuscar);
        }

        public DataTable AutocompletarenDocente(/*MetroFramework.Controls.MetroTextBox pbarrabuscar*/)
        {
            
            return objMetUsuario.AutocompletarenDocente(/*pbarrabuscar*/);
        }

        public DataTable llenarGrilla(string docente)
        {

            return objMetUsuario.llenarGrilla(docente);
        }


        public string Ingresar_Usuario(string pbarrabuscar, string ptextbox, string ptextbox2)
        {

            string dni = ExtraerDni(pbarrabuscar);

            return objMetUsuario.Ingresar_Usuario(dni, ptextbox, ptextbox2);
        }
    }
}
