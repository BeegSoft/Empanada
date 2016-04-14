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
    public partial class Pantalla2 : Form, IForm
    {
        public Pantalla2(string fecha, string ds)
        {
            InitializeComponent();
            this.ds = ds;
            this.fecha = fecha;
        }
        
        string ds, fecha;
        #region IForm Members

        public void ChangeTextBoxText(string text, int id)
        {
            if (Convert.ToInt32(listView_platillos.Items.Count) == 0)
            {
                TextBox1.Text = text;

                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT nombre_platillo,cantidad FROM PLATILLO WHERE id_orden = " + id, ds);

                DataSet dataset = new DataSet();
                DataTable tabla = new DataTable();

                adaptador.Fill(dataset);
                tabla = dataset.Tables[0];
                this.listView_platillos.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elemntos = new ListViewItem(filas["nombre_platillo"].ToString());
                    elemntos.SubItems.Add(filas["cantidad"].ToString());

                    listView_platillos.Items.Add(elemntos);
                }
            }
            else
            {
                if (Convert.ToInt32(listView1.Items.Count) == 0)
                {
                    TextBox1.Text = text;

                    OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT nombre_platillo,cantidad FROM PLATILLO WHERE id_orden = " + id, ds);

                    DataSet dataset = new DataSet();
                    DataTable tabla = new DataTable();

                    adaptador.Fill(dataset);
                    tabla = dataset.Tables[0];
                    this.listView1.Items.Clear();
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        DataRow filas = tabla.Rows[i];
                        ListViewItem elemntos = new ListViewItem(filas["nombre_platillo"].ToString());
                        elemntos.SubItems.Add(filas["cantidad"].ToString());

                        listView1.Items.Add(elemntos);
                    }
                }
                else
                {
                    if (Convert.ToInt32(listView2.Items.Count) == 0)
                    {
                        TextBox1.Text = text;

                        OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT nombre_platillo,cantidad FROM PLATILLO WHERE id_orden = " + id, ds);

                        DataSet dataset = new DataSet();
                        DataTable tabla = new DataTable();

                        adaptador.Fill(dataset);
                        tabla = dataset.Tables[0];
                        this.listView2.Items.Clear();
                        for (int i = 0; i < tabla.Rows.Count; i++)
                        {
                            DataRow filas = tabla.Rows[i];
                            ListViewItem elemntos = new ListViewItem(filas["nombre_platillo"].ToString());
                            elemntos.SubItems.Add(filas["cantidad"].ToString());

                            listView2.Items.Add(elemntos);
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(listView3.Items.Count) == 0)
                        {
                            TextBox1.Text = text;

                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT nombre_platillo,cantidad FROM PLATILLO WHERE id_orden = " + id, ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.listView3.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["nombre_platillo"].ToString());
                                elemntos.SubItems.Add(filas["cantidad"].ToString());

                                listView3.Items.Add(elemntos);
                            }
                        }
                        else
                        {
                            if (Convert.ToInt32(listView4.Items.Count) == 0)
                            {
                                TextBox1.Text = text;

                                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT nombre_platillo,cantidad FROM PLATILLO WHERE id_orden = " + id, ds);

                                DataSet dataset = new DataSet();
                                DataTable tabla = new DataTable();

                                adaptador.Fill(dataset);
                                tabla = dataset.Tables[0];
                                this.listView4.Items.Clear();
                                for (int i = 0; i < tabla.Rows.Count; i++)
                                {
                                    DataRow filas = tabla.Rows[i];
                                    ListViewItem elemntos = new ListViewItem(filas["nombre_platillo"].ToString());
                                    elemntos.SubItems.Add(filas["cantidad"].ToString());

                                    listView4.Items.Add(elemntos);
                                }
                            }

                            else
                            {
                                MessageBox.Show("Todos las comandas estan llenas ! ! ");
                            }
                        }
                    }
                }
            }


            
        }

        #endregion

        private void Pantalla2cs_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1(fecha, ds);
            form.Show(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listView_platillos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
