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
//hola
namespace empanada_2
{
    public partial class Historial : Form
    {
        public Historial(string ds)
        {
            InitializeComponent();
            this.ds = ds;
        }

        string fecha, total_pagar, total_cliente;
        //CONEXIONES
        String ds;

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                fecha = Convert.ToString(lista.Text);
            }

            textBox1.Text = fecha;

            SELECT_FECHA();

            SELECT_ORDEN();

            //HACER LA SUMA DEL TOTAL A PAGAR
            OleDbConnection conexion2 = new OleDbConnection(ds);
            conexion2.Open();

            string sql = "select SUM(total_pagar) from ORDEN WHERE fecha= '" + fecha + "'";
            string sql2 = "select COUNT(descripcion) from ORDEN WHERE fecha= '" + fecha + "'";
            OleDbCommand cmd = new OleDbCommand(sql2, conexion2);

            total_cliente = (cmd.ExecuteScalar()).ToString();
            textBox3.Text = total_cliente;


            OleDbCommand cmd2 = new OleDbCommand(sql, conexion2);

            total_pagar = (cmd2.ExecuteScalar()).ToString();
            textBox2.Text = total_pagar;
            conexion2.Close();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            textBox1.Text = fecha;

            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT fecha FROM FECHA", ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView1.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elemntos = new ListViewItem(filas["fecha"].ToString());

                listView1.Items.Add(elemntos);

            }
        }

        private void SELECT_ORDEN()
        {
            OleDbDataAdapter adaptador2 = new OleDbDataAdapter("SELECT id_orden, descripcion, total_pagar FROM ORDEN WHERE fecha = '" + fecha + "'", ds);

            DataSet dataset2 = new DataSet();
            DataTable tabla2 = new DataTable();

            adaptador2.Fill(dataset2);
            tabla2 = dataset2.Tables[0];
            this.listView_ordenes.Items.Clear();

            for (int i = 0; i < tabla2.Rows.Count; i++)
            {
                DataRow filas = tabla2.Rows[i];
                ListViewItem elemntos2 = new ListViewItem(filas["id_orden"].ToString());
                elemntos2.SubItems.Add(filas["descripcion"].ToString());
                elemntos2.SubItems.Add(filas["total_pagar"].ToString());
                listView_ordenes.Items.Add(elemntos2);
            }
        }

        private void SELECT_FECHA()
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT fecha FROM FECHA", ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView1.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elemntos = new ListViewItem(filas["fecha"].ToString());

                listView1.Items.Add(elemntos);
            }
        }
    }
}
