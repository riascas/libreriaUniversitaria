using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    /// <summary>
    /// Formulario principal que se muestra al iniciar sesión. Contiene accesos a otras secciones del sistema.
    /// </summary>
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        // Evento al cargar el formulario
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido/a - {Sesion.UsuarioLogueado.Nombre}";
        }

        // Botón para abrir formulario de clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog();
        }

        // Botón para abrir formulario de libros
        private void btnLibros_Click(object sender, EventArgs e)
        {
            FrmGestionLibros frm = new FrmGestionLibros();
            frm.ShowDialog();
        }

        // Botón para abrir formulario de reservas
        private void btnReservas_Click(object sender, EventArgs e)
        {
            FrmReservas frm = new FrmReservas();
            frm.ShowDialog();
        }

        // Botón para abrir formulario de ventas
        private void btnVentas_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.ShowDialog();
        }

        // Botón para cerrar sesión
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
            FrmLogin login = new FrmLogin();
            login.Show(); // Muestra nuevamente el login
        }
    }
}
