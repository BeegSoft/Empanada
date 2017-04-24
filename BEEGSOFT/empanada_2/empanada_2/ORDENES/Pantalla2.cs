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
        int orden_1, orden_2, orden_3, orden_4, orden_5,band,dato;

        #region IForm Members

        public void normal(string text, int id)
        {
            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string maximo1 = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
            OleDbCommand cmd31 = new OleDbCommand(maximo1, conexion);
            string valor = Convert.ToInt32(cmd31.ExecuteScalar()).ToString();

            string select = "SELECT COUNT(modificado) FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado =1";
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            string compro = (cmd.ExecuteScalar()).ToString();


            if ((Convert.ToInt32(tabla_1.Items.Count) == 0) || label2.Text == valor)
            {

                tabla_1.Items.Clear();
                textBox1.Text = text;
                orden_1 = id;
                string maximo = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
                OleDbCommand cmd3 = new OleDbCommand(maximo, conexion);
                label2.Text = Convert.ToInt32(cmd3.ExecuteScalar()).ToString();
                
                if ((Convert.ToInt32(compro) == 0) || label2.Text == valor)
                {
                    OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id + " ORDER BY id ASC", ds);

                    DataSet dataset = new DataSet();
                    DataTable tabla = new DataTable();

                    adaptador.Fill(dataset);
                    tabla = dataset.Tables[0];
                    this.tabla_1.Items.Clear();
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        DataRow filas = tabla.Rows[i];
                        ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                        elemntos.SubItems.Add(filas["Platillo"].ToString());
                        elemntos.SubItems.Add(filas["Cantidad"].ToString());

                        tabla_1.Items.Add(elemntos);
                    }

                    string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                    OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                    cmd6.Parameters.AddWithValue("@modificado", 0);

                    cmd6.ExecuteNonQuery();
                }
                else
                {
                    OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado =1 ORDER BY id ASC", ds);

                    DataSet dataset = new DataSet();
                    DataTable tabla = new DataTable();

                    adaptador.Fill(dataset);
                    tabla = dataset.Tables[0];
                    this.tabla_1.Items.Clear();
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        DataRow filas = tabla.Rows[i];
                        ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                        elemntos.SubItems.Add(filas["Platillo"].ToString());
                        elemntos.SubItems.Add(filas["Cantidad"].ToString());

                        tabla_1.Items.Add(elemntos);
                    }

                    string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                    OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                    cmd6.Parameters.AddWithValue("@modificado", 0);

                    cmd6.ExecuteNonQuery();
                }

            }
            else
            {
                if ((Convert.ToInt32(tabla_2.Items.Count) == 0) || label3.Text == valor)
                {
                    tabla_2.Items.Clear();
                    textBox2.Text = text;
                    orden_2 = id;
                    string maximo = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
                    OleDbCommand cmd3 = new OleDbCommand(maximo, conexion);
                    label3.Text = Convert.ToInt32(cmd3.ExecuteScalar()).ToString();
                    if ((Convert.ToInt32(compro) == 0) || label3.Text == valor)
                    {
                        OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id + " ORDER BY id ASC", ds);

                        DataSet dataset = new DataSet();
                        DataTable tabla = new DataTable();

                        adaptador.Fill(dataset);
                        tabla = dataset.Tables[0];
                        this.tabla_2.Items.Clear();
                        for (int i = 0; i < tabla.Rows.Count; i++)
                        {
                            DataRow filas = tabla.Rows[i];
                            ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                            elemntos.SubItems.Add(filas["Platillo"].ToString());
                            elemntos.SubItems.Add(filas["Cantidad"].ToString());

                            tabla_2.Items.Add(elemntos);
                        }
                        string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                        OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                        cmd6.Parameters.AddWithValue("@modificado", 0);

                        cmd6.ExecuteNonQuery();
                    }
                    else
                    {
                        OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado =1 ORDER BY id ASC", ds);

                        DataSet dataset = new DataSet();
                        DataTable tabla = new DataTable();

                        adaptador.Fill(dataset);
                        tabla = dataset.Tables[0];
                        this.tabla_2.Items.Clear();
                        for (int i = 0; i < tabla.Rows.Count; i++)
                        {
                            DataRow filas = tabla.Rows[i];
                            ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                            elemntos.SubItems.Add(filas["Platillo"].ToString());
                            elemntos.SubItems.Add(filas["Cantidad"].ToString());

                            tabla_2.Items.Add(elemntos);
                        }

                        string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                        OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                        cmd6.Parameters.AddWithValue("@modificado", 0);

                        cmd6.ExecuteNonQuery();
                    }
                }
                else
                {
                    if ((Convert.ToInt32(tabla_3.Items.Count) == 0) || label4.Text == valor)
                    {
                        tabla_3.Items.Clear();
                        textBox3.Text = text;
                        orden_3 = id;
                        string maximo = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
                        OleDbCommand cmd3 = new OleDbCommand(maximo, conexion);
                        label4.Text = Convert.ToInt32(cmd3.ExecuteScalar()).ToString();

                        if ((Convert.ToInt32(compro) == 0) || label4.Text == valor)
                        {
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id + " ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_3.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_3.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }
                        else
                        {
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado =1 ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_3.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_3.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        if ((Convert.ToInt32(tabla_4.Items.Count) == 0) || label5.Text == valor)
                        {
                            tabla_4.Items.Clear();
                            textBox4.Text = text;
                            orden_4 = id;
                            string maximo = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
                            OleDbCommand cmd3 = new OleDbCommand(maximo, conexion);
                            label5.Text = Convert.ToInt32(cmd3.ExecuteScalar()).ToString();

                            if ((Convert.ToInt32(compro) == 0) || label5.Text == valor)
                            {
                                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id + " ORDER BY id ASC", ds);

                                DataSet dataset = new DataSet();
                                DataTable tabla = new DataTable();

                                adaptador.Fill(dataset);
                                tabla = dataset.Tables[0];
                                this.tabla_4.Items.Clear();
                                for (int i = 0; i < tabla.Rows.Count; i++)
                                {
                                    DataRow filas = tabla.Rows[i];
                                    ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                    elemntos.SubItems.Add(filas["Platillo"].ToString());
                                    elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                    tabla_4.Items.Add(elemntos);
                                }

                                string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                                OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                                cmd6.Parameters.AddWithValue("@modificado", 0);

                                cmd6.ExecuteNonQuery();
                            }
                            else
                            {
                                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado =1 ORDER BY id ASC", ds);

                                DataSet dataset = new DataSet();
                                DataTable tabla = new DataTable();

                                adaptador.Fill(dataset);
                                tabla = dataset.Tables[0];
                                this.tabla_4.Items.Clear();
                                for (int i = 0; i < tabla.Rows.Count; i++)
                                {
                                    DataRow filas = tabla.Rows[i];
                                    ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                    elemntos.SubItems.Add(filas["Platillo"].ToString());
                                    elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                    tabla_4.Items.Add(elemntos);
                                }

                                string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                                OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                                cmd6.Parameters.AddWithValue("@modificado", 0);

                                cmd6.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            if ((Convert.ToInt32(tabla_5.Items.Count) == 0) || label6.Text == valor)
                            {
                                tabla_5.Items.Clear();
                                textBox5.Text = text;
                                orden_5 = id;
                                string maximo = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
                                OleDbCommand cmd3 = new OleDbCommand(maximo, conexion);
                                label6.Text = Convert.ToInt32(cmd3.ExecuteScalar()).ToString();

                                if ((Convert.ToInt32(compro) == 0) || label6.Text == valor)
                                {
                                    OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id + " ORDER BY id ASC", ds);

                                    DataSet dataset = new DataSet();
                                    DataTable tabla = new DataTable();

                                    adaptador.Fill(dataset);
                                    tabla = dataset.Tables[0];
                                    this.tabla_5.Items.Clear();
                                    for (int i = 0; i < tabla.Rows.Count; i++)
                                    {
                                        DataRow filas = tabla.Rows[i];
                                        ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                        elemntos.SubItems.Add(filas["Platillo"].ToString());
                                        elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                        tabla_5.Items.Add(elemntos);
                                    }

                                    string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                                    OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                                    cmd6.Parameters.AddWithValue("@modificado", 0);

                                    cmd6.ExecuteNonQuery();
                                }
                                else
                                {
                                    OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado = 1 ORDER BY id ASC", ds);

                                    DataSet dataset = new DataSet();
                                    DataTable tabla = new DataTable();

                                    adaptador.Fill(dataset);
                                    tabla = dataset.Tables[0];
                                    this.tabla_5.Items.Clear();
                                    for (int i = 0; i < tabla.Rows.Count; i++)
                                    {
                                        DataRow filas = tabla.Rows[i];
                                        ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                        elemntos.SubItems.Add(filas["Platillo"].ToString());
                                        elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                        tabla_5.Items.Add(elemntos);
                                    }

                                    string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                                    OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                                    cmd6.Parameters.AddWithValue("@modificado", 0);

                                    cmd6.ExecuteNonQuery();
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
            conexion.Close();
        }

        public void ChangeTextBoxText(string text, int id)
        {
            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string maximo1 = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
            OleDbCommand cmd31 = new OleDbCommand(maximo1, conexion);
            string valor = Convert.ToInt32(cmd31.ExecuteScalar()).ToString();

            string select = "SELECT COUNT(modificado) FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado =1";
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            string compro = (cmd.ExecuteScalar()).ToString();

            if (textBox1.Text == text)
            {
                dato = 1;
            }
            if (textBox2.Text == text )
            {
                dato = 2;
            }
            if (textBox3.Text == text)
            {
                dato = 3;
            }
            if (textBox4.Text == text)
            {
                dato = 4;
            }
            if (textBox5.Text == text)
            {
                dato = 5;
            }
            
            switch (dato)
            {
                case 1 :
                    if ((Convert.ToInt32(tabla_1.Items.Count) == 0) || label2.Text == valor)
                    {

                        tabla_1.Items.Clear();
                        textBox1.Text = text;
                        orden_1 = id;
                        string maximo = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
                        OleDbCommand cmd3 = new OleDbCommand(maximo, conexion);
                        label2.Text = Convert.ToInt32(cmd3.ExecuteScalar()).ToString();

                        if ((Convert.ToInt32(compro) == 0) || label2.Text == valor)
                        {                          
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id + " ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_1.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_1.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }
                        else
                        {
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado =1 ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_1.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_1.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }

                    }
                    break;

                case 2:
                    if ((Convert.ToInt32(tabla_2.Items.Count) == 0) || label3.Text == valor)
                    {
                        tabla_2.Items.Clear();
                        textBox2.Text = text;
                        orden_2 = id;
                        string maximo = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
                        OleDbCommand cmd3 = new OleDbCommand(maximo, conexion);
                        label3.Text = Convert.ToInt32(cmd3.ExecuteScalar()).ToString();
                        if ((Convert.ToInt32(compro) == 0) || label3.Text == valor)
                        {
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id + " ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_2.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_2.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }
                        else
                        {
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado =1 ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_2.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_2.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }
                    }
                    break;

                case 3:
                    if ((Convert.ToInt32(tabla_3.Items.Count) == 0) || label4.Text == valor)
                    {
                        tabla_3.Items.Clear();
                        textBox3.Text = text;
                        orden_3 = id;
                        string maximo = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
                        OleDbCommand cmd3 = new OleDbCommand(maximo, conexion);
                        label4.Text = Convert.ToInt32(cmd3.ExecuteScalar()).ToString();

                        if ((Convert.ToInt32(compro) == 0) || label4.Text == valor)
                        {
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id + " ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_3.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_3.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }
                        else
                        {
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado =1 ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_3.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_3.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }
                    }
                    break;

                case 4:
                    if ((Convert.ToInt32(tabla_4.Items.Count) == 0) || label5.Text == valor)
                    {
                        tabla_4.Items.Clear();
                        textBox4.Text = text;
                        orden_4 = id;
                        string maximo = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
                        OleDbCommand cmd3 = new OleDbCommand(maximo, conexion);
                        label5.Text = Convert.ToInt32(cmd3.ExecuteScalar()).ToString();

                        if ((Convert.ToInt32(compro) == 0) || label5.Text == valor)
                        {
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id + " ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_4.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_4.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }
                        else
                        {
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado =1 ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_4.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_4.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }
                    }
                    break;

                case 5:
                    if ((Convert.ToInt32(tabla_5.Items.Count) == 0) || label6.Text == valor)
                    {
                        tabla_5.Items.Clear();
                        textBox5.Text = text;
                        orden_5 = id;
                        string maximo = "SELECT Num_orden FROM ORDEN WHERE id_orden= " + id + " AND fecha ='" + fecha + "'";
                        OleDbCommand cmd3 = new OleDbCommand(maximo, conexion);
                        label6.Text = Convert.ToInt32(cmd3.ExecuteScalar()).ToString();

                        if ((Convert.ToInt32(compro) == 0) || label6.Text == valor)
                        {
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden = " + id + " ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_5.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_5.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }
                        else
                        {
                            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_orden, Platillo, Cantidad FROM VISUALIZADO WHERE id_orden=" + id + " AND modificado = 1 ORDER BY id ASC", ds);

                            DataSet dataset = new DataSet();
                            DataTable tabla = new DataTable();

                            adaptador.Fill(dataset);
                            tabla = dataset.Tables[0];
                            this.tabla_5.Items.Clear();
                            for (int i = 0; i < tabla.Rows.Count; i++)
                            {
                                DataRow filas = tabla.Rows[i];
                                ListViewItem elemntos = new ListViewItem(filas["id_orden"].ToString());
                                elemntos.SubItems.Add(filas["Platillo"].ToString());
                                elemntos.SubItems.Add(filas["Cantidad"].ToString());

                                tabla_5.Items.Add(elemntos);
                            }

                            string insertar6 = "UPDATE VISUALIZADO SET modificado = @modificado WHERE id_orden = " + id;
                            OleDbCommand cmd6 = new OleDbCommand(insertar6, conexion);
                            cmd6.Parameters.AddWithValue("@modificado", 0);

                            cmd6.ExecuteNonQuery();
                        }
                    }
                    break;

                default:
                    normal(text, id);
                    break;
            }


            
            conexion.Close();
        }
        #endregion

        #region Terminar_orden Members

        public void orden1()
        {
            tabla_1.Items.Clear();
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
            tabla_2.Items.Clear();
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
            tabla_3.Items.Clear();
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
            tabla_4.Items.Clear();
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
            tabla_5.Items.Clear();
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
