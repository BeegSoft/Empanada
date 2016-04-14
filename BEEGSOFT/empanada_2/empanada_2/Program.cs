using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace empanada_2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            string ds = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/BEEGSOFT/empanada_2/empanada_2/baseEmpanadas.mdb";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio(ds));
        }
    }
}
