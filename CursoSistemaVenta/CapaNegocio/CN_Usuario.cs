using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;
using System.Configuration;
using System.Data.SqlClient;
    
namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuarios cdUsuario = new CD_Usuarios();

        public List<Usuario> Listar()
        {
            return cdUsuario.Listar();
        }

        public int Registrar(Usuario entidad, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (entidad.Documento == "")
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }

            if (entidad.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if (entidad.Clave == "")
            {
                Mensaje += "Es necesario la contraseñaa del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return cdUsuario.Registrar(entidad, out Mensaje);
            }
        }

        public bool Editar(Usuario entidad, out string Mensaje)
        {
            Mensaje = string.Empty;
            if (entidad.Documento == "")
            {
                Mensaje += "Es necesario el documento del usuario\n";
            }

            if (entidad.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del usuario\n";
            }

            if (entidad.Clave == "")
            {
                Mensaje += "Es necesario la contraseñaa del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return cdUsuario.Editar(entidad, out Mensaje);
            }
        }

        public bool Eliminar(Usuario entidad, out string Mensaje)
        {
            return cdUsuario.Eliminar(entidad, out Mensaje);
        }
    }
}
