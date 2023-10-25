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
    public partial class FormaAlmacen : Form
    {
        int n = 0;

        public FormaAlmacen()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            
            //definimos nuestro contador
            int o = 0;

            string producto = "El producto ha sido agregado correctamente";
            if (textProducto.Text == string.Empty)
            {
                producto = "Ingresa el Producto";
                o++;
            }
            else
            {
                try
                {
                    int p1 = int.Parse(textProducto.Text);
                    producto = "ingrese letras en el el Producto";
                    o++;
                }
                catch
                {

                }
            }
            ////////////////////////////////
            string codigobarras = "El Codigo de Barras ha sido agregado correctamente";
            if (textCodigoBarras.Text == string.Empty)
            {
                codigobarras = "Ingresa el codigo de barras";
                o++;
            }
            else
            {
                try
                {
                    string p2 = textCodigoBarras.Text;
                    float pp2 = float.Parse(p2);
                    if (pp2 < 0)
                    {
                        codigobarras = "El Codigo de Barras no puede ser negativo";
                        o++;
                    }
                    else if (textCodigoBarras.Text.Length != 15)
                    {
                        codigobarras = "El Codigo de Barras debe tener 15 numeros";
                        o++;
                    }
                }
                catch
                {
                    codigobarras = "Codigo de barras Incorrecto";
                    o++;

                }
            }
            /////////////numericUpDownCodigoAlmacen
            string codigoalamacen = "El Codigo de Almacen ha sido agregado correctamente";
            if (textBoxCA.Text == string.Empty)
            {
                codigoalamacen = "Ingresa el Codigo de Almacen";
                o++;
            }
            else
            {
                try
                {
                    string p3 = textBoxCA.Text;
                    int pp3 = int.Parse(p3);
                    if (pp3 < 0)
                    {
                        codigoalamacen = "El Codigo de Almacen no puede ser negativo";
                        o++;
                    }
                    else if (pp3 == 0)
                    {
                        codigoalamacen = "El Codigo de Almacen es incorrecto";
                        o++;
                    }
                    else if (pp3 > 1001)
                    {
                        codigoalamacen = "El de Almacen no debe ser mayor a 1000";
                        o++;
                    }
                }
                catch
                {
                    codigoalamacen = "El Codigo de Almacen Incorrecto";
                    o++;

                }
            }
            //////////// PRESENTACIÓN
            string presentacion = "La presentacion del Producto ha sido agregado correctamente";
            if (comboBoxPresentacion.Text == string.Empty)
            {
                presentacion = "Ingrese la presentación del prpducto";
                o++;
            }
            // CANTIDAD
            string cantidadd = "La cantidad ha sido agregado correctamente";
            if (textCantidad.Text == string.Empty)
            {
                cantidadd = "Ingresa la Cantidad del Producto";
                o++;
            }
            else
            {
                try
                {
                    string p4 = textCantidad.Text;
                    int pp4 = int.Parse(p4);
                    if (pp4 < 0)
                    {
                        cantidadd = "La Cantidad no puede ser negativa";
                        o++;
                    }
                    else if (pp4 == 0)
                    {
                        cantidadd = "La Cantidad no es valida";
                        o++;
                    }
                }
                catch
                {
                    cantidadd = "La Cantidad es Incorrecta";
                    o++;

                }
            }
            ///////////
            string areatrabajador = "El Area ha agregado correctamente";
            if (listBoxArea.Text == string.Empty)
            {
                areatrabajador = "Area de Empleado";
            }
            //////////
            string nonotaCompra = "El numero de compra ha sido agregado correctamente";
            if (textBoxnonotaCompra.Text == string.Empty)
            {
                nonotaCompra = "Ingresa el codigo de barras";
                o++;
            }
            else
            {
                try
                {
                    string p5 = textBoxnonotaCompra.Text;
                    int pp5 = int.Parse(p5);
                    if (pp5 < 0)
                    {
                        nonotaCompra = "El numero de compra no puede ser negativo";
                        o++;
                    }
                    else if (pp5 == 0)
                    {
                        nonotaCompra = "El numero de compra es incorrecto";
                        o++;
                    }
                }
                catch
                {
                    nonotaCompra = "El numero de compra Incorrecto";
                    o++;

                }
            }

            if (o != 0)
            {
                MessageBox.Show("Ingresa" + "\n" + producto + "\n" + codigobarras + "\n" + codigoalamacen + "\n" + presentacion + "\n" + cantidadd + "\n" + areatrabajador + "\n" + nonotaCompra, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int n = dataGridView1.Rows.Add();

                //////////////////////////////////////////////////////////////////
                dataGridView1.Rows[n].Cells[0].Value = textProducto.Text;
                dataGridView1.Rows[n].Cells[1].Value = textCodigoBarras.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBoxCA.Text;
                dataGridView1.Rows[n].Cells[3].Value = comboBoxPresentacion.Text;
                dataGridView1.Rows[n].Cells[4].Value = textCantidad.Text;
                dataGridView1.Rows[n].Cells[5].Value = listBoxArea.Text;
                dataGridView1.Rows[n].Cells[6].Value = dateTimePickerCaducidad.Text;
                dataGridView1.Rows[n].Cells[7].Value = textBoxnonotaCompra.Text;
                dataGridView1.Rows[n].Cells[8].Value = dateTimePickerFechaCompra.Text;

                ////////////////////////////////////////////////////////////////////
                textProducto.Text = "";
                textCodigoBarras.Text = "";
                textBoxCA.Text = "";
                comboBoxPresentacion.Text = "";
                textCantidad.Text = "";
                listBoxArea.Text = "";
                dateTimePickerCaducidad.Text = "";
                textBoxnonotaCompra.Text = "";
                dateTimePickerFechaCompra.Text = ""; 
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                 textProducto.Text = dataGridView1.CurrentRow.Cells["producto"].Value.ToString();
                 textCodigoBarras.Text = dataGridView1.CurrentRow.Cells["codigoBarras"].Value.ToString();
                 textBoxCA.Text = dataGridView1.CurrentRow.Cells["codigoAlmacen"].Value.ToString();
                 comboBoxPresentacion.Text = dataGridView1.CurrentRow.Cells["presentacion"].Value.ToString();
                 textCantidad.Text = dataGridView1.CurrentRow.Cells["cantidad"].Value.ToString();
                 listBoxArea.Text = dataGridView1.CurrentRow.Cells["area"].Value.ToString();
                 //dateTimePickerCaducidad.Text = dataGridView1.CurrentRow.Cells["caducidad"].Value.ToString();
                 textBoxnonotaCompra.Text = dataGridView1.CurrentRow.Cells["noNotaCompra"].Value.ToString();
                 //dateTimePickerFechaCompra.Text = dataGridView1.CurrentRow.Cells["fechaCompra"].Value.ToString();
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
    }
}
/*
 * textProducto.Text = "";
                textCodigoBarras.Text = "";
                textBoxCA.Text = "";
                comboBoxPresentacion.Text = "";
                textCantidad.Text = "";
                listBoxArea.Text = "";
                dateTimePickerCaducidad.Text = "";
                textBoxnonotaCompra.Text = "";
                dateTimePickerFechaCompra.Text = "";
 * comboBoxTallaZ.BackColor = Color.Plum; white
 */
