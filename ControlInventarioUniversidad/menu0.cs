using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControlInventarioUniversidad
{
    public partial class menu0 : Form
    {
        AccederBD basedatos = new AccederBD();
        public menu0()
        {
            InitializeComponent();
            lbTiempo.Text = DateTime.Now.ToLongTimeString()+" "+DateTime.Now.ToLongDateString();
            MySqlConnection con = new MySqlConnection("server=127.0.0.1;uid=root;pwd=alvarez;database=integradora");
            con.Open();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            basedatos.ConectaDB();
            //if (basedatos.Crear("almacen", "nombre,ubicacion,clave", "'Bodega B','Hermosillo','H1'"))
            string test="test";
            if (basedatos.login(test, test) == false)
            {
                MessageBox.Show("Servidor Activo");
            }
            else
            {
                MessageBox.Show("Servidor Caido, "+AccederBD.Error);
            }
            basedatos.DesconectarDB();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }

        private void ayudaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTiempo.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString();
        }

        private void usuariosYNivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Usuarios().ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Productos().ShowDialog();
        }

        private void menu0_Load(object sender, EventArgs e)
        {
            lbBienvenido.Text="Bienvenido " + Inicio.nombre + " " + Inicio.ApellidoP + " " + Inicio.ApellidoM;
        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Reporte().ShowDialog();
        }
    }
}