using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibreriaUniversitaria.Entidades;
using LibreriaUniversitaria.LogicaNegocio;
using LibreriaUniversitaria.Entidades.Excepciones;

namespace LibreriaUniversitaria.UI
{
    /// <summary>
    /// Formulario de gestión de clientes (registro y búsqueda).
    /// </summary>
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            try
            {
                dgvClientes.DataSource = ClienteService.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente nuevo = new Cliente
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    NumeroDocumento = txtDocumento.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    EsEstudiante = chkEstudiante.Checked
                };

                ClienteService.Registrar(nuevo);

                MessageBox.Show("Cliente registrado exitosamente.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvClientes.DataSource = ClienteService.ObtenerTodos();
            }
            catch (ClienteExistenteException ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (EntidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtBuscarDni.Text.Trim();
                Cliente cliente = ClienteService.BuscarPorDocumento(dni);

                if (cliente == null)
                {
                    MessageBox.Show("No se encontró un cliente con ese DNI.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDocumento.Text = cliente.NumeroDocumento;
                txtEmail.Text = cliente.Email;
                chkEstudiante.Checked = cliente.EsEstudiante;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message);
            }
        }
    }
}