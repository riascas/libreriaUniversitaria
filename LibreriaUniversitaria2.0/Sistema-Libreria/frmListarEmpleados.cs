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
    public partial class frmListarEmpleados : Form
    {
        private EmpleadoService servicio = new EmpleadoService();
        public frmListarEmpleados()
        {
            InitializeComponent();
        }

        private void frmListarEmpleados_Load(object sender, EventArgs e)
        {
            EmpleadoService servicio = new EmpleadoService();
            var empleados = servicio.ObtenerTodos(); // trae todos

            
            var listaMostrar = empleados.Select(emp => new
            {
                Nombre = emp.UnaPersona.Nombre,
                Apellido = emp.UnaPersona.Apellido,
                DNI = emp.UnaPersona.DNI,
                Cargo = emp.UnRol.Rol,
                Usuario = emp.Usuario,
                Clave = emp.Clave,
                Mail = emp.UnaPersona.Email,
                Calle = emp.UnaPersona.UnDomicilio.Calle,
                Altura = emp.UnaPersona.UnDomicilio.Altura,
                Localidad = emp.UnaPersona.UnDomicilio.UnaLocalidad.NombreLocalidad,
                Municipio = emp.UnaPersona.UnDomicilio.UnaLocalidad.UnMunicipio.NombreMunicipio
            }).ToList();

            dgvEmpleados.DataSource = listaMostrar;
        }
    }
}
