using BLL_Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT_Libreria;

namespace Sistema_Libreria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        EmpleadoService servicio = new EmpleadoService();

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Debe completar usuario y clave.");
                return;
            }

            Empleado empleadoLogueado = servicio.Login(usuario, clave);

            if (empleadoLogueado != null)
            {
                // Paso el empleado al form de Inicio
                Inicio form = new Inicio(empleadoLogueado);
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos.");
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e) {
            txtUsuario.Text = "";
            txtClave.Text = "";
            this.Show();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
