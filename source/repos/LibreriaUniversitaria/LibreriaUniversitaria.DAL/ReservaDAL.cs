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
    /// <summary>
    /// Clase para acceder a los datos de las reservas desde la base de datos.
    /// </summary>
    public class ReservaDAL
    {
        private readonly ConexionDAL conexion;

        public ReservaDAL()
        {
            conexion = new ConexionDAL();
        }

        /// <summary>
        /// Devuelve todas las reservas registradas.
        /// </summary>
        public List<Reserva> ObtenerTodas()
        {
            List<Reserva> reservas = new List<Reserva>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"SELECT r.IdReserva, r.IdCliente, r.IdEstadoReserva, r.Fecha,
                                        c.Nombre, c.Apellido, e.Nombre AS EstadoNombre
                                 FROM Reserva r
                                 JOIN Cliente c ON r.IdCliente = c.IdCliente
                                 JOIN EstadoReserva e ON r.IdEstadoReserva = e.IdEstadoReserva";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reserva r = new Reserva
                        {
                            IdReserva = Convert.ToInt32(reader["IdReserva"]),
                            IdCliente = Convert.ToInt32(reader["IdCliente"]),
                            IdEstadoReserva = Convert.ToInt32(reader["IdEstadoReserva"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Cliente = new Cliente
                            {
                                IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString()
                            },
                            Estado = new EstadoReserva
                            {
                                IdEstadoReserva = Convert.ToInt32(reader["IdEstadoReserva"]),
                                Nombre = reader["EstadoNombre"].ToString()
                            }
                        };

                        reservas.Add(r);
                    }
                }
            }

            return reservas;
        }

        /// <summary>
        /// Inserta una nueva reserva en la base de datos.
        /// </summary>
        public int Insertar(Reserva reserva)
        {
            int idGenerado = 0;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Reserva (IdCliente, IdEstadoReserva, Fecha)
                                 VALUES (@IdCliente, @IdEstadoReserva, @Fecha);
                                 SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCliente", reserva.IdCliente);
                cmd.Parameters.AddWithValue("@IdEstadoReserva", reserva.IdEstadoReserva);
                cmd.Parameters.AddWithValue("@Fecha", reserva.Fecha);

                conn.Open();
                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return idGenerado;
        }

        /// <summary>
        /// Actualiza el estado de una reserva.
        /// </summary>
        public void ActualizarEstado(int idReserva, int idNuevoEstado)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "UPDATE Reserva SET IdEstadoReserva = @IdEstado WHERE IdReserva = @IdReserva";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEstado", idNuevoEstado);
                cmd.Parameters.AddWithValue("@IdReserva", idReserva);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Devuelve todas las reservas en estado Pendiente.
        /// </summary>
        public List<Reserva> ObtenerPendientes()
        {
            List<Reserva> pendientes = new List<Reserva>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"SELECT r.IdReserva, r.IdCliente, r.IdEstadoReserva, r.Fecha,
                                        c.Nombre, c.Apellido, e.Nombre AS EstadoNombre
                                 FROM Reserva r
                                 JOIN Cliente c ON r.IdCliente = c.IdCliente
                                 JOIN EstadoReserva e ON r.IdEstadoReserva = e.IdEstadoReserva
                                 WHERE r.IdEstadoReserva = 1"; // Suponiendo que 1 = Pendiente

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Reserva r = new Reserva
                        {
                            IdReserva = Convert.ToInt32(reader["IdReserva"]),
                            IdCliente = Convert.ToInt32(reader["IdCliente"]),
                            IdEstadoReserva = Convert.ToInt32(reader["IdEstadoReserva"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Cliente = new Cliente
                            {
                                IdCliente = Convert.ToInt32(reader["IdCliente"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString()
                            },
                            Estado = new EstadoReserva
                            {
                                IdEstadoReserva = Convert.ToInt32(reader["IdEstadoReserva"]),
                                Nombre = reader["EstadoNombre"].ToString()
                            }
                        };

                        pendientes.Add(r);
                    }
                }
            }

            return pendientes;
        }

        /// <summary>
        /// Restaura el stock de los libros reservados cuando la reserva vence.
        /// </summary>
        public void RestaurarStockDeReserva(int idReserva)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"UPDATE Libro
                                 SET Stock = Stock + dr.Cantidad
                                 FROM Libro l
                                 INNER JOIN DetalleReserva dr ON l.IdLibro = dr.IdLibro
                                 WHERE dr.IdReserva = @IdReserva";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdReserva", idReserva);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}


