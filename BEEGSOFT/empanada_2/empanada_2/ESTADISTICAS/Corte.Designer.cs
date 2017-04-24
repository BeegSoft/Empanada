namespace empanada_2
{
    partial class Corte
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.textBox_ventas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.listView_fechas = new System.Windows.Forms.ListView();
            this.column_fechas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_ganancias = new System.Windows.Forms.TextBox();
            this.Ganancias = new System.Windows.Forms.Label();
            this.textBox_gastos = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_empanadas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_clientes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 16);
            this.label7.TabIndex = 84;
            this.label7.Text = "Sistema control Empanada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Historial Generado En el Dia:";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.Location = new System.Drawing.Point(367, 73);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(24, 13);
            this.label_fecha.TabIndex = 82;
            this.label_fecha.Text = "dia";
            // 
            // textBox_ventas
            // 
            this.textBox_ventas.Enabled = false;
            this.textBox_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_ventas.Location = new System.Drawing.Point(466, 286);
            this.textBox_ventas.Name = "textBox_ventas";
            this.textBox_ventas.Size = new System.Drawing.Size(51, 20);
            this.textBox_ventas.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(362, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Ventas del Dia: $";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::empanada_2.Properties.Resources.accept;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(22, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 56);
            this.button3.TabIndex = 91;
            this.button3.Text = "Cargar Fecha";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // listView_fechas
            // 
            this.listView_fechas.BackColor = System.Drawing.Color.White;
            this.listView_fechas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_fechas});
            this.listView_fechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_fechas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView_fechas.Location = new System.Drawing.Point(12, 79);
            this.listView_fechas.Name = "listView_fechas";
            this.listView_fechas.Size = new System.Drawing.Size(124, 136);
            this.listView_fechas.TabIndex = 90;
            this.listView_fechas.UseCompatibleStateImageBehavior = false;
            this.listView_fechas.View = System.Windows.Forms.View.Details;
            // 
            // column_fechas
            // 
            this.column_fechas.Text = "Fechas Laboradas";
            this.column_fechas.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 65);
            this.label2.TabIndex = 89;
            this.label2.Text = "   Selecciona la fecha\r\nque deceas cargar de la\r\n      siguiente tabla\r\n \r\n\r\n";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listView1.Location = new System.Drawing.Point(176, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(359, 184);
            this.listView1.TabIndex = 92;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Producto";
            this.columnHeader8.Width = 202;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Cantidad";
            this.columnHeader9.Width = 76;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Total";
            this.columnHeader10.Width = 53;
            // 
            // textBox_ganancias
            // 
            this.textBox_ganancias.Enabled = false;
            this.textBox_ganancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_ganancias.Location = new System.Drawing.Point(467, 339);
            this.textBox_ganancias.Name = "textBox_ganancias";
            this.textBox_ganancias.Size = new System.Drawing.Size(51, 20);
            this.textBox_ganancias.TabIndex = 100;
            // 
            // Ganancias
            // 
            this.Ganancias.AutoSize = true;
            this.Ganancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Ganancias.Location = new System.Drawing.Point(293, 342);
            this.Ganancias.Name = "Ganancias";
            this.Ganancias.Size = new System.Drawing.Size(174, 13);
            this.Ganancias.TabIndex = 99;
            this.Ganancias.Text = "Ganancias Totales Del Dia: $";
            // 
            // textBox_gastos
            // 
            this.textBox_gastos.Enabled = false;
            this.textBox_gastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_gastos.Location = new System.Drawing.Point(466, 311);
            this.textBox_gastos.Name = "textBox_gastos";
            this.textBox_gastos.Size = new System.Drawing.Size(51, 20);
            this.textBox_gastos.TabIndex = 98;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(360, 314);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 97;
            this.label16.Text = "Gastos Del Dia: $";
            // 
            // textBox_empanadas
            // 
            this.textBox_empanadas.Enabled = false;
            this.textBox_empanadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_empanadas.Location = new System.Drawing.Point(277, 311);
            this.textBox_empanadas.Name = "textBox_empanadas";
            this.textBox_empanadas.Size = new System.Drawing.Size(51, 20);
            this.textBox_empanadas.TabIndex = 96;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(165, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 13);
            this.label14.TabIndex = 95;
            this.label14.Text = "Total De Articulos:";
            // 
            // textBox_clientes
            // 
            this.textBox_clientes.Enabled = false;
            this.textBox_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.textBox_clientes.Location = new System.Drawing.Point(277, 287);
            this.textBox_clientes.Name = "textBox_clientes";
            this.textBox_clientes.Size = new System.Drawing.Size(51, 20);
            this.textBox_clientes.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(170, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Total De Clientes:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold);
            this.button2.Image = global::empanada_2.Properties.Resources.exportar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(430, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 55);
            this.button2.TabIndex = 101;
            this.button2.Text = "Exportar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Corte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(545, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_ganancias);
            this.Controls.Add(this.Ganancias);
            this.Controls.Add(this.textBox_gastos);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox_empanadas);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox_clientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView_fechas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ventas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_fecha);
            this.Name = "Corte";
            this.Text = "Corte";
            this.Load += new System.EventHandler(this.Corte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.TextBox textBox_ventas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView_fechas;
        private System.Windows.Forms.ColumnHeader column_fechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox textBox_ganancias;
        private System.Windows.Forms.Label Ganancias;
        private System.Windows.Forms.TextBox textBox_gastos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_empanadas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_clientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}