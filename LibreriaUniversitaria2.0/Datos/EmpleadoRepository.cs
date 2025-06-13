using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;
using Libreria.DAL;

namespace LibreriaUniversitaria.Datos
{
    /// <summary>
    /// Clase que gestiona el acceso a la base de datos para empleados.
    /// </summary>
    public static class EmpleadoRepository
    {
        /// <summary>
        /// Devuelve todos los empleados registrados.
        /// </summary>
        public static List<Empleado> ObtenerTodos()
        {
            List<Empleado> empleados = new List<Empleado>();

            try
            {
                using (SqlConnection conn = DbHelper.ObtenerConexion())
                {
                    string query = @"SELECT e.IdEmpleado, e.Nombre, e.Apellido, e.DNI, e.Clave,
                                            r.IdRol, r.Nombre AS NombreRol
                                     FROM Empleado e
                                     JOIN Rol r ON e.IdRol = r.IdRol";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empleado emp = new Empleado
                            {
                                IdEmpleado = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                DNI = reader.GetString(3),       // Cambiado Documento por DNI
                                Clave = reader.GetString(4),
                                Rol = new Rol
                                {
                                    IdRol = reader.GetInt32(5),
                                    Nombre = reader.GetString(6)
                                }
                            };

                            empleados.Add(emp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo o relanzamiento de excepción personalizado
                throw new Exception("Error al obtener empleados: " + ex.Message);
            }

            return empleados;
        }

        /// <summary>
        /// Busca un empleado por número de DNI y clave (para login).
        /// </summary>
        public static Empleado ObtenerPorDocumentoYClave(string dni, string clave)
        {
            Empleado emp = null;

            try
            {
                using (SqlConnection conn = DbHelper.ObtenerConexion())
                {
                    string query = @"SELECT e.IdEmpleado, e.Nombre, e.Apellido, e.DNI, e.Clave,
                                            r.IdRol, r.Nombre AS NombreRol
                                     FROM Empleado e
                                     JOIN Rol r ON e.IdRol = r.IdRol
                                     WHERE e.DNI = @DNI AND e.Clave = @Clave";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    cmd.Parameters.AddWithValue("@Clave", clave);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            emp = new Empleado
                            {
                                IdEmpleado = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                DNI = reader.GetString(3),
                                Clave = reader.GetString(4),
                                Rol = new Rol
                                {
                                    IdRol = reader.GetInt32(5),
                                    Nombre = reader.GetString(6)
                                }
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar empleado por DNI y clave: " + ex.Message);
            }

            return emp;
        }

        /// <summary>
        /// Devuelve todos los empleados que tengan el rol indicado.
        /// </summary>
        public static List<Empleado> ObtenerPorRol(string nombreRol)
        {
            List<Empleado> empleados = new List<Empleado>();

            try
            {
                using (SqlConnection conn = DbHelper.ObtenerConexion())
                {
                    string query = @"SELECT e.IdEmpleado, e.Nombre, e.Apellido, e.DNI, e.Clave,
                                            r.IdRol, r.Nombre AS NombreRol
                                     FROM Empleado e
                                     JOIN Rol r ON e.IdRol = r.IdRol
                                     WHERE r.Nombre = @NombreRol";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NombreRol", nombreRol);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Empleado emp = new Empleado
                            {
                                IdEmpleado = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                DNI = reader.GetString(3),
                                Clave = reader.GetString(4),
                                Rol = new Rol
                                {
                                    IdRol = reader.GetInt32(5),
                                    Nombre = reader.GetString(6)
                                }
                            };

                            empleados.Add(emp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener empleados por rol: " + ex.Message);
            }

            return empleados;
        }
    }
}
