
namespace proyectoprototipo
{
    partial class DatosTrabajdor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosTrabajdor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LugarResidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelEstudios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRool = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonGei = new System.Windows.Forms.RadioButton();
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.radioButtonHombre = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxResidencia = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelApellidoP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.radioButtonM = new System.Windows.Forms.RadioButton();
            this.radioButtonU = new System.Windows.Forms.RadioButton();
            this.radioButtonNMS = new System.Windows.Forms.RadioButton();
            this.radioButtonS = new System.Windows.Forms.RadioButton();
            this.radioButtonP = new System.Windows.Forms.RadioButton();
            this.radioButtonKP = new System.Windows.Forms.RadioButton();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.labelApellidoM = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textApellidoM = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellidoP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Violet;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.ApellidoM,
            this.ApellidoP,
            this.edad,
            this.FechaDeNacimiento,
            this.LugarResidencia,
            this.Genero,
            this.NivelEstudios});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.Pink;
            this.dataGridView1.Location = new System.Drawing.Point(0, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 298);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ApellidoM
            // 
            this.ApellidoM.HeaderText = "ApellidoM";
            this.ApellidoM.Name = "ApellidoM";
            this.ApellidoM.ReadOnly = true;
            // 
            // ApellidoP
            // 
            this.ApellidoP.HeaderText = "ApellidoP";
            this.ApellidoP.Name = "ApellidoP";
            this.ApellidoP.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // FechaDeNacimiento
            // 
            this.FechaDeNacimiento.HeaderText = "Fecha De Nacimiento";
            this.FechaDeNacimiento.Name = "FechaDeNacimiento";
            this.FechaDeNacimiento.ReadOnly = true;
            // 
            // LugarResidencia
            // 
            this.LugarResidencia.HeaderText = "Lugar de Residencia";
            this.LugarResidencia.Name = "LugarResidencia";
            this.LugarResidencia.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // NivelEstudios
            // 
            this.NivelEstudios.HeaderText = "Nivel de Estudios";
            this.NivelEstudios.Name = "NivelEstudios";
            this.NivelEstudios.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Plum;
            this.groupBox3.BackgroundImage = global::proyectoprototipo.Properties.Resources.cyy;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.buttonEditar);
            this.groupBox3.Controls.Add(this.labelNombre);
            this.groupBox3.Controls.Add(this.labelEdad);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBoxResidencia);
            this.groupBox3.Controls.Add(this.buttonRool);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.labelApellidoP);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.buttonEliminar);
            this.groupBox3.Controls.Add(this.textEdad);
            this.groupBox3.Controls.Add(this.buttonAgregar);
            this.groupBox3.Controls.Add(this.labelApellidoM);
            this.groupBox3.Controls.Add(this.labelFecha);
            this.groupBox3.Controls.Add(this.textApellidoM);
            this.groupBox3.Controls.Add(this.textNombre);
            this.groupBox3.Controls.Add(this.textApellidoP);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(852, 363);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos De Trabajador 1";
            // 
            // buttonRool
            // 
            this.buttonRool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRool.Location = new System.Drawing.Point(741, 171);
            this.buttonRool.Name = "buttonRool";
            this.buttonRool.Size = new System.Drawing.Size(87, 38);
            this.buttonRool.TabIndex = 40;
            this.buttonRool.Text = "Registro  2";
            this.buttonRool.UseVisualStyleBackColor = true;
            this.buttonRool.Click += new System.EventHandler(this.buttonRool_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Pink;
            this.groupBox2.Controls.Add(this.radioButtonGei);
            this.groupBox2.Controls.Add(this.radioButtonMujer);
            this.groupBox2.Controls.Add(this.radioButtonHombre);
            this.groupBox2.Location = new System.Drawing.Point(234, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 106);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Genero ";
            // 
            // radioButtonGei
            // 
            this.radioButtonGei.AutoSize = true;
            this.radioButtonGei.Location = new System.Drawing.Point(6, 67);
            this.radioButtonGei.Name = "radioButtonGei";
            this.radioButtonGei.Size = new System.Drawing.Size(88, 20);
            this.radioButtonGei.TabIndex = 18;
            this.radioButtonGei.TabStop = true;
            this.radioButtonGei.Text = "Gabo gei";
            this.radioButtonGei.UseVisualStyleBackColor = true;
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Location = new System.Drawing.Point(6, 44);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(62, 20);
            this.radioButtonMujer.TabIndex = 17;
            this.radioButtonMujer.TabStop = true;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            // 
            // radioButtonHombre
            // 
            this.radioButtonHombre.AutoSize = true;
            this.radioButtonHombre.Location = new System.Drawing.Point(6, 19);
            this.radioButtonHombre.Name = "radioButtonHombre";
            this.radioButtonHombre.Size = new System.Drawing.Size(78, 20);
            this.radioButtonHombre.TabIndex = 16;
            this.radioButtonHombre.TabStop = true;
            this.radioButtonHombre.Text = "Hombre";
            this.radioButtonHombre.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::proyectoprototipo.Properties.Resources.magnifier_1_icon_icons_com_56924;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(483, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 61);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackgroundImage = global::proyectoprototipo.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Location = new System.Drawing.Point(556, 263);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(67, 61);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackgroundImage = global::proyectoprototipo.Properties.Resources.letterx_83737;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Location = new System.Drawing.Point(409, 263);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(68, 61);
            this.buttonEliminar.TabIndex = 1;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackgroundImage = global::proyectoprototipo.Properties.Resources.addfileinterfacesymbolofpapersheetwithtextlinesandplussign_798211;
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Location = new System.Drawing.Point(327, 263);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(76, 61);
            this.buttonAgregar.TabIndex = 0;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(17, 33);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(61, 16);
            this.labelNombre.TabIndex = 26;
            this.labelNombre.Text = "Nombre";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.Location = new System.Drawing.Point(17, 171);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(42, 16);
            this.labelEdad.TabIndex = 23;
            this.labelEdad.Text = "Edad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Lugar de residencia";
            // 
            // comboBoxResidencia
            // 
            this.comboBoxResidencia.FormattingEnabled = true;
            this.comboBoxResidencia.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Coahuila",
            "Colima",
            "Chiapas",
            "Chihuahua",
            "Durango",
            "Distrito Federal",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "México",
            "Michoacán",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz",
            "Yucatán",
            "Zacatecas"});
            this.comboBoxResidencia.Location = new System.Drawing.Point(157, 260);
            this.comboBoxResidencia.Name = "comboBoxResidencia";
            this.comboBoxResidencia.Size = new System.Drawing.Size(136, 24);
            this.comboBoxResidencia.TabIndex = 31;
            this.comboBoxResidencia.MouseLeave += new System.EventHandler(this.comboBoxResidencia_MouseLeave);
            this.comboBoxResidencia.MouseHover += new System.EventHandler(this.comboBoxResidencia_MouseHover);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 23);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // labelApellidoP
            // 
            this.labelApellidoP.AutoSize = true;
            this.labelApellidoP.Location = new System.Drawing.Point(17, 125);
            this.labelApellidoP.Name = "labelApellidoP";
            this.labelApellidoP.Size = new System.Drawing.Size(117, 16);
            this.labelApellidoP.TabIndex = 24;
            this.labelApellidoP.Text = "Apellido Paterno";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.radioButtonD);
            this.groupBox1.Controls.Add(this.radioButtonM);
            this.groupBox1.Controls.Add(this.radioButtonU);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButtonNMS);
            this.groupBox1.Controls.Add(this.radioButtonS);
            this.groupBox1.Controls.Add(this.radioButtonP);
            this.groupBox1.Controls.Add(this.radioButtonKP);
            this.groupBox1.Location = new System.Drawing.Point(312, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 194);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nivel de estudios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(121, 108);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(98, 20);
            this.radioButtonD.TabIndex = 17;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "Doctorado";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            this.radioButtonM.AutoSize = true;
            this.radioButtonM.Location = new System.Drawing.Point(121, 76);
            this.radioButtonM.Name = "radioButtonM";
            this.radioButtonM.Size = new System.Drawing.Size(82, 20);
            this.radioButtonM.TabIndex = 16;
            this.radioButtonM.TabStop = true;
            this.radioButtonM.Text = "Maestria";
            this.radioButtonM.UseVisualStyleBackColor = true;
            // 
            // radioButtonU
            // 
            this.radioButtonU.AutoSize = true;
            this.radioButtonU.Location = new System.Drawing.Point(121, 44);
            this.radioButtonU.Name = "radioButtonU";
            this.radioButtonU.Size = new System.Drawing.Size(100, 20);
            this.radioButtonU.TabIndex = 15;
            this.radioButtonU.TabStop = true;
            this.radioButtonU.Text = "Universidad\r\n";
            this.radioButtonU.UseVisualStyleBackColor = true;
            // 
            // radioButtonNMS
            // 
            this.radioButtonNMS.AutoSize = true;
            this.radioButtonNMS.Location = new System.Drawing.Point(6, 134);
            this.radioButtonNMS.Name = "radioButtonNMS";
            this.radioButtonNMS.Size = new System.Drawing.Size(103, 36);
            this.radioButtonNMS.TabIndex = 14;
            this.radioButtonNMS.TabStop = true;
            this.radioButtonNMS.Text = "Nivel Media\r\nSuperior";
            this.radioButtonNMS.UseVisualStyleBackColor = true;
            // 
            // radioButtonS
            // 
            this.radioButtonS.AutoSize = true;
            this.radioButtonS.Location = new System.Drawing.Point(6, 108);
            this.radioButtonS.Name = "radioButtonS";
            this.radioButtonS.Size = new System.Drawing.Size(98, 20);
            this.radioButtonS.TabIndex = 13;
            this.radioButtonS.TabStop = true;
            this.radioButtonS.Text = "Secundaria";
            this.radioButtonS.UseVisualStyleBackColor = true;
            // 
            // radioButtonP
            // 
            this.radioButtonP.AutoSize = true;
            this.radioButtonP.Location = new System.Drawing.Point(6, 82);
            this.radioButtonP.Name = "radioButtonP";
            this.radioButtonP.Size = new System.Drawing.Size(79, 20);
            this.radioButtonP.TabIndex = 11;
            this.radioButtonP.TabStop = true;
            this.radioButtonP.Text = "Primaria";
            this.radioButtonP.UseVisualStyleBackColor = true;
            // 
            // radioButtonKP
            // 
            this.radioButtonKP.AutoSize = true;
            this.radioButtonKP.Location = new System.Drawing.Point(6, 40);
            this.radioButtonKP.Name = "radioButtonKP";
            this.radioButtonKP.Size = new System.Drawing.Size(92, 36);
            this.radioButtonKP.TabIndex = 10;
            this.radioButtonKP.TabStop = true;
            this.radioButtonKP.Text = "Kinder \r\nPreescolar\r\n";
            this.radioButtonKP.UseVisualStyleBackColor = true;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(65, 168);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(228, 23);
            this.textEdad.TabIndex = 36;
            this.textEdad.MouseLeave += new System.EventHandler(this.textEdad_MouseLeave);
            this.textEdad.MouseHover += new System.EventHandler(this.textEdad_MouseHover);
            // 
            // labelApellidoM
            // 
            this.labelApellidoM.AutoSize = true;
            this.labelApellidoM.Location = new System.Drawing.Point(17, 79);
            this.labelApellidoM.Name = "labelApellidoM";
            this.labelApellidoM.Size = new System.Drawing.Size(122, 16);
            this.labelApellidoM.TabIndex = 25;
            this.labelApellidoM.Text = "Apellido Materno";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(17, 217);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(146, 16);
            this.labelFecha.TabIndex = 28;
            this.labelFecha.Text = "Fecha de nacimiento";
            // 
            // textApellidoM
            // 
            this.textApellidoM.Location = new System.Drawing.Point(149, 76);
            this.textApellidoM.Name = "textApellidoM";
            this.textApellidoM.Size = new System.Drawing.Size(144, 23);
            this.textApellidoM.TabIndex = 35;
            this.textApellidoM.MouseLeave += new System.EventHandler(this.textApellidoM_MouseLeave);
            this.textApellidoM.MouseHover += new System.EventHandler(this.textApellidoM_MouseHover);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(84, 30);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(209, 23);
            this.textNombre.TabIndex = 33;
            this.textNombre.MouseLeave += new System.EventHandler(this.textNombre_MouseLeave);
            this.textNombre.MouseHover += new System.EventHandler(this.textNombre_MouseHover);
            // 
            // textApellidoP
            // 
            this.textApellidoP.Location = new System.Drawing.Point(149, 122);
            this.textApellidoP.Name = "textApellidoP";
            this.textApellidoP.Size = new System.Drawing.Size(144, 23);
            this.textApellidoP.TabIndex = 34;
            this.textApellidoP.MouseLeave += new System.EventHandler(this.textApellidoP_MouseLeave);
            this.textApellidoP.MouseHover += new System.EventHandler(this.textApellidoP_MouseHover);
            // 
            // DatosTrabajdor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 660);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosTrabajdor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosTrabajdor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textApellidoM;
        private System.Windows.Forms.TextBox textApellidoP;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxResidencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.RadioButton radioButtonM;
        private System.Windows.Forms.RadioButton radioButtonU;
        private System.Windows.Forms.RadioButton radioButtonNMS;
        private System.Windows.Forms.RadioButton radioButtonS;
        private System.Windows.Forms.RadioButton radioButtonP;
        private System.Windows.Forms.RadioButton radioButtonKP;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidoM;
        private System.Windows.Forms.Label labelApellidoP;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonGei;
        private System.Windows.Forms.RadioButton radioButtonMujer;
        private System.Windows.Forms.RadioButton radioButtonHombre;
        private System.Windows.Forms.Button buttonRool;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn LugarResidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelEstudios;
    }
}