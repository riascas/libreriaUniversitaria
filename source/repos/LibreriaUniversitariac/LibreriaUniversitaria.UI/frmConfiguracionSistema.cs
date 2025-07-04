using System;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class frmConfiguracionSistema : Form
    {
        private readonly ConfiguracionBLL _cfgBLL = new ConfiguracionBLL();
        private Configuracion _config;

        public frmConfiguracionSistema()
        {
            InitializeComponent();
            CargarConfiguracion();
        }

        private void CargarConfiguracion()
        {
            // Lee la configuración actual de la BLL (puede venir de la BD o un archivo)
            _config = _cfgBLL.ObtenerConfiguracion();
            txtDescuentoEstudiante.Text = _config.DescuentoEstudiante.ToString("F2");
            txtDiasReserva.Text = _config.DiasMaxReserva.ToString();
            txtNombreLibreria.Text = _config.NombreLibreria;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDescuentoEstudiante.Text, out decimal desc) ||
                !int.TryParse(txtDiasReserva.Text, out int dias) ||
                string.IsNullOrWhiteSpace(txtNombreLibreria.Text))
            {
                MessageBox.Show("Valores inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _config.DescuentoEstudiante = desc;
            _config.DiasMaxReserva = dias;
            _config.NombreLibreria = txtNombreLibreria.Text.Trim();

            _cfgBLL.GuardarConfiguracion(_config);
            MessageBox.Show("Configuración actualizada.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
