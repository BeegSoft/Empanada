﻿using System;
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
    public partial class Gastos : Form
    {
        public Gastos(string ds)
        {
            InitializeComponent();
            this.ds = ds;            
            label2.Visible = false;
            label1.Visible = false;
            dateTimePicker1.Visible = false;
            listView_fechas.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        string ds, fecha;
        int id;

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

        private void Gastos_Load(object sender, EventArgs e)
        {
            textBox_descripcion.Focus();

            fecha = DateTime.Now.ToShortDateString();

            label_fecha.Text = DateTime.Now.ToShortDateString();



            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT FECHA.fecha FROM FECHA ORDER BY FECHA.id ASC", ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView_fechas.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["fecha"].ToString());
                listView_fechas.Items.Add(elementos);
            }

            SELECT_GASTOS();
            SUMA_GASTOS();
            GANANCIAS();
        }

        private void SELECT_GASTOS()
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT id_gastos, Fecha, Descripcion, Gasto FROM GASTOS WHERE fecha = '" + fecha + "'", ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView_gastos.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["id_gastos"].ToString());
                elementos.SubItems.Add(filas["Fecha"].ToString());
                elementos.SubItems.Add(filas["Descripcion"].ToString());
                elementos.SubItems.Add(filas["Gasto"].ToString());

                listView_gastos.Items.Add(elementos);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        double ventas, gastos;
        double ganancias;

        private void GANANCIAS()
        {
            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string select = "SELECT Venta_total, Gastos FROM FECHA WHERE fecha= '"+fecha+"'";
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            try
            {
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ventas = reader.GetDouble(0);
                        gastos = reader.GetDouble(1);
                        ganancias = ventas - gastos;                      
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //ACTUALIZAR LAS GANANCIAS
            string actualizar = "UPDATE FECHA SET Ganancia = @Ganancia WHERE fecha = '" + fecha + "'";
            OleDbCommand cmd3 = new OleDbCommand(actualizar, conexion);
            cmd3.Parameters.AddWithValue("@Ganancia", ganancias.ToString());

            cmd3.ExecuteNonQuery();

            conexion.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conexion = new OleDbConnection(ds);

                conexion.Open();
                if ((textBox_descripcion.Text == "") || (textBox_gasto.Text == ""))
                {
                    MessageBox.Show("No has introduccido la informacion necesaria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_descripcion.Focus();
                }
                else
                {

                    string select = "SELECT MAX(Id_gastos) FROM GASTOS";
                    OleDbCommand cmd1 = new OleDbCommand(select, conexion);

                    try
                    {


                        OleDbDataReader reader = cmd1.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id = reader.GetInt32(0) + 1;

                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        reader.Close();



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error orden" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                    string insertar = "INSERT INTO GASTOS (Id_gastos, Fecha, Descripcion, Gasto) VALUES (@Id_gastos, @Fecha, @Descripcion, @Gasto)";
                    OleDbCommand cmd = new OleDbCommand(insertar, conexion);
                    cmd.Parameters.AddWithValue("@Id_gastos", id);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Descripcion", textBox_descripcion.Text);
                    cmd.Parameters.AddWithValue("@Gasto", textBox_gasto.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos agregados correctamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Close();

                    SELECT_GASTOS();

                    SUMA_GASTOS();

                    GANANCIAS();

                    textBox_descripcion.Clear();
                    textBox_gasto.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introdujo datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_gasto.Focus();
            }            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Visible = false;
                label1.Visible = true;
                dateTimePicker1.Visible = true;
                listView_fechas.Visible = false;
                button2.Visible = true;
                button3.Visible = false;
                listView_gastos.Items.Clear();
            }
            else
            {
                label2.Visible = false;
                label1.Visible = false;
                dateTimePicker1.Visible = false;
                listView_fechas.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }            
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label2.Visible = true;
                label1.Visible = false;
                dateTimePicker1.Visible = false;
                listView_fechas.Visible = true;
                button2.Visible = false;
                button3.Visible = true;
                listView_gastos.Items.Clear();
            }
            else
            {
                label2.Visible = false;
                label1.Visible = false;
                dateTimePicker1.Visible = false;
                listView_fechas.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fecha = dateTimePicker1.Text;
            label_fecha.Text = fecha;
            textBox_descripcion.Focus();
            SELECT_GASTOS();
            SUMA_GASTOS();
            GANANCIAS();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView_fechas.SelectedItems)
            {
                fecha = lista.Text;
                label_fecha.Text = fecha;
            }
            textBox_descripcion.Focus();
            SELECT_GASTOS();
            SUMA_GASTOS();
            GANANCIAS();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView_gastos.SelectedItems)
            {
                int id = Convert.ToInt32(lista.Text);


                DialogResult resultado = MessageBox.Show("Esta seguro de borrarlo de los gastos?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        OleDbConnection conexion = new OleDbConnection(ds);

                        conexion.Open();
                        string insertar = "DELETE FROM GASTOS WHERE Id_gastos = " + id;
                        OleDbCommand cmd = new OleDbCommand(insertar, conexion);

                        cmd.ExecuteNonQuery();
                        conexion.Close();

                    }
                    catch (DBConcurrencyException ex)
                    {
                        MessageBox.Show("Error de concurrencia:\n" + ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    lista.Remove();
                }
                else if (resultado == DialogResult.No)
                {

                }
            }

            SELECT_GASTOS();
            SUMA_GASTOS();
            GANANCIAS();
        }

        private void textBox_gasto_TextChanged(object sender, EventArgs e)
        {
            SetDefaultCulture(new CultureInfo("es-MX"));
            double cal;
            try
            {
                if (textBox_gasto.Text == "")
                {
                    cal = 0;
                }
                else
                {
                    cal = double.Parse(textBox_gasto.Text, Thread.CurrentThread.CurrentCulture);
                }                          
            }
            catch(FormatException)
            {
                MessageBox.Show("Introdujo datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_gasto.Text="";                
                textBox_gasto.Focus();
            }
        }

        private void SUMA_GASTOS()
        {
            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();
            
            
            //SUMAR TODOS LOS GASTOS

            string sql = "select SUM(Gasto) from GASTOS WHERE Fecha = '" + fecha + "'";
            OleDbCommand cmd2 = new OleDbCommand(sql, conexion); //Conexion es tu objeto conexion                                            

            string suma_gasto = ((cmd2.ExecuteScalar()).ToString());
            if (suma_gasto == "")
            {
                suma_gasto = "0";
            }            
            //-------------------
            textBox_total.Text = suma_gasto;

            //ACTUALIZAR LOS GASTOS DE LA FECHA

            string actualizar = "UPDATE FECHA SET Gastos = @Gastos WHERE fecha = '" + fecha + "'";
            OleDbCommand cmd3 = new OleDbCommand(actualizar, conexion);
            cmd3.Parameters.AddWithValue("@Gastos", suma_gasto);

            cmd3.ExecuteNonQuery();

            conexion.Close();
        }

        private void textBox_total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
