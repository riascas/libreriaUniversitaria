using System;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class frmNuevoProveedor : Form
    {
        private readonly ProveedorBLL _bll = new ProveedorBLL();
        private Proveedor _prov;

        public frmNuevoProveedor()
        {
            InitializeComponent();
        }

        public frmNuevoProveedor(Proveedor prov) : this()
        {
            _prov = prov;
            txtRazonSocial.Text = prov.RazonSocial;
            txtCUIT.Text = prov.CUIT;
            txtTelefono.Text = prov.Telefono;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text) ||
                string.IsNullOrWhiteSpace(txtCUIT.Text))
            {
                MessageBox.Show("Complete Razon Social y CUIT.");
                return;
            }

            if (_prov == null)
                _prov = new Proveedor();

            _prov.RazonSocial = txtRazonSocial.Text.Trim();
            _prov.CUIT = txtCUIT.Text.Trim();
            _prov.Telefono = txtTelefono.Text.Trim();

            if (_prov.IdProveedor == 0)
                _bll.Alta(_prov);
            else
                _bll.Modificar(_prov);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmNuevoProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
