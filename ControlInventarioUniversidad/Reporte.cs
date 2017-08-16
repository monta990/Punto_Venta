using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ControlInventarioUniversidad
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader Lector;
        private void Reporte_Load(object sender, EventArgs e)
        {
            {
                string path = "Reporte.html"; //nombre de archivo
                File.Delete(path); //Borra si el archivo existe
                using (StreamWriter swbackup = File.CreateText(path)) //crear archivo en el directorio actual
                {
                    swbackup.WriteLine("<html><head>");
                    //swbackup.WriteLine("<style>table {border - collapse: collapse;}table, td, th {border: 1px solid black;}</style>");
                    swbackup.WriteLine("</head><body>");
                    swbackup.WriteLine("<center><h1>Reporte de Ventas</h1></center>");
                    swbackup.WriteLine("<table border='1' cellspacing='0'>");
                    swbackup.WriteLine("<tr><th>ID de Venta</th><th>Fecha Venta</th><th>Total Venta</th></tr>");
                        con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");
                        con.Open();
                        string query = "SELECT id_venta, Fecha_venta, sum(total) from ventas inner join venta_detalle using (id_venta) group by id_venta order by id_venta";
                        com = new MySqlCommand(query, con);
                        Lector = com.ExecuteReader();
                    while (Lector.Read()) //datos de la bd
                    {
                        swbackup.WriteLine("<tr><td>" + Lector.GetString(0) + "</td><td>" + Lector.GetString(1) + "</td><td>" + Lector.GetString(2) + "</td></tr>");
                    }
                    con.Close();
                    swbackup.WriteLine("</table>");
                    swbackup.WriteLine("<center><h4>Ctrl + P para imprimir</h4></center>");
                    swbackup.WriteLine("</body></html>");
                }
                webBrowser1.Url=new Uri( Directory.GetCurrentDirectory()+"/"+path); //carga el archivo creado en el webbrowser
            }
        }
    }
}