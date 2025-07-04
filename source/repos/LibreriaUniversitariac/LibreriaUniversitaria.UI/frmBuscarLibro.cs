using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class frmBuscarLibro : Form
    {
        private readonly LibroBLL _libroBLL = new LibroBLL();
        private List<Libro> _listaLibros;

        /// <summary>
        /// Libro seleccionado por el usuario.
        /// </summary>
        public Libro LibroSeleccionado { get; private set; }

        public frmBuscarLibro()
        {
            InitializeComponent();
            cmbCriterio.Items.AddRange(new[] { "Título", "Autor", "ISBN" });
            cmbCriterio.SelectedIndex = 0;
            CargarLibros();
        }

        private void CargarLibros()
        {
            _listaLibros = _libroBLL.ObtenerTodos();
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = _listaLibros;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim().ToLower();
            IEnumerable<Libro> filtrados = _listaLibros;
            switch (cmbCriterio.SelectedItem.ToString())
            {
                case "Título":
                    filtrados = _listaLibros.Where(l => l.Titulo.ToLower().Contains(texto));
                    break;
                case "Autor":
                    filtrados = _listaLibros.Where(l => l.Autor.ToLower().Contains(texto));
                    break;
                case "ISBN":
                    filtrados = _listaLibros.Where(l => l.ISBN.ToLower().Contains(texto));
                    break;
            }
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = filtrados.ToList();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null) return;
            LibroSeleccionado = (Libro)dgvLibros.CurrentRow.DataBoundItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            btnSeleccionar_Click(sender, e);
        }
    }
}
