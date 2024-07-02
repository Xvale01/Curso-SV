using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CapaEntidad;
using System.Collections;
using System.Reflection;

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


        public Compra ObtenerCompra(string NumeroDoc)
        {
            Compra entidad = new Compra();

            using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.NombreCompleto,");
                    query.AppendLine("p.Documento, p.RazonSocial,");
                    query.AppendLine("c.IdCompra, c.TipoDocumento, c.NumeroDocumento, c.MontoTotal, convert(char(10), c.FechaRegistro, 103) 'FechaRegistro'");
                    query.AppendLine("FROM Compra c");
                    query.AppendLine("INNER JOIN Usuario u ON u.IdUsuario = c.IdUsuario");
                    query.AppendLine("INNER JOIN Proveedor p ON p.IdProveedor = c.IdProveedor");
                    query.AppendLine("WHERE c.NumeroDocumento = @NumeroDoc");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConnection);

                    cmd.Parameters.AddWithValue("@NumeroDoc", NumeroDoc);
                    cmd.CommandType = CommandType.Text;

                    oConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            entidad = new Compra()
                            {
                                oUsuario = new Usuario() 
                                { 
                                    NombreCompleto = dr["NombreCompleto"].ToString() 
                                },
                                oProveedor = new Proveedor() 
                                {
                                    RazonSocial = dr["RazonSocial"].ToString(),
                                    Documento = dr["Documento"].ToString()
                                },
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                    entidad = new Compra();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    entidad = new Compra();
                }
            }
            return entidad;
        }



        public List<Detalle_Compra> ListadoDetalleCompra(int idCompra)
        {
            List<Detalle_Compra> lista = new List<Detalle_Compra>();

            using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.Nombre, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal");
                    query.AppendLine("FROM DetalleCompra dc");
                    query.AppendLine("INNER JOIN Producto p ON p.IdProducto = dc.IdProducto");
                    query.AppendLine("WHERE dc.IdCompra = @IdCompra");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConnection);
                    cmd.Parameters.AddWithValue("@IdCompra", idCompra);
                    cmd.CommandType = CommandType.Text;

                    oConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Detalle_Compra()
                            {
                                oProducto = new Producto()
                                {
                                    Nombre = dr["Nombre"].ToString(),
                                },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),

                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                    lista = new List<Detalle_Compra>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    lista = new List<Detalle_Compra>();
                }
            }

            return lista;
        }


    }
}
