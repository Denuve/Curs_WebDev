using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oras
{
    class Program
    {
        static void Main(string[] args)
        {
            Politie politie = new Politie("Politia","Politia oraselului lenes",10,"Cartierul Mistic","Strada Universala"
                ,21);
            Spital spital = new Spital("Spitalul","Spitalul oraselului lenes",5,"Cartierul Sistemului Nervos Central"
                ,"Strada Vitalitatii",1111);
            Primarie primaria = new Primarie("Primaria","Masina de facut bani",20,
                "Cartierul Ciordeles","Strada Buzunarul Plin",1000);
            Casa casa = new Casa("Casuta","Strada Ion Ionescu",69);
        }
    }
}
