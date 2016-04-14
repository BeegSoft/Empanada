namespace empanada_2
{
    partial class Fechas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fechas));
            this.listView_fechas = new System.Windows.Forms.ListView();
            this.columnHeader_fechas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_elegir = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_fechas
            // 
            this.listView_fechas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_fechas});
            this.listView_fechas.Location = new System.Drawing.Point(69, 64);
            this.listView_fechas.Name = "listView_fechas";
            this.listView_fechas.Size = new System.Drawing.Size(111, 154);
            this.listView_fechas.TabIndex = 0;
            this.listView_fechas.UseCompatibleStateImageBehavior = false;
            this.listView_fechas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_fechas
            // 
            this.columnHeader_fechas.Text = "FECHAS";
            this.columnHeader_fechas.Width = 104;
            // 
            // button_elegir
            // 
            this.button_elegir.Location = new System.Drawing.Point(24, 224);
            this.button_elegir.Name = "button_elegir";
            this.button_elegir.Size = new System.Drawing.Size(71, 25);
            this.button_elegir.TabIndex = 1;
            this.button_elegir.Text = "Elegir";
            this.button_elegir.UseVisualStyleBackColor = true;
            this.button_elegir.Click += new System.EventHandler(this.button_elegir_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(150, 224);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(71, 24);
            this.button_cancelar.TabIndex = 2;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona la fecha sobre la que deceas trabajar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ver Historial de la Fecha";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 307);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_elegir);
            this.Controls.Add(this.listView_fechas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fechas";
            this.Text = "Fechas";
            this.Load += new System.EventHandler(this.Fechas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_fechas;
        private System.Windows.Forms.ColumnHeader columnHeader_fechas;
        private System.Windows.Forms.Button button_elegir;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}