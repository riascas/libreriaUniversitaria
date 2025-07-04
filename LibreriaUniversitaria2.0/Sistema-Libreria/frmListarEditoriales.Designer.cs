namespace Sistema_Libreria
{
    partial class frmListarEditoriales
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
            this.dgvEditoriales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditoriales
            // 
            this.dgvEditoriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditoriales.Location = new System.Drawing.Point(12, 42);
            this.dgvEditoriales.Name = "dgvEditoriales";
            this.dgvEditoriales.RowHeadersWidth = 51;
            this.dgvEditoriales.RowTemplate.Height = 24;
            this.dgvEditoriales.Size = new System.Drawing.Size(1170, 455);
            this.dgvEditoriales.TabIndex = 0;
            // 
            // frmListarEditoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 517);
            this.Controls.Add(this.dgvEditoriales);
            this.Name = "frmListarEditoriales";
            this.Text = "frmListarEditoriales";
            this.Load += new System.EventHandler(this.frmListarEditoriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditoriales;
    }
}