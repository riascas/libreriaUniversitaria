using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class frmClientes : Form
    {
        private readonly ClienteBLL _clienteBLL = new ClienteBLL();
        private List<Cliente> _listaClientes;

        public frmClientes()
        {
            InitializeComponent();
            cmbCriterio.Items.AddRange(new[] { "Nombre", "Apellido", "DNI" });
            cmbCriterio.SelectedIndex = 0;
            CargarClientes();
        }

        private void CargarClientes()
        {
            _listaClientes = _clienteBLL.ObtenerTodos();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = _listaClientes;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();
            IEnumerable<Cliente> filtrados = _listaClientes;
            switch (cmbCriterio.SelectedItem.ToString())
            {
                case "Nombre":
                    filtrados = _listaClientes.Where(c => c.Nombre.ToLower().Contains(busqueda));
                    break;
                case "Apellido":
                    filtrados = _listaClientes.Where(c => c.Apellido.ToLower().Contains(busqueda));
                    break;
                case "DNI":
                    filtrados = _listaClientes.Where(c => c.Dni.ToString().Contains(busqueda));
                    break;
            }
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = filtrados.ToList();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var frm = new frmNuevoCliente())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    CargarClientes();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;
            var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            using (var frm = new frmNuevoCliente(cliente))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    CargarClientes();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;
            var cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            var msg = MessageBox.Show($"¿Eliminar cliente {cliente.Nombre} {cliente.Apellido}?",
                                     "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                _clienteBLL.Eliminar(cliente.IdCliente, cliente.IdPersona);
                CargarClientes();
            }
        }
    }
}
