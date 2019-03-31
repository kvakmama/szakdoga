//#define juci 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juci
{
    static class Program
    {
        static void attributekiir(Attribute[] attributes)
        {
            foreach (Attribute attr in attributes)
            {
                if (attr is Tulajdonos)
                {
                    Console.WriteLine("Tulajdonos:" + (attr as Tulajdonos).nev);
                }
                else if (attr is SzakertoAttribute)
                {
                    SzakertoAttribute sz = (attr as SzakertoAttribute);
                    Console.WriteLine("Expert:" + sz.nev + " a dátum:" + sz.datum);
                }
                else
                {
                    Console.WriteLine(attr);
                }
            }
        }
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

            aron.regiloves();
            aron.ujloves();
                        
            Type type = typeof(Lany);
            foreach (Object attr in type.GetCustomAttributes(false))
            {
                Console.WriteLine(attr);
            }

            Type t = typeof(Jatekos);
            System.Reflection.MemberInfo[] members = t.GetMembers();
            // todo: kiirni az osszes membert, methodot, propertyt, ezek attributumait
            Console.WriteLine("==========================================");
            foreach (System.Reflection.MemberInfo member in members)
            {
                Console.WriteLine(member);
                Attribute[] attributes = System.Attribute.GetCustomAttributes(member);
                attributekiir(attributes);
            }


            //delegate
            Jatekos lusziharcicica = new Jatekos(6);
            //lusziharcicica.sebzodik(5);
            lusziharcicica.ugrik();
            lusziharcicica.fuggveny = EnFuggvenyem;
            lusziharcicica.fuggveny += EnFuggvenyem2;
            lusziharcicica.sebzodik(5);
            lusziharcicica.fuggveny += EnFuggvenyem2;



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static void EnFuggvenyem()
        {
            Console.WriteLine("Egy Kukac típus éppen lőtt egyet!");
        }

        static void EnFuggvenyem2()
        {
            Console.WriteLine("EnFuggvenyem meghivva 2!");
        }
    }
}
