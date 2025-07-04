using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Libreria;
using ENT_Libreria;

namespace Sistema_Libreria
{
    public partial class frmAltaEditorial : Form
    {
        public frmAltaEditorial()
        {
            InitializeComponent();
        }

        private void frmAltaEditorial_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Editorial nuevaEditorial = new Editorial
            {
                NombreEditorial = txtNombreEditorial.Text,
                Contacto = txtContacto.Text,
                CUIT = txtCUIT.Text
            };
            EditorialService editorialService = new EditorialService();
            int resultado = editorialService.Insertar(nuevaEditorial);

            if (resultado == 0)
            {
                MessageBox.Show("Error al guardar la editorial. Verifique los datos ingresados.");
            }
            else
            {
                MessageBox.Show("Editorial guardada correctamente.");
                this.Close(); 
            }
        }

        private void btnSalirAlta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
