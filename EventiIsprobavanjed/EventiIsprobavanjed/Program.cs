using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EventiIsprobavanje
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EventKlasa ek = new EventKlasa(16);

            ek.Izmena += new EventKlasa.IzmenaVrednosti(
                (new MethodKlasa()).Metod);

            ek.Broj = 5;
            ek.Broj = 6;

        }
    }
}
