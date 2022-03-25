using sisVendas.Telas;
using System;

using System.Windows.Forms;

namespace sisVendas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            FormHome f = new FormHome();

            
            Application.Run(f);
        }
    }
}
