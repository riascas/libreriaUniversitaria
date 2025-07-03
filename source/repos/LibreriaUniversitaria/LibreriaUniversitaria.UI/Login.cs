using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaUniversitaria.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); // Carga el diseño que está en Login.Designer.cs
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            // Crea el formulario de inicio, lo muestra y oculta el login
            Inicio form = new Inicio();
            form.Show();
            this.Hide();

            // Al cerrar el formulario Inicio, volvemos a mostrar el Login
            form.FormClosing += frm_closing;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación o solo el login
            this.Close();
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            // Limpiamos los campos de texto al volver
            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Opcional: código al cargar el login
        }



        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
