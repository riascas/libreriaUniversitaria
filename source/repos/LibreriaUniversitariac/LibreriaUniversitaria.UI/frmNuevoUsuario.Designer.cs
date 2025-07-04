using System.Windows.Forms;

namespace LibreriaUniversitaria.UI
{
    partial class frmNuevoUsuario
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblNombre, lblApellido, lblDNI, lblEmail, lblRol;
        private TextBox txtNombre, txtApellido, txtDNI, txtEmail;
        private ComboBox cmbRol;
        private Button btnGuardar, btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre = new Label();
            this.txtNombre = new TextBox();
            this.lblApellido = new Label();
            this.txtApellido = new TextBox();
            this.lblDNI = new Label();
            this.txtDNI = new TextBox();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblRol = new Label();
            this.cmbRol = new ComboBox();
            this.btnGuardar = new Button();
            this.btnCancelar = new Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 17);
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(20, 60);
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(100, 57);
            this.txtApellido.Size = new System.Drawing.Size(200, 23);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(20, 100);
            this.lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(100, 97);
            this.txtDNI.Size = new System.Drawing.Size(200, 23);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 140);
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 137);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(20, 180);
            this.lblRol.Text = "Rol:";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbRol.Location = new System.Drawing.Point(100, 177);
            this.cmbRol.Size = new System.Drawing.Size(200, 23);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(20, 220);
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(200, 220);
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevoUsuario
            // 
            this.ClientSize = new System.Drawing.Size(340, 270);
            this.Controls.AddRange(new Control[] {
                lblNombre, txtNombre,
                lblApellido, txtApellido,
                lblDNI, txtDNI,
                lblEmail, txtEmail,
                lblRol, cmbRol,
                btnGuardar, btnCancelar
            });
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Name = "frmNuevoUsuario";
            this.Text = "Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
