﻿using System;
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
            this.labelversion.Text= String.Format("Version {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            this.lbfecha.Text = DateTime.Today.ToShortDateString()+ " " +DateTime.Now.ToLongTimeString();
        }
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader Lector;
        public float total = 0;
        public void gentotal()
        {
            float total = 0;
            for (int i = 0; i < dVCaja.RowCount; i++)
            {
                total += float.Parse(dVCaja[3,i].Value.ToString());
                lbTotalFinal.Text = total.ToString();
            }
            lbTotalFinal.Text = total.ToString();
        }
        public void CerrarVenta()  //esta incompleto
        {
            //MessageBox.Show("Label Total: "+lbTotalFinal.Text);
            //MessageBox.Show("Ingreso: "+TBcaja.Text);
            //lbTotalFinal.Text = lbTotalFinal.Text.Substring(6,6);
            
            if (float.Parse(lbTotalFinal.Text) >= total)
            {
                MessageBox.Show("Su cambio es: " + (float.Parse(TBcaja.Text) - float.Parse(lbTotalFinal.Text)));
                con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                con.Open();
                string query = "INSERT INTO ventas VALUES (null, curdate(), curtime())";
                com = new MySqlCommand(query, con);
                MySqlDataReader Lector = com.ExecuteReader();
                con.Close();
                foreach (DataGridViewRow R in dVCaja.Rows)
                {
                    //con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                    //con.Open();
                    //string query = "INSERT INTO venta_detalle VALUES (select max(id_venta) from ventas, '" R.Cells[1].ToString;
                    //com = new MySqlCommand(query, con);
                    //MySqlDataReader Lector = com.ExecuteReader();
                    //con.Close();
                }
                lbTotalFinal.Text = "0.00";
                TBcaja.Clear();
                TBcaja.Focus();
            }
        }
        public void Imprimir()
        {
            try
            {
                Ticket tiquetcito = new Ticket();
                tiquetcito.AddHeaderLine("Don Baraton S.A de C.V");
                tiquetcito.HeaderImage = Image.FromFile(@"D:\imga.bmp");
                tiquetcito.AddSubHeaderLine(DateTime.Now.ToShortDateString().ToString());
                tiquetcito.AddSubHeaderLine(DateTime.Now.ToShortTimeString().ToString());

                foreach (DataGridViewRow R in dVCaja.Rows)
                {
                    tiquetcito.AddItem(R.Cells[0].Value.ToString(), R.Cells[1].Value.ToString(), R.Cells[2].Value.ToString());
                }
                tiquetcito.AddTotal("Total: ", lbTotalFinal.Text);
                tiquetcito.AddFooterLine("Gracias por su compra");
                tiquetcito.PrintTicket("EC-PM-5890X");
            }
            catch (Exception)
            {
                MessageBox.Show("No sabes conectar una impresora? Solo soluciono por ti a $2500");
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
                    if (TBcaja.Text.IndexOf('*') != -1)
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
                    else
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