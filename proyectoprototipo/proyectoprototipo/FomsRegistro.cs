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
    public partial class FomsRegistro : Form
    {
        public FomsRegistro()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void checkMostrarC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrarC.Checked)
            {
                textContraseña.PasswordChar = '\0'; // Mostrar el texto de la contraseña
            }
            else
            {
                textContraseña.PasswordChar = '*';  // Ocultar la contraseña
            }
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

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
            textUsuario.BackColor = Color.Plum;
        }

        private void textContraseña_MouseLeave(object sender, EventArgs e)
        {
            textUsuario.BackColor = Color.White;
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == string.Empty)
            {
                if (textContraseña.Text == string.Empty)
                {
                    MessageBox.Show("Debes ingresar el usuario contraseña y correo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else 
                {
                    MessageBox.Show("Debes ingresar tu usuario y correo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textCorreo.Text == string.Empty)
            {
                if (textContraseña.Text == string.Empty)
                {
                    MessageBox.Show("La contraseña y el correo no deben estar vacios", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Debes ingresar el correo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (textContraseña.Text == string.Empty)
                {
                    MessageBox.Show("La contraseña no puede estar vacia","Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("TE HAZ REGISTRADO CORRECTAMENTE" + "\n"+ "Prueba Ingresar al Sistema","Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form = new Form1();
                    form.Show();
                }
            }
        }
    }
}
