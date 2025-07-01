using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaUniversitaria.DAL;


namespace LibreriaUniversitaria.UI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // PRUEBA TEMPORAL - Eliminar esto cuando tengas frmLogin
            ConexionDAL conexion = new ConexionDAL();
            conexion.ProbarConexion();
            MessageBox.Show("Test de conexión exitoso. Ahora podés eliminar este código y levantar tu formulario.");

            // CUANDO TENGAS FORMULARIOS:
            // Application.Run(new frmLogin());
        }


    }
}
