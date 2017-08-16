namespace ControlInventarioUniversidad
{
    partial class Caja
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbEslogan = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbfecha = new System.Windows.Forms.Label();
            this.labelversion = new System.Windows.Forms.Label();
            this.dVCaja = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTotalFinal = new System.Windows.Forms.Label();
            this.lbLeAtiende = new System.Windows.Forms.Label();
            this.TBcaja = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dVCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(336, 7);
            this.lbMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(264, 26);
            this.lbMarca.TabIndex = 2;
            this.lbMarca.Text = "Don Baraton S.A de CV";
            // 
            // lbEslogan
            // 
            this.lbEslogan.AutoSize = true;
            this.lbEslogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEslogan.Location = new System.Drawing.Point(348, 51);
            this.lbEslogan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEslogan.Name = "lbEslogan";
            this.lbEslogan.Size = new System.Drawing.Size(252, 20);
            this.lbEslogan.TabIndex = 3;
            this.lbEslogan.Text = "No es Bueno... Pero es Barato";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfecha.Location = new System.Drawing.Point(746, 7);
            this.lbfecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(229, 17);
            this.lbfecha.TabIndex = 5;
            this.lbfecha.Text = "Error al cargar la fecha y hora";
            // 
            // labelversion
            // 
            this.labelversion.AutoSize = true;
            this.labelversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelversion.Location = new System.Drawing.Point(784, 53);
            this.labelversion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelversion.Name = "labelversion";
            this.labelversion.Size = new System.Drawing.Size(191, 17);
            this.labelversion.TabIndex = 6;
            this.labelversion.Text = "Error al cargar la version";
            // 
            // dVCaja
            // 
            this.dVCaja.AllowUserToAddRows = false;
            this.dVCaja.AllowUserToDeleteRows = false;
            this.dVCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dVCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dVCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dVCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dVCaja.Location = new System.Drawing.Point(0, 85);
            this.dVCaja.Margin = new System.Windows.Forms.Padding(2);
            this.dVCaja.Name = "dVCaja";
            this.dVCaja.ReadOnly = true;
            this.dVCaja.RowTemplate.Height = 24;
            this.dVCaja.Size = new System.Drawing.Size(975, 529);
            this.dVCaja.TabIndex = 7;
            this.dVCaja.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Cant";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 180F;
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 60F;
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // lbTotalFinal
            // 
            this.lbTotalFinal.AutoSize = true;
            this.lbTotalFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFinal.Location = new System.Drawing.Point(879, 633);
            this.lbTotalFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalFinal.Name = "lbTotalFinal";
            this.lbTotalFinal.Size = new System.Drawing.Size(58, 26);
            this.lbTotalFinal.TabIndex = 10;
            this.lbTotalFinal.Text = "0.00";
            // 
            // lbLeAtiende
            // 
            this.lbLeAtiende.AutoSize = true;
            this.lbLeAtiende.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbLeAtiende.Location = new System.Drawing.Point(772, 33);
            this.lbLeAtiende.Name = "lbLeAtiende";
            this.lbLeAtiende.Size = new System.Drawing.Size(203, 17);
            this.lbLeAtiende.TabIndex = 11;
            this.lbLeAtiende.Text = "Le Atiende: Error al cargar";
            // 
            // TBcaja
            // 
            this.TBcaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.TBcaja.Location = new System.Drawing.Point(0, 687);
            this.TBcaja.Name = "TBcaja";
            this.TBcaja.Size = new System.Drawing.Size(975, 32);
            this.TBcaja.TabIndex = 12;
            this.TBcaja.TabStop = false;
            this.TBcaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBcaja_KeyPress);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbTotal.Location = new System.Drawing.Point(792, 633);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(71, 26);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "Total:";
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.TBcaja);
            this.Controls.Add(this.lbLeAtiende);
            this.Controls.Add(this.lbTotalFinal);
            this.Controls.Add(this.dVCaja);
            this.Controls.Add(this.labelversion);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lbEslogan);
            this.Controls.Add(this.lbMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Caja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dVCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbEslogan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label labelversion;
        private System.Windows.Forms.DataGridView dVCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lbTotalFinal;
        private System.Windows.Forms.Label lbLeAtiende;
        private System.Windows.Forms.TextBox TBcaja;
        private System.Windows.Forms.Label lbTotal;
    }
}