using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Compra
    {
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;
            using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from COMPRA");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConnection);
                    cmd.CommandType = CommandType.Text;
                    oConnection.Open();

                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }

            return idcorrelativo;
        }

        public bool Registrar(Compra entidad, DataTable DetalleCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCompra", oConnection);
                    cmd.Parameters.AddWithValue("IdUsuario", entidad.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("IdProveedor", entidad.oProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("TipoDocumento", entidad.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", entidad.NumeroDocumento);
                    cmd.Parameters.AddWithValue("MontoTotal", entidad.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    //primero debemos abrir la conexion abrir a la bd
                    oConnection.Open();

                    //luego ejecutar el comando
                    cmd.ExecuteNonQuery();

                 

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
            }

            return Respuesta;
        }

    }
}
