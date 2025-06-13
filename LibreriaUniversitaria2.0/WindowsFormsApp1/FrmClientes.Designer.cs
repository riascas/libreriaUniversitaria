namespace LibreriaUniversitaria.UI
{
    partial class FrmClientes
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtBuscarDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvClientes;

        /// <summary>
        /// Método requerido para limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se debe modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtBuscarDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(20, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);

            // txtApellido
            this.txtApellido.Location = new System.Drawing.Point(20, 50);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 20);

            // txtDocumento
            this.txtDocumento.Location = new System.Drawing.Point(20, 80);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(150, 20);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(20, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);

            // chkEstudiante
            this.chkEstudiante.Location = new System.Drawing.Point(20, 140);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(150, 20);
            this.chkEstudiante.Text = "¿Es estudiante?";

            // btnRegistrar
            this.btnRegistrar.Location = new System.Drawing.Point(20, 170);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 23);
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);

            // txtBuscarDni
            this.txtBuscarDni.Location = new System.Drawing.Point(200, 20);
            this.txtBuscarDni.Name = "txtBuscarDni";
            this.txtBuscarDni.Size = new System.Drawing.Size(150, 20);

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(200, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 23);
            this.btnBuscar.Text = "Buscar por DNI";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // dgvClientes
            this.dgvClientes.Location = new System.Drawing.Point(20, 210);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(500, 200);
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;

            // FrmClientes
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 430);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chkEstudiante);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtBuscarDni);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FrmClientes";
            this.Text = "Gestión de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}