using System;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class frmNuevaOrdenCompra : Form
    {
        private readonly OrdenCompraBLL _ocBLL = new OrdenCompraBLL();
        private OrdenCompra _orden;

        // Constructor para alta
        public frmNuevaOrdenCompra()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Today;
        }

        // Constructor para edición
        public frmNuevaOrdenCompra(OrdenCompra orden) : this()
        {
            _orden = orden;
            // TODO: cargar datos de _orden en los controles, por ejemplo:
            // dtpFecha.Value = _orden.Fecha;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Ejemplo de guardado (ajusta según tu DAL/BLL)
            if (_orden == null) _orden = new OrdenCompra();
            _orden.Fecha = dtpFecha.Value;
            _ocBLL.Guardar(_orden);  // Asegúrate de implementar Guardar en BLL/DAL

            MessageBox.Show("Orden guardada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
