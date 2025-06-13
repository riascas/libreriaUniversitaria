using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;
using Libreria.DAL;

namespace LibreriaUniversitaria.Datos
{
    /// <summary>
    /// Repositorio para acceder y manipular reservas en la base de datos.
    /// </summary>
    public static class ReservaRepository
    {
        /// <summary>
        /// Devuelve todas las reservas registradas.
        /// </summary>
        public static List<Reserva> ObtenerTodas()
        {
            List<Reserva> reservas = new List<Reserva>();

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"SELECT r.IdReserva, r.FechaReserva, 
                                        c.IdCliente, c.Nombre AS NombreCliente, c.Apellido,
                                        e.IdEstado AS IdEstadoReserva, e.Nombre AS NombreEstado
                                 FROM Reserva r
                                 JOIN Cliente c ON r.IdCliente = c.IdCliente
                                 JOIN EstadoReserva e ON r.IdEstado = e.IdEstado";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var reserva = new Reserva
                        {
                            IdReserva = reader.GetInt32(0),
                            FechaReserva = reader.GetDateTime(1),
                            Cliente = new Cliente
                            {
                                IdCliente = reader.GetInt32(2),
                                Nombre = reader.GetString(3),
                                Apellido = reader.GetString(4)
                            },
                            Estado = new EstadoReserva
                            {
                                IdEstadoReserva = reader.GetInt32(5),
                                Nombre = reader.GetString(6)
                            }
                        };

                        reservas.Add(reserva);
                    }
                }
            }

            return reservas;
        }

        /// <summary>
        /// Inserta una nueva reserva en la base de datos.
        /// </summary>
        public static void Insertar(Reserva reserva)
        {
            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"INSERT INTO Reserva (FechaReserva, IdCliente, IdEstado) 
                                 VALUES (@Fecha, @IdCliente, @IdEstado)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Fecha", reserva.FechaReserva);
                cmd.Parameters.AddWithValue("@IdCliente", reserva.Cliente.IdCliente);
                cmd.Parameters.AddWithValue("@IdEstado", reserva.Estado.IdEstadoReserva);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Devuelve una reserva específica por su ID.
        /// </summary>
        public static Reserva ObtenerPorId(int idReserva)
        {
            Reserva reserva = null;

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"SELECT r.IdReserva, r.FechaReserva, 
                                        c.IdCliente, c.Nombre AS NombreCliente, c.Apellido,
                                        e.IdEstado AS IdEstadoReserva, e.Nombre AS NombreEstado
                                 FROM Reserva r
                                 JOIN Cliente c ON r.IdCliente = c.IdCliente
                                 JOIN EstadoReserva e ON r.IdEstado = e.IdEstado
                                 WHERE r.IdReserva = @IdReserva";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdReserva", idReserva);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        reserva = new Reserva
                        {
                            IdReserva = reader.GetInt32(0),
                            FechaReserva = reader.GetDateTime(1),
                            Cliente = new Cliente
                            {
                                IdCliente = reader.GetInt32(2),
                                Nombre = reader.GetString(3),
                                Apellido = reader.GetString(4)
                            },
                            Estado = new EstadoReserva
                            {
                                IdEstadoReserva = reader.GetInt32(5),
                                Nombre = reader.GetString(6)
                            }
                        };
                    }
                }
            }

            return reserva;
        }

        /// <summary>
        /// Actualiza el estado de una reserva (sin transacción).
        /// </summary>
        public static void ActualizarEstado(int idReserva, int idNuevoEstado)
        {
            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = "UPDATE Reserva SET IdEstado = @IdEstado WHERE IdReserva = @IdReserva";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEstado", idNuevoEstado);
                cmd.Parameters.AddWithValue("@IdReserva", idReserva);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Actualiza el estado de una reserva dentro de una transacción existente.
        /// </summary>
        public static void ActualizarEstado(int idReserva, int idNuevoEstado, SqlConnection conn, SqlTransaction transaction)
        {
            string query = "UPDATE Reserva SET IdEstado = @IdEstado WHERE IdReserva = @IdReserva";
            SqlCommand cmd = new SqlCommand(query, conn, transaction);
            cmd.Parameters.AddWithValue("@IdEstado", idNuevoEstado);
            cmd.Parameters.AddWithValue("@IdReserva", idReserva);
            cmd.ExecuteNonQuery();
        }
    }
}
