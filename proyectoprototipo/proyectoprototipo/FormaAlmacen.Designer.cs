
namespace proyectoprototipo
{
    partial class FormaAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaAlmacen));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noNotaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxCA = new System.Windows.Forms.TextBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCaducidad = new System.Windows.Forms.DateTimePicker();
            this.listBoxArea = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnonotaCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCodigoBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPresentacion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.codigoBarras,
            this.codigoAlmacen,
            this.presentacion,
            this.cantidad,
            this.area,
            this.caducidad,
            this.noNotaCompra,
            this.fechaCompra});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 198);
            this.dataGridView1.TabIndex = 12;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            // 
            // codigoBarras
            // 
            this.codigoBarras.HeaderText = "Código De Barras";
            this.codigoBarras.Name = "codigoBarras";
            this.codigoBarras.ReadOnly = true;
            // 
            // codigoAlmacen
            // 
            this.codigoAlmacen.HeaderText = "Código De Almacen";
            this.codigoAlmacen.Name = "codigoAlmacen";
            this.codigoAlmacen.ReadOnly = true;
            // 
            // presentacion
            // 
            this.presentacion.HeaderText = "Presentación";
            this.presentacion.Name = "presentacion";
            this.presentacion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // area
            // 
            this.area.HeaderText = "Area";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            // 
            // caducidad
            // 
            this.caducidad.HeaderText = "Caducidad";
            this.caducidad.Name = "caducidad";
            this.caducidad.ReadOnly = true;
            // 
            // noNotaCompra
            // 
            this.noNotaCompra.HeaderText = "Número de Nota de Compra";
            this.noNotaCompra.Name = "noNotaCompra";
            this.noNotaCompra.ReadOnly = true;
            // 
            // fechaCompra
            // 
            this.fechaCompra.HeaderText = "Fecha de Compra";
            this.fechaCompra.Name = "fechaCompra";
            this.fechaCompra.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::proyectoprototipo.Properties.Resources.descarga__4_;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.textBoxCA);
            this.groupBox1.Controls.Add(this.buttonModificar);
            this.groupBox1.Controls.Add(this.textCantidad);
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaCompra);
            this.groupBox1.Controls.Add(this.dateTimePickerCaducidad);
            this.groupBox1.Controls.Add(this.listBoxArea);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textProducto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxnonotaCompra);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textCodigoBarras);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxPresentacion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 344);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Almacen";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackgroundImage = global::proyectoprototipo.Properties.Resources.magnifier_1_icon_icons_com_56924;
            this.buttonBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBuscar.Location = new System.Drawing.Point(864, 261);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(67, 59);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBoxCA
            // 
            this.textBoxCA.Location = new System.Drawing.Point(191, 127);
            this.textBoxCA.Name = "textBoxCA";
            this.textBoxCA.Size = new System.Drawing.Size(178, 27);
            this.textBoxCA.TabIndex = 47;
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackgroundImage = global::proyectoprototipo.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.buttonModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModificar.Location = new System.Drawing.Point(645, 265);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(67, 58);
            this.buttonModificar.TabIndex = 2;
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(191, 215);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(178, 27);
            this.textCantidad.TabIndex = 46;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = global::proyectoprototipo.Properties.Resources.letterx_83737;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminar.Location = new System.Drawing.Point(718, 264);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(67, 59);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(16, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "Cantidad";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackgroundImage = global::proyectoprototipo.Properties.Resources.addfileinterfacesymbolofpapersheetwithtextlinesandplussign_79821;
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgregar.Location = new System.Drawing.Point(791, 261);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(67, 59);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dateTimePickerFechaCompra
            // 
            this.dateTimePickerFechaCompra.Location = new System.Drawing.Point(613, 130);
            this.dateTimePickerFechaCompra.Name = "dateTimePickerFechaCompra";
            this.dateTimePickerFechaCompra.Size = new System.Drawing.Size(291, 27);
            this.dateTimePickerFechaCompra.TabIndex = 44;
            // 
            // dateTimePickerCaducidad
            // 
            this.dateTimePickerCaducidad.Location = new System.Drawing.Point(573, 36);
            this.dateTimePickerCaducidad.Name = "dateTimePickerCaducidad";
            this.dateTimePickerCaducidad.Size = new System.Drawing.Size(331, 27);
            this.dateTimePickerCaducidad.TabIndex = 43;
            // 
            // listBoxArea
            // 
            this.listBoxArea.FormattingEnabled = true;
            this.listBoxArea.ItemHeight = 19;
            this.listBoxArea.Items.AddRange(new object[] {
            "Pasillo ",
            "Perecedores",
            "Camara Fría"});
            this.listBoxArea.Location = new System.Drawing.Point(191, 259);
            this.listBoxArea.Name = "listBoxArea";
            this.listBoxArea.Size = new System.Drawing.Size(114, 23);
            this.listBoxArea.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(16, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Producto\r\n";
            // 
            // textProducto
            // 
            this.textProducto.Location = new System.Drawing.Point(191, 39);
            this.textProducto.Name = "textProducto";
            this.textProducto.Size = new System.Drawing.Size(178, 27);
            this.textProducto.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(457, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha de compra\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(457, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "No. nota de compra\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código de Almacen";
            // 
            // textBoxnonotaCompra
            // 
            this.textBoxnonotaCompra.Location = new System.Drawing.Point(645, 83);
            this.textBoxnonotaCompra.Name = "textBoxnonotaCompra";
            this.textBoxnonotaCompra.Size = new System.Drawing.Size(259, 27);
            this.textBoxnonotaCompra.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(457, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Caducidad\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Barras\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Area";
            // 
            // textCodigoBarras
            // 
            this.textCodigoBarras.Location = new System.Drawing.Point(191, 83);
            this.textCodigoBarras.Name = "textCodigoBarras";
            this.textCodigoBarras.Size = new System.Drawing.Size(178, 27);
            this.textCodigoBarras.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Presentación";
            // 
            // comboBoxPresentacion
            // 
            this.comboBoxPresentacion.FormattingEnabled = true;
            this.comboBoxPresentacion.Items.AddRange(new object[] {
            "Kg",
            "Litros",
            "g",
            "ml"});
            this.comboBoxPresentacion.Location = new System.Drawing.Point(191, 171);
            this.comboBoxPresentacion.Name = "comboBoxPresentacion";
            this.comboBoxPresentacion.Size = new System.Drawing.Size(173, 27);
            this.comboBoxPresentacion.TabIndex = 3;
            // 
            // FormaAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 542);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormaAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaAlmacen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxnonotaCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCodigoBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPresentacion;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaCompra;
        private System.Windows.Forms.DateTimePicker dateTimePickerCaducidad;
        private System.Windows.Forms.ListBox listBoxArea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn noNotaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompra;
    }
}