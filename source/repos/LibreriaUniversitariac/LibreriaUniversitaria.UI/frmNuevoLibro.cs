using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class frmNuevoLibro : Form
    {
        private readonly LibroBLL _libroBLL = new LibroBLL();
        private readonly EditorialBLL _edBLL = new EditorialBLL();
        private readonly CategoriaBLL _catBLL = new CategoriaBLL();

        private Libro _libroExistente;

        // Constructor para creación
        public frmNuevoLibro() : this(null) { }

        // Constructor para edición
        public frmNuevoLibro(Libro libro)
        {
            InitializeComponent();
            _libroExistente = libro;
            CargarCombos();
            CargarDatos();
        }

        private void CargarCombos()
        {
            // Editoriales
            List<Editorial> eds = _edBLL.ObtenerTodos();
            cmbEditorial.DataSource = eds;
            cmbEditorial.ValueMember = "IdEditorial";
            cmbEditorial.DisplayMember = "RazonSocial";

            // Categorías
            List<Categoria> cats = _catBLL.ObtenerTodos();
            cmbCategoria.DataSource = cats;
            cmbCategoria.ValueMember = "IdCategoria";
            cmbCategoria.DisplayMember = "Nombre";
        }

        private void CargarDatos()
        {
            if (_libroExistente != null)
            {
                txtTitulo.Text = _libroExistente.Titulo;
                txtISBN.Text = _libroExistente.ISBN;
                txtAutor.Text = _libroExistente.Autor;
                numericStock.Value = _libroExistente.Stock;
                txtPrecio.Text = _libroExistente.Precio.ToString("F2");
                chkActivo.Checked = _libroExistente.Activo;

                // Seleccionar editorial y categoría
                cmbEditorial.SelectedValue = _libroExistente.IdEditorial;
                cmbCategoria.SelectedValue = _libroExistente.IdCategoria;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Título obligatorio.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_libroExistente == null)
                _libroExistente = new Libro();

            // Leer campos
            _libroExistente.Titulo = txtTitulo.Text.Trim();
            _libroExistente.ISBN = txtISBN.Text.Trim();
            _libroExistente.Autor = txtAutor.Text.Trim();
            _libroExistente.Stock = (int)numericStock.Value;
            _libroExistente.Precio = decimal.Parse(txtPrecio.Text);
            _libroExistente.Activo = chkActivo.Checked;
            _libroExistente.IdEditorial = (int)cmbEditorial.SelectedValue;
            _libroExistente.IdCategoria = (int)cmbCategoria.SelectedValue;

            // Guardar
            if (_libroExistente.IdLibro == 0)
                _libroBLL.Insertar(_libroExistente);
            else
                _libroBLL.Actualizar(_libroExistente);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
