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
using iTextSharp.text.pdf;
using iTextSharp;
using iTextSharp.text;
using System.IO;

namespace ControlInventarioUniversidad
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader Lector;
        string ruta = "";
        private void Productos_Load(object sender, EventArgs e)
        {
            dGvProductos.Rows.Clear();
            try
            {
                con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                con.Open();
                string query = "SELECT * FROM productos";
                com = new MySqlCommand(query, con);
                MySqlDataReader Lector = com.ExecuteReader();
                string desc = null; 
                while (Lector.Read()) //datos de la bd
                {
                        desc=(Lector.IsDBNull(3) == true ? "No existe descripción" : Lector.GetString(3)); //si no hay descripción
                        if(Lector.IsDBNull(4))
                        {
                            dGvProductos.Rows.Add(Lector.GetString(0), Lector.GetString(1), Lector.GetString(2),desc); // si esta null
                        }
                        else
                        {
                            if(File.Exists(Lector.GetString(4))) //verifica si existe imagen   
                            dGvProductos.Rows.Add(Lector.GetString(0), Lector.GetString(1), Lector.GetString(2), desc, System.Drawing.Image.FromFile(Lector.GetString(4)),Lector.GetString(4)); //carga la imagen desde el path
                            else
                            dGvProductos.Rows.Add(Lector.GetString(0), Lector.GetString(1), Lector.GetString(2), desc); // si esta null
                        }
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show("Algo salio mal"+Error);
            }
            btLimpiar_Click(sender, e); //limpiar textbox
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
            con.Open();
            ruta = ruta.Replace(@"\",@"\\");
            string query = "INSERT INTO productos (Cod_Bar,Nombre,Precio,Descripcion,Imagen) VALUES ('"+tBcodigo.Text+"','"+tBnombre.Text+"','"+tBprecio.Text+"','"+rTbDesc.Text+"','"+ruta+"');";
            MessageBox.Show("Se agrego el articulo");
            com = new MySqlCommand(query, con);
            MySqlDataReader Lector = com.ExecuteReader();
            Productos_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //mover datos a los textbox
        {
            if (e.RowIndex!=-1)
            {
                tBcodigo.Text = dGvProductos[0, e.RowIndex].Value.ToString();
                tBnombre.Text= dGvProductos[1, e.RowIndex].Value.ToString();
                tBprecio.Text = dGvProductos[2, e.RowIndex].Value.ToString();
                rTbDesc.Text= dGvProductos[3, e.RowIndex].Value.ToString();
                pBima.Image = System.Drawing.Image.FromFile(dGvProductos[5, e.RowIndex].Value.ToString());
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e); //cargar datos al dar enter o moverce en el datagrid
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tBcodigo.Focus();
            tBcodigo.Clear();
            tBnombre.Clear();
            tBprecio.Clear();
            pBima.Image = System.Drawing.Image.FromFile(@"C:\Users\monta\OneDrive\Documentos\Visual Studio 2017\Projects\Punto_Venta\ControlInventarioUniversidad\imagenes\noima.png"); //imagen default
            rTbDesc.Clear();
        }

        private void pBima_Click(object sender, EventArgs e) //cargar imagen a picturebox
        {
            openFileImaPic.Title = "Seleccione la imagen de producto"; //titulo del cuadro de dialogo
            openFileImaPic.FileName = ""; //nombre de archivo default
            openFileImaPic.Filter = "Imagenes (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif"; //extenciones soportadas
            openFileImaPic.ShowDialog(); //lanza cuadro de dialogo abrir
            ruta = openFileImaPic.FileName; //obtiene la ruta
            if (File.Exists(ruta)) //verificar si existe la imagen
            {
                pBima.Image = System.Drawing.Image.FromFile(ruta); //ruta de imagen cargada
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Estas seguro de eliminar el producto?", "Eliminar", MessageBoxButtons.YesNo); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                con.Open();

                ruta = ruta.Replace(@"\", @"\\");
                string query = "DELETE FROM productos WHERE Cod_Bar = '" + tBcodigo.Text + "'";
                MessageBox.Show("Se elimino el articulo");
                com = new MySqlCommand(query, con);
                MySqlDataReader Lector = com.ExecuteReader();
                Productos_Load(sender, e);
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a al ventana anterior
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
            con.Open();
            ruta = ruta.Replace(@"\", @"\\");
            string query = "UPDATE productos SET Nombre = '" + tBnombre.Text + "', Precio = '" + tBprecio.Text + "', Descripcion = '" + rTbDesc.Text + "', Imagen = '" + ruta + "' WHERE Cod_Bar = '" + tBcodigo.Text + "'";
            MessageBox.Show("Articulo Actulizado");
            com = new MySqlCommand(query, con);
            MySqlDataReader Lector = com.ExecuteReader();
            Productos_Load(sender, e);
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            string path=@"C:\respint\backup.sql";
            using (StreamWriter Swbackup= File.CreateText(path));
            for (int i = 0; i < dGvProductos.Rows.Count; i++)
            {

            }
        }

        private void btPdf_Click(object sender, EventArgs e)
        {
            Document pdf = new Document(PageSize.LEGAL.Rotate());
            try
            {
                PdfWriter.GetInstance(pdf, new FileStream("productos.pdf", FileMode.Create));
                pdf.Open();
                //inicio de la generación del pdf
                PdfPTable Tabla = new PdfPTable(5); //cantidad de columnas PDF
                PdfPCell Titulo = new PdfPCell(new Phrase("Reporte de Productos"));
                Titulo.HorizontalAlignment = 1; //1 para centrar
                Titulo.Colspan = 5;
                Tabla.AddCell(Titulo); //header pdf
                Tabla.AddCell("Codigo"); //titulo columna
                Tabla.AddCell("Nombre");
                Tabla.AddCell("Descripción");
                Tabla.AddCell("Precio");
                Tabla.AddCell("Imagen");
                for (int i = 0; i < dGvProductos.Rows.Count; i++) //leer datagrid
                {
                    Tabla.AddCell(dGvProductos[0, i].Value.ToString()); //codigo
                    Tabla.AddCell(dGvProductos[1, i].Value.ToString()); //nombre
                    Tabla.AddCell(dGvProductos[2, i].Value.ToString()); //Descripción
                    Tabla.AddCell(dGvProductos[3, i].Value.ToString()); //Precio
                    Tabla.AddCell(new PdfPCell(iTextSharp.text.Image.GetInstance(@"D:\miller64.png"))); //ima
                }
                pdf.Add(Tabla);
                //fin del pdf
                pdf.Close();
            }
            catch (DocumentException PDFerror)
            {

            }
            catch (IOException IOerror)
            {

            }
            System.Diagnostics.Process.Start("productos.pdf");
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog File = new SaveFileDialog();
            File.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
            if (File.ShowDialog() == DialogResult.OK)
            {
                //Microsoft.Office.Interop.Excel.Application app; //selecciona la app
                //Microsoft.Office.Interop.Excel.Workbook libro; //genera libro para excel
                //Microsoft.Office.Interop.Excel.Worksheet hoja; //genera la hoja del libro
                //app = new Microsoft.Office.Interop.Excel.Application();
                //libro = app.Workbooks.Add();
                //libro.SaveAs(File.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                //libro.Close(true);
                //app.Quit();
                Microsoft.Office.Interop.Excel.Application app; //selecciona la app
                Microsoft.Office.Interop.Excel.Workbook libro; //genera libro para excel
                Microsoft.Office.Interop.Excel.Worksheet hoja; //genera la hoja del libro
                app = new Microsoft.Office.Interop.Excel.Application();
                libro = app.Workbooks.Add();
                hoja = (Microsoft.Office.Interop.Excel.Worksheet)libro.Worksheets[1];
                Microsoft.Office.Interop.Excel.Range Rango;
                for (int i = 1; i <= dGvProductos.Columns.Count; i++)
                {
                    hoja.Cells[1, i] = dGvProductos.Columns[i - 1].HeaderText.ToString();
                    Rango = hoja.Cells[1, i];
                    Rango.Font.Bold = true;
                    Rango.Font.Name = "Comics Sans";
                    //Rango.Font.Size = 18;
                    Rango.Interior.Color = Color.Gray;
                }
                for (int i = 0; i < dGvProductos.Rows.Count; i++)
                {
                    for (int j = 0; j < dGvProductos.Columns.Count; j++)
                    {
                        hoja.Cells[2 + i, j + 1] = dGvProductos[j, i].Value.ToString();
                    }
                }
                libro.SaveAs(File.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
                libro.Close(true);
                app.Quit();
            }
        }
    }
}