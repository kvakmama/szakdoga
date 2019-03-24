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
            aron.Lojjel<Geppuska>();

            int i = 10;
            int j = 20;
            Osszehasonlito<int> osszehasonlito = new Osszehasonlito<int>();
            Console.WriteLine("Nagyobbe az elso szam: " + i + " a masodiknal: "+ j + osszehasonlito.NagyobbAzElsoMintAMasodik(i, j));
            //Console.WriteLine("Nagyobbe2?" + NemOkos.Nagyobbe(30,10));
            ISebezheto ujtank = new Tank();
            ujtank.Sebzodj(44);
            //ujtank.Csinalj();
            Tank tankocska = new Tank();
            tankocska.Csinal();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
