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
    public class CD_Reporte
    {
        public List<ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor, out string mensaje)
        {
            mensaje = string.Empty;
            List<ReporteCompra> lista = new List<ReporteCompra>();

            try
            {
                using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ReporteCompras", oConnection);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio );
                    cmd.Parameters.AddWithValue("fechafin", fechafin );
                    cmd.Parameters.AddWithValue("idproveedor", idproveedor);

                    cmd.CommandType = CommandType.StoredProcedure;

                    oConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteCompra()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                DocumentoProveedor = dr["DocumentoProveedor"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioCompra = dr["PrecioCompra"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString(),
                            });
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                lista = new List<ReporteCompra>();
                mensaje = ex.Message;
            }

            return lista;

        }

        public List<ReporteVenta> Venta(string fechainicio, string fechafin, out string mensaje)
        {
            mensaje = string.Empty;
            List<ReporteVenta> lista = new List<ReporteVenta>();

            try
            {
                using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("sp_ReporteVentas", oConnection);
                    cmd.Parameters.AddWithValue("fechainicio", fechainicio);
                    cmd.Parameters.AddWithValue("fechafin", fechafin);

                    cmd.CommandType = CommandType.StoredProcedure;

                    oConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new ReporteVenta()
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString(),
                            });
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                lista = new List<ReporteVenta>();
                mensaje = ex.Message;
            }

            return lista;

        }

    }
}
