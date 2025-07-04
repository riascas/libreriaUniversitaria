using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.UI
{
    public partial class frmUsuarios : Form
    {
        private readonly EmpleadoBLL _bll = new EmpleadoBLL();
        private List<Empleado> _lista;

        public frmUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            _lista = _bll.ObtenerTodos();
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = _lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtBuscar.Text.Trim().ToLower();
            var filtrados = _lista.Where(u =>
                   u.Nombre.ToLower().Contains(criterio)
                || u.Apellido.ToLower().Contains(criterio)
                || u.Dni.ToString().Contains(criterio))
                .ToList();

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = filtrados;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (var dlg = new frmNuevoUsuario())
                if (dlg.ShowDialog() == DialogResult.OK)
                    CargarUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;
            var emp = (Empleado)dgvUsuarios.CurrentRow.DataBoundItem;
            using (var dlg = new frmNuevoUsuario(emp))
                if (dlg.ShowDialog() == DialogResult.OK)
                    CargarUsuarios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null) return;
            var emp = (Empleado)dgvUsuarios.CurrentRow.DataBoundItem;
            var confirm = MessageBox.Show(
                $"¿Eliminar a {emp.Nombre} {emp.Apellido}?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _bll.Eliminar(emp.IdEmpleado);
                CargarUsuarios();
            }
        }
    }
}
