using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoprototipo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FomsRegistro registro = new FomsRegistro();
            registro.Show();
        }

        private void buttonInicioDeSesion_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == string.Empty)
            {
                if (textContraseña.Text == string.Empty)
                {
                    MessageBox.Show("El usuario o contraseña son incorrectos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("El usuario o Correo electronico es incorrecto","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (textContraseña.Text == string.Empty)
                {
                    MessageBox.Show("La contraseña es incorrecta", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("HAZ INGRESADO CORRECTAMENTE", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormaHome home = new FormaHome();
                    home.Show();
                }
            }
            
        }

        private void checkMostrarC_CheckedChanged(object sender, EventArgs e)
        {
            // Verificar si el CheckBox está marcado
            if (checkMostrarC.Checked)
            {
                textContraseña.PasswordChar = '\0'; // Mostrar el texto de la contraseña
            }
            else
            {
                textContraseña.PasswordChar = '*';  // Ocultar la contraseña
            }
        }

        private void textUsuario_MouseHover(object sender, EventArgs e)
        {
            textUsuario.BackColor = Color.Plum;
        }

        private void textUsuario_MouseLeave(object sender, EventArgs e)
        {
            textUsuario.BackColor = Color.White;
        }

        private void textContraseña_MouseHover(object sender, EventArgs e)
        {
            textContraseña.BackColor = Color.Plum;
        }

        private void textContraseña_MouseLeave(object sender, EventArgs e)
        {
            textContraseña.BackColor = Color.White;
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
/*
 * if (textBox1.Text == string.Empty)
            {
                if(textBox3.Text == string.Empty)
                {
                    MessageBox.Show("El usuario o email y contraseña son incorrectos");
                }
                else
                {
                    MessageBox.Show("El usuario o email es incorrecto");
                }
            }
            else
            {
                if (textBox3.Text == string.Empty)
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }
                else
                {
                    
                    Form2 f2 = new Form2();
                    f2.Show();
                    Hide();
                }
  */