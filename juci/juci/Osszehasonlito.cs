using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juci
{
    public class Osszehasonlito<T> where T:IComparable
    {
        public bool NagyobbAzElsoMintAMasodik(T elso, T masodik)
        {
            return elso.CompareTo(masodik) >= 0;
        }
    }
}
