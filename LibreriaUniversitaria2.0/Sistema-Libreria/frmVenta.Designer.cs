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
            this.lblmenuVentas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibrosVenta
            // 
            this.dgvLibrosVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrosVenta.Location = new System.Drawing.Point(69, 118);
            this.dgvLibrosVenta.Name = "dgvLibrosVenta";
            this.dgvLibrosVenta.RowHeadersWidth = 51;
            this.dgvLibrosVenta.RowTemplate.Height = 24;
            this.dgvLibrosVenta.Size = new System.Drawing.Size(651, 137);
            this.dgvLibrosVenta.TabIndex = 0;
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLibro.ForeColor = System.Drawing.Color.White;
            this.btnAgregarLibro.Location = new System.Drawing.Point(211, 275);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(101, 56);
            this.btnAgregarLibro.TabIndex = 1;
            this.btnAgregarLibro.Text = "Agregar Libros";
            this.btnAgregarLibro.UseVisualStyleBackColor = false;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // btnFinaliarVenta
            // 
            this.btnFinaliarVenta.BackColor = System.Drawing.Color.ForestGreen;
            this.btnFinaliarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinaliarVenta.ForeColor = System.Drawing.Color.White;
            this.btnFinaliarVenta.Location = new System.Drawing.Point(455, 275);
            this.btnFinaliarVenta.Name = "btnFinaliarVenta";
            this.btnFinaliarVenta.Size = new System.Drawing.Size(101, 56);
            this.btnFinaliarVenta.TabIndex = 2;
            this.btnFinaliarVenta.Text = "Finalizar Venta";
            this.btnFinaliarVenta.UseVisualStyleBackColor = false;
            this.btnFinaliarVenta.Click += new System.EventHandler(this.btnFinaliarVenta_Click);
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(69, 72);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(157, 24);
            this.cboClientes.TabIndex = 3;
            // 
            // lblmenuVentas
            // 
            this.lblmenuVentas.AutoSize = true;
            this.lblmenuVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenuVentas.Location = new System.Drawing.Point(304, 26);
            this.lblmenuVentas.Name = "lblmenuVentas";
            this.lblmenuVentas.Size = new System.Drawing.Size(187, 25);
            this.lblmenuVentas.TabIndex = 4;
            this.lblmenuVentas.Text = "Modulo de Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cliente:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(676, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancelar Venta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmenuVentas);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.btnFinaliarVenta);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.dgvLibrosVenta);
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibrosVenta;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnFinaliarVenta;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label lblmenuVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}