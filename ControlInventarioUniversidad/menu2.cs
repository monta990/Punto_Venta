using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlInventarioUniversidad
{
    public partial class menu2 : Form
    {
        public menu2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccederBD basedatos = new AccederBD();
            basedatos.ConectaDB();
            //if (basedatos.Crear("almacen", "nombre,ubicacion,clave", "'Bodega B','Hermosillo','H1'"))
            string test = "test";
            if (basedatos.login(test, test) == false)
            {
                MessageBox.Show("Servidor Activo");
            }
            else
            {
                MessageBox.Show("Servidor Caido, " + AccederBD.Error);
            }
            basedatos.DesconectarDB();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void ayudaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }
    }
}
