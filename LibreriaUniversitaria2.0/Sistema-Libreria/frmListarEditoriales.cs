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
    public partial class frmListarEditoriales : Form
    {
        private EditorialService servicio = new EditorialService();

        public frmListarEditoriales()
        {
            InitializeComponent();
        }

        private void frmListarEditoriales_Load(object sender, EventArgs e)
        {
            
            EditorialService servicio = new EditorialService();
            var editoriales = servicio.ObtenerTodos();

            var listaMostrar = editoriales.Select(edit => new
            {
                Nombre = edit.NombreEditorial,
                Contacto = edit.Contacto,
                CUIT = edit.CUIT,
            }).ToList();

            dgvEditoriales.DataSource = listaMostrar;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
