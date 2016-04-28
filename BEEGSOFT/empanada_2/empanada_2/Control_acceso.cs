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
using System.Threading;

namespace empanada_2
{
    public partial class Control_acceso : Form
    {
        public Control_acceso(string ds)
        {
            //---------
            Thread t = new Thread(new ThreadStart(splashtart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            //---------
            this.ds = ds;


        }

        private void splashtart()
        {
            Application.Run(new Form2(ds));
        }

        private void LIMPIAR()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "SELECCIONAR";
        }
        
        string ds;

        string texto;
        int band;              

        int veces = 0;
        private const int intentos = 2;

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "SELECCIONAR")
            {
                MessageBox.Show("Seleccione Tipo de Usuario", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }                                 

            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite Usuario para Continuar", "conexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Digite Clave para Continuar", "conexion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox2.Focus();
            }            
            else
            {
                //checamos la encriptacion
                string var1;
                var1 = Encriptado.Encriptar(textBox2.Text);
                //--------               

                OleDbConnection conexion = new OleDbConnection(ds);
                conexion.Open();
                string select="SELECT * FROM USUARIOS where USUARIOS.nombre='" + textBox1.Text + "'and USUARIOS.clave='" + var1 + "'and USUARIOS.tipo_usuario='" + comboBox1.Text + "'";
                OleDbCommand cmd6 = new OleDbCommand(select, conexion);
                try
                {
                    OleDbDataReader reader = cmd6.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            MessageBox.Show("Usuario Aceptado", "Empanada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Inicio form = new Inicio(ds);
                            LIMPIAR();
                            form.Show();
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Su Usuario o Contraseña o Tipo NO Coinciden o son Erroneas \n \n                        Le Quedan " + (intentos - veces) + " Intento(s)", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LIMPIAR();
                        veces = veces + 1;                        
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error orden" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            if (veces == 2)
            {
                MessageBox.Show("Has excedido el limite permitido ", "conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            band = 0;
            if (this.textBox1.Text == "SELECCIONAR")
            {
                MessageBox.Show("Para Agregar un usuario tienes que identificarte", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }            

            else if (textBox2.Text == "")
            {
                MessageBox.Show("Para Agregar un usuario tienes que identificarte", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Para Agregar un usuario tienes que identificarte", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
            else
            {
                //checamos la encriptacion
                string var1;
                var1 = Encriptado.Encriptar(textBox2.Text);
                //-------- 
                texto = textBox1.Text; 
                OleDbConnection conexion = new OleDbConnection(ds);
                conexion.Open();
                string select = "SELECT * FROM USUARIOS where nombre='" + textBox1.Text + "'and clave='" + var1 + "'and tipo_usuario='" + comboBox1.Text + "'";
                OleDbCommand cmd6 = new OleDbCommand(select, conexion);
                try
                {
                    OleDbDataReader reader = cmd6.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {                                                        
                            Nuevo_usuario corre = new Nuevo_usuario(ds,texto,band);
                            LIMPIAR();
                            corre.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Su Usuario o Contraseña o Tipo NO Coinciden o son Erroneas \n \n                        Le Quedan " + (intentos - veces) + " Intento(s)", "conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LIMPIAR();
                        veces = veces + 1;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error orden" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            if (veces == 2)
            {
                MessageBox.Show("Has excedido el limite permitido ", "conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
          
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            band = 1;
            if (this.textBox1.Text == "SELECCIONAR")
            {
                MessageBox.Show("Para modificar un usuario tienes que identificarte", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }

            else if (textBox2.Text == "")
            {
                MessageBox.Show("Para modificar un usuario tienes que identificarte", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Para modificar un usuario tienes que identificarte", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.Focus();
            }
            else
            {
                //checamos la encriptacion
                string var1;
                var1 = Encriptado.Encriptar(textBox2.Text);
                //-------- 

                texto = textBox1.Text;

                OleDbConnection conexion = new OleDbConnection(ds);
                conexion.Open();
                string select = "SELECT * FROM USUARIOS where nombre='" + textBox1.Text + "'and clave='" + var1 + "'and tipo_usuario='" + comboBox1.Text + "'";
                OleDbCommand cmd6 = new OleDbCommand(select, conexion);
                try
                {
                    OleDbDataReader reader = cmd6.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            
                            Nuevo_usuario corre = new Nuevo_usuario(ds, texto, band);
                            LIMPIAR();
                            corre.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Su Usuario o Contraseña o Tipo NO Coinciden o son Erroneas \n \n                        Le Quedan " + (intentos - veces) + " Intento(s)", "conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LIMPIAR();
                        veces = veces + 1;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error orden" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (veces == 2)
                {
                    MessageBox.Show("Has excedido el limite permitido ", "conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }

<<<<<<< HEAD
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
=======
        private void Control_acceso_Load(object sender, EventArgs e)
        {

>>>>>>> c2bf6d83c4a7296fec5be7448545152ae2e525f5
        }
    }
}
