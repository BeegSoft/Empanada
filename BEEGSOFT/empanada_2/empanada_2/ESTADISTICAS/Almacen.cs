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

        string ds, peso, peso3, descripcion;
        double suma,suma2, peso2,cantidad;
        public int P=0,rendimiento;

        private void Almacen_Activated(object sender, EventArgs e)
        {
            if (P == 0)
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

        private void Almacen_Load(object sender, EventArgs e)
        {
            //cuando p=0 es que no es mandado del index o de otra pantalla
            if (P == 0)
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

                //ESTE ES EL QUE VAS A QUITAR SI FUNCIONA EL PROGRESSBAR
                //P = -1;
                //CARGA(P);
            }
            // si p=1 es por que e esta mandando del index cuando se carga
            else if(P==1)
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
                P = 0;
            }            
        }

        private void CARGA(int P)
        {
            if (P == -1)
            {
                OleDbConnection conexion = new OleDbConnection(ds);

                conexion.Open();
                peso2 = 90;
                string select = "SELECT Descripcion FROM ALMACEN WHERE Peso <=" + peso2;
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

            BUSCAR(comboBox_almacen.Text);

            //checar cuanto es lo que tiene de peso respecto a la descripcion
            OleDbConnection conexion4 = new OleDbConnection(ds);

            conexion4.Open();

            string sql = "select Peso from ALMACEN WHERE Descripcion='" + comboBox_almacen.Text + "'";
            OleDbCommand cmd2 = new OleDbCommand(sql, conexion4); //Conexion es tu objeto conexion

            peso = (cmd2.ExecuteScalar()).ToString();

            string sql2 = "select Rendimiento from ALMACEN WHERE Descripcion='" + comboBox_almacen.Text + "'";
            OleDbCommand cmd1 = new OleDbCommand(sql2, conexion4); //Conexion es tu objeto conexion

            peso3 = (cmd1.ExecuteScalar()).ToString();

            conexion4.Close();

            //Realizando la suma para aser la modificacion
            suma = (double.Parse(peso, Thread.CurrentThread.CurrentCulture)) - cantidad;

            suma2 = (double.Parse(peso3, Thread.CurrentThread.CurrentCulture)) - rendimiento;

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

            SELECT_ALMACEN();
        }

        public void BUSCAR(string descripcion)
        {
            if(descripcion== "carne c/chile")
            {
                cantidad =525;
                rendimiento = 15;
            }
            if (descripcion == "cochinita")
            {
                cantidad = 450;
                rendimiento = 15;
            }
            if (descripcion == "nopal")
            {
                cantidad = 360;
                rendimiento = 8;
            }
            if (descripcion == "tinga de pollo")
            {
                cantidad = 525;
                rendimiento = 15;
            }
            if (descripcion == "frijol c/queso")
            {
                cantidad = 450;
                rendimiento = 10;
            }
            if (descripcion == "rajas c/queso")
            {
                cantidad = 675;
                rendimiento = 15;
            }
            if (descripcion == "picadillo")
            {
                cantidad = 400;
                rendimiento = 10;
            }
            if (descripcion == "chicharron s/r")
            {
                cantidad = 525;
                rendimiento = 15;
            }
            if (descripcion == "chicharron s/v")
            {
                cantidad = 525;
                rendimiento = 15;
            }

            //lo nuevo que se metio
            if (descripcion == "chicharron deshebrado")
            {
                cantidad = 525;
                rendimiento = 15;
            }
            if (descripcion == "chicharron crujiente")
            {
                cantidad = 525;
                rendimiento = 15;
            }
            if (descripcion == "queso")
            {
                cantidad = 525;
                rendimiento = 15;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetDefaultCulture(new CultureInfo("es-MX"));

            BUSCAR(comboBox_almacen.Text);            
            
            //checar cuanto es lo que tiene de peso respecto a la descripcion
            OleDbConnection conexion4 = new OleDbConnection(ds);

            conexion4.Open();

            string sql = "select Peso from ALMACEN WHERE Descripcion='" + comboBox_almacen.Text + "'";
            OleDbCommand cmd2 = new OleDbCommand(sql, conexion4); //Conexion es tu objeto conexion

            peso = (cmd2.ExecuteScalar()).ToString();

            string sql2 = "select Rendimiento from ALMACEN WHERE Descripcion='" + comboBox_almacen.Text + "'";
            OleDbCommand cmd1 = new OleDbCommand(sql2, conexion4); //Conexion es tu objeto conexion

            peso3= (cmd1.ExecuteScalar()).ToString();

            conexion4.Close();

            //Realizando la suma para aser la modificacion
            suma = (double.Parse(peso, Thread.CurrentThread.CurrentCulture)) + cantidad;

            suma2 = (double.Parse(peso3, Thread.CurrentThread.CurrentCulture)) + rendimiento;

            //realizando la consulta
            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string insertar = "UPDATE ALMACEN SET Peso = @Peso, Rendimiento= @Rendimiento WHERE Descripcion= '" + comboBox_almacen.Text + "'";
            OleDbCommand cmd3 = new OleDbCommand(insertar, conexion);
            cmd3.Parameters.AddWithValue("@Peso", suma.ToString());
            cmd3.Parameters.AddWithValue("@Rendimiento", suma2.ToString());

            cmd3.ExecuteNonQuery();
            conexion.Close();

            SELECT_ALMACEN();

            IForm6 formInterface = this.Owner as IForm6;
            if (formInterface != null)
                formInterface.ACTIVADO(comboBox_almacen.Text);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
