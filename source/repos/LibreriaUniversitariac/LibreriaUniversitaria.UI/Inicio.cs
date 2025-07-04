using System;
using System.Windows.Forms;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class frmInicio : Form
    {
        private readonly Empleado empleado;

        public frmInicio(Empleado emp)
        {
            InitializeComponent();
            empleado = emp;
            ConfigurarCabecera();
            ConfigurarMenuPorRol();
        }

        private void ConfigurarCabecera()
        {
            lblUsuario.Text = $"{empleado.Nombre} {empleado.Apellido} ({empleado.Rol})";
        }

        private void ConfigurarMenuPorRol()
        {
            // Ocultamos todos inicialmente
            btnEmpleados.Visible = btnClientes.Visible = btnLibros.Visible =
            btnProveedores.Visible = btnOrdenesCompra.Visible =
            btnReservasVentas.Visible = btnReportes.Visible =
            btnConfiguracion.Visible = false;

            switch (empleado.Rol)
            {
                case "Administrador":
                    btnEmpleados.Visible = btnClientes.Visible = btnLibros.Visible =
                    btnProveedores.Visible = btnOrdenesCompra.Visible =
                    btnReservasVentas.Visible = btnReportes.Visible =
                    btnConfiguracion.Visible = true;
                    break;
                case "Vendedor":
                    btnClientes.Visible = btnReservasVentas.Visible = true;
                    break;
                case "Bibliotecario":
                    btnLibros.Visible = btnProveedores.Visible = btnOrdenesCompra.Visible = true;
                    break;
                case "Gerente":
                    btnReportes.Visible = true;
                    break;
            }
        }

        private void CargarFormularioEnPanel(Form frm)
        {
            pnlMain.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
            => CargarFormularioEnPanel(new frmUsuarios());

        private void btnClientes_Click(object sender, EventArgs e)
            => CargarFormularioEnPanel(new frmClientes());

        private void btnLibros_Click(object sender, EventArgs e)
            => CargarFormularioEnPanel(new frmBuscarLibro());

        private void btnProveedores_Click(object sender, EventArgs e)
            => CargarFormularioEnPanel(new frmNuevoProveedor());

        private void btnOrdenesCompra_Click(object sender, EventArgs e)
            => CargarFormularioEnPanel(new frmNuevaOrdenCompra());

        private void btnReservasVentas_Click(object sender, EventArgs e)
            => CargarFormularioEnPanel(new frmNuevaReservaVenta());

        private void btnReportes_Click(object sender, EventArgs e)
            => CargarFormularioEnPanel(new frmVerReservasVentas());

        private void btnConfiguracion_Click(object sender, EventArgs e)
            => CargarFormularioEnPanel(new frmConfiguracionSistema());

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
