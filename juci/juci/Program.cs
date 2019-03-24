using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juci
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Jatekos aron = new Jatekos(10);
            Lany juci = new Lany(2);
            aron.kiir();
            juci.kiir();
            juci.lanytulajdonsag();
            Console.WriteLine(juci.MiASzin);
            juci.MiASzin = "rozsa";
            Console.WriteLine(juci.MiASzin);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
