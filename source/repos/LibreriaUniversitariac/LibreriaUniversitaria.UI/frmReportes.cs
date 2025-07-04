using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;
using FontAwesome.Sharp;

namespace LibreriaUniversitaria.UI
{
    public partial class frmReportes : Form
    {
        private readonly ReporteBLL reporteBLL;

        /// <summary>
        /// Constructor: inicializa componentes y la capa de negocio de reportes.
        /// </summary>
        public frmReportes()
        {
            InitializeComponent();
            reporteBLL = new ReporteBLL();
            cmbTipoReporte.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento Click de btnGenerar: genera el reporte seleccionado.
        /// </summary>
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;
            string tipo = cmbTipoReporte.Text;

            var resultados = new List<object>();

            if (tipo == "Ventas por Vendedor")
            {
                foreach (var x in reporteBLL.VentasPorVendedor(desde, hasta))
                    resultados.Add(x);
            }
            else if (tipo == "Ventas por Libro")
            {
                foreach (var x in reporteBLL.VentasPorLibro(desde, hasta))
                    resultados.Add(x);
            }
            else if (tipo == "Reservas por Estado")
            {
                foreach (var x in reporteBLL.ReservasPorEstado(desde, hasta))
                    resultados.Add(x);
            }
            else if (tipo == "Ventas por Cliente")
            {
                foreach (var x in reporteBLL.VentasPorCliente(desde, hasta))
                    resultados.Add(x);
            }

            dgvReportes.DataSource = resultados;
            lblTotalRegistros.Text = $"Total: {resultados.Count}";
        }

        /// <summary>
        /// Evento Click de btnExportar: exporta el contenido de la grilla a Excel.
        /// </summary>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (dgvReportes.DataSource == null) return;
            // TODO: implementar exportación a Excel
            MessageBox.Show("Exportar a Excel aún no implementado.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Evento Click de btnVolver: cierra el formulario.
        /// </summary>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Handler para el evento Load del formulario (suscrito en el Designer).
        /// Inicializa cualquier lógica adicional al mostrar el formulario.
        /// </summary>
        private void frmReportes_Load(object sender, EventArgs e)
        {
            // Por ahora no hay lógica extra al cargar.
        }

    }
}
