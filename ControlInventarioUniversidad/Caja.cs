using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using LibPrintTicket;

namespace ControlInventarioUniversidad
{

    public partial class Caja : Form
    {

        public Caja()
        {
            InitializeComponent();
            this.labelversion.Text= String.Format("Version {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());  //carga versión
            this.lbfecha.Text = DateTime.Today.ToShortDateString()+ " " +DateTime.Now.ToLongTimeString(); // muestra fecha de timer
        }
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader Lector;
        public float total = 0; //variable para guardar total
        public float cambio; //variable para cambio , se llama en el modulo de impresión
        public void gentotal() //calcula el total
        {
            float total = 0;
            for (int i = 0; i < dVCaja.RowCount; i++) //conteo del precio de cada articulo
            {
                total += float.Parse(dVCaja[3,i].Value.ToString()); //suma cada articulo a total
                lbTotalFinal.Text = total.ToString(); //label de total a variable
            }
            lbTotalFinal.Text = total.ToString();
        }
        public void CerrarVenta()  //cierra venta, manda a imprimir ticket y guarda log en base de datos
        {
            //inicio de mensajes de diaganostico
            //MessageBox.Show("Label Total: "+lbTotalFinal.Text); 
            //MessageBox.Show("Ingreso: "+TBcaja.Text);
            //lbTotalFinal.Text = lbTotalFinal.Text.Substring(6,6);
            //fin de mensajea de diagnostico
            
            if (float.Parse(lbTotalFinal.Text) >= total) //carga los datos en el log de ventas en BD
            {
                cambio = float.Parse(lbTotalFinal.Text) - total;
                MessageBox.Show("Su cambio es: " + (float.Parse(TBcaja.Text) - float.Parse(lbTotalFinal.Text)));
                //Guardar en BD
                con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                con.Open();
                string query = "INSERT INTO ventas VALUES (null, curdate(), curtime())";
                com = new MySqlCommand(query, con);
                MySqlDataReader Lector = com.ExecuteReader();
                con.Close();
                foreach (DataGridViewRow R in dVCaja.Rows)
                {
                    con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");
                    con.Open();
                    query = "INSERT INTO venta_detalle VALUES ((select max(id_venta) FROM ventas),'" + R.Cells[1].Value.ToString() + "', " + R.Cells[3].Value.ToString() + ");";
                    com = new MySqlCommand(query, con);
                    com.ExecuteNonQuery();
                    con.Close();
                }
                Imprimir(); // llama imprimir
                lbTotalFinal.Text = "0.00"; //reinicioa label de total a 0
                dVCaja.Rows.Clear();
                TBcaja.SelectAll();
                TBcaja.Clear();
                TBcaja.Focus();
            }
        }
        public void Imprimir() //genera el ticket
        {
            try
            {
                Ticket tiquetcito = new Ticket(); //inicio de ticket
                tiquetcito.AddHeaderLine("Don Baraton S.A de C.V"); //encabezado
                tiquetcito.HeaderImage = Image.FromFile(@"D:\imga.bmp"); //imagen de inicio de ticket
                tiquetcito.AddSubHeaderLine(DateTime.Now.ToShortDateString().ToString()); //muestra fecha
                tiquetcito.AddSubHeaderLine(DateTime.Now.ToShortTimeString().ToString()); //muestra hora

                foreach (DataGridViewRow R in dVCaja.Rows) //se imprimen los productos
                {
                    tiquetcito.AddItem(R.Cells[0].Value.ToString(), R.Cells[1].Value.ToString(), R.Cells[2].Value.ToString());
                }
                tiquetcito.AddTotal("Total: ", lbTotalFinal.Text); //impresión de total
                tiquetcito.AddTotal("Cambio: ", cambio.ToString()); //impresion del cambio
                tiquetcito.AddFooterLine("Gracias por su compra"); //leyanda de pie de ticket
                tiquetcito.PrintTicket("EC-PM-5890X"); //es necesario especificar el nombre de la impresora, tal y como esta registrada en el sistema operativo
            }
            catch (Exception)
            {
                MessageBox.Show("No sabes conectar una impresora? Solo soluciono por ti a $2500 \n facturo :)");
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lbfecha.Text = DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            //ubicaciones de los objetos
            dVCaja.Width = this.Width;
            dVCaja.Height = this.Height - 200;
            TBcaja.Width = this.Width;
            TBcaja.Location = new Point(0, this.Height - TBcaja.Height - 5); //acomodo del textbox de codigos
            lbMarca.Location = new Point(this.Width / 2 - lbMarca.Width / 2, 5);
            lbEslogan.Location = new Point(this.Width / 2 - lbEslogan.Width / 2, 60);
            lbfecha.Location = new Point(this.Width - lbfecha.Width, 5);
            labelversion.Location = new Point(this.Width - labelversion.Width, 60);
            lbLeAtiende.Text = "Le Atiende: " + Inicio.nombre + " " + Inicio.ApellidoP + " " + Inicio.ApellidoM;
            lbLeAtiende.Location = new Point(this.Width - lbLeAtiende.Width, 40);
            lbTotalFinal.Location = new Point(this.Width - lbTotalFinal.Width -80, dVCaja.Height+100);
            lbTotal.Location = new Point(this.Width - lbTotal.Width - 150, dVCaja.Height + 100);
            TBcaja.Focus();
        }

        private void TBcaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    if (TBcaja.Text.IndexOf('*') != -1) //multiplica el articulo (ejemplo 10*cosigo de barras)
                    {
                        string[] cantCodigo = TBcaja.Text.Split('*');
                        double bProducto = double.Parse(cantCodigo[1]);
                        con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                        con.Open();
                        string query = "SELECT * FROM productos WHERE Cod_Bar = '" + bProducto + "'";
                        com = new MySqlCommand(query, con);
                        MySqlDataReader Lector = com.ExecuteReader();
                        while (Lector.Read()) //datos de la bd
                        {
                            double subTotal = double.Parse(cantCodigo[0]) * Lector.GetDouble(2); //multiplicacion de cantidad por precio
                            dVCaja.Rows.Add(cantCodigo[0], Lector.GetString(1), Lector.GetDouble(2), double.Parse(subTotal.ToString())); // si esta null
                        }
                    }
                    else // si no hay multiplicación
                    {
                        con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                        con.Open();
                        string query = "SELECT * FROM productos WHERE Cod_Bar = '" + TBcaja.Text + "'";
                        com = new MySqlCommand(query, con);
                        MySqlDataReader Lector = com.ExecuteReader();
                        while (Lector.Read()) //datos de la bd
                            dVCaja.Rows.Add(1, Lector.GetString(1), Lector.GetString(2), Lector.GetString(2)); // si esta null
                    }
                    gentotal();
                    TBcaja.Clear();
                }
                catch (Exception Error)
                {
                    MessageBox.Show("Codigo de barras inexistente verificalo");
                    TBcaja.Clear();
                    TBcaja.Focus();
                }
            }
            else if (e.KeyChar == (char)Keys.Escape)  //cancelar utlimo articulo
            {
                if (dVCaja.Rows.Count > 0)
                {
                    dVCaja.Rows.RemoveAt(dVCaja.Rows.Count - 1);
                }
                gentotal();
            }
            else if (e.KeyChar == (char)Keys.Tab) //repetir ultimo articulo
            {
                if (dVCaja.Rows.Count > 0)
                {
                    dVCaja.Rows.Add(dVCaja[0, dVCaja.Rows.Count - 1].Value.ToString(), dVCaja[1, dVCaja.Rows.Count - 1].Value.ToString(), dVCaja[2, dVCaja.Rows.Count - 1].Value.ToString(), dVCaja[3, dVCaja.Rows.Count - 1].Value.ToString());
                }
                gentotal();
            }
            else if (e.KeyChar == 'x') //imprime ticket :)
            {
                Imprimir(); //llama a imprimir
                TBcaja.Focus();
                TBcaja.Clear();
            }
            else if (e.KeyChar == '.')
            {
                if (dVCaja.Rows.Count > 0)
                {
                    CerrarVenta();
                }
            }
            else if (e.KeyChar == '-') //sale de la ventana
            {
                this.Close();
            }
        }
    }
}