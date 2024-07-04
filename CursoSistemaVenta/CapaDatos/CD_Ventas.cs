using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace CapaDatos
{
    public class CD_Ventas
    {
        public int ObtenerCorrelativo()
        {
            int idcorrelativo = 0;
            using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from Venta");
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

        public bool RestarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock - @cantidad where idproducto = @idproducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConnection);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    oConnection.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool SumarStock(int idProducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update producto set stock = stock + @cantidad where idproducto = @idproducto");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConnection);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idProducto);
                    cmd.CommandType = CommandType.Text;
                    oConnection.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }




        public bool Registrar(Venta entidad, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarVenta", oConnection);
                    cmd.Parameters.AddWithValue("IdUsuario", entidad.oUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("TipoDocumento", entidad.TipoDocumento);
                    cmd.Parameters.AddWithValue("NumeroDocumento", entidad.NumeroDocumento);
                    cmd.Parameters.AddWithValue("DocumentoCliente", entidad.DocumentoCliente);
                    cmd.Parameters.AddWithValue("NombreCliente", entidad.NombreCliente);
                    cmd.Parameters.AddWithValue("MontoPago", entidad.MontoPago);
                    cmd.Parameters.AddWithValue("MontoCambio", entidad.MontoCambio);
                    cmd.Parameters.AddWithValue("MontoTotal", entidad.MontoTotal);
                    cmd.Parameters.AddWithValue("DetalleVenta", DetalleVenta);
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


        //public Venta ObtenerVenta(string NumeroDoc)
        //{
        //    Venta entidad = new Venta();

        //    using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
        //    {
        //        try
        //        {
        //            StringBuilder query = new StringBuilder();
        //            query.AppendLine("SELECT u.NombreCompleto,");
        //            query.AppendLine("p.Documento, p.RazonSocial,");
        //            query.AppendLine("c.IdVenta, c.TipoDocumento, c.NumeroDocumento, c.MontoTotal, convert(char(10), c.FechaRegistro, 103) 'FechaRegistro'");
        //            query.AppendLine("FROM Venta c");
        //            query.AppendLine("INNER JOIN Usuario u ON u.IdUsuario = c.IdUsuario");
        //            query.AppendLine("INNER JOIN Proveedor p ON p.IdProveedor = c.IdProveedor");
        //            query.AppendLine("WHERE c.NumeroDocumento = @NumeroDoc");

        //            SqlCommand cmd = new SqlCommand(query.ToString(), oConnection);

        //            cmd.Parameters.AddWithValue("@NumeroDoc", NumeroDoc);
        //            cmd.CommandType = CommandType.Text;

        //            oConnection.Open();

        //            using (SqlDataReader dr = cmd.ExecuteReader())
        //            {
        //                while (dr.Read())
        //                {

        //                    entidad = new Venta()
        //                    {
        //                        oUsuario = new Usuario() 
        //                        { 
        //                            NombreCompleto = dr["NombreCompleto"].ToString() 
        //                        },
        //                        oProveedor = new Proveedor() 
        //                        {
        //                            RazonSocial = dr["RazonSocial"].ToString(),
        //                            Documento = dr["Documento"].ToString()
        //                        },
        //                        IdVenta = Convert.ToInt32(dr["IdVenta"]),
        //                        TipoDocumento = dr["TipoDocumento"].ToString(),
        //                        NumeroDocumento = dr["NumeroDocumento"].ToString(),
        //                        MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
        //                        FechaRegistro = dr["FechaRegistro"].ToString()
        //                    };
        //                }
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //            Console.WriteLine("SQL Error: " + ex.Message);
        //            entidad = new Venta();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error: " + ex.Message);
        //            entidad = new Venta();
        //        }
        //    }
        //    return entidad;
        //}



        //public List<Detalle_Venta> ListadoDetalleVenta(int idVenta)
        //{
        //    List<Detalle_Venta> lista = new List<Detalle_Venta>();

        //    using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
        //    {
        //        try
        //        {
        //            StringBuilder query = new StringBuilder();
        //            query.AppendLine("SELECT p.Nombre, dc.PrecioVenta, dc.Cantidad, dc.MontoTotal");
        //            query.AppendLine("FROM DetalleVenta dc");
        //            query.AppendLine("INNER JOIN Producto p ON p.IdProducto = dc.IdProducto");
        //            query.AppendLine("WHERE dc.IdVenta = @IdVenta");

        //            SqlCommand cmd = new SqlCommand(query.ToString(), oConnection);
        //            cmd.Parameters.AddWithValue("@IdVenta", idVenta);
        //            cmd.CommandType = CommandType.Text;

        //            oConnection.Open();

        //            using (SqlDataReader dr = cmd.ExecuteReader())
        //            {
        //                while (dr.Read())
        //                {
        //                    lista.Add(new Detalle_Venta()
        //                    {
        //                        oProducto = new Producto()
        //                        {
        //                            Nombre = dr["Nombre"].ToString(),
        //                        },
        //                        PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
        //                        Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
        //                        MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),

        //                    });
        //                }
        //            }
        //        }
        //        catch (SqlException ex)
        //        {
        //            Console.WriteLine("SQL Error: " + ex.Message);
        //            lista = new List<Detalle_Venta>();
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Error: " + ex.Message);
        //            lista = new List<Detalle_Venta>();
        //        }
        //    }

        //    return lista;
        //}
    }
}
