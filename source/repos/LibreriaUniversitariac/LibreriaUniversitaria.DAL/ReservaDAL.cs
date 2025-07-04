using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    public class ReservaDAL
    {
        private readonly ConexionDAL _conexion = new ConexionDAL();

        public List<Reserva> ObtenerTodos()
        {
            var lista = new List<Reserva>();
            const string sqlCab = @"
                SELECT r.IdReserva, r.FechaReserva, r.Estado,
                       c.IdCliente, p.Nombre, p.Apellido, p.Dni, p.Email
                  FROM Reserva r
                  JOIN Cliente c ON r.IdCliente = c.IdCliente
                  JOIN Persona p ON c.IdPersona = p.IdPersona;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sqlCab, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        lista.Add(new Reserva
                        {
                            IdReserva = reader.GetInt32(0),
                            FechaReserva = reader.GetDateTime(1),
                            Estado = (EstadoReserva)Enum.Parse(typeof(EstadoReserva), reader.GetString(2)),
                            Cliente = new Cliente
                            {
                                IdCliente = reader.GetInt32(3),
                                Nombre = reader.GetString(4),
                                Apellido = reader.GetString(5),
                                Dni = reader.GetInt32(6),
                                Email = reader.GetString(7)
                            }
                        });
                    }
            }

            foreach (var res in lista)
                res.Detalles = ObtenerDetalles(res.IdReserva);

            return lista;
        }

        private List<DetalleReserva> ObtenerDetalles(int idReserva)
        {
            var dets = new List<DetalleReserva>();
            const string sqlDet = @"
                SELECT d.IdReserva, d.IdLibro, l.Titulo, d.Cantidad, d.Subtotal
                  FROM DetalleReserva d
                  JOIN Libro l ON d.IdLibro = l.IdLibro
                 WHERE d.IdReserva = @idRes;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sqlDet, conn))
            {
                cmd.Parameters.AddWithValue("@idRes", idReserva);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        dets.Add(new DetalleReserva
                        {
                            IdReserva = reader.GetInt32(0),
                            IdLibro = reader.GetInt32(1),
                            Libro = new Libro
                            {
                                IdLibro = reader.GetInt32(1),
                                Titulo = reader.GetString(2)
                            },
                            Cantidad = reader.GetInt32(3),
                            Subtotal = reader.GetDecimal(4)
                        });
            }
            return dets;
        }

        public int InsertarConDetalles(Reserva r)
        {
            int newId;
            const string sqlCab = @"
                INSERT INTO Reserva (FechaReserva, Estado, IdCliente)
                VALUES (@fecha, @estado, @idCli);
                SELECT CAST(SCOPE_IDENTITY() AS INT);";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sqlCab, conn))
            {
                cmd.Parameters.AddWithValue("@fecha", r.FechaReserva);
                cmd.Parameters.AddWithValue("@estado", r.Estado.ToString());
                cmd.Parameters.AddWithValue("@idCli", r.Cliente.IdCliente);
                conn.Open();
                newId = (int)cmd.ExecuteScalar();
            }

            const string sqlDet = @"
                INSERT INTO DetalleReserva (IdReserva, IdLibro, Cantidad, Subtotal)
                VALUES (@idRes, @idLib, @cant, @subt);";
            foreach (var d in r.Detalles)
                using (var conn = _conexion.ObtenerConexion())
                using (var cmd = new SqlCommand(sqlDet, conn))
                {
                    cmd.Parameters.AddWithValue("@idRes", newId);
                    cmd.Parameters.AddWithValue("@idLib", d.IdLibro);
                    cmd.Parameters.AddWithValue("@cant", d.Cantidad);
                    cmd.Parameters.AddWithValue("@subt", d.Subtotal);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

            return newId;
        }

        public void ActualizarEstado(int idReserva, EstadoReserva nuevoEstado)
        {
            const string sql = @"
                UPDATE Reserva
                   SET Estado = @estado
                 WHERE IdReserva = @idRes;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@estado", nuevoEstado.ToString());
                cmd.Parameters.AddWithValue("@idRes", idReserva);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Reserva ObtenerPorId(int id) => ObtenerTodos().Find(r => r.IdReserva == id);
    }
}
