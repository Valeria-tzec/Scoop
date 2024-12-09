using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoop
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Application.Run(form1);

            // quité esto por el botón de regresar
            //if (form1.AutenticacionManager)
            //{  Application.Run(new Admin());}
            //else if (form1.AutenticacionEmployee)
            //{Application.Run(new Maquina());}

        }
    }
}
