using System;
using System.Windows.Forms;

namespace LibreriaUniversitaria.UI
{
    partial class frmConfiguracionSistema
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private Label lblNombreLib, lblDescEst, lblDiasRes;
        private TextBox txtNombreLibreria, txtDescuentoEstudiante, txtDiasReserva;
        private Button btnGuardar, btnVolver;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.lblNombreLib = new Label();
            this.txtNombreLibreria = new TextBox();
            this.lblDescEst = new Label();
            this.txtDescuentoEstudiante = new TextBox();
            this.lblDiasRes = new Label();
            this.txtDiasReserva = new TextBox();
            this.btnGuardar = new Button();
            this.btnVolver = new Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Text = "⚙️ Configuración del Sistema";
            // 
            // lblNombreLib
            // 
            this.lblNombreLib.AutoSize = true;
            this.lblNombreLib.Location = new System.Drawing.Point(20, 70);
            this.lblNombreLib.Text = "Nombre Librería:";
            // 
            // txtNombreLibreria
            // 
            this.txtNombreLibreria.Location = new System.Drawing.Point(150, 67);
            this.txtNombreLibreria.Size = new System.Drawing.Size(200, 23);
            // 
            // lblDescEst
            // 
            this.lblDescEst.AutoSize = true;
            this.lblDescEst.Location = new System.Drawing.Point(20, 110);
            this.lblDescEst.Text = "Descuento Estudiante (%):";
            // 
            // txtDescuentoEstudiante
            // 
            this.txtDescuentoEstudiante.Location = new System.Drawing.Point(200, 107);
            this.txtDescuentoEstudiante.Size = new System.Drawing.Size(80, 23);
            // 
            // lblDiasRes
            // 
            this.lblDiasRes.AutoSize = true;
            this.lblDiasRes.Location = new System.Drawing.Point(20, 150);
            this.lblDiasRes.Text = "Días Máx. Reserva:";
            // 
            // txtDiasReserva
            // 
            this.txtDiasReserva.Location = new System.Drawing.Point(150, 147);
            this.txtDiasReserva.Size = new System.Drawing.Size(50, 23);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(20, 190);
            this.btnGuardar.Size = new System.Drawing.Size(100, 30);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(150, 190);
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new EventHandler(this.btnVolver_Click);
            // 
            // frmConfiguracionSistema
            // 
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombreLib);
            this.Controls.Add(this.txtNombreLibreria);
            this.Controls.Add(this.lblDescEst);
            this.Controls.Add(this.txtDescuentoEstudiante);
            this.Controls.Add(this.lblDiasRes);
            this.Controls.Add(this.txtDiasReserva);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "frmConfiguracionSistema";
            this.Text = "Configuración Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
