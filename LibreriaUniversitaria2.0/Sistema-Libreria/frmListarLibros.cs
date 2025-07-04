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
    public partial class frmListarLibros : Form
    {
        private LibroService servicio = new LibroService();
        public frmListarLibros()
        {
            InitializeComponent();
        }

        private void frmListarLibros_Load(object sender, EventArgs e)
        {
            LibroService servicio = new LibroService();
            var libros = servicio.ObtenerTodos();

            var listaMostrar = libros.Select(libro => new
            {
                ISBN = libro.ISNB,
                Titulo = libro.Titulo,
                Autor = libro.Autor,
                Genero = libro.UnaCategoriaLibro.DescripcionCategoria,
                Estado = libro.UnEstadoLibro.DescripcionEstadoLibro,
                Disponible = libro.Disponible ? "Sí" : "No",
            }).ToList();

            dgvLibros.DataSource = listaMostrar;
        }
    }
}
