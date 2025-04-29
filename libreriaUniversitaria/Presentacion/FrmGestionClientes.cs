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
    // Formulario de gestión de clientes
    // Sirve para mostrar, agregar, editar o eliminar clientes
    public partial class FrmGestionClientes : Form
    {
        public FrmGestionClientes()
        {
            InitializeComponent();
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            // Aquí se cargarán los datos al iniciar el formulario
            // Por ejemplo: cargar lista de clientes desde el repositorio
        }
    }
}

