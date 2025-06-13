using System;
using System.Windows.Forms;
using FontAwesome.Sharp;  // tener instalado FontAwesome.Sharp desde NuGet

namespace LibreriaUniversitaria.UI
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.BtnIngresar = new FontAwesome.Sharp.IconButton();
            this.BtnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();

            // label1 (panel azul)
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 220);

            // label2 (titulo)
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 160);
            this.label2.Text = "VENTA DE LIBROS";

            // iconPictureBox1
            this.iconPictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 100;
            this.iconPictureBox1.Location = new System.Drawing.Point(50, 40);
            this.iconPictureBox1.Size = new System.Drawing.Size(100, 100);

            // label3 (documento)
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 35);
            this.label3.Text = "Nro de documento";

            // txtDocumento
            this.txtDocumento.Location = new System.Drawing.Point(223, 50);
            this.txtDocumento.Size = new System.Drawing.Size(200, 20);

            // label4 (clave)
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 85);
            this.label4.Text = "Contraseña";

            // txtClave
            this.txtClave.Location = new System.Drawing.Point(223, 100);
            this.txtClave.Size = new System.Drawing.Size(200, 20);
            this.txtClave.PasswordChar = '*';

            // BtnIngresar
            this.BtnIngresar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.BtnIngresar.IconColor = System.Drawing.Color.White;
            this.BtnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnIngresar.IconSize = 20;
            this.BtnIngresar.Location = new System.Drawing.Point(223, 145);
            this.BtnIngresar.Size = new System.Drawing.Size(90, 35);
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);

            // BtnCancelar
            this.BtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.BtnCancelar.IconColor = System.Drawing.Color.White;
            this.BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCancelar.IconSize = 20;
            this.BtnCancelar.Location = new System.Drawing.Point(333, 145);
            this.BtnCancelar.Size = new System.Drawing.Size(90, 35);
            this.BtnCancelar.Text = "Salir";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);

            // FrmLogin
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 220);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Librería Universitaria";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtClave;
        private FontAwesome.Sharp.IconButton BtnIngresar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
    }
}