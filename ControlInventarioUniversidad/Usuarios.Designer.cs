using System.Reflection;
namespace ControlInventarioUniversidad
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.dGvUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBtipousuario = new System.Windows.Forms.TextBox();
            this.tBidusuario = new System.Windows.Forms.TextBox();
            this.tBpssusuario = new System.Windows.Forms.TextBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.tBappaterno = new System.Windows.Forms.TextBox();
            this.tBapmaterno = new System.Windows.Forms.TextBox();
            this.tBemail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btPdf = new System.Windows.Forms.Button();
            this.btExcel = new System.Windows.Forms.Button();
            this.cBusuario = new System.Windows.Forms.ComboBox();
            this.btn_csv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBima)).BeginInit();
            this.SuspendLayout();
            // 
            // dGvUsuarios
            // 
            this.dGvUsuarios.AllowUserToAddRows = false;
            this.dGvUsuarios.AllowUserToDeleteRows = false;
            this.dGvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column8,
            this.Column4,
            this.Column6});
            this.dGvUsuarios.Location = new System.Drawing.Point(9, 60);
            this.dGvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dGvUsuarios.Name = "dGvUsuarios";
            this.dGvUsuarios.ReadOnly = true;
            this.dGvUsuarios.RowTemplate.Height = 24;
            this.dGvUsuarios.Size = new System.Drawing.Size(981, 354);
            this.dGvUsuarios.TabIndex = 0;
            this.dGvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dGvUsuarios.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo Usuario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ID Usuario";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "PASS Usuario";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ap Paterno";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ap Materno";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
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
            this.label1.Location = new System.Drawing.Point(440, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 436);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 476);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 511);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PASS Usuario";
            // 
            // tBtipousuario
            // 
            this.tBtipousuario.Location = new System.Drawing.Point(90, 436);
            this.tBtipousuario.Margin = new System.Windows.Forms.Padding(2);
            this.tBtipousuario.Name = "tBtipousuario";
            this.tBtipousuario.Size = new System.Drawing.Size(179, 20);
            this.tBtipousuario.TabIndex = 0;
            // 
            // tBidusuario
            // 
            this.tBidusuario.Location = new System.Drawing.Point(90, 476);
            this.tBidusuario.Margin = new System.Windows.Forms.Padding(2);
            this.tBidusuario.Name = "tBidusuario";
            this.tBidusuario.Size = new System.Drawing.Size(179, 20);
            this.tBidusuario.TabIndex = 6;
            // 
            // tBpssusuario
            // 
            this.tBpssusuario.Location = new System.Drawing.Point(90, 511);
            this.tBpssusuario.Margin = new System.Windows.Forms.Padding(2);
            this.tBpssusuario.Name = "tBpssusuario";
            this.tBpssusuario.PasswordChar = '*';
            this.tBpssusuario.Size = new System.Drawing.Size(179, 20);
            this.tBpssusuario.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(845, 436);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Imagen:";
            // 
            // pBima
            // 
            this.pBima.Image = ((System.Drawing.Image)(resources.GetObject("pBima.Image")));
            this.pBima.Location = new System.Drawing.Point(848, 453);
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
            this.btCrear.Location = new System.Drawing.Point(11, 549);
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
            this.btActualizar.Location = new System.Drawing.Point(102, 549);
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
            this.btEliminar.Location = new System.Drawing.Point(207, 549);
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
            this.btSalir.Location = new System.Drawing.Point(782, 580);
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
            this.btLimpiar.Location = new System.Drawing.Point(11, 578);
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
            this.toolStrip1.Size = new System.Drawing.Size(999, 25);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileImaPic
            // 
            this.openFileImaPic.FileName = "openFileDialog1";
            // 
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(564, 545);
            this.btBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(143, 23);
            this.btBackup.TabIndex = 18;
            this.btBackup.Text = "Resp tabla Usuario";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 511);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ap Materno:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 476);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Ap Paterno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 436);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nombre:";
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(354, 436);
            this.tBnombre.Margin = new System.Windows.Forms.Padding(2);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(179, 20);
            this.tBnombre.TabIndex = 22;
            // 
            // tBappaterno
            // 
            this.tBappaterno.Location = new System.Drawing.Point(354, 474);
            this.tBappaterno.Margin = new System.Windows.Forms.Padding(2);
            this.tBappaterno.Name = "tBappaterno";
            this.tBappaterno.Size = new System.Drawing.Size(179, 20);
            this.tBappaterno.TabIndex = 23;
            // 
            // tBapmaterno
            // 
            this.tBapmaterno.Location = new System.Drawing.Point(354, 511);
            this.tBapmaterno.Margin = new System.Windows.Forms.Padding(2);
            this.tBapmaterno.Name = "tBapmaterno";
            this.tBapmaterno.Size = new System.Drawing.Size(179, 20);
            this.tBapmaterno.TabIndex = 24;
            // 
            // tBemail
            // 
            this.tBemail.Location = new System.Drawing.Point(354, 545);
            this.tBemail.Margin = new System.Windows.Forms.Padding(2);
            this.tBemail.Name = "tBemail";
            this.tBemail.Size = new System.Drawing.Size(179, 20);
            this.tBemail.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 549);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email:";
            // 
            // btPdf
            // 
            this.btPdf.Location = new System.Drawing.Point(564, 578);
            this.btPdf.Name = "btPdf";
            this.btPdf.Size = new System.Drawing.Size(91, 23);
            this.btPdf.TabIndex = 27;
            this.btPdf.Text = "Generar PDF";
            this.btPdf.UseVisualStyleBackColor = true;
            this.btPdf.Click += new System.EventHandler(this.btPdf_Click);
            // 
            // btExcel
            // 
            this.btExcel.Location = new System.Drawing.Point(672, 578);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(92, 23);
            this.btExcel.TabIndex = 28;
            this.btExcel.Text = "Exportar Excel";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // cBusuario
            // 
            this.cBusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBusuario.FormattingEnabled = true;
            this.cBusuario.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.cBusuario.Location = new System.Drawing.Point(90, 435);
            this.cBusuario.Name = "cBusuario";
            this.cBusuario.Size = new System.Drawing.Size(179, 21);
            this.cBusuario.TabIndex = 29;
            this.cBusuario.SelectedIndexChanged += new System.EventHandler(this.cBusuario_SelectedIndexChanged);
            // 
            // btn_csv
            // 
            this.btn_csv.Location = new System.Drawing.Point(740, 545);
            this.btn_csv.Name = "btn_csv";
            this.btn_csv.Size = new System.Drawing.Size(92, 23);
            this.btn_csv.TabIndex = 31;
            this.btn_csv.Text = "Exportar CSV";
            this.btn_csv.UseVisualStyleBackColor = true;
            this.btn_csv.Click += new System.EventHandler(this.btn_csv_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 604);
            this.Controls.Add(this.btn_csv);
            this.Controls.Add(this.cBusuario);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.btPdf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBemail);
            this.Controls.Add(this.tBapmaterno);
            this.Controls.Add(this.tBappaterno);
            this.Controls.Add(this.tBnombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btBackup);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.pBima);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBpssusuario);
            this.Controls.Add(this.tBidusuario);
            this.Controls.Add(this.tBtipousuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGvUsuarios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBtipousuario;
        private System.Windows.Forms.TextBox tBidusuario;
        private System.Windows.Forms.TextBox tBpssusuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pBima;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.OpenFileDialog openFileImaPic;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.TextBox tBappaterno;
        private System.Windows.Forms.TextBox tBapmaterno;
        private System.Windows.Forms.TextBox tBemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btPdf;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox cBusuario;
        private System.Windows.Forms.Button btn_csv;
    }
}