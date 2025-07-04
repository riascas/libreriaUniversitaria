using BLL_Libreria;
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
    public partial class frmListarClientes : Form
    {
        private ClienteService clienteService = new ClienteService();

        public frmListarClientes()
        {
            InitializeComponent();
        }

        private void frmListarClientes_Load(object sender, EventArgs e)
        {

            ClienteService servicio = new ClienteService();
            var clientes = servicio.ObtenerTodos();

            var listaMostrar = clientes.Select(c => new
            {
                Nombre = c.UnaPersona.Nombre,
                Apellido = c.UnaPersona.Apellido,
                DNI = c.UnaPersona.DNI,
                Email = c.UnaPersona.Email,
                Calle = c.UnaPersona.UnDomicilio.Calle,
                Altura = c.UnaPersona.UnDomicilio.Altura,
                Localidad = c.UnaPersona.UnDomicilio.UnaLocalidad.NombreLocalidad,
                EsEstudiante = c.EsEstudiante ? "Sí" : "No"
            }).ToList();

            dgvClientes.DataSource = listaMostrar;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

