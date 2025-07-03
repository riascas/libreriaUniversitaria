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

            this.Text = $"Inicio - Rol: {_empleado.UnRol.Rol}";

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
                btnGestionUsuarios.Visible = false;
                // ocultar otras funciones
            }
        }


        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            // Cerrar formularios hijos abiertos, si querés evitar duplicados
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
    }
}
