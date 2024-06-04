using System;
using System.Configuration;

namespace CapaDatos
{
    public class Connection
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }
}