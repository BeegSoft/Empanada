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
    public partial class Fechas : Form
    {
        public Fechas(string ds)
        {
            InitializeComponent();
            this.ds = ds;
        }
        //CONEXIONES
        String ds;
        private void Fechas_Load(object sender, EventArgs e)
        {

            SELECT_FECHA();
        }

        private void SELECT_FECHA()
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT fecha FROM FECHA", ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView_fechas.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elemntos = new ListViewItem(filas["fecha"].ToString());

                listView_fechas.Items.Add(elemntos);

            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {            
            this.Hide();
        }

        private void button_elegir_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView_fechas.SelectedItems)
            {
                string fecha = lista.Text;

                this.Hide();
                Pantalla2 form = new Pantalla2(fecha, ds);
                form.Show();

                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView_fechas.SelectedItems)
            {
                string fecha = lista.Text;
                this.Hide();
                Historial form2 = new Historial(fecha, ds);
                form2.Show();
                this.Hide();
            }
        }
    }
}
