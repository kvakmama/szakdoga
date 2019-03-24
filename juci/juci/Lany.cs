using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juci
{
    public class Lany : Jatekos
    {
        public string MiASzin
        {
            get { return szin;}
            set { szin = value; }
        }

        public Lany(int z):base(z)
        {
            szin = "piros";
        }
        
        public void lanytulajdonsag()
        {
            Console.WriteLine("szoknyas, tancol, szine:"+szin+", lany id:"+(get_id()));
        }
    }
}
