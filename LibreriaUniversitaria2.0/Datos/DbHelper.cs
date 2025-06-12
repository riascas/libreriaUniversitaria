using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Libreria.DAL
{
    /// <summary>
    /// Clase auxiliar para acceder a la cadena de conexión definida en App.config
    /// </summary>
    public static class DbHelper
    {
        public static string CadenaConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
            }
        }
    }
}
