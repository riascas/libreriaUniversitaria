using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;
using BCrypt.Net;    

namespace LibreriaUniversitaria.DAL
{
    public class EmpleadoDAL
    {
        private readonly ConexionDAL _conexion = new ConexionDAL();

        public List<Empleado> ObtenerTodos()
        {
            var lista = new List<Empleado>();
            const string sql = @"
                SELECT e.IdEmpleado, p.IdPersona,
                       p.Nombre, p.Apellido, p.Dni, p.Email,
                       p.IdDomicilio, e.Rol
                  FROM Empleado e
             LEFT JOIN Persona   p ON e.IdPersona = p.IdPersona;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        lista.Add(new Empleado(
                            idPersona: rdr.GetInt32(1),
                            nombre: rdr.GetString(2),
                            apellido: rdr.GetString(3),
                            dni: rdr.GetInt32(4),
                            email: rdr.GetString(5),
                            domicilio: null,
                            idEmpleado: rdr.GetInt32(0),
                            rol: rdr.GetString(7)
                        ));
                    }
                }
            }
            return lista;
        }

        public Empleado ObtenerPorId(int idEmpleado)
        {
            return ObtenerTodos().Find(e => e.IdEmpleado == idEmpleado);
        }

        public bool ValidarLogin(string email, string password)
        {
            const string sql = @"
                SELECT ClaveHash
                  FROM Empleado e
                  JOIN Persona  p ON e.IdPersona = p.IdPersona
                 WHERE p.Email = @em;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@em", email);
                conn.Open();
                var hash = cmd.ExecuteScalar() as string;
                return hash != null && BCrypt.Net.BCrypt.Verify(password, hash);
            }
        }

        public void Insertar(Empleado e)
        {
            const string sql = @"
                INSERT INTO Persona
                  (Nombre, Apellido, Dni, Email, IdDomicilio)
                VALUES
                  (@n, @a, @d, @em, @dom);
                DECLARE @pid INT = SCOPE_IDENTITY();
                INSERT INTO Empleado
                  (IdPersona, Rol, ClaveHash)
                VALUES
                  (@pid, @rol, @hash);";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@n", e.Nombre);
                cmd.Parameters.AddWithValue("@a", e.Apellido);
                cmd.Parameters.AddWithValue("@d", e.Dni);
                cmd.Parameters.AddWithValue("@em", e.Email);
                cmd.Parameters.AddWithValue("@dom", (object)e.Domicilio?.IdDomicilio ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@rol", e.Rol);
                cmd.Parameters.AddWithValue("@hash", BCrypt.Net.BCrypt.HashPassword(e.Clave));
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Empleado e)
        {
            const string sql = @"
                UPDATE Persona
                   SET Nombre = @n, Apellido = @a, Dni = @d, Email = @em
                 WHERE IdPersona = @pid;
                UPDATE Empleado
                   SET Rol = @rol, ClaveHash = @hash
                 WHERE IdEmpleado = @eid;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@n", e.Nombre);
                cmd.Parameters.AddWithValue("@a", e.Apellido);
                cmd.Parameters.AddWithValue("@d", e.Dni);
                cmd.Parameters.AddWithValue("@em", e.Email);
                cmd.Parameters.AddWithValue("@pid", e.IdPersona);
                cmd.Parameters.AddWithValue("@rol", e.Rol);
                cmd.Parameters.AddWithValue("@hash", e.ClaveHash);
                cmd.Parameters.AddWithValue("@eid", e.IdEmpleado);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idEmpleado, int idPersona)
        {
            const string sql = @"
                DELETE FROM Empleado WHERE IdEmpleado = @eid;
                DELETE FROM Persona  WHERE IdPersona  = @pid;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@eid", idEmpleado);
                cmd.Parameters.AddWithValue("@pid", idPersona);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
