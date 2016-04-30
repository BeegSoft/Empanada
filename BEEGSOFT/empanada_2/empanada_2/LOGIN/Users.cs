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
    public partial class Users : Form
    {
        public Users(string ds,int band)
        {
            InitializeComponent();
            this.band = band;            
            this.ds = ds;
        }
        int band;
        string texto;
        string ds;
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Empanada/BEEGSOFT/empanada_2/empanada_2/baseEmpanadas.mdb");
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            texto = "ROOT";
            band = 0;
            Nuevo_usuario abre = new Nuevo_usuario(ds,texto,band);
            abre.Show();
        }

        private void BORRAR()
        {
            if (band == 0)
            {
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    string text = lista.Text;

                    DialogResult resultado = MessageBox.Show("Esta seguro de borrar el usuario?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            OleDbConnection conexion = new OleDbConnection(ds);

                            conexion.Open();
                            string borrar = "DELETE FROM USUARIOS WHERE nombre = '"+ text+"'";
                            OleDbCommand cmd = new OleDbCommand(borrar, conexion);

                            cmd.ExecuteNonQuery();


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
                }
            }
            else if (band == 1)
            {
                foreach (ListViewItem lista in listView2.SelectedItems)
                {
                    string nombre = lista.Text;

                    DialogResult resultado = MessageBox.Show("Esta seguro de borrar el usuario?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            OleDbConnection conexion = new OleDbConnection(ds);

                            conexion.Open();
                            string borrar = "DELETE FROM USUARIOS WHERE nombre = '"+nombre+"'";
                            OleDbCommand cmd = new OleDbCommand(borrar, conexion);
                            cmd.ExecuteNonQuery();

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
                }
            }
        }

        private void SELECT_USUARIOS(int band)
        {
            if (band == 0)
            {
                label2.Text = "Usted Ingreso como usuario Root";
                listView2.Visible = false;

                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT USUARIOS.id, USUARIOS.nombre, USUARIOS.clave, USUARIOS.TIPO_USUARIO FROM USUARIOS ", ds);

                DataSet dataset = new DataSet();
                DataTable tabla = new DataTable();

                adaptador.Fill(dataset);
                tabla = dataset.Tables[0];
                this.listView1.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["nombre"].ToString());
                    elementos.SubItems.Add(filas["clave"].ToString());
                    elementos.SubItems.Add(filas["tipo_usuario"].ToString());
                    elementos.SubItems.Add(filas["id"].ToString());
                    listView1.Items.Add(elementos);
                }
            }
            else if(band==1)
            {
                label2.Text = "Usted Ingreso Como Administrador";
                listView1.Visible = false;
                button1.Visible = false;
                label3.Visible = false;
                textBox1.Visible = false;

                OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT USUARIOS.nombre, USUARIOS.TIPO_USUARIO FROM USUARIOS WHERE USUARIOS.tipo_usuario <>'ROOT'", ds);

                DataSet dataset = new DataSet();
                DataTable tabla = new DataTable();

                adaptador.Fill(dataset);
                tabla = dataset.Tables[0];
                this.listView2.Items.Clear();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    DataRow filas = tabla.Rows[i];
                    ListViewItem elementos = new ListViewItem(filas["nombre"].ToString());                    
                    elementos.SubItems.Add(filas["tipo_usuario"].ToString());
                    listView2.Items.Add(elementos);
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            if (band == 0)
            {                
                SELECT_USUARIOS(band);                
            }
            else if (band == 1)
            {                
                SELECT_USUARIOS(band);
            }
        }
        
           
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {                     
            if (band == 0)
            {
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    texto = lista.Text;
                    band = 1;
                    Nuevo_usuario abre = new Nuevo_usuario(ds, texto, band);
                    abre.Show();
                }                
            }
            else if (band == 1)
            {
                foreach (ListViewItem lista in listView2.SelectedItems)
                {
                    texto = lista.Text;
                    band = 1;                   
                    Nuevo_usuario abre = new Nuevo_usuario(ds, texto, band);
                    abre.Show();
                }
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Empanada/BEEGSOFT/empanada_2/empanada_2/baseEmpanadas.mdb");
        }

        private void AbrirProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio corre = new Inicio(ds);
            corre.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lista in listView1.SelectedItems)
            {
                string text = lista.Text;


                OleDbConnection conexion = new OleDbConnection(ds);
                conexion.Open();
                string select = "SELECT clave FROM USUARIOS WHERE nombre= '"+ text+"'";
                OleDbCommand cmd6 = new OleDbCommand(select, conexion);
                try
                {
                    OleDbDataReader reader = cmd6.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string clv_des = reader.GetString(0);
                            string aux = Encriptado.DesEncriptar(clv_des);
                            textBox1.Text = aux;
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
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            BORRAR();
        }
    }
}
