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
            aron.alapszine();
            juci.alapszine();
            juci.lanytulajdonsag();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
