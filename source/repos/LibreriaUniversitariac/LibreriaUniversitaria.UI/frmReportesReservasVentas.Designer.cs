using System.Windows.Forms;

namespace LibreriaUniversitaria.UI
{
    partial class frmReportesReservasVentas
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo, lblUsuario, lblDesde, lblHasta;
        private DateTimePicker dtpDesde, dtpHasta;
        private Button btnFiltrar, btnCerrar;
        private TabControl tabControlReportes;
        private TabPage tabGeo, tabLibros, tabVendedores;
        private DataGridView dgvGeo, dgvLibros, dgvVendedores;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.tabControlReportes = new System.Windows.Forms.TabControl();
            this.tabGeo = new System.Windows.Forms.TabPage();
            this.dgvGeo = new System.Windows.Forms.DataGridView();
            this.tabLibros = new System.Windows.Forms.TabPage();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.tabVendedores = new System.Windows.Forms.TabPage();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabControlReportes.SuspendLayout();
            this.tabGeo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeo)).BeginInit();
            this.tabLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.tabVendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(280, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Reportes de Reservas y Ventas";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(660, 25);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(112, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "[Rol: Nombre Apellido]";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(130, 66);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(188, 60);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(422, 66);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(496, 60);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(702, 56);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(80, 25);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tabControlReportes
            // 
            this.tabControlReportes.Controls.Add(this.tabGeo);
            this.tabControlReportes.Controls.Add(this.tabLibros);
            this.tabControlReportes.Controls.Add(this.tabVendedores);
            this.tabControlReportes.Location = new System.Drawing.Point(20, 90);
            this.tabControlReportes.Name = "tabControlReportes";
            this.tabControlReportes.SelectedIndex = 0;
            this.tabControlReportes.Size = new System.Drawing.Size(780, 380);
            this.tabControlReportes.TabIndex = 7;
            // 
            // tabGeo
            // 
            this.tabGeo.Controls.Add(this.dgvGeo);
            this.tabGeo.Location = new System.Drawing.Point(4, 22);
            this.tabGeo.Name = "tabGeo";
            this.tabGeo.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeo.Size = new System.Drawing.Size(772, 354);
            this.tabGeo.TabIndex = 0;
            this.tabGeo.Text = "Geolocalización";
            this.tabGeo.UseVisualStyleBackColor = true;
            // 
            // dgvGeo
            // 
            this.dgvGeo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGeo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGeo.Location = new System.Drawing.Point(3, 3);
            this.dgvGeo.Name = "dgvGeo";
            this.dgvGeo.ReadOnly = true;
            this.dgvGeo.Size = new System.Drawing.Size(766, 348);
            this.dgvGeo.TabIndex = 0;
            // 
            // tabLibros
            // 
            this.tabLibros.Controls.Add(this.dgvLibros);
            this.tabLibros.Location = new System.Drawing.Point(4, 22);
            this.tabLibros.Name = "tabLibros";
            this.tabLibros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLibros.Size = new System.Drawing.Size(772, 354);
            this.tabLibros.TabIndex = 1;
            this.tabLibros.Text = "Libros";
            this.tabLibros.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibros.Location = new System.Drawing.Point(3, 3);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.Size = new System.Drawing.Size(766, 348);
            this.dgvLibros.TabIndex = 0;
            // 
            // tabVendedores
            // 
            this.tabVendedores.Controls.Add(this.dgvVendedores);
            this.tabVendedores.Location = new System.Drawing.Point(4, 22);
            this.tabVendedores.Name = "tabVendedores";
            this.tabVendedores.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendedores.Size = new System.Drawing.Size(772, 354);
            this.tabVendedores.TabIndex = 2;
            this.tabVendedores.Text = "Vendedores";
            this.tabVendedores.UseVisualStyleBackColor = true;
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVendedores.Location = new System.Drawing.Point(3, 3);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.ReadOnly = true;
            this.dgvVendedores.Size = new System.Drawing.Size(766, 348);
            this.dgvVendedores.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(720, 490);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 30);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmReportesReservasVentas
            // 
            this.ClientSize = new System.Drawing.Size(824, 530);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.tabControlReportes);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmReportesReservasVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes de Reservas y Ventas";
            this.tabControlReportes.ResumeLayout(false);
            this.tabGeo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeo)).EndInit();
            this.tabLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.tabVendedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
