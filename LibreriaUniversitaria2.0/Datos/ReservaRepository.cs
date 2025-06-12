using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;
using Libreria.DAL;

namespace LibreriaUniversitaria.Datos
{
    /// <summary>
    /// Clase que gestiona el acceso a la tabla Reserva en la base de datos.
    /// </summary>
    public static class ReservaRepository
    {
        /// <summary>
        /// Devuelve todas las reservas con cliente, estado y sus ítems.
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

                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Reserva reserva = new Reserva
                        {
                            IdReserva = Convert.ToInt32(lector["IdReserva"]),
                            FechaReserva = Convert.ToDateTime(lector["FechaReserva"]),
                            Cliente = new Cliente
                            {
                                IdCliente = Convert.ToInt32(lector["IdCliente"]),
                                Nombre = lector["NombreCliente"].ToString(),
                                Apellido = lector["Apellido"].ToString()
                            },
                            Estado = new EstadoReserva
                            {
                                IdEstadoReserva = Convert.ToInt32(lector["IdEstadoReserva"]),
                                Nombre = lector["NombreEstado"].ToString()
                            },
                            Items = new List<DetalleReserva>()
                        };

                        // CORREGIDO: llamamos al método correcto
                        reserva.Items = DetalleReservaRepository.ObtenerPorReserva(reserva.IdReserva);
                        reservas.Add(reserva);
                    }
                }
            }

            return reservas;
        }

        /// <summary>
        /// Busca una reserva por su ID.
        /// </summary>
        public static Reserva BuscarPorId(int idReserva)
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
                                 WHERE r.IdReserva = @idReserva";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idReserva", idReserva);
                conn.Open();

                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        reserva = new Reserva
                        {
                            IdReserva = Convert.ToInt32(lector["IdReserva"]),
                            FechaReserva = Convert.ToDateTime(lector["FechaReserva"]),
                            Cliente = new Cliente
                            {
                                IdCliente = Convert.ToInt32(lector["IdCliente"]),
                                Nombre = lector["NombreCliente"].ToString(),
                                Apellido = lector["Apellido"].ToString()
                            },
                            Estado = new EstadoReserva
                            {
                                IdEstadoReserva = Convert.ToInt32(lector["IdEstadoReserva"]),
                                Nombre = lector["NombreEstado"].ToString()
                            },
                            Items = new List<DetalleReserva>()
                        };

                        // CORREGIDO: llamada correcta al método de detalles
                        reserva.Items = DetalleReservaRepository.ObtenerPorReserva(reserva.IdReserva);
                    }
                }
            }

            return reserva;
        }

        /// <summary>
        /// Devuelve las reservas asociadas a un cliente específico.
        /// </summary>
        public static List<Reserva> ObtenerPorCliente(int idCliente)
        {
            List<Reserva> reservas = new List<Reserva>();

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"SELECT r.IdReserva, r.FechaReserva,
                                        c.IdCliente, c.Nombre AS NombreCliente, c.Apellido,
                                        e.IdEstado AS IdEstadoReserva, e.Nombre AS NombreEstado
                                 FROM Reserva r
                                 JOIN Cliente c ON r.IdCliente = c.IdCliente
                                 JOIN EstadoReserva e ON r.IdEstado = e.IdEstado
                                 WHERE r.IdCliente = @idCliente";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                conn.Open();

                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Reserva reserva = new Reserva
                        {
                            IdReserva = Convert.ToInt32(lector["IdReserva"]),
                            FechaReserva = Convert.ToDateTime(lector["FechaReserva"]),
                            Cliente = new Cliente
                            {
                                IdCliente = Convert.ToInt32(lector["IdCliente"]),
                                Nombre = lector["NombreCliente"].ToString(),
                                Apellido = lector["Apellido"].ToString()
                            },
                            Estado = new EstadoReserva
                            {
                                IdEstadoReserva = Convert.ToInt32(lector["IdEstadoReserva"]),
                                Nombre = lector["NombreEstado"].ToString()
                            },
                            Items = new List<DetalleReserva>()
                        };

                        // CORREGIDO: obtener ítems correctamente
                        reserva.Items = DetalleReservaRepository.ObtenerPorReserva(reserva.IdReserva);
                        reservas.Add(reserva);
                    }
                }
            }

            return reservas;
        }

        /// <summary>
        /// Inserta una nueva reserva con sus detalles.
        /// </summary>
        public static int Insertar(Reserva reserva)
        {
            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string insertQuery = @"INSERT INTO Reserva (FechaReserva, IdCliente, IdEstado)
                                       VALUES (@fecha, @idCliente, @idEstado);
                                       SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@fecha", reserva.FechaReserva);
                cmd.Parameters.AddWithValue("@idCliente", reserva.Cliente.IdCliente);
                cmd.Parameters.AddWithValue("@idEstado", reserva.Estado.IdEstadoReserva);

                conn.Open();
                int nuevoId = Convert.ToInt32(cmd.ExecuteScalar());

                // CORREGIDO: insertar detalles en el orden correcto
                foreach (var item in reserva.Items)
                {
                    DetalleReservaRepository.Insertar(item, nuevoId);
                }

                return nuevoId;
            }
        }
    }
}
