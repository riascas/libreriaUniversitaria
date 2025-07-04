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
    public partial class frmLibroCompra : Form
    {
        public Libro LibroSeleccionado { get; private set; }
        public int CantidadSeleccionada { get; private set; }

        public frmLibroCompra()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmLibroCompra_Load(object sender, EventArgs e)
        {
            // Cargar combos  
            var categoriaService = new CategoriaLibroService();
            var estadoService = new EstadoLibroService();

            cboCategoria.DataSource = categoriaService.ObtenerTodos();
            cboCategoria.DisplayMember = "DescripcionCategoria";
            cboEstado.DataSource = estadoService.ObtenerTodos();
            cboEstado.DisplayMember = "DescripcionEstadoLibro";
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            LibroSeleccionado = new Libro
            {
                ISNB = txtISNB.Text,
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                PrecioLibro = Convert.ToDecimal(txtPrecio.Text),
                UnaCategoriaLibro = (CategoriaLibro)cboCategoria.SelectedItem,
                UnEstadoLibro = (EstadoLibro)cboEstado.SelectedItem,
                Disponible = true
            };

            CantidadSeleccionada = (int)nudCantidad.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
