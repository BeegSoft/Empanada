namespace empanada_2
{
    partial class Users
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button25 = new System.Windows.Forms.Button();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Clave Desencriptada:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 367);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 99;
            this.button1.Text = "Obtener Clave";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader8});
            this.listView2.Location = new System.Drawing.Point(190, 155);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(227, 195);
            this.listView2.TabIndex = 97;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "NOMBRE";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "TIPO DE USUARIO";
            this.columnHeader8.Width = 120;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(24, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(394, 195);
            this.listView1.TabIndex = 96;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOMBRE";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CLAVE";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TIPO DE USUARIO";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 35;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.AbrirProgramaToolStripMenuItem,
            this.abrirBaseDeDatosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(537, 87);
            this.menuStrip1.TabIndex = 95;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Image = global::empanada_2.Properties.Resources.add_female_user;
            this.registrarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Image = global::empanada_2.Properties.Resources.book_search;
            this.modificarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // AbrirProgramaToolStripMenuItem
            // 
            this.AbrirProgramaToolStripMenuItem.BackColor = System.Drawing.Color.DarkSalmon;
            this.AbrirProgramaToolStripMenuItem.Image = global::empanada_2.Properties.Resources.picasion_com_486ae478bb1e5c7f9f0eac83a104f497;
            this.AbrirProgramaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AbrirProgramaToolStripMenuItem.Name = "AbrirProgramaToolStripMenuItem";
            this.AbrirProgramaToolStripMenuItem.Size = new System.Drawing.Size(100, 83);
            this.AbrirProgramaToolStripMenuItem.Text = "Abrir Programa";
            this.AbrirProgramaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AbrirProgramaToolStripMenuItem.Click += new System.EventHandler(this.AbrirProgramaToolStripMenuItem_Click);
            // 
            // abrirBaseDeDatosToolStripMenuItem
            // 
            this.abrirBaseDeDatosToolStripMenuItem.Image = global::empanada_2.Properties.Resources.bdd;
            this.abrirBaseDeDatosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.abrirBaseDeDatosToolStripMenuItem.Name = "abrirBaseDeDatosToolStripMenuItem";
            this.abrirBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(122, 83);
            this.abrirBaseDeDatosToolStripMenuItem.Text = "Abrir Base De Datos";
            this.abrirBaseDeDatosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.abrirBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.abrirBaseDeDatosToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = global::empanada_2.Properties.Resources.shut_down;
            this.cerrarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 93;
            this.label1.Text = "Bienvenido ";
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Image = global::empanada_2.Properties.Resources.delete;
            this.button25.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button25.Location = new System.Drawing.Point(424, 155);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(42, 43);
            this.button25.TabIndex = 98;
            this.button25.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::empanada_2.Properties.Resources.female_male_users;
            this.usuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(76, 83);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 401);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem AbrirProgramaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem abrirBaseDeDatosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
    }
}