using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaUniversitaria.UI
{
    public partial class Inicio : Form
    {

        /// <summary>
        /// Evento que se dispara al hacer clic en el menú de usuarios.
        /// Cierra formularios hijos anteriores y abre frmUsuarios como MDI.
        /// </summary>
        private void menusuarios_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close(); // Evita formularios duplicados
            }

            // Abrimos el formulario de usuarios
            frmUsuarios usuariosForm = new frmUsuarios();
            usuariosForm.MdiParent = this;
            usuariosForm.FormBorderStyle = FormBorderStyle.None;
            usuariosForm.Dock = DockStyle.Fill;
            usuariosForm.Show();
        }

        /// <summary>
        /// Evento de pintura del panel contenedor. Puede quedar vacío si no se usa.
        /// </summary>
        private void contenedor_Paint(object sender, PaintEventArgs e)
        {
            // No se requiere implementación específica por ahora
        }

        /// <summary>
        /// Evento al hacer clic en "Ventas por libro".
        /// </summary>
        private void librToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lógica para mostrar reporte de ventas por libro
        }
         


        private void Inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
