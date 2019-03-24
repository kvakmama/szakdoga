using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juci
{

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

        public Jatekos(int z):this()
        {
            x = z * 2;
            y = z * 2;
            szin = alapszin;
        }

        public void kiir()
        {
            Console.WriteLine("x:"+x+", y:"+y+", alapszin:"+alapszin+", id:"+id+", szin:"+szin);
        }

        public int get_id()
        {
            return id;
        }
    }
}
