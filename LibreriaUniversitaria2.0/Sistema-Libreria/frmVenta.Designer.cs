namespace Sistema_Libreria
{
    partial class frmVenta
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
            this.dgvLibrosVenta = new System.Windows.Forms.DataGridView();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnFinaliarVenta = new System.Windows.Forms.Button();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibrosVenta
            // 
            this.dgvLibrosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrosVenta.Location = new System.Drawing.Point(69, 85);
            this.dgvLibrosVenta.Name = "dgvLibrosVenta";
            this.dgvLibrosVenta.RowHeadersWidth = 51;
            this.dgvLibrosVenta.RowTemplate.Height = 24;
            this.dgvLibrosVenta.Size = new System.Drawing.Size(651, 137);
            this.dgvLibrosVenta.TabIndex = 0;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Location = new System.Drawing.Point(183, 275);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(101, 56);
            this.btnAgregarLibro.TabIndex = 1;
            this.btnAgregarLibro.Text = "Agregar Libros";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // btnFinaliarVenta
            // 
            this.btnFinaliarVenta.Location = new System.Drawing.Point(455, 275);
            this.btnFinaliarVenta.Name = "btnFinaliarVenta";
            this.btnFinaliarVenta.Size = new System.Drawing.Size(101, 56);
            this.btnFinaliarVenta.TabIndex = 2;
            this.btnFinaliarVenta.Text = "Finalizar Venta";
            this.btnFinaliarVenta.UseVisualStyleBackColor = true;
            this.btnFinaliarVenta.Click += new System.EventHandler(this.btnFinaliarVenta_Click);
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(69, 28);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(157, 24);
            this.cboClientes.TabIndex = 3;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.btnFinaliarVenta);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.dgvLibrosVenta);
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibrosVenta;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnFinaliarVenta;
        private System.Windows.Forms.ComboBox cboClientes;
    }
}