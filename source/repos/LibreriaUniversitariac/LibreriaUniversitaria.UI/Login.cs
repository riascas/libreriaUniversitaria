using System;
using System.Windows.Forms;
using LibreriaUniversitaria.Entidades;
using LibreriaUniversitaria.BLL;

namespace LibreriaUniversitaria.UI
{
    public partial class frmLogin : Form
    {
        private readonly EmpleadoBLL empleadoBLL;

        public frmLogin()
        {
            InitializeComponent();
            empleadoBLL = new EmpleadoBLL();
            txtDNI.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    e.Handled = true;
            };
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDNI.Text) || !int.TryParse(txtDNI.Text, out int dni))
            {
                MessageBox.Show("DNI inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Ingrese contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Empleado emp;
            try
            {
                emp = empleadoBLL.ValidarLogin(dni, txtClave.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (emp == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();
            using (var inicio = new frmInicio(emp))
                inicio.ShowDialog();
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

