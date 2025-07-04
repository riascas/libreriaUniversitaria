using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Libreria
{
    public partial class Inicio : Form
    {
        private Empleado _empleado;
        public Inicio(Empleado empleado)
        {
            InitializeComponent();
           // indexUsuario.Click += indexUsuario_click;

            this.IsMdiContainer = true; // Esto convierte al formulario en un contenedor MDI

            _empleado = empleado;

            lblUsuario.Text = $"Usuario: {_empleado.UnaPersona.Nombre} {_empleado.UnaPersona.Apellido} ({_empleado.UnRol.Rol})";


            ConfigurarPorRol();

        }

        private void ConfigurarPorRol()
        {
            if (_empleado.UnRol.Rol == "Administrador")
            {
                // mostrar todo
            }
            else if (_empleado.UnRol.Rol == "Vendedor")
            {
                menuUsuario.Visible = false;
                menuEditorial.Visible = false;
                menuCompras.Visible = false;
                // ocultar otras funciones
            }
            else if (_empleado.UnRol.Rol == "Gerente")
            {
                menuCompras.Visible = false;
                menuVentaReserva.Visible = false;
                // ocultar otras funciones
            }
            else if (_empleado.UnRol.Rol == "Bibliotecario")
            {
                menuUsuario.Visible = false;
                menuClientes.Visible = false;
                menuVentaReserva.Visible = false;
                // ocultar otras funciones
            }
            else
            {
                // Manejar caso de rol desconocido si es necesario
                MessageBox.Show("Rol desconocido. No se pueden mostrar las opciones del menú.");
            }
        }


        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

            // Crear y mostrar frmUsuarios dentro de inicio.cs
            frmUsuarios usuariosForm = new frmUsuarios();
            usuariosForm.MdiParent = this; // asignar como hijo del formulario principal
            usuariosForm.FormBorderStyle = FormBorderStyle.None; // Opcional: sin bordes
            usuariosForm.Dock = DockStyle.Fill; // Opcional: ocupa todo el espacio disponible
            usuariosForm.Show();
        }



        private void prueba(object sender, EventArgs e)
        {
            

        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menusuarios_Click(object sender, EventArgs e)
        {

        }

        private void librToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void menuListarEmpleados_Click(object sender, EventArgs e)
        {
            frmListarEmpleados form = new frmListarEmpleados();
            form.ShowDialog();
        }

        private void menuAltaEmpleado_Click(object sender, EventArgs e)
        {
            frmAltaEmpleado form = new frmAltaEmpleado();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarClientes form = new frmListarClientes();
            form.ShowDialog();
        }

        private void menuAltaCliente_Click(object sender, EventArgs e)
        {
            frmAltaCliente form = new frmAltaCliente();
            form.ShowDialog();
        }

        private void menuListarEditoriales_Click(object sender, EventArgs e)
        {
            frmListarEditoriales form = new frmListarEditoriales();
            form.ShowDialog();
        }

        private void menuAltaEditorial_Click(object sender, EventArgs e)
        {
            frmAltaEditorial form = new frmAltaEditorial();
            form.ShowDialog();
        }

        private void menuListarLibro_Click(object sender, EventArgs e)
        {
            frmListarLibros form = new frmListarLibros();
            form.ShowDialog();
        }

        private void menuCompras_Click(object sender, EventArgs e)
        {
            frmCompra form = new frmCompra();
            form.ShowDialog();
        }
    }
}
