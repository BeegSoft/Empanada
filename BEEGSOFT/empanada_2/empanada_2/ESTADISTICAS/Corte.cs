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
    public partial class Corte : Form
    {
        public Corte(string ds)
        {
            InitializeComponent();
            this.ds = ds;            
        }
        public struct CrearNodo2
        {
            public string platillo;
            public string cantidad;
            public string total;
        }

        public static List<CrearNodo2> tabla_corte = new List<CrearNodo2>();

        string ds, fecha;

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
        public string platillo,cantidad, total;

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            foreach (ListViewItem lista in listView_fechas.SelectedItems)
            {
                fecha = lista.Text;
                label_fecha.Text = fecha;
            }
            METODOCOMBO(fecha);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            xla.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)xla.ActiveSheet;

            int i = 3;
            int j = 1;
            foreach (ListViewItem comp in listView1.Items)
            {
                ws.Cells[2, 1] = ("PRODUCTO");
                ws.Cells[2, 2] = ("CANTIDAD");
                ws.Cells[2, 3] = ("TOTAL");               

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
            ws.Cells[2, 5] = ("TOTAL DE CLIENTES");
            ws.Cells[3, 5] = textBox_clientes.Text;

            ws.Cells[2, 7] = ("VENTAS DEL DIA");
            ws.Cells[3, 7] = textBox_ventas.Text;

            ws.Cells[5, 5] = ("TOTAL DE ARTICULOS");
            ws.Cells[6, 5] = textBox_empanadas.Text;

            ws.Cells[5, 7] = ("GASTOS DEL DIA");
            ws.Cells[6, 7] = textBox_gastos.Text;

            ws.Cells[8, 7] = ("GANANCIAS TOTALES DEL DIA");
            ws.Cells[9, 7] = textBox_ganancias.Text;
        }

        private void METODOCOMBO(string date)
        {
            
            tabla_corte.Clear();
            //SUMAR LAS VENTAS DE LOS PLATILLOS SELECCIONADOS
            OleDbConnection conexion = new OleDbConnection(ds);

            conexion.Open();
            var li = new CrearNodo2();
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT nombre_platillo FROM MENU", ds);

            DataSet dataset = new DataSet();
            DataTable tabla = new DataTable();

            adaptador.Fill(dataset);
            tabla = dataset.Tables[0];            
            this.listView1.Items.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["nombre_platillo"].ToString());
                //listView_esta.Items.Add(elementos);

                string cal1 = "SELECT SUM(PLATILLO.pagar) FROM(FECHA INNER JOIN ORDEN ON FECHA.fecha = ORDEN.fecha) INNER JOIN PLATILLO ON ORDEN.id_orden = PLATILLO.id_orden WHERE PLATILLO.nombre_platillo = '" + elementos.Text + "'" + "AND FECHA.fecha = '" + date + "'";
                OleDbCommand cmd31 = new OleDbCommand(cal1, conexion); //Conexion es tu objeto conexion                                
                cantidad = (cmd31.ExecuteScalar()).ToString();
                if (cantidad == "")
                {
                    cantidad = "0";
                }

                string cal2 = "SELECT SUM(PLATILLO.cantidad) FROM(FECHA INNER JOIN ORDEN ON FECHA.fecha = ORDEN.fecha) INNER JOIN PLATILLO ON ORDEN.id_orden = PLATILLO.id_orden WHERE PLATILLO.nombre_platillo = '" + elementos.Text + "'" + "AND FECHA.fecha='" + date + "'";
                OleDbCommand cmd2 = new OleDbCommand(cal2, conexion); //Conexion es tu objeto conexion
                total = (cmd2.ExecuteScalar()).ToString();

                if (total == "")
                {
                    total = "0";
                }                            

                li.platillo=elementos.Text;
                li.cantidad=cantidad;
                li.total = total;
                tabla_corte.Add(li);
            }

            for(int i = 0; i < tabla_corte.Count; i++)
            {
                platillo = tabla_corte[i].platillo;
                cantidad = tabla_corte[i].cantidad;
                total = tabla_corte[i].total;
                
                ListViewItem elemntos2 = new ListViewItem(platillo);
                elemntos2.SubItems.Add(total);
                elemntos2.SubItems.Add(cantidad);
                listView1.Items.Add(elemntos2);

            }
            string select = "SELECT SUM(ORDEN.total_pagar) FROM ORDEN INNER JOIN FECHA ON ORDEN.fecha = FECHA.fecha WHERE FECHA.fecha='" + date + "'";

            OleDbCommand cmd = new OleDbCommand(select, conexion); //Conexion es tu objeto conexion                                

            textBox_ventas.Text = (cmd.ExecuteScalar()).ToString();
            if (textBox_ventas.Text == "")
            {
                textBox_ventas.Text = "0";
            }


            //...................................

            //SUMA GASTOS
            string select5 = "SELECT SUM(Gastos) FROM FECHA  WHERE FECHA.fecha='" + date + "'";

            OleDbCommand cmd5 = new OleDbCommand(select5, conexion); //Conexion es tu objeto conexion                                

            textBox_gastos.Text = (cmd5.ExecuteScalar()).ToString();
            if (textBox_gastos.Text == "")
            {
                textBox_gastos.Text = "0";
            }
            //--------------------------------

            //SUMA GANANCIAS
            string select6 = "SELECT SUM(Ganancia) FROM FECHA  WHERE FECHA.fecha='" + date + "'";

            OleDbCommand cmd6 = new OleDbCommand(select6, conexion); //Conexion es tu objeto conexion                                

            textBox_ganancias.Text = (cmd6.ExecuteScalar()).ToString();
            if (textBox_ganancias.Text == "")
            {
                textBox_ganancias.Text = "0";
            }
            //--------------------------------

            //SUMAR LAS VENTAS DE LOS PLATILLOS SELECCIONADOS

            string select2 = "SELECT COUNT(ORDEN.total_pagar) FROM ORDEN INNER JOIN FECHA ON ORDEN.fecha = FECHA.fecha  WHERE FECHA.fecha='" + date + "'";

            OleDbCommand cmd3 = new OleDbCommand(select2, conexion); //Conexion es tu objeto conexion                                

            textBox_clientes.Text = (cmd3.ExecuteScalar()).ToString();
            if (textBox_clientes.Text == "")
            {
                textBox_clientes.Text = "0";
            }

            //--------------------------------------------------------

            //TOTAL DE EMPANADAS VENDIDAS EN EL PERIODO SELECCIONADO

            string select3 = "SELECT SUM(PLATILLO.cantidad) FROM(FECHA INNER JOIN ORDEN ON FECHA.fecha = ORDEN.fecha) INNER JOIN PLATILLO ON ORDEN.id_orden = PLATILLO.id_orden  WHERE FECHA.fecha='" + date + "'";

            OleDbCommand cmd4 = new OleDbCommand(select3, conexion); //Conexion es tu objeto conexion                                

            textBox_empanadas.Text = (cmd4.ExecuteScalar()).ToString();
            if (textBox_empanadas.Text == "")
            {
                textBox_empanadas.Text = "0";
            }

            conexion.Close();                          
        }
        private void SELECT_FECHA()
        {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT fecha FROM FECHA ORDER BY FECHA.id ASC", ds);

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

        private void Corte_Load(object sender, EventArgs e)
        {            
            fecha = DateTime.Now.ToShortDateString();

            label_fecha.Text = DateTime.Now.ToShortDateString();
            METODOCOMBO(fecha);
            SELECT_FECHA();
        }
    }
}
