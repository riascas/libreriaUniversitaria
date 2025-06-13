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
    /// Clase de acceso a datos para operaciones CRUD de Cliente.
    /// </summary>
    public static class ClienteRepository
    {
        /// <summary>
        /// Devuelve todos los clientes registrados en la base de datos.
        /// </summary>
        public static List<Cliente> ObtenerTodos()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Cliente";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            IdCliente = Convert.ToInt32(reader["IdCliente"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            NumeroDocumento = reader["Documento"].ToString(),
                            Email = reader["Email"].ToString(),
                            EsEstudiante = Convert.ToBoolean(reader["EsEstudiante"])
                        };

                        lista.Add(cliente);
                    }
                }
            }

            return lista;
        }

        /// <summary>
        /// Busca un cliente por su número de documento (DNI).
        /// </summary>
        public static Cliente BuscarPorDocumento(string dni)
        {
            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Cliente WHERE Documento = @dni";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dni", dni);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Cliente
                            {
                                IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                NumeroDocumento = reader["Documento"].ToString(),
                                Email = reader["Email"].ToString(),
                                EsEstudiante = Convert.ToBoolean(reader["EsEstudiante"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Inserta un nuevo cliente en la base de datos.
        /// </summary>
        public static void Registrar(Cliente cliente)
        {
            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                conn.Open();

                string query = @"INSERT INTO Cliente (Nombre, Apellido, Documento, Email, EsEstudiante)
                                 VALUES (@nombre, @apellido, @documento, @email, @esEstudiante)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                    cmd.Parameters.AddWithValue("@documento", cliente.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@email", cliente.Email);
                    cmd.Parameters.AddWithValue("@esEstudiante", cliente.EsEstudiante);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

