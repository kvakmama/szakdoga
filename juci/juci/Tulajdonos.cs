using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juci
{
    [System.AttributeUsage(AttributeTargets.Class|AttributeTargets.Method, AllowMultiple = true)]
    public class Tulajdonos : System.Attribute
    {
        public string nev;
        public Tulajdonos(string aNev)
        { nev = aNev; }
    }

    public class SzakertoAttribute : System.Attribute
    {
        public string datum;
        public string nev;
        public SzakertoAttribute(string aNev)
        { nev = aNev; }
    }
}
