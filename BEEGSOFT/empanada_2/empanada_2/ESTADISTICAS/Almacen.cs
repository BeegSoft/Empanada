using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

using System.Globalization;
using System.Reflection;
using System.Threading;

namespace empanada_2
{
    public partial class Almacen : Form
    {
        public Almacen(string ds)
        {
            InitializeComponent();
            this.ds = ds;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            groupBox1.Size=new Size(181, 87);
            this.Size=new Size(263, 147);
        }        

        string ds, descripcion,tipo;
        double suma,suma2,cantidad, peso, peso3, rendimiento;
        public int P=0;

        private void Almacen_Activated(object sender, EventArgs e)
        {
            if (P == 0)
            {
                SELECT_ALMACEN(tipo);

                DataSet dss = new DataSet();
                //indicamos la consulta en SQL
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT Descripcion FROM ALMACEN", ds);
                //se indica el nombre de la tabla
                da.Fill(dss, "Descripcion");
                comboBox_almacen.DataSource = dss.Tables[0].DefaultView;
                //se especifica el campo de la tabla
                comboBox_almacen.ValueMember = "Descripcion";

                //ESTE ES EL QUE VAS A QUITAR SI FUNCIONA EL PROGRESSBAR
                P = -1;
                CARGA(P);
            }
        }

