using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class frmVerReservasVentas : Form
    {
        private readonly ReservaBLL _resBLL = new ReservaBLL();
        private List<Reserva> _todas;

        public frmVerReservasVentas()
        {
            InitializeComponent();
            dtpDesde.Value = DateTime.Today.AddDays(-30);
            dtpHasta.Value = DateTime.Today;
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Carga todo y luego filtra en memoria
            _todas = _resBLL.ObtenerTodos();
            AplicarFiltro();
        }

        private void AplicarFiltro()
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);
            var filtradas = _todas
                .Where(r => r.FechaReserva >= desde && r.FechaReserva <= hasta)
                .Select(r => new
                {
                    r.IdReserva,
                    Cliente = $"{r.Cliente.Nombre} {r.Cliente.Apellido}",
                    Fecha = r.FechaReserva.ToShortDateString(),
                    Estado = r.Estado,
                    Total = r.Detalles.Sum(d => d.Subtotal).ToString("F2")
                })
                .ToList();
            dgvInforme.DataSource = filtradas;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
