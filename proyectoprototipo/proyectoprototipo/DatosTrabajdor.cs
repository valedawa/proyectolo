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
    public partial class DatosTrabajdor : Form
    {
        private int n = 0;
        public DatosTrabajdor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            int n2 = 0;
            int o = 0;
            int n3 = 0;
            

            string nombre = "ha sido agregado correctamente el Nombre";
            string apellidoM = "ha sido agregado correctamente el Apellido M";
            string apellidoP = "ha sido agregado correctamente el Apellido P";
            string edad = "ha sido agregado correctamente el Edad";
            string lugarResidencia = "ha sido agregado correctamente el Nombre";
            string nivelEstudios = "ha sido agregado correctamente el Nombre";
            string generog = "ha sido agregado correctamente el Nombre";

            if (textNombre.Text == string.Empty)
            {
                nombre = "Ingresa tu Nombre";
                o++;
            }
            else
            {
                try
                {
                    int p1 = int.Parse(textNombre.Text);
                    nombre = "Ingrese letras en su Nombre";
                    o++;
                }
                catch
                {
                }
            }
            if (textApellidoM.Text == string.Empty)
            {
                apellidoM = "Ingresa tu Apellido M";
                o++;
            }
            else
            {
                try
                {
                    int p2 = int.Parse(textApellidoM.Text);
                    apellidoM = "Ingrese letras en su Apellido";
                    o++;
                }
                catch
                {
                }
            }
            if (textApellidoP.Text == string.Empty)
            {
                apellidoP = "Ingresa tu Apellido P";
                o++;
            }
            else
            {
                try
                {
                    int p3 = int.Parse(textApellidoP.Text);
                    apellidoP = "Ingrese letras en su Apellido";
                    o++;
                }
                catch
                {
                }
            }
            if (textEdad.Text == string.Empty)
            {
                edad = "Ingresa tu Edad";
                o++;
            }
            else
            {
                try
                {
                    string p4 = textEdad.Text;
                    int pp4 = int.Parse(p4);
                    if (pp4 < 0)
                    {
                        edad = "Su edad deve ser positiva";
                        o++;
                    }
                    else if (pp4 == 0)
                    {
                        edad = "Edad incorrecta";
                        o++;
                    }
                    else if (pp4 > 50)
                    {
                        edad = "El rango de edad no es valido";
                        o++;
                    }
                }
                catch
                {
                    edad = "Su edad debe ser valida";
                    o++;
                }
            }
            /////////////////////// combo box
            if (comboBoxResidencia.Text == string.Empty)
            {
                lugarResidencia = "Ingrese su lugar de residencia";
                o++;
            }
            //////////// Radio buttons
            if (radioButtonHombre.Checked || radioButtonMujer.Checked || radioButtonGei.Checked)
            {
                n3 = 1;
               
            }
            else
            {
                generog = "Ingresa tu genero no seas gabo";

            }
            if (radioButtonKP.Checked || radioButtonP.Checked || radioButtonS.Checked|| radioButtonNMS.Checked || radioButtonU.Checked|| radioButtonM.Checked || radioButtonD.Checked)
            {
                n2 = 1;
            }
            else
            {
                nivelEstudios = "Ingresa tu nivel de estudios";

            }



            if (n2 == 0 && o != 0 && n3 == 0)
            {
                MessageBox.Show("Ingresa" + "\n" + nombre + "\n" + apellidoM + "\n" + apellidoP + "\n" + edad + "\n" + lugarResidencia + "\n" + generog + "\n" + nivelEstudios, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((n2 != 0 && o != 0 && n3 == 0))
            {
                MessageBox.Show("Ingresa" + "\n" + nombre + "\n" + apellidoM + "\n" + apellidoP + "\n" + edad + "\n" + lugarResidencia + "\n" + generog + "\n" + nivelEstudios, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((n2 == 0 && o == 0 && n3 == 0))
            {
                MessageBox.Show("Ingresa" + "\n" + nombre + "\n" + apellidoM + "\n" + apellidoP + "\n" + edad + "\n" + lugarResidencia + "\n" + generog + "\n" + nivelEstudios, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((n2 == 0 && o != 0 && n3 != 0))
            {
                MessageBox.Show("Ingresa" + "\n" + nombre + "\n" + apellidoM + "\n" + apellidoP + "\n" + edad + "\n" + lugarResidencia + "\n" + generog + "\n" + nivelEstudios, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((n2 != 0 && o == 0 && n3 == 0))
            {
                MessageBox.Show("Ingresa" + "\n" + nombre + "\n" + apellidoM + "\n" + apellidoP + "\n" + edad + "\n" + lugarResidencia + "\n" + generog + "\n" + nivelEstudios, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((n2 != 0 && o != 0 && n3 != 0))
            {
                MessageBox.Show("Ingresa" + "\n" + nombre + "\n" + apellidoM + "\n" + apellidoP + "\n" + edad + "\n" + lugarResidencia + "\n" + generog + "\n" + nivelEstudios, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((n2 == 0 && o == 0 && n3 != 0))
            {
                MessageBox.Show("Ingresa" + "\n" + nombre + "\n" + apellidoM + "\n" + apellidoP + "\n" + edad + "\n" + lugarResidencia + "\n" + generog + "\n" + nivelEstudios, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((n2 != 0 && o == 0 && n3 != 0))
            {
                /// comprobar los datos
                //////////////////////////////////////////////////////////////////
                int n = dataGridView1.Rows.Add();// DE

                //////////////////////////////////////////////////////////////////
                dataGridView1.Rows[n].Cells[0].Value = textNombre.Text;
                dataGridView1.Rows[n].Cells[1].Value = textApellidoM.Text;
                dataGridView1.Rows[n].Cells[2].Value = textApellidoP.Text;
                dataGridView1.Rows[n].Cells[3].Value = textEdad.Text;
                dataGridView1.Rows[n].Cells[4].Value = dateTimePicker1.Text;
                dataGridView1.Rows[n].Cells[5].Value = comboBoxResidencia.Text;

                //limpiar los radio buttons

                if (radioButtonHombre.Checked)
                {
                    dataGridView1.Rows[n].Cells[6].Value = radioButtonHombre.Text;
                }
                else if (radioButtonMujer.Checked)
                {
                    dataGridView1.Rows[n].Cells[6].Value = radioButtonMujer.Text;
                }
                else if (radioButtonGei.Checked)
                {
                    dataGridView1.Rows[n].Cells[6].Value = radioButtonGei.Text;
                }

                /////limpiar los radio buttons

                if (radioButtonKP.Checked)
                {
                    dataGridView1.Rows[n].Cells[7].Value = radioButtonKP.Text;
                }
                else if (radioButtonP.Checked)
                {
                    dataGridView1.Rows[n].Cells[7].Value = radioButtonP.Text;
                }
                else if (radioButtonS.Checked)
                {
                    dataGridView1.Rows[n].Cells[7].Value = radioButtonS.Text;
                }
                else if (radioButtonNMS.Checked)
                {
                    dataGridView1.Rows[n].Cells[7].Value = radioButtonNMS.Text;
                }
                else if (radioButtonU.Checked)
                {
                    dataGridView1.Rows[n].Cells[7].Value = radioButtonU.Text;
                }
                else if (radioButtonM.Checked)
                {
                    dataGridView1.Rows[n].Cells[7].Value = radioButtonM.Text;
                }
                else if (radioButtonD.Checked)
                {
                    dataGridView1.Rows[n].Cells[7].Value = radioButtonD.Text;
                }

                //limpiamos los txt 
                textNombre.Text = "";
                textApellidoM.Text = "";
                textApellidoP.Text = "";
                textEdad.Text = "";
                dateTimePicker1.Text = "";
                comboBoxResidencia.Text = "";
                radioButtonHombre.Checked = false;
                radioButtonMujer.Checked = false;
                radioButtonGei.Checked = false;
                radioButtonKP.Checked = false;
                radioButtonP.Checked = false;
                radioButtonS.Checked = false;
                radioButtonNMS.Checked = false;
                radioButtonU.Checked = false;
                radioButtonM.Checked = false;
                radioButtonD.Checked = false;

            }



        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            try
            {

                if (n != -1)
                {
                    dataGridView1.Rows.RemoveAt(n);
                }
            }
            catch
            {
                MessageBox.Show("No puedes eliminar datos inexistentes", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRool_Click(object sender, EventArgs e)
        {
            DatosTrabajador2 trabajador2 = new DatosTrabajador2();
            trabajador2.Show();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglón", "Modificando Datos del trabajador",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                textApellidoM.Text = dataGridView1.CurrentRow.Cells["ApellidoM"].Value.ToString();
                textApellidoP.Text = dataGridView1.CurrentRow.Cells["ApellidoP"].Value.ToString();
                textEdad.Text = dataGridView1.CurrentRow.Cells["edad"].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["FechaDeNacimiento"].Value.ToString();
                comboBoxResidencia.Text = dataGridView1.CurrentRow.Cells["LugarResidencia"].Value.ToString();
            }

            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textNombre_MouseHover(object sender, EventArgs e)
        {
            textNombre.BackColor = Color.Plum;
        }

        private void textNombre_MouseLeave(object sender, EventArgs e)
        {
            textNombre.BackColor = Color.White;
        }

        private void textApellidoM_MouseHover(object sender, EventArgs e)
        {
            textApellidoM.BackColor = Color.Plum;
        }

        private void textApellidoM_MouseLeave(object sender, EventArgs e)
        {
            textApellidoM.BackColor = Color.White;
        }

        private void textApellidoP_MouseHover(object sender, EventArgs e)
        {
            textApellidoP.BackColor = Color.Plum;
        }

        private void textApellidoP_MouseLeave(object sender, EventArgs e)
        {
            textApellidoP.BackColor = Color.White;
        }

        private void textEdad_MouseHover(object sender, EventArgs e)
        {
            textEdad.BackColor = Color.Plum;
        }

        private void textEdad_MouseLeave(object sender, EventArgs e)
        {
            textEdad.BackColor = Color.White;
        }

        private void comboBoxResidencia_MouseHover(object sender, EventArgs e)
        {
            comboBoxResidencia.BackColor = Color.Plum;
        }

        private void comboBoxResidencia_MouseLeave(object sender, EventArgs e)
        {
            comboBoxResidencia.BackColor = Color.White;
        }
    }
}
