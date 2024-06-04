using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;
using System.Configuration;
using System.Data.SqlClient;
    
namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuarios ocd_usuario = new CD_Usuarios();


        public List<Usuario> Listar()
        {
            return ocd_usuario.Listar();
        }
    }
}
