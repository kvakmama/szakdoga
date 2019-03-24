using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juci
{
    public class Tank: AbsztractOs, ISebezheto
    {
        int eletero;

        public override void Csinal()
        {
            Console.WriteLine("overrideolt csinal absztract os osztalybol meghivva");
        }

        public void Sebzodj(int mennyit)
        {
            eletero = eletero - mennyit;
        }
    }
}
