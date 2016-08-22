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

namespace empanada_2
{
    public partial class Pantalla2 : Form, IForm, Terminar_orden, IForm7
    {
        public Pantalla2(string fecha, string ds,int band,string operador)
        {
            InitializeComponent();
            this.ds = ds;
            this.fecha = fecha;
            this.band = band;
            this.operador = operador;
        }
        
        string ds, fecha,operador;
        int orden_1, orden_2, orden_3, orden_4, orden_5,band;

        #region IForm Members

        public void ChangeTextBoxText(string text, int id)
        {
            if (Convert.ToInt32(listView_platillos.Items.Count) == 0)
            {
                textBox1.Text = text;
                orden_1 = id;
                label2.Text = id.ToString();
                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id, ds);

                DataSet dataset = new DataSet();
                DataTable tabla = new DataTable();

                adaptador.Fill(dataset);
                tabla = dataset.Tables[0];
                this.listView_platillos.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                    elemntos.SubItems.Add(filas["Platillo"].ToString());
                    elemntos.SubItems.Add(filas["Cantidad"].ToString());

                    listView_platillos.Items.Add(elemntos);
                }
            }
            else
            {
                if (Convert.ToInt32(listView1.Items.Count) == 0)
                {
                    textBox2.Text = text;
                    orden_2 = id;
                    label3.Text = id.ToString();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id, ds);

                    DataSet dataset = new DataSet();
                    DataTable tabla = new DataTable();

                    adaptador.Fill(dataset);
                    tabla = dataset.Tables[0];
                    this.listView1.Items.Clear();
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        DataRow filas = tabla.Rows[i];
                        ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                        elemntos.SubItems.Add(filas["Platillo"].ToString());
                        elemntos.SubItems.Add(filas["Cantidad"].ToString());

                        listView1.Items.Add(elemntos);
                    }
                }
                else
                {
                    if (Convert.ToInt32(listView2.Items.Count) == 0)
                    {
                        textBox3.Text = text;
                        orden_3 = id;
                        label4.Text = id.ToString();
                        OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id, ds);

                        DataSet dataset = new DataSet();
                        DataTable tabla = new DataTable();

                        adaptador.Fill(dataset);
                        tabla = dataset.Tables[0];
                        this.listView2.Items.Clear();
                        for (int i = 0; i < tabla.Rows.Count; i++)
                        {
                            DataRow filas = tabla.Rows[i];
                            ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                            elemntos.SubItems.Add(filas["Platillo"].ToString());
                            elemntos.SubItems.Add(filas["Cantidad"].ToString());

                            listView2.Items.Add(elemntos);
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(listView3.Items.Count) == 0)
                        {
                            textBox4.Text = text;
                            orden_4 = id;
                            label5.Text = id.ToString();
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id, ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.listView3.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                listView3.Items.Add(elemntos);
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(listView4.Items.Count) == 0)
                            {
                                textBox5.Text = text;
                                orden_5 = id;
                                label6.Text = id.ToString();
                                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id, ds);

                                DataSet dataset = new DataSet();
                                DataTable tabla = new DataTable();

                                adaptador.Fill(dataset);
                                tabla = dataset.Tables[0];
                                this.listView4.Items.Clear();
                                for (int i = 0; i < tabla.Rows.Count; i++)
                                {
                                    DataRow filas = tabla.Rows[i];
                                    ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                    elemntos.SubItems.Add(filas["Platillo"].ToString());
                                    elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                    listView4.Items.Add(elemntos);
                                }
                            }

                            else
                            {
                                MessageBox.Show("Todos las comandas estan llenas ! ! ", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region Terminar_orden Members

        public void orden1()
        {
            listView_platillos.Items.Clear();
            textBox1.Text = "";
            label2.Text = "0";

            OleDbConnection conexion = new OleDbConnection(ds);
            
            conexion.Open();
            string insertar = "DELETE FROM VISUALIZADO WHERE id_orden = " + orden_1;
            OleDbCommand cmd = new OleDbCommand(insertar, conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void orden2()
        {
            listView1.Items.Clear();
            textBox2.Text = "";
            label3.Text = "0";

            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string insertar = "DELETE FROM VISUALIZADO WHERE id_orden = " + orden_2;
            OleDbCommand cmd = new OleDbCommand(insertar, conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void orden3()
        {
            listView2.Items.Clear();
            textBox3.Text = "";
            label4.Text = "0";

            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string insertar = "DELETE FROM VISUALIZADO WHERE id_orden = " + orden_3;
            OleDbCommand cmd = new OleDbCommand(insertar, conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void orden4()
        {
            listView3.Items.Clear();
            textBox4.Text = "";
            label5.Text = "0";


            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string insertar = "DELETE FROM VISUALIZADO WHERE id_orden = " + orden_4;
            OleDbCommand cmd = new OleDbCommand(insertar, conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void orden5()
        {
            listView4.Items.Clear();
            textBox5.Text = "";
            label6.Text = "0";

            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string insertar = "DELETE FROM VISUALIZADO WHERE id_orden = " + orden_5;   
            OleDbCommand cmd = new OleDbCommand(insertar, conexion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        
        #endregion

        public void Cerrar_sesion()
        {
            this.Close();
        }
        private void Pantalla2cs_Load(object sender, EventArgs e)
        {
            if (band == 3)
            {
                Form1 form = new Form1(fecha, ds,operador);
                form.estadisticasToolStripMenuItem.Visible = false;
                form.gastosToolStripMenuItem.Visible = false;
                form.modificarToolStripMenuItem.Visible = false;              
                form.Show(this);
                
            }
            else
            {
                Form1 form = new Form1(fecha, ds,operador);
                form.Show(this);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            orden1();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            orden2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orden3();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            orden4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            orden5();
        }

    }
}
