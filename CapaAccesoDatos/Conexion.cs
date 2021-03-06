﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CaAD//GestionJardin
{
    public abstract class Conexion
    {
        private readonly string cadenaDeConexion;

        public Conexion()
        {
            cadenaDeConexion = "Data Source=(local)\\SQLEXPRESS01; Initial Catalog = GESTION_JARDIN; Integrated Security = True";
            //Cadena Romi: "Data Source=DESKTOP-4EDP5RJ\\SQLEXPRESS; Initial Catalog = GESTION_JARDIN; Integrated Security = True";
            //Cadena Gaston: "Data Source=LAPTOP-AS4VOUTB\\SQLEXPRESS; Initial Catalog = GESTION_JARDIN; Integrated Security = True";
            //Nadia: DESKTOP-1IPVM4C-LAPTOP-LO0TLLQO
            //Alvaro:"Data Source=LAPTOP-O8465LJG\SQLEXPRESS; Initial Catalog = GESTION_JARDIN; Integrated Security = True";
        }

        protected SqlConnection generarConexion() // metodo para conectar desde la clase de metodos de las entidades.
        {
            return new SqlConnection(cadenaDeConexion);
        }
    }
}
