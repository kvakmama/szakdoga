﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juci
{
    [System.Serializable, Tulajdonos("Judit"), SzakertoAttribute("Béla", datum = "2012")]
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

        //[Conditional("juci")]
        //[Conditional("DEBUG")]
        public void lanytulajdonsag()
        {
            Console.WriteLine("szoknyas, tancol, szine:"+szin+", lany id:"+(get_id()));
        }
    }
}
