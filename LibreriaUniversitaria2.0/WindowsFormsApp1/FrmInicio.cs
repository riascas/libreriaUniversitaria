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
    /// Formulario de inicio que se abre luego del login exitoso.
    /// Muestra el nombre del empleado logueado.
    /// </summary>
    public partial class FrmInicio : Form
    {
        private Empleado _usuarioLogueado;

        public FrmInicio(Empleado usuario)
        {
            InitializeComponent();
            _usuarioLogueado = usuario;
        }

        /// <summary>
        /// Al cargar el formulario, se muestra el nombre completo y rol del usuario.
        /// </summary>
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = $"Bienvenido/a: {_usuarioLogueado.NombreCompleto()} ({_usuarioLogueado.Rol.Nombre})";
        }

        /// <summary>
        /// Evento del botón cerrar (si lo agregás).
        /// </summary>
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
