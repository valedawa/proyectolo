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
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelAlmacen.Visible = false;
           panelTrabajadores.Visible = false;

        }
        private void hideSubmenu()
        {
            if (panelTrabajadores.Visible == true)
                panelTrabajadores.Visible = false;
            if (panelAlmacen.Visible == true)
                panelAlmacen.Visible = false;

        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void buttonRegistroTrabajador_Click(object sender, EventArgs e)
        {
            showSubmenu(panelTrabajadores);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DatosTrabajdor trabajdor = new DatosTrabajdor();
            trabajdor.Show();
            hideSubmenu();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void buttonRegistroAlmacen_Click(object sender, EventArgs e)
        {
            showSubmenu(panelAlmacen);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            FormaAlmacen al = new FormaAlmacen();
            al.Show();
            hideSubmenu();
        }
    }
    // showSubmenu(panelMediaSubmenu); en botones fuera
    //hideSubmenu(); botones dentro

}
