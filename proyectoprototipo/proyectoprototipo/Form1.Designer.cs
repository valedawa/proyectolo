
namespace proyectoprototipo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.labelTittle = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureUsuario = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.pictureContraseña = new System.Windows.Forms.PictureBox();
            this.buttonInicioDeSesion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.checkMostrarC = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::proyectoprototipo.Properties.Resources.Diseño_sin_título__2_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(409, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 332);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCerrar.BackgroundImage = global::proyectoprototipo.Properties.Resources.Diseño_sin_título__3_;
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Location = new System.Drawing.Point(885, 0);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(50, 49);
            this.buttonCerrar.TabIndex = 1;
            this.buttonCerrar.UseVisualStyleBackColor = false;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.BackColor = System.Drawing.Color.Transparent;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.Location = new System.Drawing.Point(122, 189);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(221, 33);
            this.labelTittle.TabIndex = 2;
            this.labelTittle.Text = "Inicio de Sesion";
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.Location = new System.Drawing.Point(131, 276);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(170, 22);
            this.textUsuario.TabIndex = 3;
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            this.textUsuario.MouseLeave += new System.EventHandler(this.textUsuario_MouseLeave);
            this.textUsuario.MouseHover += new System.EventHandler(this.textUsuario_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(128, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario";
            // 
            // pictureUsuario
            // 
            this.pictureUsuario.BackgroundImage = global::proyectoprototipo.Properties.Resources.usuario;
            this.pictureUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureUsuario.Location = new System.Drawing.Point(90, 256);
            this.pictureUsuario.Name = "pictureUsuario";
            this.pictureUsuario.Size = new System.Drawing.Size(35, 33);
            this.pictureUsuario.TabIndex = 5;
            this.pictureUsuario.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(128, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña";
            // 
            // textContraseña
            // 
            this.textContraseña.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseña.Location = new System.Drawing.Point(131, 356);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.PasswordChar = '*';
            this.textContraseña.Size = new System.Drawing.Size(170, 22);
            this.textContraseña.TabIndex = 6;
            this.textContraseña.MouseLeave += new System.EventHandler(this.textContraseña_MouseLeave);
            this.textContraseña.MouseHover += new System.EventHandler(this.textContraseña_MouseHover);
            // 
            // pictureContraseña
            // 
            this.pictureContraseña.BackgroundImage = global::proyectoprototipo.Properties.Resources.contraseña;
            this.pictureContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureContraseña.Location = new System.Drawing.Point(87, 336);
            this.pictureContraseña.Name = "pictureContraseña";
            this.pictureContraseña.Size = new System.Drawing.Size(35, 33);
            this.pictureContraseña.TabIndex = 8;
            this.pictureContraseña.TabStop = false;
            // 
            // buttonInicioDeSesion
            // 
            this.buttonInicioDeSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.buttonInicioDeSesion.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.buttonInicioDeSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonInicioDeSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonInicioDeSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicioDeSesion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicioDeSesion.Location = new System.Drawing.Point(141, 412);
            this.buttonInicioDeSesion.Name = "buttonInicioDeSesion";
            this.buttonInicioDeSesion.Size = new System.Drawing.Size(156, 28);
            this.buttonInicioDeSesion.TabIndex = 9;
            this.buttonInicioDeSesion.Text = "Inicio de Sesion";
            this.buttonInicioDeSesion.UseVisualStyleBackColor = false;
            this.buttonInicioDeSesion.Click += new System.EventHandler(this.buttonInicioDeSesion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(128, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "¿No tienes cuenta?";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.White;
            this.buttonRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRegistrar.Location = new System.Drawing.Point(259, 446);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(76, 28);
            this.buttonRegistrar.TabIndex = 11;
            this.buttonRegistrar.Text = "Registrar\r\n";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkMostrarC
            // 
            this.checkMostrarC.AutoSize = true;
            this.checkMostrarC.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMostrarC.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkMostrarC.Location = new System.Drawing.Point(268, 384);
            this.checkMostrarC.Name = "checkMostrarC";
            this.checkMostrarC.Size = new System.Drawing.Size(134, 20);
            this.checkMostrarC.TabIndex = 12;
            this.checkMostrarC.Text = "Mostrar Contraseña";
            this.checkMostrarC.UseVisualStyleBackColor = true;
            this.checkMostrarC.CheckedChanged += new System.EventHandler(this.checkMostrarC_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::proyectoprototipo.Properties.Resources.imagen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 550);
            this.Controls.Add(this.checkMostrarC);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonInicioDeSesion);
            this.Controls.Add(this.pictureContraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.pictureUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.PictureBox pictureContraseña;
        private System.Windows.Forms.Button buttonInicioDeSesion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.CheckBox checkMostrarC;
    }
}

