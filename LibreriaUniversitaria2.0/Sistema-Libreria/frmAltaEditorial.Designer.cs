namespace Sistema_Libreria
{
    partial class frmAltaEditorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.lblContactoEditorial = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblNombreEditorial = new System.Windows.Forms.Label();
            this.txtNombreEditorial = new System.Windows.Forms.TextBox();
            this.btnSalirAlta = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(43, 138);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(41, 16);
            this.lblCUIT.TabIndex = 23;
            this.lblCUIT.Text = "CUIT:";
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(46, 157);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(169, 22);
            this.txtCUIT.TabIndex = 22;
            // 
            // lblContactoEditorial
            // 
            this.lblContactoEditorial.AutoSize = true;
            this.lblContactoEditorial.Location = new System.Drawing.Point(43, 84);
            this.lblContactoEditorial.Name = "lblContactoEditorial";
            this.lblContactoEditorial.Size = new System.Drawing.Size(63, 16);
            this.lblContactoEditorial.TabIndex = 19;
            this.lblContactoEditorial.Text = "Contacto:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(46, 103);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(169, 22);
            this.txtContacto.TabIndex = 18;
            // 
            // lblNombreEditorial
            // 
            this.lblNombreEditorial.AutoSize = true;
            this.lblNombreEditorial.Location = new System.Drawing.Point(43, 30);
            this.lblNombreEditorial.Name = "lblNombreEditorial";
            this.lblNombreEditorial.Size = new System.Drawing.Size(111, 16);
            this.lblNombreEditorial.TabIndex = 17;
            this.lblNombreEditorial.Text = "Nombre Editorial:";
            // 
            // txtNombreEditorial
            // 
            this.txtNombreEditorial.Location = new System.Drawing.Point(46, 49);
            this.txtNombreEditorial.Name = "txtNombreEditorial";
            this.txtNombreEditorial.Size = new System.Drawing.Size(169, 22);
            this.txtNombreEditorial.TabIndex = 16;
            // 
            // btnSalirAlta
            // 
            this.btnSalirAlta.BackColor = System.Drawing.Color.Red;
            this.btnSalirAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAlta.ForeColor = System.Drawing.Color.White;
            this.btnSalirAlta.Location = new System.Drawing.Point(247, 351);
            this.btnSalirAlta.Name = "btnSalirAlta";
            this.btnSalirAlta.Size = new System.Drawing.Size(84, 36);
            this.btnSalirAlta.TabIndex = 25;
            this.btnSalirAlta.Text = "Salir";
            this.btnSalirAlta.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(58, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 58);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Agregar Editorial";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAltaEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 417);
            this.Controls.Add(this.btnSalirAlta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.lblContactoEditorial);
            this.Controls.Add(this.txtContacto);
            this.Controls.Add(this.lblNombreEditorial);
            this.Controls.Add(this.txtNombreEditorial);
            this.Name = "frmAltaEditorial";
            this.Text = "frmAltaEditorial";
            this.Load += new System.EventHandler(this.frmAltaEditorial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label lblContactoEditorial;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblNombreEditorial;
        private System.Windows.Forms.TextBox txtNombreEditorial;
        private System.Windows.Forms.Button btnSalirAlta;
        private System.Windows.Forms.Button btnGuardar;
    }
}