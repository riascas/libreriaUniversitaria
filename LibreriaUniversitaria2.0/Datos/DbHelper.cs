using System.Data.SqlClient;

namespace LibreriaUniversitaria.Datos
{
    /// <summary>
    /// Clase helper para acceder a la base de datos.
    /// Contiene la cadena de conexión y métodos reutilizables.
    /// </summary>
    public static class DbHelper
    {
        // Cadena de conexión fija. 
        private static string cadenaConexion = "Data Source=.;Initial Catalog=LibreriaUniversitaria;Integrated Security=True";

        /// <summary>
        /// Permite acceder a la cadena de conexión desde otros repositorios.
        /// </summary>
        public static string CadenaConexion => cadenaConexion;

        /// <summary>
        /// Devuelve una nueva conexión SQL ya configurada.
        /// </summary>
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
