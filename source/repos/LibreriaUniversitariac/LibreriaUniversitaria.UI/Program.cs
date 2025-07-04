using System;
using System.Windows.Forms;

namespace LibreriaUniversitaria.UI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Iniciar la aplicación con frmLogin
            Application.Run(new frmLogin());
        }
    }
}
