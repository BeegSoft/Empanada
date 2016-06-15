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
        }

        string ds, peso;
        double suma;


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


        private void Almacen_Load(object sender, EventArgs e)
        {
            SELECT_ALMACEN();

            DataSet dss = new DataSet();
            //indicamos la consulta en SQL
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT Descripcion FROM ALMACEN", ds);
            //se indica el nombre de la tabla
            da.Fill(dss, "Descripcion");
            comboBox_almacen.DataSource = dss.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            comboBox_almacen.ValueMember = "Descripcion";
        }

        private void SELECT_ALMACEN()
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT Id,Descripcion,Peso,Rendimiento FROM ALMACEN", ds);

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
                elemntos.SubItems.Add(filas["Peso"].ToString());
                elemntos.SubItems.Add(filas["Rendimiento"].ToString());

                listView_almacen.Items.Add(elemntos);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetDefaultCulture(new CultureInfo("es-MX"));

            if (textBox_almacen.Text == "")
            {
                MessageBox.Show("No has introduccido la informacion necesaria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_almacen.Focus();
            }
            else
            {
                try
                {
                    //checar cuanto es lo que tiene de peso respecto a la descripcion
                    OleDbConnection conexion4 = new OleDbConnection(ds);

                    conexion4.Open();

                    string sql = "select Peso from ALMACEN WHERE Descripcion='" + comboBox_almacen.Text + "'";
                    OleDbCommand cmd2 = new OleDbCommand(sql, conexion4); //Conexion es tu objeto conexion

                    peso = (cmd2.ExecuteScalar()).ToString();
                    

                    conexion4.Close();

                    //Realizando la resta para aser la modificacion
                    suma = (double.Parse(peso, Thread.CurrentThread.CurrentCulture)) - (double.Parse(textBox_almacen.Text, Thread.CurrentThread.CurrentCulture));
                    

                    //realizando la consulta
                    OleDbConnection conexion = new OleDbConnection(ds);

                    conexion.Open();

                    string insertar = "UPDATE ALMACEN SET Peso = @Peso WHERE Descripcion= '" + comboBox_almacen.Text + "'";
                    OleDbCommand cmd3 = new OleDbCommand(insertar, conexion);
                    cmd3.Parameters.AddWithValue("@Peso", suma.ToString());

                    cmd3.ExecuteNonQuery();
                    conexion.Close();

                    SELECT_ALMACEN();
                }
                catch { }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetDefaultCulture(new CultureInfo("es-MX"));

            if (textBox_almacen.Text == "")
            {
                MessageBox.Show("No has introduccido la informacion necesaria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_almacen.Focus();
            }
            else
            {
                try
                {
                    //checar cuanto es lo que tiene de peso respecto a la descripcion
                    OleDbConnection conexion4 = new OleDbConnection(ds);

                    conexion4.Open();

                    string sql = "select Peso from ALMACEN WHERE Descripcion='" + comboBox_almacen.Text + "'";
                    OleDbCommand cmd2 = new OleDbCommand(sql, conexion4); //Conexion es tu objeto conexion

                    peso = (cmd2.ExecuteScalar()).ToString();
                    
                    conexion4.Close();

                    //Realizando la suma para aser la modificacion
                    suma = (double.Parse(peso, Thread.CurrentThread.CurrentCulture)) + (double.Parse(textBox_almacen.Text, Thread.CurrentThread.CurrentCulture));                    

                    //realizando la consulta
                    OleDbConnection conexion = new OleDbConnection(ds);

                    conexion.Open();

                    string insertar = "UPDATE ALMACEN SET Peso = @Peso WHERE Descripcion= '" +comboBox_almacen.Text +"'";
                    OleDbCommand cmd3 = new OleDbCommand(insertar, conexion);
                    cmd3.Parameters.AddWithValue("@Peso", suma.ToString());

                    cmd3.ExecuteNonQuery();
                    conexion.Close();

                    SELECT_ALMACEN();
                }
                catch { }
            }
        }
    }
}
