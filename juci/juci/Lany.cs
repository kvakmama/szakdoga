using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juci
{
    public class Lany : Jatekos
    {
        public Lany(int z):base(z)
        {
            szin = "piros";
        }
        
        public void lanytulajdonsag()
        {
            Console.WriteLine("szoknyas, tancol");
            Console.WriteLine(get_id());
            Console.WriteLine(szin);
        }
    }
}
