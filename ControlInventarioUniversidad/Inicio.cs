using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using MySql.Data.MySqlClient;

namespace ControlInventarioUniversidad
{
    public partial class Inicio : Form
    {
        public static string nombre, ApellidoP, ApellidoM;
        //public static string user, pass;
        public Inicio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Ejemplo utilizando paradigma de programación orientada a objetos
            if (tBusuario.Text.Trim() == "" || tBpass.Text.Trim() == "") //verifica que no este vacio
            {
                MessageBox.Show("Error el usuario o contrasena estan en blanco");
                if (tBusuario.Text.Trim() == "") //vemos cual esta vacio y mandamos el focus al lugar vacio
                {
                    tBusuario.Focus();
                }
                else
                {
                    tBpass.Focus();
                }
            }
            else
            {
                MySqlConnection con = new MySqlConnection("server=127.0.0.1;uid=root;pwd=alvarez;database=integradora");
                con.Open();
                string query = "SELECT * FROM usuarios WHERE id_usuario='" + tBusuario.Text + "' AND pass_usuario='" + tBpass.Text + "'";
                MySqlCommand com = new MySqlCommand(query, con);
                MySqlDataReader lector = com.ExecuteReader();
                if (!lector.HasRows)
                {
                    MessageBox.Show("El usuario o contraseña estan mal", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    while (lector.Read())
                    {
                        nombre = lector.GetString(3);
                        ApellidoP = lector.GetString(4);
                        ApellidoM = lector.GetString(5);
                        if (lector.GetString(0) == "0")
                        {
                            new menu0().ShowDialog();
                        }
                        if (lector.GetString(0) == "1")
                        {
                            new menu1().ShowDialog();
                        }
                    }
                    tBusuario.Clear();
                    tBpass.Clear();
                    tBusuario.Focus();
                }
                con.Close();
                //user = tBusuario.Text;
                //pass = tBpass.Text;
                //AccederBD basedatos = new AccederBD();
                //if (basedatos.login(tBusuario.Text, tBpass.Text) == true) //verifica estado de acceso para el error
                //{
                //    //nada
                //}
                //else
                //{
                //    MessageBox.Show("Error: " + AccederBD.Error2); //especifica el error
                //    MessageBox.Show("Error: " + AccederBD.Error); //especifica el error
                //}
                //basedatos.DesconectarDB();
            }
        }

        private void button2_Click(object sender, EventArgs e) //boton salir
        {
            DialogResult dialog = MessageBox.Show("Quieres salir del sistema", "Cerrar el programa", MessageBoxButtons.YesNo); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a al ventana anterior
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.lbVer.Text = String.Format("Versión {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }
    }
}