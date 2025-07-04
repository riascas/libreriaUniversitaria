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
using static Sistema_Libreria.frmLibroVenta;

namespace Sistema_Libreria
{
    public partial class frmVenta : Form
    {
        private List<ItemVentaGrilla> librosSeleccionados = new List<ItemVentaGrilla>();

        public frmVenta()
        {
            InitializeComponent();
            CargarClientes();
            ConfigurarGrilla();
        }

        private void CargarClientes()
        {
            var clienteService = new ClienteService();
            cboClientes.DataSource = clienteService.ObtenerTodos();
            cboClientes.DisplayMember = "NombreCompleto";
            cboClientes.ValueMember = "IdCliente";

        }

        private void ConfigurarGrilla()
        {
            dgvLibrosVenta.AutoGenerateColumns = false;
            dgvLibrosVenta.Columns.Clear();

            dgvLibrosVenta.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Título", DataPropertyName = "Titulo" });
            dgvLibrosVenta.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Autor", DataPropertyName = "Autor" });
            dgvLibrosVenta.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio Unitario", DataPropertyName = "PrecioUnitario" });
            dgvLibrosVenta.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", DataPropertyName = "Cantidad" });
            dgvLibrosVenta.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Subtotal", DataPropertyName = "Subtotal" });
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            frmLibroVenta frm = new frmLibroVenta();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.LibroSeleccionado == null)
                {
                    MessageBox.Show("Error: no se seleccionó un libro válido.");
                    return;
                }

                var item = new ItemVentaGrilla
                {
                    Titulo = frm.LibroSeleccionado.Titulo,
                    Autor = frm.LibroSeleccionado.Autor,
                    PrecioUnitario = frm.LibroSeleccionado.PrecioLibro,
                    Cantidad = frm.CantidadSeleccionada,
                    LibroReferencia = frm.LibroSeleccionado
                };

                librosSeleccionados.Add(item);
                dgvLibrosVenta.DataSource = null;
                dgvLibrosVenta.DataSource = librosSeleccionados;
            }
        }

        private void btnFinaliarVenta_Click(object sender, EventArgs e)
        {
            if (librosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un libro.");
                return;
            }

            Cliente cliente = (Cliente)cboClientes.SelectedItem;
            Empleado vendedor = ObtenerEmpleadoLogueado();

            Venta venta = new Venta
            {
                FechaVenta = DateTime.Now,
                UnCliente = cliente,
                UnEmpleado = vendedor,
                DetalleVentas = new List<DetalleVenta>()
            };

            decimal total = 0;
            foreach (var item in librosSeleccionados)
            {
                if (item.LibroReferencia == null)
                {
                    MessageBox.Show("Hay un detalle de venta con libro nulo.");
                    return;
                }

                decimal precioFinal = cliente.EsEstudiante ? item.PrecioUnitario * 0.9m : item.PrecioUnitario;

                var detalle = new DetalleVenta
                {
                    CantidadVenta = item.Cantidad,
                    PrecioVenta = precioFinal,
                    UnaVenta = venta,
                    LibroReferencia = item.LibroReferencia
                };
                venta.DetalleVentas.Add(detalle);
                total += precioFinal * item.Cantidad;
            }

            venta.TotalVenta = total;

            VentaService service = new VentaService();
            try
            {
                service.RegistrarVenta(venta);
                MessageBox.Show("Venta registrada con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message);
            }
        }

        private Empleado ObtenerEmpleadoLogueado()
        {
            return new Empleado
            {
                IdEmpleado = 4,
                Usuario = "diego_venta",
                Clave = "clave123",
                UnaPersona = new Persona { Nombre = "Diego", Apellido = "Cesari" },
                UnRol = new RolEmpleado { Rol = "Vendedor" }
            };
        }

        // Clase auxiliar para mostrar en la grilla
        public class ItemVentaGrilla
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int Cantidad { get; set; }
            public decimal Subtotal => PrecioUnitario * Cantidad;
            public Libro LibroReferencia { get; set; }
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