        public void SetDefaultCulture(CultureInfo culture)
        {
            Type type = typeof(CultureInfo);

            try
            {
                type.InvokeMember("s_userDefaultCulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });

                type.InvokeMember("s_userDefaultUICulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });
            }
            catch { }

            try
            {
                type.InvokeMember("m_userDefaultCulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });

                type.InvokeMember("m_userDefaultUICulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });
            }
            catch { }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {            
            tipo = "platillo";
            groupBox1.Size = new Size(226, 318);
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            button13.Visible = true;
            button1.Visible = false;
            button5.Visible = true;
            //button5.Location = new Point(28, 178);
            button4.Visible = true;
            SELECT_ALMACEN(tipo);
            label2.Visible = true;
            textBox2.Visible = true;
            this.Size = new Size(797, 381);
            listView_almacen.Size=new Size(275, 318);

            listView_almacen.Location = new Point(265, 12);
            this.Size = new Size(581, 381);
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            DataSet dss = new DataSet();
            //indicamos la consulta en SQL
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT Descripcion FROM ALMACEN WHERE tipo ='" + tipo + "'", ds);
            //se indica el nombre de la tabla
            da.Fill(dss, "Descripcion");
            comboBox_almacen.DataSource = dss.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            comboBox_almacen.ValueMember = "Descripcion";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Size = new Size(797, 381);
            listView_almacen.Location=new Point(469, 12);
            label1.Visible = true;
            textBox1.Visible = true;
            label2.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;

            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string select = "SELECT Peso1, Rendimiento1 FROM ALMACEN WHERE Descripcion = '" + comboBox_almacen.Text + "'";
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            try
            {
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox1.Text = reader.GetDouble(0).ToString();
                        textBox2.Text = reader.GetDouble(1).ToString();
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double descuento;
            OleDbConnection conexion = new OleDbConnection(ds);
            SetDefaultCulture(new CultureInfo("es-MX"));
            conexion.Open();

            descuento = (double.Parse(textBox1.Text, Thread.CurrentThread.CurrentCulture))/ (double.Parse(textBox2.Text, Thread.CurrentThread.CurrentCulture));

            string insertar = "UPDATE ALMACEN SET Peso= @Peso, Rendimiento = @Rendimiento, descuento=@descuento WHERE Descripcion = '" + comboBox_almacen.Text + "'";
            OleDbCommand cmd = new OleDbCommand(insertar, conexion);
            cmd.Parameters.AddWithValue("@Peso", double.Parse(textBox1.Text, Thread.CurrentThread.CurrentCulture));
            cmd.Parameters.AddWithValue("@Rendimiento", double.Parse(textBox2.Text, Thread.CurrentThread.CurrentCulture));
            cmd.Parameters.AddWithValue("@descuento", descuento);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Datos modificados correctamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexion.Close();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();

            listView_almacen.Location = new Point(265, 12);
            this.Size = new Size(581, 381);
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Tienes el campo de cantidad a agregar vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                SetDefaultCulture(new CultureInfo("es-MX"));
                //checar cuanto es lo que tiene de peso respecto a la descripcion
                OleDbConnection conexion4 = new OleDbConnection(ds);

                conexion4.Open();
                string sql = "select Peso,Rendimiento from ALMACEN WHERE Descripcion='" + comboBox_almacen.Text + "'";
                OleDbCommand cmd = new OleDbCommand(sql, conexion4);
                try
                {
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            peso = reader.GetDouble(0);
                            peso3 = reader.GetDouble(1);
                        }
                    }
                    else
                    {
                    }
                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conexion4.Close();

                //Realizando la suma para aser la modificacion
                suma = (double.Parse(textBox1.Text, Thread.CurrentThread.CurrentCulture)) + peso;

                suma2 = (double.Parse(textBox1.Text, Thread.CurrentThread.CurrentCulture)) + peso3;

                //realizando la consulta
                OleDbConnection conexion = new OleDbConnection(ds);

                conexion.Open();

                string insertar = "UPDATE ALMACEN SET Peso = @Peso, Rendimiento= @Rendimiento, Peso1 = @Peso1, Rendimiento1= @Rendimiento1 WHERE Descripcion= '" + comboBox_almacen.Text + "'";
                OleDbCommand cmd3 = new OleDbCommand(insertar, conexion);
                cmd3.Parameters.AddWithValue("@Peso", suma.ToString());
                cmd3.Parameters.AddWithValue("@Rendimiento", suma2.ToString());
                cmd3.Parameters.AddWithValue("@Peso1", suma.ToString());
                cmd3.Parameters.AddWithValue("@Rendimiento1", suma2.ToString());

                cmd3.ExecuteNonQuery();
                conexion.Close();
                SELECT_ALMACEN(tipo);
            }
            
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {

            textBox1.Enabled = true;
            textBox1.Clear();           
            tipo = "bebida";
            label1.Visible = true;
            button1.Visible = true;
            button5.Visible = false;
            textBox1.Visible = true;
            button13.Visible = false;
            button4.Visible = false ;
            label2.Visible = false;
            textBox2.Visible = false;
            //button5.Location = new Point(291, 99);
            groupBox1.Size = new Size(226, 175);
            button2.Visible = false;
            this.Size = new Size(797, 287);
            listView_almacen.Size = new Size(275, 215);
            listView_almacen.Location = new Point(469, 12);
            SELECT_ALMACEN(tipo);

            DataSet dss = new DataSet();
            //indicamos la consulta en SQL
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT Descripcion FROM ALMACEN WHERE tipo ='" + tipo + "'", ds);
            //se indica el nombre de la tabla
            da.Fill(dss, "Descripcion");
            comboBox_almacen.DataSource = dss.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            comboBox_almacen.ValueMember = "Descripcion";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SetDefaultCulture(new CultureInfo("es-MX"));
            double cal;
            try
            {
                if (textBox1.Text == "")
                {
                    cal = 0;
                }
                else
                {
                    cal = double.Parse(textBox1.Text, Thread.CurrentThread.CurrentCulture);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introdujo datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SetDefaultCulture(new CultureInfo("es-MX"));
            double cal;
            try
            {
                if (textBox2.Text == "")
                {
                    cal = 0;
                }
                else
                {
                    cal = double.Parse(textBox2.Text, Thread.CurrentThread.CurrentCulture);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introdujo datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                textBox2.Focus();
            }
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            if (tipo == "")
            {

            }
            else
            {
                //cuando p=0 es que no es mandado del index o de otra pantalla
                if (P == 0)
                {
                    SELECT_ALMACEN(tipo);

                    DataSet dss = new DataSet();
                    //indicamos la consulta en SQL
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT Descripcion FROM ALMACEN WHERE tipo ='" + tipo + "'", ds);
                    //se indica el nombre de la tabla
                    da.Fill(dss, "Descripcion");
                    comboBox_almacen.DataSource = dss.Tables[0].DefaultView;
                    //se especifica el campo de la tabla
                    comboBox_almacen.ValueMember = "Descripcion";

                    //ESTE ES EL QUE VAS A QUITAR SI FUNCIONA EL PROGRESSBAR
                    //P = -1;
                    //CARGA(P);
                }
                // si p=1 es por que e esta mandando del index cuando se carga
                else if (P == 1)
                {
                    SELECT_ALMACEN(tipo);

                    DataSet dss = new DataSet();
                    //indicamos la consulta en SQL
                    OleDbDataAdapter da = new OleDbDataAdapter("SELECT Descripcion FROM ALMACEN WHERE tipo ='" + tipo + "'", ds);
                    //se indica el nombre de la tabla
                    da.Fill(dss, "Descripcion");
                    comboBox_almacen.DataSource = dss.Tables[0].DefaultView;
                    //se especifica el campo de la tabla
                    comboBox_almacen.ValueMember = "Descripcion";
                    P = 0;
                }
            }
        }

        private void CARGA(int P)
        {
            if (P == -1)
            {
                OleDbConnection conexion = new OleDbConnection(ds);

                conexion.Open();               
                string select = "SELECT Descripcion FROM ALMACEN WHERE Rendimiento <=" + 3;
                OleDbCommand cmd = new OleDbCommand(select, conexion);
                try
                {
                    OleDbDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            descripcion = reader.GetString(0);
                            MessageBox.Show(descripcion + " se encuentra sobre el limite permitido te sugerimos que agregues mas producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                    }
                    reader.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexion.Close();
                P = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*progressBar1.Increment(1);
            if (progressBar1.Value == 100)
                timer1.Stop();
                CARGA(P);*/
        }

        private void SELECT_ALMACEN(string tipo)
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT Id,Descripcion,Rendimiento FROM ALMACEN WHERE tipo ='"+tipo+"'", ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView_almacen.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elemntos = new ListViewItem(filas["Id"].ToString());
                elemntos.SubItems.Add(filas["Descripcion"].ToString());                
                elemntos.SubItems.Add(filas["Rendimiento"].ToString());

                listView_almacen.Items.Add(elemntos);
            }           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetDefaultCulture(new CultureInfo("es-MX"));

            BUSCAR(comboBox_almacen.Text);

            //checar cuanto es lo que tiene de peso respecto a la descripcion
            OleDbConnection conexion4 = new OleDbConnection(ds);

            conexion4.Open();
            string sql = "select Peso,Rendimiento from ALMACEN WHERE Descripcion='" + comboBox_almacen.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion4);
            try
            {
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        peso = reader.GetDouble(0);
                        peso3 = reader.GetDouble(1);
                    }
                }
                else
                {
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conexion4.Close();

            //Realizando la suma para aser la modificacion
            
            suma = peso - cantidad;
            
            suma2 = peso3 - rendimiento;

            if (suma < 0 || suma2 < 0)
            {
                //cantidad
                if (suma < 0)
                {
                    suma = 0;
                }

                //rendimiento
                if (suma2 < 0)
                {
                    suma2 = 0;
                }
            }

            //realizando la consulta
            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string insertar = "UPDATE ALMACEN SET Peso = @Peso, Rendimiento= @Rendimiento WHERE Descripcion= '" + comboBox_almacen.Text + "'";
            OleDbCommand cmd3 = new OleDbCommand(insertar, conexion);
            cmd3.Parameters.AddWithValue("@Peso", suma.ToString());
            cmd3.Parameters.AddWithValue("@Rendimiento", suma2.ToString());

            cmd3.ExecuteNonQuery();
            conexion.Close();

            SELECT_ALMACEN(tipo);
        }

        public void BUSCAR(string descripcion)
        {
            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();            
            string select = "SELECT Peso1,Rendimiento1 FROM ALMACEN WHERE Descripcion = '" + descripcion+"'";
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            try
            {
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cantidad = reader.GetDouble(0);
                        rendimiento = reader.GetDouble(1);                        
                    }
                }
                else
                {
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();

            //if (descripcion== "carne c/chile")
            //{
            //    cantidad =525;
            //    rendimiento = 15;
            //}           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            SetDefaultCulture(new CultureInfo("es-MX"));
            BUSCAR(comboBox_almacen.Text);

            //checar cuanto es lo que tiene de peso respecto a la descripcion
            OleDbConnection conexion4 = new OleDbConnection(ds);

            conexion4.Open();
            string sql = "select Peso,Rendimiento from ALMACEN WHERE Descripcion='" + comboBox_almacen.Text + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conexion4);
            try
            {
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        peso = reader.GetDouble(0);
                        peso3 = reader.GetDouble(1);
                    }
                }
                else
                {
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conexion4.Close();

            //Realizando la suma para aser la modificacion
            suma = peso + cantidad;

            suma2 = peso3 + rendimiento;

            //realizando la consulta
            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string insertar = "UPDATE ALMACEN SET Peso = @Peso, Rendimiento= @Rendimiento WHERE Descripcion= '" + comboBox_almacen.Text + "'";
            OleDbCommand cmd3 = new OleDbCommand(insertar, conexion);
            cmd3.Parameters.AddWithValue("@Peso", suma.ToString());
            cmd3.Parameters.AddWithValue("@Rendimiento", suma2.ToString());

            cmd3.ExecuteNonQuery();
            conexion.Close();            

            SELECT_ALMACEN(tipo);

            IForm6 formInterface = this.Owner as IForm6;
            if (formInterface != null)
                formInterface.ACTIVADO(comboBox_almacen.Text);
        }
    }
}
