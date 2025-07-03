namespace LibreriaUniversitaria.UI
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusquedacliente = new System.Windows.Forms.TextBox();
            this.cbobuscarusuario = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgtablaclientes = new System.Windows.Forms.DataGridView();
            this.Idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colapellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvlistalibro = new System.Windows.Forms.DataGridView();
            this.tboxbusquedalibro = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnguardarreserva = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxlibro = new System.Windows.Forms.ComboBox();
            this.colidlibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colautor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablaclientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistalibro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.Silver;
            this.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.SearchMinus;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 16;
            this.btnbuscar.Location = new System.Drawing.Point(669, 104);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(35, 23);
            this.btnbuscar.TabIndex = 49;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtbusquedacliente
            // 
            this.txtbusquedacliente.Location = new System.Drawing.Point(517, 108);
            this.txtbusquedacliente.Name = "txtbusquedacliente";
            this.txtbusquedacliente.Size = new System.Drawing.Size(134, 20);
            this.txtbusquedacliente.TabIndex = 48;
            // 
            // cbobuscarusuario
            // 
            this.cbobuscarusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobuscarusuario.FormattingEnabled = true;
            this.cbobuscarusuario.Location = new System.Drawing.Point(381, 108);
            this.cbobuscarusuario.Name = "cbobuscarusuario";
            this.cbobuscarusuario.Size = new System.Drawing.Size(126, 21);
            this.cbobuscarusuario.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(311, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Buscar por: ";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(215, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(549, 66);
            this.label9.TabIndex = 44;
            this.label9.Text = "Datos del Cliente";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dtgtablaclientes
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgtablaclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgtablaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtablaclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idcliente,
            this.Documento,
            this.Colnombre,
            this.colapellido,
            this.Correo,
            this.ColSeleccion});
            this.dtgtablaclientes.Location = new System.Drawing.Point(215, 144);
            this.dtgtablaclientes.MultiSelect = false;
            this.dtgtablaclientes.Name = "dtgtablaclientes";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgtablaclientes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgtablaclientes.RowTemplate.Height = 28;
            this.dtgtablaclientes.RowTemplate.ReadOnly = true;
            this.dtgtablaclientes.Size = new System.Drawing.Size(549, 129);
            this.dtgtablaclientes.TabIndex = 43;
            // 
            // Idcliente
            // 
            this.Idcliente.HeaderText = "IdCliente";
            this.Idcliente.Name = "Idcliente";
            this.Idcliente.Visible = false;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Nro documento";
            this.Documento.Name = "Documento";
            // 
            // Colnombre
            // 
            this.Colnombre.HeaderText = "Nombre ";
            this.Colnombre.Name = "Colnombre";
            // 
            // colapellido
            // 
            this.colapellido.HeaderText = "Apellido";
            this.colapellido.Name = "colapellido";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // ColSeleccion
            // 
            this.ColSeleccion.HeaderText = "Seleccionar";
            this.ColSeleccion.Name = "ColSeleccion";
            this.ColSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btneliminar
            // 
            this.btneliminar.AutoSize = true;
            this.btneliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btneliminar.IconSize = 15;
            this.btneliminar.Location = new System.Drawing.Point(887, 567);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(79, 37);
            this.btneliminar.TabIndex = 41;
            this.btneliminar.Text = "Eliminar todo";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 16;
            this.btnguardar.Location = new System.Drawing.Point(725, 567);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 37);
            this.btnguardar.TabIndex = 39;
            this.btnguardar.Text = "Guardar Venta";
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Silver;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.IconSize = 16;
            this.btnlimpiar.Location = new System.Drawing.Point(717, 104);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(35, 23);
            this.btnlimpiar.TabIndex = 50;
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(390, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "Carga de ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(520, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Buscar por: ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(944, 66);
            this.label3.TabIndex = 53;
            this.label3.Text = "Datos del Libro";
            // 
            // dgvlistalibro
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvlistalibro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvlistalibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistalibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colidlibro,
            this.isbn,
            this.coltitulo,
            this.colautor,
            this.preciounitario,
            this.editorial,
            this.estado,
            this.categoria,
            this.stock,
            this.seleccionar});
            this.dgvlistalibro.Location = new System.Drawing.Point(26, 379);
            this.dgvlistalibro.MultiSelect = false;
            this.dgvlistalibro.Name = "dgvlistalibro";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvlistalibro.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvlistalibro.RowTemplate.Height = 28;
            this.dgvlistalibro.RowTemplate.ReadOnly = true;
            this.dgvlistalibro.Size = new System.Drawing.Size(944, 129);
            this.dgvlistalibro.TabIndex = 52;
            // 
            // tboxbusquedalibro
            // 
            this.tboxbusquedalibro.Location = new System.Drawing.Point(726, 339);
            this.tboxbusquedalibro.Name = "tboxbusquedalibro";
            this.tboxbusquedalibro.Size = new System.Drawing.Size(134, 20);
            this.tboxbusquedalibro.TabIndex = 56;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Silver;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SearchMinus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(882, 336);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(35, 23);
            this.iconButton1.TabIndex = 57;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Silver;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 16;
            this.iconButton2.Location = new System.Drawing.Point(926, 336);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 23);
            this.iconButton2.TabIndex = 58;
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnguardarreserva
            // 
            this.btnguardarreserva.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnguardarreserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarreserva.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardarreserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarreserva.ForeColor = System.Drawing.Color.White;
            this.btnguardarreserva.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardarreserva.IconColor = System.Drawing.Color.White;
            this.btnguardarreserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardarreserva.IconSize = 16;
            this.btnguardarreserva.Location = new System.Drawing.Point(806, 567);
            this.btnguardarreserva.Name = "btnguardarreserva";
            this.btnguardarreserva.Size = new System.Drawing.Size(75, 37);
            this.btnguardarreserva.TabIndex = 59;
            this.btnguardarreserva.Text = "Guardar Reserva";
            this.btnguardarreserva.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Subtotal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(104, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "soy el subtotal";
            // 
            // cboxlibro
            // 
            this.cboxlibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxlibro.FormattingEnabled = true;
            this.cboxlibro.Location = new System.Drawing.Point(590, 339);
            this.cboxlibro.Name = "cboxlibro";
            this.cboxlibro.Size = new System.Drawing.Size(126, 21);
            this.cboxlibro.TabIndex = 55;
            // 
            // colidlibro
            // 
            this.colidlibro.HeaderText = "Idlibro";
            this.colidlibro.Name = "colidlibro";
            this.colidlibro.Visible = false;
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            // 
            // coltitulo
            // 
            this.coltitulo.HeaderText = "Titulo";
            this.coltitulo.Name = "coltitulo";
            // 
            // colautor
            // 
            this.colautor.HeaderText = "Autor";
            this.colautor.Name = "colautor";
            // 
            // preciounitario
            // 
            this.preciounitario.HeaderText = "Precio unitario";
            this.preciounitario.Name = "preciounitario";
            // 
            // editorial
            // 
            this.editorial.HeaderText = "Editorial";
            this.editorial.Name = "editorial";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            // 
            // seleccionar
            // 
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1009, 627);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnguardarreserva);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.tboxbusquedalibro);
            this.Controls.Add(this.cboxlibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvlistalibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusquedacliente);
            this.Controls.Add(this.cbobuscarusuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtgtablaclientes);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmVentas";
            this.Text = "Gestión de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablaclientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistalibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusquedacliente;
        private System.Windows.Forms.ComboBox cbobuscarusuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgtablaclientes;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvlistalibro;
        private System.Windows.Forms.TextBox tboxbusquedalibro;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colapellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeleccion;
        private FontAwesome.Sharp.IconButton btnguardarreserva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboxlibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidlibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colautor;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionar;
    }
}