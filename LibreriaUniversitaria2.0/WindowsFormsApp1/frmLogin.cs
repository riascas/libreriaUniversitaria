using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
           string usuario =textBox1.Text;
           string password = textBox2.Text;
            if(usuario == "" || password == "")
            {
                MessageBox.Show("Rellene todos los campos por favor");
                return;
            }
            else
            {
                if(usuario =="diego" && password == "123")
                {
                    MessageBox.Show("Bienvenido" + textBox1.Text+ "Usuario registrado");
                }
                else
                {
                    if (usuario == "esmilce" && password == "123")
                    {
                        MessageBox.Show("Bienvenido" + textBox1.Text + "Usuario registrado");
                    }
                    else
                    {
                        MessageBox.Show("usuario no registrado");
                        return;
                    }
                }

            }
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
    }
}
