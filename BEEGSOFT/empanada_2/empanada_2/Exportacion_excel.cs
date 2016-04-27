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
    public partial class Exportacion_excel : Form
    {
        public Exportacion_excel(string ds)
        {
            InitializeComponent();
            this.ds = ds;
        }
        string ds;
        int fechaa, fechab;

        private void Exportacion_excel_Load(object sender, EventArgs e)
        {
            SELECT_FECHA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CARGAR();
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;

            int i = 2;
            int j = 1;

            foreach (ListViewItem comp in listView_esta.Items)
            {
                ws.Cells[1, 1] = ("FECHA");
                ws.Cells[1, 2] = ("ID");
                ws.Cells[1, 3] = ("PLATILLO");
                ws.Cells[1, 4] = ("CANTIDA");
                ws.Cells[1, 5] = ("TOTAL");

                ws.Cells[i, j] = comp.Text.ToString();
                //MessageBox.Show(comp.Text.ToString());
                foreach (ListViewItem.ListViewSubItem drv in comp.SubItems)
                {
                    ws.Cells[i, j] = drv.Text.ToString();
                    j++;
                }
                j = 1;
                i++;
            }
        }

        private void SELECT_FECHA()
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT FECHA.fecha FROM FECHA ORDER BY FECHA.fecha", ds);

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

        }

        private void button2_Click_1(object sender, EventArgs e)
        {           
            CARGAR();
        }

        private void CARGAR()
        {
            //Primera fecha
            string var1 = fechaA.Text;
            var1 = var1.Substring(0, 2);

            string var2 = fechaA.Text;
            var2 = var2.Substring(3, 2);

            string var3 = fechaA.Text;
            var3 = var3.Substring(6, 4);

            //juntando las cadenas
            string FECHAA = string.Concat(var3, var2, var1);
            fechaa = Convert.ToInt32(FECHAA);
            //----------------

            //Segunda fecha
            var1 = fechaB.Text;
            var1 = var1.Substring(0, 2);

            var2 = fechaB.Text;
            var2 = var2.Substring(3, 2);

            var3 = fechaB.Text;
            var3 = var3.Substring(6, 4);

            //juntando las cadenas
            string FECHAB = string.Concat(var3, var2, var1);
            fechab = Convert.ToInt32(FECHAB);


            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT FECHA.fecha, ORDEN.id_orden, PLATILLO.nombre_platillo, PLATILLO.cantidad, PLATILLO.pagar FROM(FECHA INNER JOIN ORDEN ON FECHA.fecha = ORDEN.fecha) INNER JOIN PLATILLO ON ORDEN.id_orden = PLATILLO.id_orden WHERE id >= " + fechaa + " AND id <= " + fechab, ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];
            this.listView_esta.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elemntos = new ListViewItem(filas["fecha"].ToString());
                elemntos.SubItems.Add(filas["id_orden"].ToString());
                elemntos.SubItems.Add(filas["nombre_platillo"].ToString());
                elemntos.SubItems.Add(filas["cantidad"].ToString());
                elemntos.SubItems.Add(filas["pagar"].ToString());

                listView_esta.Items.Add(elemntos);
            }          
        }
    }
}
