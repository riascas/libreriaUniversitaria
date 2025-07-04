namespace LibreriaUniversitaria.UI
{
    partial class frmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusquedacliente = new System.Windows.Forms.TextBox();
            this.cbobuscarcliente = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.dtgtablaclientes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxestudiante = new System.Windows.Forms.CheckBox();
            this.limpiar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.cboxmunicipio = new System.Windows.Forms.ComboBox();
            this.cboxlocalidad = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidocliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnicliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estudiantecliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablaclientes)).BeginInit();
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
            this.btnbuscar.Location = new System.Drawing.Point(1349, 62);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 32);
            this.btnbuscar.TabIndex = 49;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // txtbusquedacliente
            // 
            this.txtbusquedacliente.Location = new System.Drawing.Point(1199, 66);
            this.txtbusquedacliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbusquedacliente.Name = "txtbusquedacliente";
            this.txtbusquedacliente.Size = new System.Drawing.Size(139, 22);
            this.txtbusquedacliente.TabIndex = 48;
            // 
            // cbobuscarcliente
            // 
            this.cbobuscarcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbobuscarcliente.FormattingEnabled = true;
            this.cbobuscarcliente.Location = new System.Drawing.Point(1029, 66);
            this.cbobuscarcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbobuscarcliente.Name = "cbobuscarcliente";
            this.cbobuscarcliente.Size = new System.Drawing.Size(148, 24);
            this.cbobuscarcliente.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(944, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "Buscar por: ";
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(41, 321);
            this.txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(231, 22);
            this.txtbox.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(357, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1149, 74);
            this.label9.TabIndex = 44;
            this.label9.Text = "Lista de Clientes:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Silver;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.IconSize = 18;
            this.btnlimpiar.Location = new System.Drawing.Point(1161, 64);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(48, 32);
            this.btnlimpiar.TabIndex = 50;
            this.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // dtgtablaclientes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgtablaclientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgtablaclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtablaclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.nombrecliente,
            this.apellidocliente,
            this.dnicliente,
            this.emailcliente,
            this.calle,
            this.Altura,
            this.localidad,
            this.municipio,
            this.estudiantecliente});
            this.dtgtablaclientes.Location = new System.Drawing.Point(357, 117);
            this.dtgtablaclientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgtablaclientes.MultiSelect = false;
            this.dtgtablaclientes.Name = "dtgtablaclientes";
            this.dtgtablaclientes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgtablaclientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgtablaclientes.RowTemplate.Height = 28;
            this.dtgtablaclientes.RowTemplate.ReadOnly = true;
            this.dtgtablaclientes.Size = new System.Drawing.Size(1149, 134);
            this.dtgtablaclientes.TabIndex = 43;
            this.dtgtablaclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgtablaclientes_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(20, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 29);
            this.label8.TabIndex = 42;
            this.label8.Text = "Detalle Clientes";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 17;
            this.btneliminar.Location = new System.Drawing.Point(40, 625);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(232, 28);
            this.btneliminar.TabIndex = 41;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btneditar.IconColor = System.Drawing.Color.White;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.IconSize = 16;
            this.btneditar.Location = new System.Drawing.Point(40, 573);
            this.btneditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(232, 28);
            this.btneditar.TabIndex = 40;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 16;
            this.btnguardar.Location = new System.Drawing.Point(40, 523);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(232, 28);
            this.btnguardar.TabIndex = 39;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 464);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Es estudiante:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(41, 229);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(231, 22);
            this.txtemail.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Email:";
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(41, 183);
            this.txtdni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(231, 22);
            this.txtdni.TabIndex = 32;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(41, 137);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(231, 22);
            this.txtapellido.TabIndex = 31;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(41, 86);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(231, 22);
            this.txtnombre.TabIndex = 30;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.BackColor = System.Drawing.Color.White;
            this.DNI.Location = new System.Drawing.Point(38, 163);
            this.DNI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(33, 16);
            this.DNI.TabIndex = 29;
            this.DNI.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 677);
            this.label1.TabIndex = 26;
            // 
            // cboxestudiante
            // 
            this.cboxestudiante.AutoSize = true;
            this.cboxestudiante.Location = new System.Drawing.Point(158, 463);
            this.cboxestudiante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxestudiante.Name = "cboxestudiante";
            this.cboxestudiante.Size = new System.Drawing.Size(18, 17);
            this.cboxestudiante.TabIndex = 51;
            this.cboxestudiante.UseVisualStyleBackColor = true;
            // 
            // limpiar
            // 
            this.limpiar.BackColor = System.Drawing.Color.Silver;
            this.limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.limpiar.Enabled = false;
            this.limpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.limpiar.ForeColor = System.Drawing.Color.Black;
            this.limpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.limpiar.IconColor = System.Drawing.Color.Black;
            this.limpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.limpiar.IconSize = 18;
            this.limpiar.Location = new System.Drawing.Point(1408, 62);
            this.limpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(49, 32);
            this.limpiar.TabIndex = 52;
            this.limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.limpiar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 395);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Municipio:";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem2.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem2.Text = "iconMenuItem2";
            // 
            // cboxmunicipio
            // 
            this.cboxmunicipio.FormattingEnabled = true;
            this.cboxmunicipio.Location = new System.Drawing.Point(41, 415);
            this.cboxmunicipio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxmunicipio.Name = "cboxmunicipio";
            this.cboxmunicipio.Size = new System.Drawing.Size(231, 24);
            this.cboxmunicipio.TabIndex = 55;
            // 
            // cboxlocalidad
            // 
            this.cboxlocalidad.FormattingEnabled = true;
            this.cboxlocalidad.Location = new System.Drawing.Point(41, 367);
            this.cboxlocalidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxlocalidad.Name = "cboxlocalidad";
            this.cboxlocalidad.Size = new System.Drawing.Size(231, 24);
            this.cboxlocalidad.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 347);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Localidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(38, 255);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 58;
            this.label11.Text = "Calle:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 275);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 22);
            this.textBox1.TabIndex = 59;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(38, 301);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 60;
            this.label12.Text = "Altura:";
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Idcliente";
            this.IdCliente.MinimumWidth = 6;
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Visible = false;
            this.IdCliente.Width = 125;
            // 
            // nombrecliente
            // 
            this.nombrecliente.HeaderText = "Nombre";
            this.nombrecliente.MinimumWidth = 6;
            this.nombrecliente.Name = "nombrecliente";
            this.nombrecliente.Width = 125;
            // 
            // apellidocliente
            // 
            this.apellidocliente.HeaderText = "Apellido";
            this.apellidocliente.MinimumWidth = 6;
            this.apellidocliente.Name = "apellidocliente";
            this.apellidocliente.Width = 125;
            // 
            // dnicliente
            // 
            this.dnicliente.HeaderText = "DNI";
            this.dnicliente.MinimumWidth = 6;
            this.dnicliente.Name = "dnicliente";
            this.dnicliente.Width = 125;
            // 
            // emailcliente
            // 
            this.emailcliente.HeaderText = "Email";
            this.emailcliente.MinimumWidth = 6;
            this.emailcliente.Name = "emailcliente";
            this.emailcliente.Width = 125;
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.MinimumWidth = 6;
            this.calle.Name = "calle";
            this.calle.Width = 125;
            // 
            // Altura
            // 
            this.Altura.HeaderText = "Altura";
            this.Altura.MinimumWidth = 6;
            this.Altura.Name = "Altura";
            this.Altura.Width = 125;
            // 
            // localidad
            // 
            this.localidad.HeaderText = "Localidad";
            this.localidad.MinimumWidth = 6;
            this.localidad.Name = "localidad";
            this.localidad.Width = 125;
            // 
            // municipio
            // 
            this.municipio.HeaderText = "Municipio";
            this.municipio.MinimumWidth = 6;
            this.municipio.Name = "municipio";
            this.municipio.Width = 125;
            // 
            // estudiantecliente
            // 
            this.estudiantecliente.HeaderText = "Estudiante";
            this.estudiantecliente.MinimumWidth = 6;
            this.estudiantecliente.Name = "estudiantecliente";
            this.estudiantecliente.Width = 125;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1519, 677);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboxlocalidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboxmunicipio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.cboxestudiante);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusquedacliente);
            this.Controls.Add(this.cbobuscarcliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.dtgtablaclientes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClientes";
            this.Text = "Gestión de clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgtablaclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusquedacliente;
        private System.Windows.Forms.ComboBox cbobuscarcliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.DataGridView dtgtablaclientes;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cboxestudiante;
        private FontAwesome.Sharp.IconButton limpiar;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private System.Windows.Forms.ComboBox cboxmunicipio;
        private System.Windows.Forms.ComboBox cboxlocalidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidocliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnicliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Altura;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estudiantecliente;
    }
}