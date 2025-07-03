using BLL_Libreria;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Libreria
{
    public partial class frmAltaCliente : Form
    {
        public frmAltaCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            var localidadService = new LocalidadService();
            cmbLocalidadCliente.DataSource = localidadService.ObtenerTodos();
            cmbLocalidadCliente.DisplayMember = "NombreLocalidad";
            cmbLocalidadCliente.ValueMember = "IdLocalidad";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente
            {
                EsEstudiante = chkEstudiante.Checked,
                UnaPersona = new Persona
                {
                    Nombre = txtNombreCliente.Text,
                    Apellido = txtApellidoCliente.Text,
                    DNI = txtDNICliente.Text,
                    Email = txtEmailCliente.Text,
                    UnDomicilio = new Domicilio
                    {
                        Calle = txtCalleCliente.Text,
                        Altura = int.Parse(txtAlturaCliente.Text),
                        UnaLocalidad = new Localidad
                        {
                            IdLocalidad = (int)cmbLocalidadCliente.SelectedValue
                        }
                    }
                }
            };

            ClienteService clienteService = new ClienteService();
            int resultado = clienteService.Insertar(nuevo);

            if (resultado > 0)
            {
                MessageBox.Show("Cliente agregado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hubo un error al insertar el cliente.");
            }
        }

        private void btnSalirAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
