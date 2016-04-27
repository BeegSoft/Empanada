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
    public partial class Control_acceso : Form
    {
        public Control_acceso(string fecha,string ds)
        {
            InitializeComponent();
            this.ds = ds;
            this.fecha = fecha;
        }
        string ds;
        string fecha;

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection(ds);
            conexion.Open();

            conexion.Close();
        }
    }
}
