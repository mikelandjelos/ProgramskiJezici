using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _EventiIsprobavanje
{
    internal class EventKlasa
    {

        private int broj;

        public delegate void IzmenaVrednosti(int i);

        public event IzmenaVrednosti Izmena;

        public EventKlasa(int i)
        { 
            broj = i;
        }

        public int Broj
        { 
            get { return broj; }
            set 
            {
                if (value == broj)
                    return;
                if (Izmena != null)
                    Izmena(value);
                else
                    Console.Error.WriteLine("Nema event handlera!");
                broj = value;
            }
        }

    }
}
