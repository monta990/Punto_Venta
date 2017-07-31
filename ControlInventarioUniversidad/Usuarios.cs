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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp;
using iTextSharp.text;

namespace ControlInventarioUniversidad
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader Lector;
        string ruta = "";
        string ima = @"C:\Users\monta\OneDrive\Documentos\Visual Studio 2017\Projects\Punto_Venta\ControlInventarioUniversidad\imagenes\noima.png";
        private void Usuarios_Load(object sender, EventArgs e)
        {
            dGvUsuarios.Rows.Clear();
            try
            {
                con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                con.Open();
                string query = "SELECT * FROM usuarios";
                com = new MySqlCommand(query, con);
                MySqlDataReader Lector = com.ExecuteReader();
                string desc = ""; 
                while (Lector.Read()) //datos de la bd
                {
                    //desc = (Lector.IsDBNull(3) == true ? "No existe descripción" : Lector.GetString(3)); //si no hay descripción
                    if (Lector.IsDBNull(7))
                    {
                        dGvUsuarios.Rows.Add(Lector.GetString(0), Lector.GetString(1), Lector.GetString(2), Lector.GetString(3), Lector.GetString(4), Lector.GetString(5), Lector.GetString(6), desc); // si esta null
                    }
                    else
                        {
                            if(File.Exists(Lector.GetString(7))) //verifica si existe imagen   
                            dGvUsuarios.Rows.Add(Lector.GetString(0), Lector.GetString(1), Lector.GetString(2), Lector.GetString(3), Lector.GetString(4), Lector.GetString(5), Lector.GetString(6), System.Drawing.Image.FromFile(Lector.GetString(7)),Lector.GetString(7)); //carga la imagen desde el path
                            else
                            dGvUsuarios.Rows.Add(Lector.GetString(0), Lector.GetString(1), Lector.GetString(2), Lector.GetString(3), Lector.GetString(4), Lector.GetString(5), Lector.GetString(6), desc); // si esta null
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
            if (ruta.Trim() == "")
            {
                ruta = @"C:\Users\monta\OneDrive\Documentos\Visual Studio 2017\Projects\Punto_Venta\ControlInventarioUniversidad\imagenes\noima.png";
            }
            else
            {
                con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                con.Open();
                ruta = ruta.Replace(@"\", @"\\");
                string query = "INSERT INTO usuarios (tipo_usuario,id_usuario,pass_usuario,NOMBRE_USUARIO,AP_USUARIO,AM_USUARIO,MAIL_USUARIO,FOTO_USUARIO) VALUES ('" + tBtipousuario.Text + "','" + tBidusuario.Text + "','" + tBpssusuario.Text + "','" + tBnombre.Text + "','" + tBapmaterno.Text + "','" + tBappaterno.Text + "','" + tBemail.Text + "','" + ruta + "');";
                MessageBox.Show("Se agrego el articulo");
                com = new MySqlCommand(query, con);
                MySqlDataReader Lector = com.ExecuteReader();
                Usuarios_Load(sender, e);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //mover datos a los textbox
        {
            if (e.RowIndex!=-1)
            {
                tBtipousuario.Text = dGvUsuarios[0, e.RowIndex].Value.ToString();
                tBidusuario.Text= dGvUsuarios[1, e.RowIndex].Value.ToString();
                tBpssusuario.Text = dGvUsuarios[2, e.RowIndex].Value.ToString();
                tBnombre.Text= dGvUsuarios[3, e.RowIndex].Value.ToString();
                tBappaterno.Text = dGvUsuarios[4, e.RowIndex].Value.ToString();
                tBapmaterno.Text = dGvUsuarios[5, e.RowIndex].Value.ToString();
                tBemail.Text = dGvUsuarios[6, e.RowIndex].Value.ToString();
                pBima.Image = System.Drawing.Image.FromFile(dGvUsuarios[8, e.RowIndex].Value.ToString());
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_CellClick(sender, e); //cargar datos al dar enter o moverce en el datagrid
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tBtipousuario.Focus();
            tBtipousuario.Clear();
            tBidusuario.Clear();
            tBpssusuario.Clear();
            tBnombre.Clear();
            tBapmaterno.Clear();
            tBappaterno.Clear();
            tBemail.Clear();
            pBima.Image = System.Drawing.Image.FromFile(@"C:\Users\monta\OneDrive\Documentos\Visual Studio 2017\Projects\Punto_Venta\ControlInventarioUniversidad\imagenes\noima.png"); //imagen default
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
            DialogResult dialog = MessageBox.Show("Estas seguro de eliminar al usuario?", "Eliminar", MessageBoxButtons.YesNo); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                con.Open();
                //ruta = ruta.Replace(@"\", @"\\");
                string query = "DELETE FROM usuarios WHERE id_usuario = '" + tBidusuario.Text + "'";
                MessageBox.Show("Se elimino el articulo");
                com = new MySqlCommand(query, con);
                MySqlDataReader Lector = com.ExecuteReader();
                Usuarios_Load(sender, e);
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a al ventana anterior
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            if (ruta.Trim() == "")
            {
                ruta = @"C:\Users\monta\OneDrive\Documentos\Visual Studio 2017\Projects\Punto_Venta\ControlInventarioUniversidad\imagenes\noima.png";
            }
            else
            {
                con = new MySqlConnection("Server = 127.0.0.1;Database=integradora;Uid=root;Pwd=alvarez");  //offline
                con.Open();
                ruta = ruta.Replace(@"\", @"\\");
                string query = "UPDATE usuarios SET tipo_usuario = '" + tBtipousuario.Text + "', id_usuario = '" + tBidusuario.Text + "', pass_usuario = '" + tBpssusuario.Text + "', NOMBRE_USUARIO = '" + tBnombre.Text + "', AP_USUARIO = '" + tBapmaterno.Text + "', AM_USUARIO = '" + tBapmaterno.Text + "', MAIL_USUARIO = '" + tBemail.Text + "', FOTO_USUARIO = '" + ruta + "' WHERE id_usuario = '" + tBidusuario.Text + "'";
                //string query = "INSERT INTO usuarios (tipo_usuario,id_usuario,pass_usuario,NOMBRE_USUARIO,AP_USUARIO,AM_USUARIO,MAIL_USUARIO,FOTO_USUARIO) VALUES ('" + tBtipousuario.Text + "','" + tBidusuario.Text + "','" + tBpssusuario.Text + "','" + tBnombre.Text + "','" + tBapmaterno.Text + "','" + tBappaterno.Text + "','" + tBemail.Text + "','" + ruta + "');";
                MessageBox.Show("Articulo Actulizado");
                com = new MySqlCommand(query, con);
                MySqlDataReader Lector = com.ExecuteReader();
                Usuarios_Load(sender, e);
            }
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            string path=@"C:\respint\backup.sql";
            using (StreamWriter Swbackup= File.CreateText(path));
            for (int i = 0; i < dGvUsuarios.Rows.Count; i++)
            {

            }
        }

        private void btPdf_Click(object sender, EventArgs e)
        {
            Document pdf = new Document(PageSize.LEGAL.Rotate());
            try
            {
                PdfWriter.GetInstance(pdf, new FileStream("usuarios.pdf", FileMode.Create));
                pdf.Open();
                //inicio de la generación del pdf
                PdfPTable Tabla = new PdfPTable(5); //cantidad de columnas PDF
                PdfPCell Titulo = new PdfPCell(new Phrase("Reporte de Usuarios"));
                Titulo.HorizontalAlignment = 1; //1 para centrar
                Titulo.Colspan = 5;
                Tabla.AddCell(Titulo); //header pdf
                Tabla.AddCell("Nivel"); //titulo columna
                Tabla.AddCell("Usuario");
                Tabla.AddCell("Nombre");
                Tabla.AddCell("Apellido Paterno");
                Tabla.AddCell("Apellido Materno");
                Tabla.AddCell("Email");
                //Tabla.AddCell("Imagen");
                for (int i = 0; i < dGvUsuarios.Rows.Count; i++) //leer datagrid
                {
                    Tabla.AddCell(dGvUsuarios[0, i].Value.ToString()); //nivel
                    Tabla.AddCell(dGvUsuarios[1, i].Value.ToString()); //usuario
                    Tabla.AddCell(dGvUsuarios[3, i].Value.ToString()); //nombre
                    Tabla.AddCell(dGvUsuarios[4, i].Value.ToString()); //ap
                    Tabla.AddCell(dGvUsuarios[5, i].Value.ToString()); //am
                    Tabla.AddCell(dGvUsuarios[6, i].Value.ToString()); //email
                    //Tabla.AddCell(new PdfPCell(iTextSharp.text.Image.GetInstance(@"D:\miller64.png"))); //ima
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
            System.Diagnostics.Process.Start("usuarios.pdf");
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
                for (int i = 1; i <= dGvUsuarios.Columns.Count; i++)
                {
                    hoja.Cells[1, i] = dGvUsuarios.Columns[i - 1].HeaderText.ToString();
                    Rango = hoja.Cells[1, i];
                    Rango.Font.Bold = true;
                    Rango.Font.Name = "Comics Sans";
                    //Rango.Font.Size = 18;
                    Rango.Interior.Color = Color.Gray;
                }
                for (int i = 0; i < dGvUsuarios.Rows.Count; i++)
                {
                    for (int j = 0; j < dGvUsuarios.Columns.Count; j++)
                    {
                        hoja.Cells[2 + i, j + 1] = dGvUsuarios[j, i].Value.ToString();
                    }
                }
                libro.SaveAs(File.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
                libro.Close(true);
                app.Quit();
            }
        }
    }
}