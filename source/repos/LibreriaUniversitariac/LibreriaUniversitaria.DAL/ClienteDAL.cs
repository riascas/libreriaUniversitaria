using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    /// <summary>
    /// Acceso a datos para la entidad Cliente.
    /// </summary>
    public class ClienteDAL
    {
        private readonly ConexionDAL _conexion = new ConexionDAL();

        /// <summary>
        /// Obtiene todos los clientes.
        /// </summary>
        public List<Cliente> ObtenerTodos()
        {
            var lista = new List<Cliente>();
            const string sql = @"
                SELECT
                    CAST(c.IdCliente    AS INT) AS IdCliente,
                    CAST(p.IdPersona    AS INT) AS IdPersona,
                    p.Nombre,
                    p.Apellido,
                    CAST(p.DNI          AS INT) AS DNI,
                    p.Email,
                    CAST(c.EsEstudiante AS BIT) AS EsEstudiante
                FROM Cliente c
                JOIN Persona p ON c.IdPersona = p.IdPersona;
            ";

            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int idCli = int.TryParse(dr["IdCliente"].ToString(), out var t1) ? t1 : 0;
                        int idPers = int.TryParse(dr["IdPersona"].ToString(), out var t2) ? t2 : 0;
                        int dni = int.TryParse(dr["DNI"].ToString(), out var t3) ? t3 : 0;
                        bool esEst = bool.TryParse(dr["EsEstudiante"].ToString(), out var b) ? b : false;

                        lista.Add(new Cliente
                        {
                            IdCliente = idCli,
                            IdPersona = idPers,
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            Dni = dni,
                            Email = dr["Email"] == DBNull.Value
                                               ? null
                                               : dr["Email"].ToString(),
                            EsEstudiante = esEst
                        });
                    }
                }
            }

            return lista;
        }

        /// <summary>
        /// Obtiene un cliente por su Id.
        /// </summary>
        public Cliente ObtenerPorId(int idCliente)
        {
            const string sql = @"
                SELECT
                    CAST(c.IdCliente    AS INT) AS IdCliente,
                    CAST(p.IdPersona    AS INT) AS IdPersona,
                    p.Nombre,
                    p.Apellido,
                    CAST(p.DNI          AS INT) AS DNI,
                    p.Email,
                    CAST(c.EsEstudiante AS BIT) AS EsEstudiante
                FROM Cliente c
                JOIN Persona p ON c.IdPersona = p.IdPersona
                WHERE c.IdCliente = @id;
            ";

            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idCliente);
                conn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    if (!dr.Read()) return null;

                    int idCli = int.TryParse(dr["IdCliente"].ToString(), out var t1) ? t1 : 0;
                    int idPers = int.TryParse(dr["IdPersona"].ToString(), out var t2) ? t2 : 0;
                    int dni = int.TryParse(dr["DNI"].ToString(), out var t3) ? t3 : 0;
                    bool esEst = bool.TryParse(dr["EsEstudiante"].ToString(), out var b) ? b : false;

                    return new Cliente
                    {
                        IdCliente = idCli,
                        IdPersona = idPers,
                        Nombre = dr["Nombre"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        Dni = dni,
                        Email = dr["Email"] == DBNull.Value
                                           ? null
                                           : dr["Email"].ToString(),
                        EsEstudiante = esEst
                    };
                }
            }
        }

        /// <summary>
        /// Busca un cliente por DNI.
        /// </summary>
        public Cliente ObtenerPorDNI(int dniBuscado)
        {
            const string sql = @"
                SELECT
                    CAST(c.IdCliente    AS INT) AS IdCliente,
                    CAST(p.IdPersona    AS INT) AS IdPersona,
                    p.Nombre,
                    p.Apellido,
                    CAST(p.DNI          AS INT) AS DNI,
                    p.Email,
                    CAST(c.EsEstudiante AS BIT) AS EsEstudiante
                FROM Cliente c
                JOIN Persona p ON c.IdPersona = p.IdPersona
                WHERE p.DNI = @dni;
            ";

            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@dni", dniBuscado);
                conn.Open();
                using (var dr = cmd.ExecuteReader())
                {
                    if (!dr.Read()) return null;

                    int idCli = int.TryParse(dr["IdCliente"].ToString(), out var t1) ? t1 : 0;
                    int idPers = int.TryParse(dr["IdPersona"].ToString(), out var t2) ? t2 : 0;
                    int dniVal = int.TryParse(dr["DNI"].ToString(), out var t3) ? t3 : 0;
                    bool esEst = bool.TryParse(dr["EsEstudiante"].ToString(), out var b) ? b : false;

                    return new Cliente
                    {
                        IdCliente = idCli,
                        IdPersona = idPers,
                        Nombre = dr["Nombre"].ToString(),
                        Apellido = dr["Apellido"].ToString(),
                        Dni = dniVal,
                        Email = dr["Email"] == DBNull.Value
                                           ? null
                                           : dr["Email"].ToString(),
                        EsEstudiante = esEst
                    };
                }
            }
        }

        /// <summary>
        /// Inserta una nueva Persona y un nuevo Cliente (en una única transacción).
        /// </summary>
        public void Insertar(Cliente c)
        {
            using (var conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // 1) Insertar Persona
                        const string sqlPersona = @"
                            INSERT INTO Persona (Nombre, Apellido, DNI, Email)
                            VALUES (@nombre, @apellido, @dni, @email);
                            SELECT SCOPE_IDENTITY();
                        ";
                        int newIdPersona;
                        using (var cmdP = new SqlCommand(sqlPersona, conn, tran))
                        {
                            cmdP.Parameters.AddWithValue("@nombre", c.Nombre);
                            cmdP.Parameters.AddWithValue("@apellido", c.Apellido);
                            cmdP.Parameters.AddWithValue("@dni", c.Dni);
                            cmdP.Parameters.AddWithValue("@email", (object)c.Email ?? DBNull.Value);
                            newIdPersona = Convert.ToInt32(cmdP.ExecuteScalar());
                        }

                        // 2) Insertar Cliente
                        const string sqlCliente = @"
                            INSERT INTO Cliente (IdPersona, EsEstudiante)
                            VALUES (@idPersona, @esEst);
                        ";
                        using (var cmdC = new SqlCommand(sqlCliente, conn, tran))
                        {
                            cmdC.Parameters.AddWithValue("@idPersona", newIdPersona);
                            cmdC.Parameters.AddWithValue("@esEst", c.EsEstudiante);
                            cmdC.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Actualiza la Persona y el Cliente.
        /// </summary>
        public void Actualizar(Cliente c)
        {
            using (var conn = _conexion.ObtenerConexion())
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // 1) UPDATE Persona
                        const string sqlUpdP = @"
                            UPDATE Persona
                            SET Nombre   = @nombre,
                                Apellido = @apellido,
                                DNI      = @dni,
                                Email    = @email
                            WHERE IdPersona = @idPersona;
                        ";
                        using (var cmdP = new SqlCommand(sqlUpdP, conn, tran))
                        {
                            cmdP.Parameters.AddWithValue("@nombre", c.Nombre);
                            cmdP.Parameters.AddWithValue("@apellido", c.Apellido);
                            cmdP.Parameters.AddWithValue("@dni", c.Dni);
                            cmdP.Parameters.AddWithValue("@email", (object)c.Email ?? DBNull.Value);
                            cmdP.Parameters.AddWithValue("@idPersona", c.IdPersona);
                            cmdP.ExecuteNonQuery();
                        }

                        // 2) UPDATE Cliente
                        const string sqlUpdC = @"
                            UPDATE Cliente
                            SET EsEstudiante = @esEst
                            WHERE IdCliente = @idCliente;
                        ";
                        using (var cmdC = new SqlCommand(sqlUpdC, conn, tran))
                        {
                            cmdC.Parameters.AddWithValue("@esEst", c.EsEstudiante);
                            cmdC.Parameters.AddWithValue("@idCliente", c.IdCliente);
                            cmdC.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Elimina un cliente y su persona asociada.
        /// </summary>
        public void Eliminar(int idCliente, int idPersona)
        {
            const string sql = @"
                DELETE FROM Cliente WHERE IdCliente = @idCli;
                DELETE FROM Persona WHERE IdPersona = @idPers;
            ";

            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@idCli", idCliente);
                cmd.Parameters.AddWithValue("@idPers", idPersona);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
