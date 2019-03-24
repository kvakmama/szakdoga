using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juci
{
    public class Tank: ISebezheto
    {
        int eletero;
        public void Sebzodj(int mennyit)
        {
            eletero = eletero - mennyit;
        }
    }
}
