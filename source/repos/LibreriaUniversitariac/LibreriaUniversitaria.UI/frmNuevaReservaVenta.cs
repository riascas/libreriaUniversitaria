using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class frmNuevaReservaVenta : Form
    {
        private readonly ClienteBLL _clienteBLL = new ClienteBLL();
        private readonly LibroBLL _libroBLL = new LibroBLL();
        private readonly ReservaBLL _reservaBLL = new ReservaBLL();

        private Cliente _clienteActual;
        private Reserva _reservaActual;
        private List<DetalleReserva> _detalles = new List<DetalleReserva>();

        public frmNuevaReservaVenta()
        {
            InitializeComponent();
            rbNuevaReserva.Checked = true;
            ActualizarEstadoControles();
        }

        private void ActualizarEstadoControles()
        {
            bool esNueva = rbNuevaReserva.Checked;
            txtIdReserva.Enabled = !esNueva;
            btnBuscarReserva.Enabled = !esNueva;
            btnAgregar.Enabled = esNueva && _clienteActual != null;
            txtCantidad.Enabled = esNueva && _clienteActual != null;
            dgvDetalle.Enabled = esNueva && _clienteActual != null;
            btnConfirmarReserva.Enabled = esNueva && _detalles.Any();
            btnConfirmarVenta.Enabled = !esNueva && _reservaActual != null && _reservaActual.Estado == EstadoReserva.Pendiente;
            btnCancelarReserva.Enabled = !esNueva && _reservaActual != null && _reservaActual.Estado == EstadoReserva.Pendiente;
        }

        private void rbNuevaReserva_CheckedChanged(object sender, EventArgs e) => ActualizarEstadoControles();
        private void rbBuscarReserva_CheckedChanged(object sender, EventArgs e) => ActualizarEstadoControles();

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var frm = new frmBuscarCliente())
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    _clienteActual = frm.ClienteSeleccionado;
                    lblNombreCliente.Text = $"{_clienteActual.Nombre} {_clienteActual.Apellido}";
                    txtDNICliente.Text = _clienteActual.Dni.ToString();
                    AplicarDescuento();
                    ActualizarEstadoControles();
                }
        }

        private void btnBuscarLibro_Click(object sender, EventArgs e)
        {
            using (var frm = new frmBuscarLibro())
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var libro = frm.LibroSeleccionado;
                    txtISBN.Text = libro.ISBN;
                    txtTitulo.Text = libro.Titulo;
                    txtPrecio.Text = libro.Precio.ToString("F2");
                }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var libro = _libroBLL.ObtenerPorISBN(txtISBN.Text);
            if (libro == null)
            {
                MessageBox.Show("Seleccione un libro válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal precio = libro.Precio;
            decimal subtotal = precio * cantidad;
            var detalle = new DetalleReserva { Libro = libro, Cantidad = cantidad, Subtotal = subtotal };
            _detalles.Add(detalle);
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = _detalles.Select(d => new
            {
                d.Libro.Titulo,
                d.Cantidad,
                Subtotal = d.Subtotal.ToString("F2")
            }).ToList();
            CalcularTotales();
            ActualizarEstadoControles();
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdReserva.Text, out int id)) { MessageBox.Show("ID inválido."); return; }
            _reservaActual = _reservaBLL.ObtenerPorId(id);
            if (_reservaActual == null) { MessageBox.Show("Reserva no encontrada."); return; }
            lblNombreCliente.Text = $"{_reservaActual.Cliente.Nombre} {_reservaActual.Cliente.Apellido}";
            txtDNICliente.Text = _reservaActual.Cliente.Dni.ToString();
            dgvDetalle.DataSource = _reservaActual.Detalles.Select(d => new
            {
                d.Libro.Titulo,
                d.Cantidad,
                Subtotal = d.Subtotal.ToString("F2")
            }).ToList();
            CalcularTotales();
            ActualizarEstadoControles();
        }

        private void CalcularTotales()
        {
            decimal subtotal = _detalles.Sum(d => d.Subtotal);
            decimal descuento = (_clienteActual?.EsEstudiante ?? false) ? subtotal * 0.1m : 0m;
            decimal total = subtotal - descuento;
            lblSubtotal.Text = subtotal.ToString("F2");
            lblDescuento.Text = descuento.ToString("F2");
            lblTotal.Text = total.ToString("F2");
        }

        private void AplicarDescuento()
        {
            lblEstudiante.Visible = _clienteActual.EsEstudiante;
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Cliente = _clienteActual,
                FechaReserva = DateTime.Now,
                Estado = EstadoReserva.Pendiente,
                Detalles = _detalles
            };
            int id = _reservaBLL.InsertarReserva(reserva);
            MessageBox.Show($"Reserva registrada con ID {id}.");
            LimpiarTodo();
        }

        private void btnConfirmarVenta_Click(object sender, EventArgs e)
        {
            _reservaBLL.CambiarEstado(_reservaActual.IdReserva, EstadoReserva.Vendida);
            MessageBox.Show("Venta confirmada.");
            LimpiarTodo();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            _reservaBLL.CambiarEstado(_reservaActual.IdReserva, EstadoReserva.Cancelada);
            MessageBox.Show("Reserva cancelada.");
            LimpiarTodo();
        }

        private void btnVolver_Click(object sender, EventArgs e) => Close();

        private void LimpiarTodo()
        {
            _clienteActual = null;
            _reservaActual = null;
            _detalles.Clear();
            dgvDetalle.DataSource = null;
            lblNombreCliente.Text = "";
            txtDNICliente.Text = "";
            txtISBN.Text = "";
            txtTitulo.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            txtIdReserva.Text = "";
            lblSubtotal.Text = "0.00";
            lblDescuento.Text = "0.00";
            lblTotal.Text = "0.00";
            ActualizarEstadoControles();
        }
    }
}
