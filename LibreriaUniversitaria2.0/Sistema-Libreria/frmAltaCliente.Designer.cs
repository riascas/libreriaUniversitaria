namespace Sistema_Libreria
{
    partial class frmAltaCliente
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
            this.btnSalirAlta = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbLocalidadCliente = new System.Windows.Forms.ComboBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblAlturaCliente = new System.Windows.Forms.Label();
            this.txtAlturaCliente = new System.Windows.Forms.TextBox();
            this.lblCalleCliente = new System.Windows.Forms.Label();
            this.txtCalleCliente = new System.Windows.Forms.TextBox();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lbllocalidadCliente = new System.Windows.Forms.Label();
            this.chkEstudiante = new System.Windows.Forms.CheckBox();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalirAlta
            // 
            this.btnSalirAlta.BackColor = System.Drawing.Color.Red;
            this.btnSalirAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAlta.ForeColor = System.Drawing.Color.White;
            this.btnSalirAlta.Location = new System.Drawing.Point(627, 481);
            this.btnSalirAlta.Name = "btnSalirAlta";
            this.btnSalirAlta.Size = new System.Drawing.Size(84, 36);
            this.btnSalirAlta.TabIndex = 39;
            this.btnSalirAlta.Text = "Salir";
            this.btnSalirAlta.UseVisualStyleBackColor = false;
            this.btnSalirAlta.Click += new System.EventHandler(this.btnSalirAlta_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(315, 363);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 58);
            this.btnGuardar.TabIndex = 38;
            this.btnGuardar.Text = "Agregar Cliente";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbLocalidadCliente
            // 
            this.cmbLocalidadCliente.FormattingEnabled = true;
            this.cmbLocalidadCliente.Location = new System.Drawing.Point(434, 218);
            this.cmbLocalidadCliente.Name = "cmbLocalidadCliente";
            this.cmbLocalidadCliente.Size = new System.Drawing.Size(169, 24);
            this.cmbLocalidadCliente.TabIndex = 37;
            this.cmbLocalidadCliente.Text = "Elige Localidad";
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(141, 199);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(33, 16);
            this.lblDNICliente.TabIndex = 35;
            this.lblDNICliente.Text = "DNI:";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(144, 218);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(169, 22);
            this.txtDNICliente.TabIndex = 34;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(141, 247);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(44, 16);
            this.lblEmailCliente.TabIndex = 33;
            this.lblEmailCliente.Text = "Email:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(144, 266);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(169, 22);
            this.txtEmailCliente.TabIndex = 32;
            // 
            // lblAlturaCliente
            // 
            this.lblAlturaCliente.AutoSize = true;
            this.lblAlturaCliente.Location = new System.Drawing.Point(431, 144);
            this.lblAlturaCliente.Name = "lblAlturaCliente";
            this.lblAlturaCliente.Size = new System.Drawing.Size(44, 16);
            this.lblAlturaCliente.TabIndex = 31;
            this.lblAlturaCliente.Text = "Altura:";
            // 
            // txtAlturaCliente
            // 
            this.txtAlturaCliente.Location = new System.Drawing.Point(434, 163);
            this.txtAlturaCliente.Name = "txtAlturaCliente";
            this.txtAlturaCliente.Size = new System.Drawing.Size(169, 22);
            this.txtAlturaCliente.TabIndex = 30;
            // 
            // lblCalleCliente
            // 
            this.lblCalleCliente.AutoSize = true;
            this.lblCalleCliente.Location = new System.Drawing.Point(431, 91);
            this.lblCalleCliente.Name = "lblCalleCliente";
            this.lblCalleCliente.Size = new System.Drawing.Size(41, 16);
            this.lblCalleCliente.TabIndex = 27;
            this.lblCalleCliente.Text = "Calle:";
            // 
            // txtCalleCliente
            // 
            this.txtCalleCliente.Location = new System.Drawing.Point(434, 110);
            this.txtCalleCliente.Name = "txtCalleCliente";
            this.txtCalleCliente.Size = new System.Drawing.Size(169, 22);
            this.txtCalleCliente.TabIndex = 26;
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(141, 145);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(60, 16);
            this.lblApellidoCliente.TabIndex = 25;
            this.lblApellidoCliente.Text = "Apellido:";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(144, 164);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(169, 22);
            this.txtApellidoCliente.TabIndex = 24;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(141, 91);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(59, 16);
            this.lblNombreCliente.TabIndex = 21;
            this.lblNombreCliente.Text = "Nombre:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(144, 110);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(169, 22);
            this.txtNombreCliente.TabIndex = 20;
            // 
            // lbllocalidadCliente
            // 
            this.lbllocalidadCliente.AutoSize = true;
            this.lbllocalidadCliente.Location = new System.Drawing.Point(431, 199);
            this.lbllocalidadCliente.Name = "lbllocalidadCliente";
            this.lbllocalidadCliente.Size = new System.Drawing.Size(70, 16);
            this.lbllocalidadCliente.TabIndex = 40;
            this.lbllocalidadCliente.Text = "Localidad:";
            this.lbllocalidadCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkEstudiante
            // 
            this.chkEstudiante.AutoSize = true;
            this.chkEstudiante.Location = new System.Drawing.Point(563, 268);
            this.chkEstudiante.Name = "chkEstudiante";
            this.chkEstudiante.Size = new System.Drawing.Size(18, 17);
            this.chkEstudiante.TabIndex = 41;
            this.chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.AutoSize = true;
            this.lblEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstudiante.Location = new System.Drawing.Point(431, 268);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(117, 18);
            this.lblEstudiante.TabIndex = 42;
            this.lblEstudiante.Text = "Es Estudiante:";
            // 
            // frmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 530);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.chkEstudiante);
            this.Controls.Add(this.lbllocalidadCliente);
            this.Controls.Add(this.btnSalirAlta);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbLocalidadCliente);
            this.Controls.Add(this.lblDNICliente);
            this.Controls.Add(this.txtDNICliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.lblAlturaCliente);
            this.Controls.Add(this.txtAlturaCliente);
            this.Controls.Add(this.lblCalleCliente);
            this.Controls.Add(this.txtCalleCliente);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Name = "frmAltaCliente";
            this.Text = "frmAltaCliente";
            this.Load += new System.EventHandler(this.frmAltaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalirAlta;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbLocalidadCliente;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblAlturaCliente;
        private System.Windows.Forms.TextBox txtAlturaCliente;
        private System.Windows.Forms.Label lblCalleCliente;
        private System.Windows.Forms.TextBox txtCalleCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lbllocalidadCliente;
        private System.Windows.Forms.CheckBox chkEstudiante;
        private System.Windows.Forms.Label lblEstudiante;
    }
}