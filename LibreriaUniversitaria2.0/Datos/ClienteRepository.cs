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
        // Cadena de conexión centralizada
        private static string connectionString = DbHelper.CadenaConexion;

        /// <summary>
        /// Devuelve todos los clientes existentes en la base de datos.
        /// </summary>
        public static List<Cliente> ObtenerTodos()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cliente";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(reader["IdCliente"]),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        TipoDocumento = reader["TipoDocumento"].ToString(),
                        NumeroDocumento = reader["NroDocumento"].ToString(),
                        EsEstudiante = Convert.ToBoolean(reader["EsEstudiante"])
                    };

                    lista.Add(cliente);
                }

                reader.Close();
            }

            return lista;
        }

        /// <summary>
        /// Busca un cliente por su ID.
        /// </summary>
        public static Cliente BuscarPorId(int id)
        {
            Cliente cliente = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cliente WHERE IdCliente = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(reader["IdCliente"]),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        TipoDocumento = reader["TipoDocumento"].ToString(),
                        NumeroDocumento = reader["NroDocumento"].ToString(),
                        EsEstudiante = Convert.ToBoolean(reader["EsEstudiante"])
                    };
                }

                reader.Close();
            }

            return cliente;
        }

        /// <summary>
        /// Busca un cliente por tipo y número de documento.
        /// </summary>
        public static Cliente BuscarPorDocumento(string tipoDoc, string nroDoc)
        {
            Cliente cliente = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Cliente WHERE TipoDocumento = @tipo AND NroDocumento = @nro";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tipo", tipoDoc);
                cmd.Parameters.AddWithValue("@nro", nroDoc);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(reader["IdCliente"]),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        TipoDocumento = reader["TipoDocumento"].ToString(),
                        NumeroDocumento = reader["NroDocumento"].ToString(),
                        EsEstudiante = Convert.ToBoolean(reader["EsEstudiante"])
                    };
                }

                reader.Close();
            }

            return cliente;
        }

        /// <summary>
        /// Inserta un nuevo cliente en la base de datos.
        /// </summary>
        public static void Insertar(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Cliente (Nombre, Apellido, TipoDocumento, NroDocumento, EsEstudiante) 
                                 VALUES (@nombre, @apellido, @tipo, @nro, @esEstudiante)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@tipo", cliente.TipoDocumento);
                cmd.Parameters.AddWithValue("@nro", cliente.NumeroDocumento);
                cmd.Parameters.AddWithValue("@esEstudiante", cliente.EsEstudiante);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Actualiza los datos de un cliente.
        /// </summary>
        public static void Actualizar(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Cliente SET Nombre = @nombre, Apellido = @apellido, 
                                 TipoDocumento = @tipo, NroDocumento = @nro, EsEstudiante = @esEstudiante 
                                 WHERE IdCliente = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@tipo", cliente.TipoDocumento);
                cmd.Parameters.AddWithValue("@nro", cliente.NumeroDocumento);
                cmd.Parameters.AddWithValue("@esEstudiante", cliente.EsEstudiante);
                cmd.Parameters.AddWithValue("@id", cliente.IdCliente);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Elimina un cliente por su ID.
        /// </summary>
        public static void Eliminar(int id)
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
    }
}
