﻿using System;
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
            //CONEXION PARA LA BASE DE DATOS
            string ds = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Empanada/BEEGSOFT/empanada_2/empanada_2/baseEmpanadas.mdb";

            
            //CONEXION PARA LOS USUARIOS
            string ds2 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Empanada/BEEGSOFT/empanada_2/empanada_2/UsuariosEmpanadas.mdb";
            //  h   ola
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Control_acceso(ds,ds2));
            //Algo
        }
    }
}
