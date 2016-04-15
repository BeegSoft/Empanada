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
    public partial class Inicio : Form
    {
        public Inicio(string ds)
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

        //CONEXION
        string ds;
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fechahoy = DateTime.Now;
            string fecha = fechahoy.ToString("d");
            
            try
            {
                OleDbConnection conexion = new OleDbConnection(ds);

                conexion.Open();
               
                    string insertar = "INSERT INTO FECHA (fecha) VALUES (@fecha)";
                    OleDbCommand cmd = new OleDbCommand(insertar, conexion);
                    cmd.Parameters.AddWithValue("@fecha", fecha);

                    cmd.ExecuteNonQuery();

                    conexion.Close();

                    Pantalla2 form = new Pantalla2(fecha, ds);
                    form.Show();
            }

            catch (Exception)
            {
                MessageBox.Show("Ya existe un historial del dia de hoy\n\n      Vaya a CONTINUAR DIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechahoy = DateTime.Now;
            string fecha = fechahoy.ToString("d");

            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();

            string select = "SELECT COUNT(fecha) FROM FECHA WHERE fecha='" + fecha + "'";
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            try
            {

                string compro = (cmd.ExecuteScalar()).ToString();

                if (Convert.ToInt32(compro) != 0)
                {
                    Form1 form = new Form1(fecha, ds);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("No hay un dia en el historial", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error orden" + ex, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu form = new Menu(ds);
            form.Show();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Historial form = new Historial(ds);
            form.Show();
        }
    }
}
