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
    public class CD_Proveedor
    {
        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdProveedor, Documento, RazonSocial, Correo, Telefono, Estado FROM Proveedor");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConnection);
                    cmd.CommandType = CommandType.Text;

                    oConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                IdProveedor = Convert.ToInt32(dr["IdProveedor"]),
                                Documento = dr["Documento"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error: " + ex.Message);
                    lista = new List<Proveedor>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    lista = new List<Proveedor>();
                }
            }

            return lista;
        }

        public int Registrar(Proveedor entidad, out string mensaje)
        {
            int idProveedorGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarProveedor", oConnection);
                    cmd.Parameters.AddWithValue("Documento", entidad.Documento);
                    cmd.Parameters.AddWithValue("RazonSocial", entidad.RazonSocial);
                    cmd.Parameters.AddWithValue("Correo", entidad.Correo);
                    cmd.Parameters.AddWithValue("Telefono", entidad.Telefono);
                    cmd.Parameters.AddWithValue("Estado", entidad.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oConnection.Open();
                    cmd.ExecuteNonQuery();

                    idProveedorGenerado = Convert.ToInt32(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idProveedorGenerado = 0;
                mensaje = ex.Message;
            }

            return idProveedorGenerado;
        }


        public bool Editar(Proveedor entidad, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarProveedor", oConnection);
                    cmd.Parameters.AddWithValue("IdProveedor", entidad.IdProveedor);
                    cmd.Parameters.AddWithValue("Documento", entidad.Documento);
                    cmd.Parameters.AddWithValue("RazonSocial", entidad.RazonSocial);
                    cmd.Parameters.AddWithValue("Correo", entidad.Correo);
                    cmd.Parameters.AddWithValue("Telefono", entidad.Telefono);
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

        public bool Eliminar(Proveedor entidad, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_EliminarProveedor", oConnection);
                    cmd.Parameters.AddWithValue("IdProveedor", entidad.IdProveedor);
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
