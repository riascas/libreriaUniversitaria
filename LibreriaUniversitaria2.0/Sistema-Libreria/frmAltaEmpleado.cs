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
    public partial class frmAltaEmpleado : Form
    {
        public frmAltaEmpleado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmAltaEmpleado_Load(object sender, EventArgs e)
        {
            RolEmpleadoService rolService = new RolEmpleadoService();
            LocalidadService locService = new LocalidadService();

            cmbRolEmpleado.DataSource = rolService.ObtenerTodos();
            cmbRolEmpleado.DisplayMember = "Rol";
            cmbRolEmpleado.ValueMember = "IdRolEmpleado";

            cmbLocalidad.DataSource = locService.ObtenerTodos();
            cmbLocalidad.DisplayMember = "NombreLocalidad";
            cmbLocalidad.ValueMember = "IdLocalidad";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado nuevoEmpleado = new Empleado();
                nuevoEmpleado.Usuario = txtUsuario.Text;
                nuevoEmpleado.Clave = txtClave.Text;
                nuevoEmpleado.UnRol = (RolEmpleado)cmbRolEmpleado.SelectedItem;

                Persona persona = new Persona();
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                persona.DNI = txtDNI.Text;
                persona.Email = txtEmail.Text;

                Domicilio domicilio = new Domicilio();
                domicilio.Calle = txtCalle.Text;
                domicilio.Altura = int.Parse(txtAltura.Text);
                domicilio.UnaLocalidad = (Localidad)cmbLocalidad.SelectedItem;

                persona.UnDomicilio = domicilio;
                nuevoEmpleado.UnaPersona = persona;

                EmpleadoService service = new EmpleadoService();
                int resultado = service.AltaEmpleado(nuevoEmpleado);

                if (resultado > 0)
                {
                    MessageBox.Show("Empleado agregado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar el empleado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnSalirAlta_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
