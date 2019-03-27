using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juci
{
    [System.Serializable, Tulajdonos("Judit"), Tulajdonos("Judit2"), SzakertoAttribute("Béla", datum = "2012")]
    public class Jatekos
    {
        private int id;
        private static int szamlalo = 1;
        public int x, y;
        private string alapszin = "barna";
        protected string szin;

        public void Lojjel<T>() where T:Fegyver,new()
        {
            T fegyver = new T();
            fegyver.Lo();
        }

        public Jatekos()
        {
            id = szamlalo;
            szamlalo++;  
        }

        //[Tulajdonos("Lusszmussz"), SzakertoAttribute("Béla", datum = "2012")]
        public Jatekos(int z):this()
        {
            x = z * 2;
            y = z * 2;
            szin = alapszin;
        }

        [Tulajdonos("Lusszmussz"), SzakertoAttribute("Béla", datum = "2012")]
        public void kiir()
        {
            Console.WriteLine("x:"+x+", y:"+y+", alapszin:"+alapszin+", id:"+id+", szin:"+szin);
        }

        public int get_id()
        {
            return id;
        }

        [Obsolete("Ez mar nem jo, uj_loves method van helyette")]
        public void regiloves()
        {
            Console.WriteLine("regi loves");
        }
        [Tulajdonos("Judit"), SzakertoAttribute("Béla", datum = "2012")]
        public void ujloves()
        {
            Console.WriteLine("mar lelollek, mert elfaradtam!");
        }
    }
}
