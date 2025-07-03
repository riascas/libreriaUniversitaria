using System;
using System.Data;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    /// <summary>
    /// Clase responsable del acceso a datos de la entidad Empleado.
    /// </summary>
    public class EmpleadoDAL
    {
        private readonly ConexionDAL conexion;

        /// <summary>
        /// Constructor que inicializa la conexión a la base de datos.
        /// </summary>
        public EmpleadoDAL()
        {
            conexion = new ConexionDAL();
        }

        /// <summary>
        /// Valida el login de un empleado buscando por DNI (en Persona) y clave (en Empleado).
        /// También trae el nombre del rol para mostrar en el sistema.
        /// </summary>
        /// <param name="documento">Número de DNI ingresado</param>
        /// <param name="clave">Clave ingresada</param>
        /// <returns>Empleado completo si existe, null si no lo encuentra</returns>
        public Empleado ValidarLogin(int documento, string clave)
        {
            Empleado empleado = null;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"
                    SELECT 
                        e.IdEmpleado,
                        e.IdRol,
                        e.Clave,
                        p.DNI,
                        p.Nombre,
                        p.Apellido,
                        p.Email,
                        r.Nombre AS NombreRol
                    FROM Empleado e
                    INNER JOIN Persona p ON e.IdPersona = p.IdPersona
                    INNER JOIN Rol r ON e.IdRol = r.IdRol
                    WHERE p.DNI = @dni AND e.Clave = @clave";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dni", documento);
                cmd.Parameters.AddWithValue("@clave", clave);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        empleado = new Empleado
                        {
                            IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                            IdRol = Convert.ToInt32(reader["IdRol"]),
                            Clave = reader["Clave"].ToString(),
                            Dni = Convert.ToInt32(reader["DNI"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Email = reader["Email"].ToString(),
                            NombreRol = reader["NombreRol"].ToString()
                        };
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al validar login: " + ex.Message);
                }
            }

            return empleado;
        }
    }
}
