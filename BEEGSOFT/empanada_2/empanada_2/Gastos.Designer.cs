namespace empanada_2
{
    partial class Gastos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView_fechas = new System.Windows.Forms.ListView();
            this.column_fechas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_descripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_gasto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView_gastos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "   Selecciona el dia que \r\n  decees modificar para \r\nagregar un gasto faltante";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listView_fechas
            // 
            this.listView_fechas.BackColor = System.Drawing.Color.White;
            this.listView_fechas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_fechas});
            this.listView_fechas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView_fechas.Location = new System.Drawing.Point(12, 62);
            this.listView_fechas.Name = "listView_fechas";
            this.listView_fechas.Size = new System.Drawing.Size(124, 163);
            this.listView_fechas.TabIndex = 25;
            this.listView_fechas.UseCompatibleStateImageBehavior = false;
            this.listView_fechas.View = System.Windows.Forms.View.Details;
            // 
            // column_fechas
            // 
            this.column_fechas.Text = "Fechas Laboradas";
            this.column_fechas.Width = 120;
            // 
            // textBox_descripcion
            // 
            this.textBox_descripcion.Location = new System.Drawing.Point(36, 47);
            this.textBox_descripcion.Name = "textBox_descripcion";
            this.textBox_descripcion.Size = new System.Drawing.Size(100, 20);
            this.textBox_descripcion.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Gasto";
            // 
            // textBox_gasto
            // 
            this.textBox_gasto.Location = new System.Drawing.Point(61, 93);
            this.textBox_gasto.Name = "textBox_gasto";
            this.textBox_gasto.Size = new System.Drawing.Size(61, 20);
            this.textBox_gasto.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "$";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Escoger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Location = new System.Drawing.Point(348, 31);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(21, 13);
            this.label_fecha.TabIndex = 38;
            this.label_fecha.Text = "dia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Gastos geberados en el dia:";
            // 
            // listView_gastos
            // 
            this.listView_gastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_gastos.Location = new System.Drawing.Point(342, 61);
            this.listView_gastos.Name = "listView_gastos";
            this.listView_gastos.Size = new System.Drawing.Size(327, 167);
            this.listView_gastos.TabIndex = 41;
            this.listView_gastos.UseCompatibleStateImageBehavior = false;
            this.listView_gastos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripción";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Gasto";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(675, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_descripcion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_gasto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(150, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 163);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar un gasto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(582, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "$";
            // 
            // textBox_total
            // 
            this.textBox_total.Enabled = false;
            this.textBox_total.Location = new System.Drawing.Point(601, 233);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(43, 20);
            this.textBox_total.TabIndex = 45;
            this.textBox_total.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(482, 236);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Total Gastos del dia:";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 40;
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 273);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView_gastos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_fecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView_fechas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gastos";
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.Gastos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView_fechas;
        private System.Windows.Forms.ColumnHeader column_fechas;
        private System.Windows.Forms.TextBox textBox_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_gasto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView_gastos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}