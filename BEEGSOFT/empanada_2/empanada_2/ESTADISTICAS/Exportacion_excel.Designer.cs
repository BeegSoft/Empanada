namespace empanada_2
{
    partial class Exportacion_excel
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
            this.label6 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.fechaB = new System.Windows.Forms.DateTimePicker();
            this.fechaA = new System.Windows.Forms.DateTimePicker();
            this.listView_esta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_fechas = new System.Windows.Forms.ListView();
            this.column_fechas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_gastos = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Desde";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(161, 27);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(35, 13);
            this.a.TabIndex = 14;
            this.a.Text = "Hasta";
            // 
            // fechaB
            // 
            this.fechaB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaB.Location = new System.Drawing.Point(211, 23);
            this.fechaB.Name = "fechaB";
            this.fechaB.Size = new System.Drawing.Size(85, 20);
            this.fechaB.TabIndex = 13;
            this.fechaB.Value = new System.DateTime(2016, 4, 18, 0, 0, 0, 0);
            // 
            // fechaA
            // 
            this.fechaA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaA.Location = new System.Drawing.Point(60, 23);
            this.fechaA.Name = "fechaA";
            this.fechaA.Size = new System.Drawing.Size(85, 20);
            this.fechaA.TabIndex = 12;
            this.fechaA.Value = new System.DateTime(2016, 4, 10, 0, 0, 0, 0);
            // 
            // listView_esta
            // 
            this.listView_esta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.listView_esta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_esta.Location = new System.Drawing.Point(164, 72);
            this.listView_esta.Name = "listView_esta";
            this.listView_esta.Size = new System.Drawing.Size(472, 247);
            this.listView_esta.TabIndex = 17;
            this.listView_esta.UseCompatibleStateImageBehavior = false;
            this.listView_esta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 43;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Platillo";
            this.columnHeader3.Width = 202;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Cantidad";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 53;
            // 
            // listView_fechas
            // 
            this.listView_fechas.BackColor = System.Drawing.Color.White;
            this.listView_fechas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_fechas});
            this.listView_fechas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView_fechas.Location = new System.Drawing.Point(10, 70);
            this.listView_fechas.Name = "listView_fechas";
            this.listView_fechas.Size = new System.Drawing.Size(124, 178);
            this.listView_fechas.TabIndex = 24;
            this.listView_fechas.UseCompatibleStateImageBehavior = false;
            this.listView_fechas.View = System.Windows.Forms.View.Details;
            // 
            // column_fechas
            // 
            this.column_fechas.Text = "Fechas Laboradas";
            this.column_fechas.Width = 120;
            // 
            // listView_gastos
            // 
            this.listView_gastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView_gastos.Location = new System.Drawing.Point(175, 311);
            this.listView_gastos.Name = "listView_gastos";
            this.listView_gastos.Size = new System.Drawing.Size(185, 97);
            this.listView_gastos.TabIndex = 26;
            this.listView_gastos.UseCompatibleStateImageBehavior = false;
            this.listView_gastos.View = System.Windows.Forms.View.Details;
            this.listView_gastos.Visible = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fecha";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Descripcion";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Gasto";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 7F);
            this.button2.Image = global::empanada_2.Properties.Resources.exportar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(515, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 55);
            this.button2.TabIndex = 76;
            this.button2.Text = "Exportar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 7F);
            this.button3.Image = global::empanada_2.Properties.Resources.mostrar1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(310, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 55);
            this.button3.TabIndex = 75;
            this.button3.Text = "Mostrar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 7F);
            this.button1.Image = global::empanada_2.Properties.Resources.mostrar1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(417, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 55);
            this.button1.TabIndex = 77;
            this.button1.Text = "Mostrar todo";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exportacion_excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView_gastos);
            this.Controls.Add(this.listView_fechas);
            this.Controls.Add(this.listView_esta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.a);
            this.Controls.Add(this.fechaB);
            this.Controls.Add(this.fechaA);
            this.Name = "Exportacion_excel";
            this.Text = "Exportacion_excel";
            this.Load += new System.EventHandler(this.Exportacion_excel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.DateTimePicker fechaB;
        private System.Windows.Forms.DateTimePicker fechaA;
        private System.Windows.Forms.ListView listView_esta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView_fechas;
        private System.Windows.Forms.ColumnHeader column_fechas;
        private System.Windows.Forms.ListView listView_gastos;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}