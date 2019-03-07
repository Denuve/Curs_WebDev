using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oras
{
    class Casa:Adresa
    {
        public Casa(string Cartier,string Strada,int Numar)
        {
            this.Cartier = Cartier;
            this.Strada = Strada;
            this.Numar = Numar;
        }
    }
}
