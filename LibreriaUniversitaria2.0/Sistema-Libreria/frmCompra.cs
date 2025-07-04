using BLL_Libreria;
using ENT_Libreria;
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
    public partial class frmCompra : Form
    {
        public frmCompra()
        {
            InitializeComponent();
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            var orden = new OrdenCompra
            {
                UnaEditorial = (Editorial)cboEditorial.SelectedItem,
                UnEmpleado = ObtenerUsuarioLogueado(), // Método para obtener el usuario logueado
            };

            var librosConCantidad = new List<(Libro libro, int cantidad)>();

            foreach (DataGridViewRow row in dgvLibrosCompra.Rows)
            {
                if (row.Cells["Libro"].Value == null)
                    continue;

                var libro = (Libro)row.Cells["Libro"].Value;
                if (libro == null)
                    continue;

                if (!int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out int cantidad) || cantidad <= 0)
                    continue;

                librosConCantidad.Add((libro, cantidad));
            }

            var service = new OrdenCompraService();
            service.RegistrarOrdenCompra(orden, librosConCantidad);

            MessageBox.Show("Orden de compra registrada exitosamente.");
            this.Close();
        }

        private Empleado ObtenerUsuarioLogueado()
        {
            // Implementación para obtener el usuario logueado
            // Esto puede depender de cómo se maneja la sesión en tu aplicación
            // Por ejemplo, podrías usar una clase estática o un servicio de inyección de dependencias
            return new Empleado
            {
                IdEmpleado = 1, // Ejemplo de datos
                Usuario = "admin",
                Clave = "1234",
                UnRol = new RolEmpleado { /* Inicializar según sea necesario */ },
                UnaPersona = new Persona
                {
                    Nombre = "Juan",
                    Apellido = "Pérez",
                    DNI = "12345678",
                    Email = "juan.perez@example.com",
                    UnDomicilio = new Domicilio { /* Inicializar según sea necesario */ }
                }
            };
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            CargarEditoriales();
            ConfigurarGrilla();
        }

        private void CargarEditoriales()
        {
            var service = new EditorialService();
            var listaEditoriales = service.ObtenerTodos();  // Asegurate de obtener la lista

            if (listaEditoriales == null || listaEditoriales.Count == 0)
            {
                MessageBox.Show("No se encontraron editoriales en la base de datos.");
                return;
            }

            cboEditorial.DataSource = listaEditoriales;
            cboEditorial.DisplayMember = "NombreEditorial"; // esto sí existe en tu clase
            cboEditorial.ValueMember = "IdEditorial";
        }

        private void ConfigurarGrilla()
        {
            dgvLibrosCompra.Columns.Clear();
            dgvLibrosCompra.AutoGenerateColumns = false;

            dgvLibrosCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ISNB",
                HeaderText = "ISNB",
                DataPropertyName = "ISNB"
            });

            dgvLibrosCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Titulo",
                HeaderText = "Título",
                DataPropertyName = "Titulo"
            });

            dgvLibrosCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Autor",
                HeaderText = "Autor",
                DataPropertyName = "Autor"
            });

            dgvLibrosCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Precio",
                HeaderText = "Precio",
                DataPropertyName = "PrecioLibro"
            });

            dgvLibrosCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
            });

            dgvLibrosCompra.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Libro",
                HeaderText = "Libro (obj)",
                Visible = false
            });
        }

        private void btnAddLibro_Click(object sender, EventArgs e)
        {
            if (!dgvLibrosCompra.Columns.Contains("Libro"))
            {
                dgvLibrosCompra.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Libro",
                    HeaderText = "Libro (obj)",
                    Visible = false
                });
            }

            frmLibroCompra formLibro = new frmLibroCompra();
            if (formLibro.ShowDialog() == DialogResult.OK)
            {
                if (formLibro.LibroSeleccionado != null)
                {
                    Libro libro = formLibro.LibroSeleccionado;
                    int cantidad = formLibro.CantidadSeleccionada;

                    dgvLibrosCompra.Rows.Add(libro.ISNB, libro.Titulo, libro.Autor, libro.PrecioLibro, cantidad, libro);
                }
                else
                {
                    MessageBox.Show("No se seleccionó un libro válido.");
                }
            }
        }

        private void dgvLibrosCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
