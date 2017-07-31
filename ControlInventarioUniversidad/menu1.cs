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
    public partial class menu1 : Form
    {
        public menu1()
        {
            InitializeComponent();
            lbTiempo.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
            lbBienvenido.Text = "Bienvenido " + Inicio.nombre + " " + Inicio.ApellidoP + " " + Inicio.ApellidoM;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Quieres salir del menu?", "Cerrar el menu", MessageBoxButtons.YesNo); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a al ventana anterior
            }
        }

        private void button1_Click(object sender, EventArgs e) //verifica servidor
        {
            AccederBD basedatos = new AccederBD();
            basedatos.ConectaDB();
            string test = "test";
            if (basedatos.login(test, test) == false)
            {
                MessageBox.Show("Servidor Activo");
            }
            else
            {
                MessageBox.Show("Servidor Caido");
            }
            basedatos.DesconectarDB();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void ayudaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Caja().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTiempo.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }
    }
}