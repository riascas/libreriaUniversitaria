using ENT_Libreria;
using BLL_Libreria;
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
    public partial class frmLibroVenta : Form
    {
        public Libro LibroSeleccionado { get; private set; }
        public int CantidadSeleccionada { get; private set; }


        public frmLibroVenta()
        {
            InitializeComponent();
            CargarLibros();
        }
        private void CargarLibros()
        {
            var libroService = new LibroService();

            cboLibros.DataSource = libroService.ObtenerTodos();
            cboLibros.DisplayMember = "Titulo";
            cboLibros.ValueMember = "IdLibro";
        }
        private void frmLibroVenta_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cboLibros.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un libro.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida.");
                return;
            }

            int idLibro = Convert.ToInt32(cboLibros.SelectedValue);
            LibroService libroService = new LibroService();
            Libro libro = libroService.BuscarPorId(idLibro);

            if (libro == null)
            {
                MessageBox.Show("El libro seleccionado no existe.");
                return;
            }

            LibroSeleccionado = libro;
            CantidadSeleccionada = cantidad;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public class ItemVentaGrilla
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int Cantidad { get; set; }
            public decimal Subtotal => PrecioUnitario * Cantidad;
            public Libro LibroReferencia { get; set; }
        }
    }
}
