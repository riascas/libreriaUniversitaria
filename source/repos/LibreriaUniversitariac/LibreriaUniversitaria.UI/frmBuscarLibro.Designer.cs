using System.Windows.Forms;

namespace LibreriaUniversitaria.UI
{
    partial class frmBuscarLibro
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitulo;
        private ComboBox cmbCriterio;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvLibros;
        private Button btnSeleccionar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new Label();
            this.cmbCriterio = new ComboBox();
            this.txtBuscar = new TextBox();
            this.btnBuscar = new Button();
            this.dgvLibros = new DataGridView();
            this.btnSeleccionar = new Button();
            this.btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblTitulo.Text = "📚 Búsqueda de Libros";
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCriterio.Location = new System.Drawing.Point(20, 60);
            this.cmbCriterio.Size = new System.Drawing.Size(120, 23);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(150, 60);
            this.txtBuscar.Size = new System.Drawing.Size(200, 23);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(360, 60);
            this.btnBuscar.Size = new System.Drawing.Size(80, 23);
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.Location = new System.Drawing.Point(20, 100);
            this.dgvLibros.Size = new System.Drawing.Size(760, 380);
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellDoubleClick);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnSeleccionar.Location = new System.Drawing.Point(20, 500);
            this.btnSeleccionar.Size = new System.Drawing.Size(100, 30);
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(130, 500);
            this.btnCancelar.Size = new System.Drawing.Size(100, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmBuscarLibro
            // 
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cmbCriterio);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "frmBuscarLibro";
            this.Text = "Buscar Libro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
