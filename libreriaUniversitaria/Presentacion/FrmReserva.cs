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
    // Formulario de reservas de libros
    // Permite a un cliente reservar un libro si está disponible
    public partial class FrmReserva : Form
    {
        public FrmReserva()
        {
            InitializeComponent();
        }

        private void FrmReserva_Load(object sender, EventArgs e)
        {
            // Cargar clientes y libros para permitir seleccionar una reserva
        }
    }
}

