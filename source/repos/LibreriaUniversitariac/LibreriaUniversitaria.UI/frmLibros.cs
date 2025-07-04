using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class frmLibros : Form
    {
        private readonly LibroBLL _libroBLL = new LibroBLL();

        public frmLibros()
        {
            InitializeComponent();
            // Atento: estamos con C#7.3, así que no podemos usar "using var"
        }

        /// <summary>
        /// Se ejecuta cuando el formulario arranca: carga todos los libros en la grilla.
        /// </summary>
        private void frmLibros_Load(object sender, EventArgs e)
        {
            CargarGrilla(_libroBLL.ObtenerTodos());
        }

        /// <summary>
        /// Filtra por título en tiempo real según lo que escribe el usuario.
        /// </summary>
        private void txtCriterio_TextChanged(object sender, EventArgs e)
        {
            string crit = txtCriterio.Text.Trim();
            List<Libro> lista;
            if (string.IsNullOrEmpty(crit))
                lista = _libroBLL.ObtenerTodos();
            else
                lista = _libroBLL.BuscarPorTitulo(crit);
            CargarGrilla(lista);
        }

        /// <summary>
        /// Botón Buscar: dispara el TextChanged para recargar.
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtCriterio_TextChanged(sender, e);
        }

        /// <summary>
        /// Doble clic en la grilla: abre el editor de libro seleccionado.
        /// </summary>
        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var libro = (Libro)dgvLibros.Rows[e.RowIndex].DataBoundItem;
            // Using tradicional por C#7.3:
            Form frm = new frmNuevoLibro1(libro);
            if (frm.ShowDialog(this) == DialogResult.OK)
                CargarGrilla(_libroBLL.ObtenerTodos());
        }

        /// <summary>
        /// Botón Nuevo: abre formulario en blanco para crear libro.
        /// </summary>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Form frm = new frmNuevoLibro1(new Libro());
            if (frm.ShowDialog(this) == DialogResult.OK)
                CargarGrilla(_libroBLL.ObtenerTodos());
        }

        /// <summary>
        /// Botón Editar: abre formulario con el libro de la fila seleccionada.
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null) return;
            var libro = (Libro)dgvLibros.CurrentRow.DataBoundItem;
            Form frm = new frmNuevoLibro1(libro);
            if (frm.ShowDialog(this) == DialogResult.OK)
                CargarGrilla(_libroBLL.ObtenerTodos());
        }

        /// <summary>
        /// Botón Orden de Compra: abre el formulario de orden.
        /// </summary>
        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            Form frm = new frmOrdenDeCompra();
            frm.ShowDialog(this);
        }

        /// <summary>
        /// Botón Volver: cierra este formulario.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Pone la lista de libros en el DataGridView.
        /// </summary>
        private void CargarGrilla(List<Libro> lista)
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = lista;
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
