using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oras
{
    class Primarie : Institutie
    {
        public Primarie(string Name, string Description, int Numar_Angajati, string Cartier, string Strada, int Numar)
        {
            this.Name = Name;
            this.Description = Description;
            this.Numar_Angajati = Numar_Angajati;

            this.Cartier = Cartier;
            this.Strada = Strada;
            this.Numar = Numar;
        }
    }
}
