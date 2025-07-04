using System.Data.SqlClient;

namespace LibreriaUniversitaria.DAL
{
    /// <summary>
    /// Encapsula la cadena de conexión y la creación de SqlConnection.
    /// </summary>
    public class ConexionDAL
    {
        private readonly string _cadena;

        public ConexionDAL()
        {
            // Ajustá tu servidor/instancia según sea necesario
            _cadena = @"Server=INF-026\SQLEXPRESS;Database=LibreriaUniversitaria;Trusted_Connection=True;";
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadena);
        }
    }
}
