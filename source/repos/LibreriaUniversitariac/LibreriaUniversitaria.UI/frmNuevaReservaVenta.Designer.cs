using System.Windows.Forms;
using System;

namespace LibreriaUniversitaria.UI
{
    partial class frmNuevaReservaVenta
    {
        private System.ComponentModel.IContainer components = null;
        private RadioButton rbNuevaReserva, rbBuscarReserva;
        private Label lblIdReserva;
        private TextBox txtIdReserva;
        private Button btnBuscarReserva;
        private Button btnBuscarCliente, btnBuscarLibro;
        private Label lblDNICliente, lblNombreCliente, lblEstudiante;
        private TextBox txtDNICliente;
        private TextBox txtISBN, txtTitulo, txtPrecio, txtCantidad;
        private Button btnAgregar;
        private DataGridView dgvDetalle;
        private Label lblSubtotal, lblDescuento, lblTotal;
        private Button btnConfirmarReserva, btnConfirmarVenta, btnCancelarReserva, btnVolver;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rbNuevaReserva = new System.Windows.Forms.RadioButton();
            this.rbBuscarReserva = new System.Windows.Forms.RadioButton();
            this.lblIdReserva = new System.Windows.Forms.Label();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblEstudiante = new System.Windows.Forms.Label();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirmarReserva = new System.Windows.Forms.Button();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // rbNuevaReserva
            // 
            this.rbNuevaReserva.AutoSize = true;
            this.rbNuevaReserva.Checked = true;
            this.rbNuevaReserva.Location = new System.Drawing.Point(20, 20);
            this.rbNuevaReserva.Name = "rbNuevaReserva";
            this.rbNuevaReserva.Size = new System.Drawing.Size(100, 17);
            this.rbNuevaReserva.TabIndex = 0;
            this.rbNuevaReserva.TabStop = true;
            this.rbNuevaReserva.Text = "Nueva Reserva";
            this.rbNuevaReserva.CheckedChanged += new System.EventHandler(this.rbNuevaReserva_CheckedChanged);
            // 
            // rbBuscarReserva
            // 
            this.rbBuscarReserva.AutoSize = true;
            this.rbBuscarReserva.Location = new System.Drawing.Point(150, 20);
            this.rbBuscarReserva.Name = "rbBuscarReserva";
            this.rbBuscarReserva.Size = new System.Drawing.Size(101, 17);
            this.rbBuscarReserva.TabIndex = 1;
            this.rbBuscarReserva.Text = "Buscar Reserva";
            this.rbBuscarReserva.CheckedChanged += new System.EventHandler(this.rbBuscarReserva_CheckedChanged);
            // 
            // lblIdReserva
            // 
            this.lblIdReserva.Location = new System.Drawing.Point(20, 50);
            this.lblIdReserva.Name = "lblIdReserva";
            this.lblIdReserva.Size = new System.Drawing.Size(100, 23);
            this.lblIdReserva.TabIndex = 2;
            this.lblIdReserva.Text = "ID Reserva:";
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Location = new System.Drawing.Point(150, 50);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(100, 20);
            this.txtIdReserva.TabIndex = 3;
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.Location = new System.Drawing.Point(281, 45);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarReserva.TabIndex = 4;
            this.btnBuscarReserva.Text = "Buscar";
            this.btnBuscarReserva.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(20, 90);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.Location = new System.Drawing.Point(150, 95);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(100, 23);
            this.lblDNICliente.TabIndex = 6;
            this.lblDNICliente.Text = "DNI:";
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(256, 90);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(100, 20);
            this.txtDNICliente.TabIndex = 7;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 130);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(100, 23);
            this.lblNombreCliente.TabIndex = 8;
            // 
            // lblEstudiante
            // 
            this.lblEstudiante.ForeColor = System.Drawing.Color.Green;
            this.lblEstudiante.Location = new System.Drawing.Point(300, 130);
            this.lblEstudiante.Name = "lblEstudiante";
            this.lblEstudiante.Size = new System.Drawing.Size(100, 23);
            this.lblEstudiante.TabIndex = 9;
            this.lblEstudiante.Text = "Estudiante -10%";
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(20, 170);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLibro.TabIndex = 10;
            this.btnBuscarLibro.Text = "Buscar Libro";
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(140, 170);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 11;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(260, 170);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(420, 170);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(500, 170);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(666, 170);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.Location = new System.Drawing.Point(20, 210);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(760, 250);
            this.dgvDetalle.TabIndex = 16;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(20, 480);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotal.TabIndex = 17;
            this.lblSubtotal.Text = "Subtotal: 0.00";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Location = new System.Drawing.Point(200, 480);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(100, 23);
            this.lblDescuento.TabIndex = 18;
            this.lblDescuento.Text = "Descuento: 0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(380, 480);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "Total: 0.00";
            // 
            // btnConfirmarReserva
            // 
            this.btnConfirmarReserva.Location = new System.Drawing.Point(20, 510);
            this.btnConfirmarReserva.Name = "btnConfirmarReserva";
            this.btnConfirmarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarReserva.TabIndex = 20;
            this.btnConfirmarReserva.Text = "Confirmar Reserva";
            this.btnConfirmarReserva.Click += new System.EventHandler(this.btnConfirmarReserva_Click);
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Location = new System.Drawing.Point(180, 510);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarVenta.TabIndex = 21;
            this.btnConfirmarVenta.Text = "Confirmar Venta";
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Location = new System.Drawing.Point(360, 510);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarReserva.TabIndex = 22;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(560, 510);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 23;
            this.btnVolver.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmNuevaReservaVenta
            // 
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.rbNuevaReserva);
            this.Controls.Add(this.rbBuscarReserva);
            this.Controls.Add(this.lblIdReserva);
            this.Controls.Add(this.txtIdReserva);
            this.Controls.Add(this.btnBuscarReserva);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblDNICliente);
            this.Controls.Add(this.txtDNICliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblEstudiante);
            this.Controls.Add(this.btnBuscarLibro);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnConfirmarReserva);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNuevaReservaVenta";
            this.Text = "Reservas y Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
