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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            frmVentas form = new frmVentas();
            form.Show();
            this.Hide();

            form.FormClosing += frm_closing;
        }
        private void frm_closing(object sender, FormClosingEventArgs e) {
            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();

        }
    }
}
