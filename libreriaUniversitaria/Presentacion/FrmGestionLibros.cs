using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Presentacion
{
    // Formulario de gestión de libros
    // Permite mostrar, registrar o actualizar libros
    public partial class FrmGestionLibros : Form
    {
        public FrmGestionLibros()
        {
            InitializeComponent();
        }

        private void FrmGestionLibros_Load(object sender, EventArgs e)
        {
            // Aquí se cargarán los libros disponibles desde el repositorio
        }
    }
}

