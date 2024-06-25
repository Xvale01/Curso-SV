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
    public class CD_Cliente
    {
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT IdCliente, Documento, NombreCompleto, Correo, Telefono, Estado FROM Cliente");


                    SqlCommand cmd = new SqlCommand(query.ToString(), oConnection);
                    cmd.CommandType = CommandType.Text;

                    oConnection.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Cliente()
                            {
                                IdCliente = Convert.ToInt32(dr["IdCliente"]),
                                Documento = dr["Documento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
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
                    lista = new List<Cliente>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    lista = new List<Cliente>();
                }
            }

            return lista;
        }

        public int Registrar(Cliente entidad, out string mensaje)
        {
            int idClienteGenerado = 0;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCliente", oConnection);
                    cmd.Parameters.AddWithValue("Documento", entidad.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", entidad.NombreCompleto);
                    cmd.Parameters.AddWithValue("Correo", entidad.Correo);
                    cmd.Parameters.AddWithValue("Telefono", entidad.Telefono);
                    cmd.Parameters.AddWithValue("Estado", entidad.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oConnection.Open();
                    cmd.ExecuteNonQuery();

                    idClienteGenerado = Convert.ToInt32(cmd.Parameters["Respuesta"].Value);
                    mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idClienteGenerado = 0;
                mensaje = ex.Message;
            }

            return idClienteGenerado;
        }


        public bool Editar(Cliente entidad, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("SP_EditarCliente", oConnection);
                    cmd.Parameters.AddWithValue("IdCliente", entidad.IdCliente);
                    cmd.Parameters.AddWithValue("Documento", entidad.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", entidad.NombreCompleto);
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

        public bool Eliminar(Cliente entidad, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM cliente WHERE IdCliente = @IdCliente", oConnection);
                    cmd.Parameters.AddWithValue("@IdCliente", entidad.IdCliente);
                    cmd.CommandType = CommandType.Text;
                    oConnection.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false ;
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
