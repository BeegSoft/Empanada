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
    public partial class Menu_agregar : Form
    {
        public Menu_agregar(string ds)
        {
            InitializeComponent();
            this.ds = ds;
            this.Size = new Size(196, 112);
        }
        int id,id2;        
        String ds;
        public string tipo;
        //int band = 0;
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
        private void Menu_agregar_Load(object sender, EventArgs e)
        {            
            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string select = "SELECT MAX(id_platillo) FROM MENU";
            OleDbCommand cmd = new OleDbCommand(select, conexion);

            try
            {


                OleDbDataReader reader = cmd.ExecuteReader();

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


            string select1 = "SELECT MAX(Id) FROM ALMACEN";
            OleDbCommand cmd1 = new OleDbCommand(select1, conexion);

            try
            {


                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id2 = reader.GetInt32(0) + 1;
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


            conexion.Close();
        }

        private void INSERT_MENU()
        {
            SetDefaultCulture(new CultureInfo("es-MX"));
            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string insertar = "INSERT INTO MENU(id_platillo, nombre_platillo, precio_platillo, tipo) VALUES (@id_platillo, @nombre_platillo, @precio_platillo, @tipo)";
            OleDbCommand cmd = new OleDbCommand(insertar, conexion);
            cmd.Parameters.AddWithValue("@id_platillo", id);
            cmd.Parameters.AddWithValue("@nombre_platillo", textBox_nombre.Text);
            cmd.Parameters.AddWithValue("@precio_platillo", double.Parse(textBox_precio.Text, Thread.CurrentThread.CurrentCulture));
            cmd.Parameters.AddWithValue("@tipo", tipo);

            cmd.ExecuteNonQuery();
            //MessageBox.Show("Datos agregados correctamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexion.Close();


            conexion.Open();

            string insertar1 = "INSERT INTO ALMACEN(Id,Descripcion,Peso,Rendimiento,descuento,tipo,Peso1,Rendimiento1) VALUES(@Id,@Descripcion,@Peso,@Rendimiento,@descuento,@tipo,@Peso1,@Rendimiento1)";
            OleDbCommand cmd1 = new OleDbCommand(insertar1, conexion);
            cmd1.Parameters.AddWithValue("@Id", id2);
            cmd1.Parameters.AddWithValue("@Descripcion", textBox_nombre.Text);
            cmd1.Parameters.AddWithValue("@Peso", 0);
            cmd1.Parameters.AddWithValue("@Rendimiento", 0);
            cmd1.Parameters.AddWithValue("@descuento", 0);
            cmd1.Parameters.AddWithValue("@tipo", tipo);
            cmd1.Parameters.AddWithValue("@Peso1", 0);
            cmd1.Parameters.AddWithValue("@Rendimiento1", 0);

            cmd1.ExecuteNonQuery();        

            MessageBox.Show("Datos agregados correctamente ahora accede al almacen para agregar producto", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_nombre.TextLength == 0 || textBox_precio.TextLength == 0)
                {
                    MessageBox.Show("Tienes Campos vacios para continuar", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (textBox_nombre.TextLength >= 15)
                    {
                        MessageBox.Show("No pudes poner un nombre muy largo trata de reducirlo o abreviarlo un poco", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_nombre.Clear();
                        textBox_nombre.Focus();
                    }
                    else
                    {
                        try
                        {
                            INSERT_MENU();
                        }

                        catch (DBConcurrencyException ex)
                        {
                            MessageBox.Show("Error de concurrencia:\n" + ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Menu form = new Menu(ds);
                        form.Show();

                        this.Close();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introdujo datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu form = new Menu(ds);
            form.Show();

            this.Close();
        }

        private void textBox_precio_TextChanged(object sender, EventArgs e)
        {
            SetDefaultCulture(new CultureInfo("es-MX"));
            double cal;
            try
            {
                if (textBox_precio.Text == "")
                {
                    cal = 0;
                }
                else
                {
                    cal = double.Parse(textBox_precio.Text, Thread.CurrentThread.CurrentCulture);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Introdujo datos incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_precio.Text = "";
                textBox_precio.Focus();
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {           
            tipo = "platillo";
            this.Size = new Size(437, 245);
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {           
            tipo = "bebida";
            this.Size = new Size(437, 245);
        }
    }
}
