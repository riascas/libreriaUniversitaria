using System;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;

namespace LibreriaUniversitaria.UI
{
    public partial class frmReportesReservasVentas : Form
    {
        private readonly ReporteBLL _reporteBLL = new ReporteBLL();

        public frmReportesReservasVentas()
        {
            InitializeComponent();
            // Fechas por defecto: último mes
            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;
            CargarTodosReportes();
        }

        private void CargarTodosReportes()
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);
            dgvGeo.DataSource = _reporteBLL.GetVentasPorRegion(desde, hasta);
            dgvLibros.DataSource = _reporteBLL.GetVentasPorLibro(desde, hasta);
            dgvVendedores.DataSource = _reporteBLL.GetVentasPorVendedor(desde, hasta);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarTodosReportes();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
