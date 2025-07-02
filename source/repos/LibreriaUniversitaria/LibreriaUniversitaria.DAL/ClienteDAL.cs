using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    public class ClienteDAL
    {
        private readonly ConexionDAL conexion;

        public ClienteDAL()
        {
            conexion = new ConexionDAL();
        }

        // Agrega un nuevo cliente a la base de datos
        public void Insertar(Cliente cliente)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"INSERT INTO Cliente (IdPersona) 
                                 VALUES (@IdPersona); 
                                 SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdPersona", cliente.IdPersona);

                // Devuelve el ID generado
                cliente.IdCliente = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Devuelve todos los clientes con sus datos personales
        public List<Cliente> ObtenerTodos()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT c.IdCliente, p.IdPersona, p.Nombre, p.Apellido, p.DNI, p.Email
                                 FROM Cliente c
                                 INNER JOIN Persona p ON c.IdPersona = p.IdPersona";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente c = new Cliente
                    {
                        IdCliente = Convert.ToInt32(reader["IdCliente"]),
                        IdPersona = Convert.ToInt32(reader["IdPersona"]),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Dni = Convert.ToInt32(reader["DNI"]),
                        Email = reader["Email"].ToString()
                    };
                    lista.Add(c);
                }
            }

            return lista;
        }

        // Busca un cliente por DNI
        public Cliente BuscarPorDni(int dni)
        {
            Cliente cliente = null;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT c.IdCliente, p.IdPersona, p.Nombre, p.Apellido, p.DNI, p.Email
                                 FROM Cliente c
                                 INNER JOIN Persona p ON c.IdPersona = p.IdPersona
                                 WHERE p.DNI = @DNI";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DNI", dni);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    cliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(reader["IdCliente"]),
                        IdPersona = Convert.ToInt32(reader["IdPersona"]),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Dni = Convert.ToInt32(reader["DNI"]),
                        Email = reader["Email"].ToString()
                    };
                }
            }

            return cliente;
        }

        // Actualiza los datos del cliente (solo lo de persona)
        public void Actualizar(Cliente cliente)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"UPDATE Persona 
                                 SET Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, Email = @Email
                                 WHERE IdPersona = @IdPersona";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@DNI", cliente.Dni);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@IdPersona", cliente.IdPersona);

                cmd.ExecuteNonQuery();
            }
        }

        // Elimina un cliente de la tabla Cliente y su Persona asociada
        public void Eliminar(int idCliente, int idPersona)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string queryCliente = "DELETE FROM Cliente WHERE IdCliente = @IdCliente";
                SqlCommand cmdCliente = new SqlCommand(queryCliente, conn);
                cmdCliente.Parameters.AddWithValue("@IdCliente", idCliente);
                cmdCliente.ExecuteNonQuery();

                string queryPersona = "DELETE FROM Persona WHERE IdPersona = @IdPersona";
                SqlCommand cmdPersona = new SqlCommand(queryPersona, conn);
                cmdPersona.Parameters.AddWithValue("@IdPersona", idPersona);
                cmdPersona.ExecuteNonQuery();
            }
        }
    }
}


