using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstracijaList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoKlasa demoKlasa = new DemoKlasa();
            demoKlasa.dodajElement("klm");
            demoKlasa.dodajElement("abc");
            demoKlasa.dodajElement("dfg");
            demoKlasa.dodajElement("hij");

            Console.WriteLine(demoKlasa);
            demoKlasa.SortList();
            Console.WriteLine(demoKlasa);

            Console.WriteLine("String.Compare(\"a\", \"b\") == {0}, String.Compare(\"a\", \"a\") == {1}, String.Compare(\"b\", \"a\") == {2}\n",
                String.Compare("a", "b"),
                String.Compare("a", "a"),
                String.Compare("b", "a"));

            //DemoKlasa nova = new DemoKlasa(demoKlasa);
            //Console.WriteLine(nova + "\n");

            //// sta daje?
            //Console.WriteLine(nova == demoKlasa);

            //nova = nova + "novi element1";
            //nova = nova + "novi element2";

            //demoKlasa = demoKlasa + "novi element2";
            //demoKlasa = demoKlasa + "novi element1";



            //demoKlasa.SortList();

            //// sta daje?
            //Console.WriteLine(String.Compare("abc", "efg"));

            //Console.WriteLine(nova);
            //Console.WriteLine(demoKlasa);

        }
    }
}
