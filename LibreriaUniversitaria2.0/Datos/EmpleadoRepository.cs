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

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"SELECT e.IdEmpleado, e.Nombre, e.Apellido, e.Documento, e.Clave,
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
                            Documento = reader.GetString(3),
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

            return empleados;
        }

        /// <summary>
        /// Busca un empleado por número de documento y clave (para login).
        /// </summary>
        public static Empleado ObtenerPorDocumentoYClave(string documento, string clave)
        {
            Empleado emp = null;

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"SELECT e.IdEmpleado, e.Nombre, e.Apellido, e.Documento, e.Clave,
                                        r.IdRol, r.Nombre AS NombreRol
                                 FROM Empleado e
                                 JOIN Rol r ON e.IdRol = r.IdRol
                                 WHERE e.Documento = @Documento AND e.Clave = @Clave";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Documento", documento);
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
                            Documento = reader.GetString(3),
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

            return emp;
        }

        /// <summary>
        /// Devuelve todos los empleados que tengan el rol indicado.
        /// </summary>
        public static List<Empleado> ObtenerPorRol(string nombreRol)
        {
            List<Empleado> empleados = new List<Empleado>();

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"SELECT e.IdEmpleado, e.Nombre, e.Apellido, e.Documento, e.Clave,
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
                            Documento = reader.GetString(3),
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

            return empleados;
        }
    }
}

