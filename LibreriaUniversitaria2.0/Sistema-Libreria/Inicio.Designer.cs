namespace Sistema_Libreria
{
    partial class Inicio
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
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.menuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.menuListarEmpleados = new FontAwesome.Sharp.IconMenuItem();
            this.menuAltaEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditorial = new FontAwesome.Sharp.IconMenuItem();
            this.menuListarEditoriales = new FontAwesome.Sharp.IconMenuItem();
            this.menuAltaEditorial = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuListarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAltaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentaReserva = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.geolocalizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.menuListarLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1067, 59);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de ventas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.White;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.ForeColor = System.Drawing.Color.Black;
            this.contenedor.Location = new System.Drawing.Point(0, 132);
            this.contenedor.Margin = new System.Windows.Forms.Padding(4);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1067, 422);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(708, 9);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(138, 18);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Nombre del usuario";
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem3.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem3.Text = "iconMenuItem3";
            // 
            // menuUsuario
            // 
            this.menuUsuario.AutoSize = false;
            this.menuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuListarEmpleados,
            this.menuAltaEmpleado});
            this.menuUsuario.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuUsuario.IconColor = System.Drawing.Color.Black;
            this.menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuario.IconSize = 50;
            this.menuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(152, 69);
            this.menuUsuario.Text = "Empleados";
            this.menuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuUsuario.Click += new System.EventHandler(this.menusuarios_Click);
            // 
            // menuListarEmpleados
            // 
            this.menuListarEmpleados.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuListarEmpleados.IconColor = System.Drawing.Color.Black;
            this.menuListarEmpleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuListarEmpleados.Name = "menuListarEmpleados";
            this.menuListarEmpleados.Size = new System.Drawing.Size(224, 26);
            this.menuListarEmpleados.Text = "Lista usuarios";
            this.menuListarEmpleados.Click += new System.EventHandler(this.menuListarEmpleados_Click);
            // 
            // menuAltaEmpleado
            // 
            this.menuAltaEmpleado.Name = "menuAltaEmpleado";
            this.menuAltaEmpleado.Size = new System.Drawing.Size(224, 26);
            this.menuAltaEmpleado.Text = "Alta de Empleado";
            this.menuAltaEmpleado.Click += new System.EventHandler(this.menuAltaEmpleado_Click);
            // 
            // menuEditorial
            // 
            this.menuEditorial.AutoSize = false;
            this.menuEditorial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuListarEditoriales,
            this.menuAltaEditorial,
            this.menuListarLibro});
            this.menuEditorial.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.menuEditorial.IconColor = System.Drawing.Color.Black;
            this.menuEditorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuEditorial.IconSize = 50;
            this.menuEditorial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuEditorial.Name = "menuEditorial";
            this.menuEditorial.Size = new System.Drawing.Size(152, 69);
            this.menuEditorial.Text = "Editoriales";
            this.menuEditorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuListarEditoriales
            // 
            this.menuListarEditoriales.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuListarEditoriales.IconColor = System.Drawing.Color.Black;
            this.menuListarEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuListarEditoriales.Name = "menuListarEditoriales";
            this.menuListarEditoriales.Size = new System.Drawing.Size(224, 26);
            this.menuListarEditoriales.Text = "Listar Editoriales";
            this.menuListarEditoriales.Click += new System.EventHandler(this.menuListarEditoriales_Click);
            // 
            // menuAltaEditorial
            // 
            this.menuAltaEditorial.IconChar = FontAwesome.Sharp.IconChar.None;
            this.menuAltaEditorial.IconColor = System.Drawing.Color.Black;
            this.menuAltaEditorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAltaEditorial.Name = "menuAltaEditorial";
            this.menuAltaEditorial.Size = new System.Drawing.Size(224, 26);
            this.menuAltaEditorial.Text = "Alta de Editorial";
            this.menuAltaEditorial.Click += new System.EventHandler(this.menuAltaEditorial_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.AutoSize = false;
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menuCompras.IconColor = System.Drawing.Color.Black;
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 50;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Size = new System.Drawing.Size(120, 69);
            this.menuCompras.Text = "Compras";
            this.menuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuClientes
            // 
            this.menuClientes.AutoSize = false;
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuListarClientes,
            this.menuAltaCliente});
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.menuClientes.IconColor = System.Drawing.Color.Black;
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 50;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(152, 69);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuListarClientes
            // 
            this.menuListarClientes.Name = "menuListarClientes";
            this.menuListarClientes.Size = new System.Drawing.Size(178, 26);
            this.menuListarClientes.Text = "Lista Clientes";
            this.menuListarClientes.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // menuAltaCliente
            // 
            this.menuAltaCliente.Name = "menuAltaCliente";
            this.menuAltaCliente.Size = new System.Drawing.Size(178, 26);
            this.menuAltaCliente.Text = "Alta Cliente";
            this.menuAltaCliente.Click += new System.EventHandler(this.menuAltaCliente_Click);
            // 
            // menuVentaReserva
            // 
            this.menuVentaReserva.AutoSize = false;
            this.menuVentaReserva.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.menuVentaReserva.IconColor = System.Drawing.Color.Black;
            this.menuVentaReserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentaReserva.IconSize = 50;
            this.menuVentaReserva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentaReserva.Name = "menuVentaReserva";
            this.menuVentaReserva.Size = new System.Drawing.Size(120, 69);
            this.menuVentaReserva.Text = "Ventas/Reserva";
            this.menuVentaReserva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuReportes
            // 
            this.menuReportes.AutoSize = false;
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geolocalizacionToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.librToolStripMenuItem});
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menuReportes.IconColor = System.Drawing.Color.Black;
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 50;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(120, 69);
            this.menuReportes.Text = "Reportes";
            this.menuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // geolocalizacionToolStripMenuItem
            // 
            this.geolocalizacionToolStripMenuItem.Name = "geolocalizacionToolStripMenuItem";
            this.geolocalizacionToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.geolocalizacionToolStripMenuItem.Text = "Geolocalizacion";
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.vendedorToolStripMenuItem.Text = "Ventas por Vendedor";
            // 
            // librToolStripMenuItem
            // 
            this.librToolStripMenuItem.Name = "librToolStripMenuItem";
            this.librToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.librToolStripMenuItem.Text = "Ventas por libro";
            this.librToolStripMenuItem.Click += new System.EventHandler(this.librToolStripMenuItem_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuEditorial,
            this.menuCompras,
            this.menuClientes,
            this.menuVentaReserva,
            this.menuReportes});
            this.menu.Location = new System.Drawing.Point(0, 59);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1067, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnExit.IconColor = System.Drawing.Color.Red;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.Location = new System.Drawing.Point(1017, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 56);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuListarLibro
            // 
            this.menuListarLibro.Name = "menuListarLibro";
            this.menuListarLibro.Size = new System.Drawing.Size(224, 26);
            this.menuListarLibro.Text = "Lista de Libros";
            this.menuListarLibro.Click += new System.EventHandler(this.menuListarLibro_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem menuUsuario;
        private FontAwesome.Sharp.IconMenuItem menuListarEmpleados;
        private FontAwesome.Sharp.IconMenuItem menuEditorial;
        private FontAwesome.Sharp.IconMenuItem menuListarEditoriales;
        private FontAwesome.Sharp.IconMenuItem menuAltaEditorial;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuVentaReserva;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem geolocalizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAltaEmpleado;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.ToolStripMenuItem menuListarClientes;
        private System.Windows.Forms.ToolStripMenuItem menuAltaCliente;
        private System.Windows.Forms.ToolStripMenuItem menuListarLibro;
    }
}