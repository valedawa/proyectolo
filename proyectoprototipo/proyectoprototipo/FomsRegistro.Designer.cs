
namespace proyectoprototipo
{
    partial class FomsRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FomsRegistro));
            this.labelTittle = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonR = new System.Windows.Forms.Button();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkMostrarC = new System.Windows.Forms.CheckBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.BackColor = System.Drawing.Color.Transparent;
            this.labelTittle.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTittle.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.labelTittle.Location = new System.Drawing.Point(154, 20);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(417, 44);
            this.labelTittle.TabIndex = 0;
            this.labelTittle.Text = "Registro De Usuarios";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUsuario.Location = new System.Drawing.Point(62, 109);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(164, 24);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Crea tu Usuario";
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textUsuario.Location = new System.Drawing.Point(274, 106);
            this.textUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(164, 27);
            this.textUsuario.TabIndex = 18;
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            this.textUsuario.MouseLeave += new System.EventHandler(this.textUsuario_MouseLeave);
            this.textUsuario.MouseHover += new System.EventHandler(this.textUsuario_MouseHover);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(-147, 463);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(96, 21);
            this.textBox6.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(62, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Crea tu Contraseña";
            // 
            // buttonR
            // 
            this.buttonR.BackColor = System.Drawing.Color.Thistle;
            this.buttonR.Location = new System.Drawing.Point(533, 187);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(93, 33);
            this.buttonR.TabIndex = 23;
            this.buttonR.Text = "Registrar";
            this.buttonR.UseVisualStyleBackColor = false;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // textContraseña
            // 
            this.textContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContraseña.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textContraseña.Location = new System.Drawing.Point(274, 150);
            this.textContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.PasswordChar = '*';
            this.textContraseña.Size = new System.Drawing.Size(164, 27);
            this.textContraseña.TabIndex = 24;
            this.textContraseña.MouseLeave += new System.EventHandler(this.textContraseña_MouseLeave);
            this.textContraseña.MouseHover += new System.EventHandler(this.textContraseña_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Thistle;
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkMostrarC
            // 
            this.checkMostrarC.AutoSize = true;
            this.checkMostrarC.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMostrarC.ForeColor = System.Drawing.Color.DarkBlue;
            this.checkMostrarC.Location = new System.Drawing.Point(437, 241);
            this.checkMostrarC.Name = "checkMostrarC";
            this.checkMostrarC.Size = new System.Drawing.Size(134, 20);
            this.checkMostrarC.TabIndex = 26;
            this.checkMostrarC.Text = "Mostrar Contraseña";
            this.checkMostrarC.UseVisualStyleBackColor = true;
            this.checkMostrarC.CheckedChanged += new System.EventHandler(this.checkMostrarC_CheckedChanged);
            // 
            // textCorreo
            // 
            this.textCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textCorreo.Location = new System.Drawing.Point(274, 196);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(164, 27);
            this.textCorreo.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(62, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Correo Electronico";
            // 
            // FomsRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::proyectoprototipo.Properties.Resources.descarga__6_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 300);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkMostrarC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelTittle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FomsRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FomsRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkMostrarC;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.Label label2;
    }
}