using System.Reflection;
namespace ControlInventarioUniversidad
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.dGvProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBcodigo = new System.Windows.Forms.TextBox();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.tBprecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rTbDesc = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pBima = new System.Windows.Forms.PictureBox();
            this.btCrear = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileImaPic = new System.Windows.Forms.OpenFileDialog();
            this.btBackup = new System.Windows.Forms.Button();
            this.btPdf = new System.Windows.Forms.Button();
            this.btExcel = new System.Windows.Forms.Button();
            this.bt_csv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBima)).BeginInit();
            this.SuspendLayout();
            // 
            // dGvProductos
            // 
            this.dGvProductos.AllowUserToAddRows = false;
            this.dGvProductos.AllowUserToDeleteRows = false;
            this.dGvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6});
            this.dGvProductos.Location = new System.Drawing.Point(9, 60);
            this.dGvProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dGvProductos.Name = "dGvProductos";
            this.dGvProductos.ReadOnly = true;
            this.dGvProductos.RowTemplate.Height = 24;
            this.dGvProductos.Size = new System.Drawing.Size(722, 354);
            this.dGvProductos.TabIndex = 0;
            this.dGvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dGvProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Descripción";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Imagen";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ruta";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 421);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 461);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 496);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio:";
            // 
            // tBcodigo
            // 
            this.tBcodigo.Location = new System.Drawing.Point(64, 421);
            this.tBcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.tBcodigo.Name = "tBcodigo";
            this.tBcodigo.Size = new System.Drawing.Size(179, 20);
            this.tBcodigo.TabIndex = 0;
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(64, 461);
            this.tBnombre.Margin = new System.Windows.Forms.Padding(2);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(179, 20);
            this.tBnombre.TabIndex = 6;
            // 
            // tBprecio
            // 
            this.tBprecio.Location = new System.Drawing.Point(64, 496);
            this.tBprecio.Margin = new System.Windows.Forms.Padding(2);
            this.tBprecio.Name = "tBprecio";
            this.tBprecio.Size = new System.Drawing.Size(179, 20);
            this.tBprecio.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 421);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción:";
            // 
            // rTbDesc
            // 
            this.rTbDesc.Location = new System.Drawing.Point(266, 438);
            this.rTbDesc.Margin = new System.Windows.Forms.Padding(2);
            this.rTbDesc.Name = "rTbDesc";
            this.rTbDesc.Size = new System.Drawing.Size(204, 79);
            this.rTbDesc.TabIndex = 9;
            this.rTbDesc.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 421);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Imagen:";
            // 
            // pBima
            // 
            this.pBima.Image = ((System.Drawing.Image)(resources.GetObject("pBima.Image")));
            this.pBima.Location = new System.Drawing.Point(589, 438);
            this.pBima.Margin = new System.Windows.Forms.Padding(2);
            this.pBima.Name = "pBima";
            this.pBima.Size = new System.Drawing.Size(140, 144);
            this.pBima.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBima.TabIndex = 11;
            this.pBima.TabStop = false;
            this.pBima.Click += new System.EventHandler(this.pBima_Click);
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(12, 529);
            this.btCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(56, 19);
            this.btCrear.TabIndex = 12;
            this.btCrear.Text = "&Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(95, 529);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(62, 19);
            this.btActualizar.TabIndex = 13;
            this.btActualizar.Text = "&Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(181, 529);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(62, 19);
            this.btEliminar.TabIndex = 14;
            this.btEliminar.Text = "&Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(451, 529);
            this.btSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(50, 19);
            this.btSalir.TabIndex = 15;
            this.btSalir.Text = "&Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(266, 529);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(56, 19);
            this.btLimpiar.TabIndex = 16;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileImaPic
            // 
            this.openFileImaPic.FileName = "openFileDialog1";
            // 
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(326, 529);
            this.btBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(88, 19);
            this.btBackup.TabIndex = 18;
            this.btBackup.Text = "Respaldar SQL";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // btPdf
            // 
            this.btPdf.Location = new System.Drawing.Point(228, 559);
            this.btPdf.Name = "btPdf";
            this.btPdf.Size = new System.Drawing.Size(83, 23);
            this.btPdf.TabIndex = 19;
            this.btPdf.Text = "Generar PDF";
            this.btPdf.UseVisualStyleBackColor = true;
            this.btPdf.Click += new System.EventHandler(this.btPdf_Click);
            // 
            // btExcel
            // 
            this.btExcel.Location = new System.Drawing.Point(317, 559);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(85, 23);
            this.btExcel.TabIndex = 20;
            this.btExcel.Text = "Exportar Excel";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // bt_csv
            // 
            this.bt_csv.Location = new System.Drawing.Point(408, 559);
            this.bt_csv.Name = "bt_csv";
            this.bt_csv.Size = new System.Drawing.Size(93, 23);
            this.bt_csv.TabIndex = 21;
            this.bt_csv.Text = "Exportar CSV";
            this.bt_csv.UseVisualStyleBackColor = true;
            this.bt_csv.Click += new System.EventHandler(this.bt_csv_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 589);
            this.Controls.Add(this.bt_csv);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.btPdf);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.pBima);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rTbDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBprecio);
            this.Controls.Add(this.tBnombre);
            this.Controls.Add(this.tBcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGvProductos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBcodigo;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.TextBox tBprecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rTbDesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pBima;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.OpenFileDialog openFileImaPic;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btPdf;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.Button bt_csv;
    }
}