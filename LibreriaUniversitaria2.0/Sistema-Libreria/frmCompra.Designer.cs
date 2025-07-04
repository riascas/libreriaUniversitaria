namespace Sistema_Libreria
{
    partial class frmCompra
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
            this.cboEditorial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLibrosCompra = new System.Windows.Forms.DataGridView();
            this.btnAddLibro = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEditorial
            // 
            this.cboEditorial.FormattingEnabled = true;
            this.cboEditorial.Location = new System.Drawing.Point(52, 47);
            this.cboEditorial.Name = "cboEditorial";
            this.cboEditorial.Size = new System.Drawing.Size(121, 24);
            this.cboEditorial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editorial:";
            // 
            // dgvLibrosCompra
            // 
            this.dgvLibrosCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrosCompra.Location = new System.Drawing.Point(52, 89);
            this.dgvLibrosCompra.Name = "dgvLibrosCompra";
            this.dgvLibrosCompra.RowHeadersWidth = 51;
            this.dgvLibrosCompra.RowTemplate.Height = 24;
            this.dgvLibrosCompra.Size = new System.Drawing.Size(655, 103);
            this.dgvLibrosCompra.TabIndex = 2;
            this.dgvLibrosCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibrosCompra_CellContentClick);
            // 
            // btnAddLibro
            // 
            this.btnAddLibro.Location = new System.Drawing.Point(593, 214);
            this.btnAddLibro.Name = "btnAddLibro";
            this.btnAddLibro.Size = new System.Drawing.Size(123, 42);
            this.btnAddLibro.TabIndex = 3;
            this.btnAddLibro.Text = "Agregar Libro";
            this.btnAddLibro.UseVisualStyleBackColor = true;
            this.btnAddLibro.Click += new System.EventHandler(this.btnAddLibro_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Location = new System.Drawing.Point(593, 262);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(123, 44);
            this.btnFinalizarCompra.TabIndex = 4;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // frmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnAddLibro);
            this.Controls.Add(this.dgvLibrosCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEditorial);
            this.Name = "frmCompra";
            this.Text = "frmCompra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboEditorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLibrosCompra;
        private System.Windows.Forms.Button btnAddLibro;
        private System.Windows.Forms.Button btnFinalizarCompra;
    }
}