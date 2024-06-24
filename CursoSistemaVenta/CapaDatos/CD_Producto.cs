using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Producto
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdProducto,Codigo,Nombre, p.Descripcion, c.IdCategoria, c.Descripcion" +
                        " 'DescripcionCategoria', Stock, PrecioCompra,PrecioVenta,p.Estado FROM Producto p");
                    query.AppendLine("INNER JOIN Categoria c ON c.IdCategoria = p.IdCategoria");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConnection);
                    cmd.CommandType = CommandType.Text;

                    oConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Producto()
                            {
                                IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                Codigo = dr["Codigo"].ToString(),
                                Nombre = dr["Nombre"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                oCategoria = new Categoria()
                                {
                                    IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                    Descripcion = dr["DescripcionCategoria"].ToString()
                                },
                                Stock = Convert.ToInt32(dr["Stock"].ToString()),
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                    lista = new List<Producto>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    lista = new List<Producto>();
                }
            }

            return lista;
        }

        public int Registrar(Producto entidad, out string mensaje)
        {
            int idProductoGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProducto", oConnection);
                    cmd.Parameters.AddWithValue("Codigo", entidad.Codigo);
                    cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
                    cmd.Parameters.AddWithValue("Nombre", entidad.Nombre);
                    cmd.Parameters.AddWithValue("IdCategoria", entidad.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Estado", entidad.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oConnection.Open();
                    cmd.ExecuteNonQuery();

                    idProductoGenerado = Convert.ToInt32(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idProductoGenerado = 0;
                mensaje = ex.Message;
            }

            return idProductoGenerado;
        }


        public bool Editar(Producto entidad, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarProducto", oConnection);
                    cmd.Parameters.AddWithValue("IdProducto", entidad.IdProducto);
                    cmd.Parameters.AddWithValue("Codigo", entidad.Codigo);
                    cmd.Parameters.AddWithValue("Descripcion", entidad.Descripcion);
                    cmd.Parameters.AddWithValue("Nombre", entidad.Nombre);
                    cmd.Parameters.AddWithValue("IdCategoria", entidad.oCategoria.IdCategoria);
                    cmd.Parameters.AddWithValue("Estado", entidad.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConnection.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }

        public bool Eliminar(Producto entidad, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarProducto", oConnection);
                    cmd.Parameters.AddWithValue("IdProducto", entidad.IdProducto);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oConnection.Open();
                    cmd.ExecuteNonQuery();

                    respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }

    }
}
