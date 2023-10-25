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
    public partial class DatosTrabajador2 : Form
    {
        private int n = 0;
        public DatosTrabajador2()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            int o = 0;
            ///////////////definimos las variables utilizados
            string noTrabajador = "ha sido agregado correctamente el numero de trabajador";
            string noCompleto = "ha sido agregado correctamente el nombre";
            string Area = "ha sido agregado correctamente su Area de Trabajo";
            string tallaZapato = "ha sido agregado correctamente su Talla de Zapato";
            string talla = "ha sido agregado correctamente su Talla ";
            string corrreoelectronico = "ha sido agregado correctamente su correo Electronico ";
            string curp = "ha sido agregado correctamente su CURP ";
            string noTelefonico = "ha sido agregado correctamente su Número de Telefono ";
            /////////////////////////////////////////////////
            if (textCorreoE.Text == string.Empty)
            {
                corrreoelectronico = "Ingresa tu Nombre";
                o++;
            }
            if (textBoxCURP.Text == string.Empty)
            {
                curp = "Ingresa tu Curp";
                o++;
            }
            else if (textBoxCURP.Text.Length != 18)
            {
                curp = "Ingresa tu CURP con 18 caracteres";
                o++;
            }

            ////////////COMBO BOX
            if (comboBoxArea.Text == string.Empty)
            {
                Area = "Ingrese su Area de Trabajo";
                o++;
            }
            if (comboBoxTallaZ.Text == string.Empty)
            {
                tallaZapato = "Ingrese su Talla de zapato";
                o++;
            }
            if (comboBoxT.Text == string.Empty)
            {
                talla = "Ingrese su Talla";
                o++;
            }
            if (textNoTrabajor.Text == string.Empty)
            {
                noTrabajador = "Ingresa Numero de trabajador";
                o++;
            }
            else
            {
                try
                {
                    string p1 = textNoTrabajor.Text;
                    int pp1 = int.Parse(p1);
                    if (pp1 < 0)
                    {
                        noTrabajador = "Numero de trabajador no debe ser negativa";
                        o++;
                    }
                    else if (pp1 == 0)
                    {
                        noTrabajador = "Numero de trabajador incorrecto";
                        o++;
                    }
                }
                catch
                {
                    noTrabajador = "Número de Trabajador Incorrecto";
                    o++;
                }
            }
            if (textNoTelefonico.Text == string.Empty)
            {
                noTelefonico = "Ingresa tu Número Telefonico";
                o++;
            }
            else
            {
                try
                {
                    string p3 = textNoTrabajor.Text;
                    int pp3 = int.Parse(p3);
                    if (pp3 < 0)
                    {
                        noTelefonico = "Numero de telefono no debe ser negativo";
                        o++;
                    }
                    else if (pp3 == 0)
                    {
                        noTelefonico = "Numero de telefono incorrecto";
                        o++;
                    }
                    else if (textNoTelefonico.Text.Length != 10)
                    {
                        curp = "Ingresa tu Telefono con 10 caracteres";
                        o++;
                    }
                }
                catch
                {
                    noTelefonico = "Número de telefono Incorrecto";
                    o++;

                }
            }

            ///
            if (textNombreCompleto.Text == string.Empty)
            {
                noCompleto = "Ingresa tu Nombre";
                o++;
            }
            else
            {
                try
                {
                    int p2 = int.Parse(textNombreCompleto.Text);
                    noCompleto = "IngresE letras en su Nombre";
                    o++;
                }
                catch
                {
                    o++;
                }
            }

            if (o != 0)
            {

                MessageBox.Show("Ingresa" + "\n" + noTrabajador + "\n" + noCompleto + "\n" + Area + "\n" + tallaZapato + "\n" + talla + "\n" + corrreoelectronico + "\n" + curp + "\n" + noTelefonico, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                /// comprobar los datos
                //////////////////////////////////////////////////////////////////
                int n = dataGridView1.Rows.Add();

                //////////////////////////////////////////////////////////////////
                dataGridView1.Rows[n].Cells[0].Value = textNoTrabajor.Text;
                dataGridView1.Rows[n].Cells[1].Value = textNombreCompleto.Text;
                dataGridView1.Rows[n].Cells[2].Value = comboBoxArea.Text;
                dataGridView1.Rows[n].Cells[3].Value = comboBoxTallaZ.Text;
                dataGridView1.Rows[n].Cells[4].Value = comboBoxT.Text;
                dataGridView1.Rows[n].Cells[5].Value = textCorreoE.Text;
                dataGridView1.Rows[n].Cells[6].Value = textBoxCURP.Text;
                dataGridView1.Rows[n].Cells[7].Value = textNoTelefonico.Text;

                ////////////////////////////////////////////////////////////////////
                textNoTrabajor.Text = "";
                textNombreCompleto.Text = "";
                comboBoxArea.Text = "";
                comboBoxTallaZ.Text = "";
                comboBoxT.Text = "";
                textCorreoE.Text = "";
                textBoxCURP.Text = "";
                textNoTelefonico.Text = "";
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
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglón", "Modificando Datos del trabajador",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textNoTrabajor.Text = dataGridView1.CurrentRow.Cells["noTrabajador"].Value.ToString();
                textNombreCompleto.Text = dataGridView1.CurrentRow.Cells["nombreCompleto"].Value.ToString();
                comboBoxArea.Text = dataGridView1.CurrentRow.Cells["areadeempleo"].Value.ToString();
                comboBoxTallaZ.Text = dataGridView1.CurrentRow.Cells["tallaZapato"].Value.ToString();
                comboBoxT.Text = dataGridView1.CurrentRow.Cells["talla"].Value.ToString();
                textCorreoE.Text = dataGridView1.CurrentRow.Cells["correoelectronico"].Value.ToString();
                textBoxCURP.Text = dataGridView1.CurrentRow.Cells["curp"].Value.ToString();
                textNoTelefonico.Text = dataGridView1.CurrentRow.Cells["notelefono"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textNoTrabajor_MouseHover(object sender, EventArgs e)
        {
            textNoTrabajor.BackColor = Color.Plum;

        }

        private void textNoTrabajor_MouseLeave(object sender, EventArgs e)
        {
            textNoTrabajor.BackColor = Color.White;
        }

        private void textNombreCompleto_MouseHover(object sender, EventArgs e)
        {
            textNombreCompleto.BackColor = Color.Plum;
        }

        private void textNombreCompleto_MouseLeave(object sender, EventArgs e)
        {
            textNombreCompleto.BackColor = Color.White;
        }

        private void comboBoxArea_MouseHover(object sender, EventArgs e)
        {
            comboBoxArea.BackColor = Color.Plum;
        }

        private void comboBoxArea_MouseLeave(object sender, EventArgs e)
        {
            comboBoxArea.BackColor = Color.White;
        }

        private void comboBoxTallaZ_MouseHover(object sender, EventArgs e)
        {
            comboBoxTallaZ.BackColor = Color.Plum;
        }

        private void comboBoxTallaZ_MouseLeave(object sender, EventArgs e)
        {
            comboBoxTallaZ.BackColor = Color.White;
        }

        private void comboBoxT_MouseHover(object sender, EventArgs e)
        {
            comboBoxT.BackColor = Color.Plum;
        }

        private void comboBoxT_MouseLeave(object sender, EventArgs e)
        {
            comboBoxT.BackColor = Color.White;
        }

        private void textCorreoE_MouseHover(object sender, EventArgs e)
        {
            textCorreoE.BackColor = Color.Plum;
        }

        private void textCorreoE_MouseLeave(object sender, EventArgs e)
        {
            textCorreoE.BackColor = Color.White;
        }

        private void textBoxCURP_MouseHover(object sender, EventArgs e)
        {
            textBoxCURP.BackColor = Color.Plum;
        }

        private void textBoxCURP_MouseLeave(object sender, EventArgs e)
        {
            textBoxCURP.BackColor = Color.White;
        }

        private void textNoTelefonico_MouseHover(object sender, EventArgs e)
        {
            textNoTelefonico.BackColor = Color.Plum;
        }

        private void textNoTelefonico_MouseLeave(object sender, EventArgs e)
        {
            textNoTelefonico.BackColor = Color.White;
        }
    }
}
/*
 * textNoTrabajor.Text = "";
                textNombreCompleto.Text = "";
                comboBoxArea.Text = "";
                comboBoxTallaZ.Text = "";
                comboBoxT.Text = "";
                textCorreoE.Text = "";
                textBoxCURP.Text = "";
                textNoTelefonico.Text = "";
 */