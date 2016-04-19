namespace empanada_2
{
    partial class Historial
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_clientes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ganancias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaA = new System.Windows.Forms.DateTimePicker();
            this.fechaB = new System.Windows.Forms.DateTimePicker();
            this.a = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox_platillos = new System.Windows.Forms.ComboBox();
            this.textBox_platillos_vendidos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_venta_platillo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_clientes);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_ganancias);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(15, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 152);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pedidos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox_clientes
            // 
            this.textBox_clientes.Enabled = false;
            this.textBox_clientes.Location = new System.Drawing.Point(121, 88);
            this.textBox_clientes.Name = "textBox_clientes";
            this.textBox_clientes.Size = new System.Drawing.Size(100, 20);
            this.textBox_clientes.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total Clientes:";
            // 
            // textBox_ganancias
            // 
            this.textBox_ganancias.Enabled = false;
            this.textBox_ganancias.Location = new System.Drawing.Point(121, 45);
            this.textBox_ganancias.Name = "textBox_ganancias";
            this.textBox_ganancias.Size = new System.Drawing.Size(100, 20);
            this.textBox_ganancias.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ganancias:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Historial de las Ventas Realizadas Por Fecha Establecida";
            // 
            // fechaA
            // 
            this.fechaA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaA.Location = new System.Drawing.Point(73, 90);
            this.fechaA.Name = "fechaA";
            this.fechaA.Size = new System.Drawing.Size(85, 20);
            this.fechaA.TabIndex = 6;
            this.fechaA.Value = new System.DateTime(2016, 4, 18, 0, 0, 0, 0);
            // 
            // fechaB
            // 
            this.fechaB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaB.Location = new System.Drawing.Point(224, 90);
            this.fechaB.Name = "fechaB";
            this.fechaB.Size = new System.Drawing.Size(85, 20);
            this.fechaB.TabIndex = 7;
            this.fechaB.Value = new System.DateTime(2016, 4, 18, 0, 0, 0, 0);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(174, 94);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(35, 13);
            this.a.TabIndex = 8;
            this.a.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Escoga entre que fechas quiere las estadisticas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Desde";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox_platillos
            // 
            this.comboBox_platillos.FormattingEnabled = true;
            this.comboBox_platillos.Location = new System.Drawing.Point(8, 34);
            this.comboBox_platillos.Name = "comboBox_platillos";
            this.comboBox_platillos.Size = new System.Drawing.Size(121, 21);
            this.comboBox_platillos.TabIndex = 12;
            this.comboBox_platillos.SelectedIndexChanged += new System.EventHandler(this.comboBox_platillos_SelectedIndexChanged);
            // 
            // textBox_platillos_vendidos
            // 
            this.textBox_platillos_vendidos.Location = new System.Drawing.Point(194, 36);
            this.textBox_platillos_vendidos.Name = "textBox_platillos_vendidos";
            this.textBox_platillos_vendidos.Size = new System.Drawing.Size(100, 20);
            this.textBox_platillos_vendidos.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(195, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vendidos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(195, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ventas";
            // 
            // textBox_venta_platillo
            // 
            this.textBox_venta_platillo.Location = new System.Drawing.Point(194, 88);
            this.textBox_venta_platillo.Name = "textBox_venta_platillo";
            this.textBox_venta_platillo.Size = new System.Drawing.Size(100, 20);
            this.textBox_venta_platillo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Platillo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_venta_platillo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_platillos_vendidos);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox_platillos);
            this.groupBox3.Location = new System.Drawing.Point(15, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 152);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Platillos vendidos";
            // 
            // grafica
            // 
            chartArea1.Name = "ChartArea1";
            this.grafica.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafica.Legends.Add(legend1);
            this.grafica.Location = new System.Drawing.Point(430, 109);
            this.grafica.Name = "grafica";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafica.Series.Add(series1);
            this.grafica.Size = new System.Drawing.Size(470, 361);
            this.grafica.TabIndex = 20;
            this.grafica.Text = "chart1";
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 482);
            this.Controls.Add(this.grafica);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.a);
            this.Controls.Add(this.fechaB);
            this.Controls.Add(this.fechaA);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ganancias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_clientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker fechaA;
        private System.Windows.Forms.DateTimePicker fechaB;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox_platillos;
        private System.Windows.Forms.TextBox textBox_platillos_vendidos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_venta_platillo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafica;
    }
}