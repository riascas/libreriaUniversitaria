using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;
using LibreriaUniversitaria.Entidades.Excepciones;

namespace LibreriaUniversitaria.UI
{
    public partial class Login : Form
    {
        private readonly EmpleadoBLL empleadoBLL;

        public Login()
        {
            InitializeComponent();
            empleadoBLL = new EmpleadoBLL();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txtdocumento.Text) || string.IsNullOrWhiteSpace(txtclave.Text))
                    throw new LoginException("Debe ingresar el número de documento y la contraseña.");

                // Validamos que el documento sea numérico
                if (!int.TryParse(txtdocumento.Text, out int documento))
                    throw new LoginException("El número de documento debe contener solo números.");

                string clave = txtclave.Text;

                // Consultamos al BLL si el login es válido
                Empleado empleado = empleadoBLL.ValidarLogin(documento, clave);

                if (empleado == null)
                    throw new LoginException("Credenciales incorrectas. Verifique los datos ingresados.");

                // Si llegó hasta acá, el login fue exitoso. Abrimos la pantalla principal.
                Inicio formInicio = new Inicio(empleado); // Le pasamos el empleado con su nombre y rol
                formInicio.Show();
                this.Hide();

                // Al cerrar Inicio, se vuelve a mostrar el login vacío
                formInicio.FormClosing += frm_closing;
            }
            catch (LoginException ex)
            {
                MessageBox.Show(ex.Message, "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario Login
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            // Al cerrar la ventana principal, limpiamos los campos y mostramos el login
            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }
    }
}
