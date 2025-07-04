using System;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;
using BCrypt.Net;

namespace LibreriaUniversitaria.UI
{
    public partial class frmNuevoUsuario : Form
    {
        private readonly EmpleadoBLL _empBLL = new EmpleadoBLL();
        private readonly Empleado _empleado;

        // Alta
        public frmNuevoUsuario()
        {
            InitializeComponent();
            cmbRol.Items.AddRange(new[] { "Administrador", "Vendedor", "Bibliotecario", "Gerente" });
            cmbRol.SelectedIndex = 0;
        }

        // Edición
        public frmNuevoUsuario(Empleado emp) : this()
        {
            _empleado = emp;
            txtNombre.Text = emp.Nombre;
            txtApellido.Text = emp.Apellido;
            txtDNI.Text = emp.Dni.ToString();
            txtEmail.Text = emp.Email;
            cmbRol.SelectedItem = emp.Rol;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDNI.Text.Trim(), out int dni))
            {
                MessageBox.Show("DNI inválido."); return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Complete todos los campos."); return;
            }

            if (_empleado == null)
            {
                var nuevo = new Empleado
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Dni = dni,
                    Email = txtEmail.Text.Trim(),
                    Rol = cmbRol.SelectedItem.ToString(),
                    Clave = dni.ToString(),        // contraseña inicial DNI
                };
                _empBLL.Alta(nuevo);
            }
            else
            {
                _empleado.Nombre = txtNombre.Text.Trim();
                _empleado.Apellido = txtApellido.Text.Trim();
                _empleado.Dni = dni;
                _empleado.Email = txtEmail.Text.Trim();
                _empleado.Rol = cmbRol.SelectedItem.ToString();
                // clave no se modifica aquí
                _empBLL.Modificar(_empleado);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
