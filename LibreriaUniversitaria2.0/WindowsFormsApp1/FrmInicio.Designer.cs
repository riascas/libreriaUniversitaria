namespace LibreriaUniversitaria.UI
{
    partial class FrmInicio
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBienvenida;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si se deben eliminar los recursos administrados; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.Location = new System.Drawing.Point(30, 30);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(200, 28);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido/a:";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
