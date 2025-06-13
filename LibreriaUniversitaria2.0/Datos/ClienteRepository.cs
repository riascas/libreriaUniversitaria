using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;
using System.Data.SqlClient;
using Libreria.DAL;

namespace LibreriaUniversitaria.Datos
{
    /// <summary>
    /// Clase que maneja el acceso a la tabla Cliente en la base de datos.
    /// </summary>
    public static class ClienteRepository
    {
        private static string connectionString = DbHelper.CadenaConexion;

        /// <summary>
        /// Devuelve todos los clientes existentes en la base de datos.
        /// </summary>
        public static List<Cliente> ObtenerTodos()
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT IdCliente, Nombre, Apellido, NumeroDocumento, EsEstudiante, Email FROM Cliente";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente
                            {
                                IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                NumeroDocumento = reader["NumeroDocumento"].ToString(),
                                EsEstudiante = Convert.ToBoolean(reader["EsEstudiante"]),
                                Email = reader["Email"] == DBNull.Value ? null : reader["Email"].ToString()
                            };

                            lista.Add(cliente);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message);
            }

            return lista;
        }

        /// <summary>
        /// Busca un cliente por su ID.
        /// </summary>
        public static Cliente BuscarPorId(int id)
        {
            Cliente cliente = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT IdCliente, Nombre, Apellido, NumeroDocumento, EsEstudiante, Email FROM Cliente WHERE IdCliente = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Cliente
                            {
                                IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                NumeroDocumento = reader["NumeroDocumento"].ToString(),
                                EsEstudiante = Convert.ToBoolean(reader["EsEstudiante"]),
                                Email = reader["Email"] == DBNull.Value ? null : reader["Email"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cliente por ID: " + ex.Message);
            }

            return cliente;
        }

        /// <summary>
        /// Busca un cliente por número de documento.
        /// </summary>
        public static Cliente BuscarPorDocumento(string nroDoc)
        {
            Cliente cliente = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT IdCliente, Nombre, Apellido, NumeroDocumento, EsEstudiante, Email FROM Cliente WHERE NumeroDocumento = @nro";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nro", nroDoc);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cliente = new Cliente
                            {
                                IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                NumeroDocumento = reader["NumeroDocumento"].ToString(),
                                EsEstudiante = Convert.ToBoolean(reader["EsEstudiante"]),
                                Email = reader["Email"] == DBNull.Value ? null : reader["Email"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cliente por documento: " + ex.Message);
            }

            return cliente;
        }

        /// <summary>
        /// Inserta un nuevo cliente en la base de datos.
        /// </summary>
        public static void Insertar(Cliente cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"INSERT INTO Cliente (Nombre, Apellido, NumeroDocumento, EsEstudiante, Email) 
                                     VALUES (@nombre, @apellido, @nro, @esEstudiante, @email)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    cmd.Parameters.AddWithValue("@nro", cliente.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@esEstudiante", cliente.EsEstudiante);
                    cmd.Parameters.AddWithValue("@email", (object)cliente.Email ?? DBNull.Value);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza los datos de un cliente.
        /// </summary>
        public static void Actualizar(Cliente cliente)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE Cliente SET Nombre = @nombre, Apellido = @apellido, 
                                     NumeroDocumento = @nro, EsEstudiante = @esEstudiante, Email = @email 
                                     WHERE IdCliente = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    cmd.Parameters.AddWithValue("@nro", cliente.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@esEstudiante", cliente.EsEstudiante);
                    cmd.Parameters.AddWithValue("@email", (object)cliente.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", cliente.IdCliente);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cliente: " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina un cliente por su ID.
        /// </summary>
        public static void Eliminar(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Cliente WHERE IdCliente = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar cliente: " + ex.Message);
            }
        }
    }
}
