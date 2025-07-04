using System.Windows.Forms;
using FontAwesome.Sharp;

namespace LibreriaUniversitaria.UI
{
    partial class frmInicio
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlMain;
        private IconButton btnEmpleados;
        private IconButton btnClientes;
        private IconButton btnLibros;
        private IconButton btnProveedores;
        private IconButton btnOrdenesCompra;
        private IconButton btnReservasVentas;
        private IconButton btnReportes;
        private IconButton btnConfiguracion;
        private Label lblUsuario;
        private Button btnCerrar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new Panel();
            this.btnEmpleados = new IconButton();
            this.btnClientes = new IconButton();
            this.btnLibros = new IconButton();
            this.btnProveedores = new IconButton();
            this.btnOrdenesCompra = new IconButton();
            this.btnReservasVentas = new IconButton();
            this.btnReportes = new IconButton();
            this.btnConfiguracion = new IconButton();
            this.lblUsuario = new Label();
            this.btnCerrar = new Button();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(20, 150);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(940, 500);
            this.pnlMain.TabIndex = 8;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.FlatStyle = FlatStyle.Flat;
            this.btnEmpleados.IconChar = IconChar.UserGear;
            this.btnEmpleados.IconColor = System.Drawing.Color.Black;
            this.btnEmpleados.IconFont = IconFont.Auto;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEmpleados.Location = new System.Drawing.Point(20, 50);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(100, 80);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatStyle = FlatStyle.Flat;
            this.btnClientes.IconChar = IconChar.Users;
            this.btnClientes.IconColor = System.Drawing.Color.Black;
            this.btnClientes.IconFont = IconFont.Auto;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(140, 50);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 80);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.FlatStyle = FlatStyle.Flat;
            this.btnLibros.IconChar = IconChar.Book;
            this.btnLibros.IconColor = System.Drawing.Color.Black;
            this.btnLibros.IconFont = IconFont.Auto;
            this.btnLibros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLibros.Location = new System.Drawing.Point(260, 50);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(100, 80);
            this.btnLibros.TabIndex = 2;
            this.btnLibros.Text = "Libros";
            this.btnLibros.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.FlatStyle = FlatStyle.Flat;
            this.btnProveedores.IconChar = IconChar.Truck;
            this.btnProveedores.IconColor = System.Drawing.Color.Black;
            this.btnProveedores.IconFont = IconFont.Auto;
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProveedores.Location = new System.Drawing.Point(380, 50);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(100, 80);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnOrdenesCompra
            // 
            this.btnOrdenesCompra.FlatStyle = FlatStyle.Flat;
            this.btnOrdenesCompra.IconChar = IconChar.CartShopping;
            this.btnOrdenesCompra.IconColor = System.Drawing.Color.Black;
            this.btnOrdenesCompra.IconFont = IconFont.Auto;
            this.btnOrdenesCompra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrdenesCompra.Location = new System.Drawing.Point(500, 50);
            this.btnOrdenesCompra.Name = "btnOrdenesCompra";
            this.btnOrdenesCompra.Size = new System.Drawing.Size(100, 80);
            this.btnOrdenesCompra.TabIndex = 4;
            this.btnOrdenesCompra.Text = "Órdenes Compra";
            this.btnOrdenesCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdenesCompra.UseVisualStyleBackColor = true;
            this.btnOrdenesCompra.Click += new System.EventHandler(this.btnOrdenesCompra_Click);
            // 
            // btnReservasVentas
            // 
            this.btnReservasVentas.FlatStyle = FlatStyle.Flat;
            this.btnReservasVentas.IconChar = IconChar.ClipboardList;
            this.btnReservasVentas.IconColor = System.Drawing.Color.Black;
            this.btnReservasVentas.IconFont = IconFont.Auto;
            this.btnReservasVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservasVentas.Location = new System.Drawing.Point(620, 50);
            this.btnReservasVentas.Name = "btnReservasVentas";
            this.btnReservasVentas.Size = new System.Drawing.Size(100, 80);
            this.btnReservasVentas.TabIndex = 5;
            this.btnReservasVentas.Text = "Reservas/Ventas";
            this.btnReservasVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReservasVentas.UseVisualStyleBackColor = true;
            this.btnReservasVentas.Click += new System.EventHandler(this.btnReservasVentas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.FlatStyle = FlatStyle.Flat;
            this.btnReportes.IconChar = IconChar.ChartBar;
            this.btnReportes.IconColor = System.Drawing.Color.Black;
            this.btnReportes.IconFont = IconFont.Auto;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportes.Location = new System.Drawing.Point(740, 50);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(100, 80);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.FlatStyle = FlatStyle.Flat;
            this.btnConfiguracion.IconChar = IconChar.Gears;
            this.btnConfiguracion.IconColor = System.Drawing.Color.Black;
            this.btnConfiguracion.IconFont = IconFont.Auto;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfiguracion.Location = new System.Drawing.Point(860, 50);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(100, 80);
            this.btnConfiguracion.TabIndex = 7;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(600, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(115, 13);
            this.lblUsuario.Text = "[Nombre Apellido (Rol)]";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnCerrar.Location = new System.Drawing.Point(880, 670);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 30);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmInicio
            // 
            this.ClientSize = new System.Drawing.Size(984, 720);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnLibros);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnOrdenesCompra);
            this.Controls.Add(this.btnReservasVentas);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Name = "frmInicio";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Librería Universitaria";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
