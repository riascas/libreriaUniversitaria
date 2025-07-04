using System;
using System.Windows.Forms;

namespace LibreriaUniversitaria.UI
{
    partial class frmNuevaOrdenCompra
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
        private Button btnCancelar;

        /// <summary> 
        /// Limpia los recursos usados. 
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.dtpFecha = new DateTimePicker();
            this.btnGuardar = new Button();
            this.btnCancelar = new Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 25);
            this.lblTitulo.Text = "🛒 Nueva Orden de Compra";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(20, 60);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(20, 100);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(140, 100);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new EventHandler(this.btnCancelar_Click);
            // 
            // frmNuevaOrdenCompra
            // 
            this.ClientSize = new System.Drawing.Size(400, 160);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "frmNuevaOrdenCompra";
            this.Text = "Nueva Orden de Compra";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
