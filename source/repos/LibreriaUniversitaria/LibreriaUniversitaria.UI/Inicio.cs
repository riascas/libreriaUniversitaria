using System;
using System.Windows.Forms;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class Inicio : Form
    {
        private Empleado empleadoLogueado;

        public Inicio(Empleado empleado)
        {
            InitializeComponent();
            empleadoLogueado = empleado;
            lblusuario.Text = empleado.Nombre + " " + empleado.Apellido + " (" + ObtenerNombreRol(empleado.IdRol) + ")";
            ConfigurarMenuPorRol(empleado.IdRol);
        }

        private string ObtenerNombreRol(int idRol)
        {
            switch (idRol)
            {
                case 1: return "Administrador";
                case 2: return "Bibliotecario";
                case 3: return "Vendedor";
                case 4: return "Gerente";
                default: return "Desconocido";
            }
        }

        private void ConfigurarMenuPorRol(int idRol)
        {
            menusuarios.Visible = false;
            menuproveedor.Visible = false;
            menucompras.Visible = false;
            menuclientes.Visible = false;
            menuproveedores.Visible = false;
            menureportes.Visible = false;

            if (idRol == 1)
            {
                menusuarios.Visible = true;
                menuproveedor.Visible = true;
                menucompras.Visible = true;
                menuclientes.Visible = true;
                menuproveedores.Visible = true;
                menureportes.Visible = true;
            }
            else if (idRol == 2)
            {
                menuproveedor.Visible = true;
                menucompras.Visible = true;
            }
            else if (idRol == 3)
            {
                menuclientes.Visible = true;
                menuproveedores.Visible = true;
            }
            else if (idRol == 4)
            {
                menureportes.Visible = true;
            }
        }

        private void menusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmUsuarios());
        }

        private void menuproveedor_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmProveedor());
        }

        private void menucompras_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmCompras());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmVentas());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            // Aquí puedes abrir formulario de reportes o dejar vacío
        }

        // Método para abrir formularios hijos en el panel MDI
        private void AbrirFormularioHijo(Form frm)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        // Evento vacío para el Paint del panel contenedor, para evitar error
        private void contenedor_Paint(object sender, PaintEventArgs e)
        {
            // No hay lógica por ahora
        }

        // Evento para el clic del menú (vacío para evitar error)
        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // No hay lógica por ahora
        }

        // Evento para el clic en "Ventas por libro" del submenú de reportes
        private void librToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Implementar lógica para reporte de ventas por libro
        }

        // Evento Load vacío para evitar error
        private void Inicio_Load(object sender, EventArgs e)
        {
            // Código opcional al cargar el formulario
        }
    }
}
