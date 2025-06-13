using System;
using System.Windows.Forms;
using LibreriaUniversitaria.LogicaNegocio;
using LibreriaUniversitaria.Entidades.Excepciones;
using LibreriaUniversitaria.Entidades;
using FontAwesome.Sharp; // Requiere paquete NuGet FontAwesome.Sharp

namespace LibreriaUniversitaria.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta al presionar el botón Ingresar.
        /// Valida credenciales y abre la ventana principal si son correctas.
        /// </summary>
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            string dni = txtDocumento.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Debe ingresar DNI y clave.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Empleado usuario = EmpleadoService.Login(dni, clave);

                if (usuario != null)
                {
                    // Pasamos el usuario al formulario de inicio
                    FrmInicio frm = new FrmInicio(usuario);
                    frm.Show();
                    this.Hide();
                }
            }
            catch (EntidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cierra la aplicación si se presiona Cancelar.
        /// </summary>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
