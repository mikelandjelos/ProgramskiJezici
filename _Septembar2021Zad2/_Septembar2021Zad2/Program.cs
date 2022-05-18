using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://blanketi.sicef.info/elfak/pregled/2825

namespace _Septembar2021Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grad grad = new Grad("Nis", 5);
            Nekretnina n = 
                new Nekretnina(TipNekretnine.Soliter,
                20, true, 15, 200.2, "Aleksandra Medvedeva 20",
                DateTime.Now);
            Park x = new Park(4, 20, true, 14, 300.2, "Park brt", DateTime.Today);
            Parcela y;

            grad.DodajOptimalno(n);
            grad.DodajOptimalno(x);
            grad.DodajOptimalno(n);
            grad.DodajOptimalno(x);
            grad.DodajOptimalno(n);
            grad.DodajOptimalno(x);
            grad.DodajOptimalno(n);
            grad.DodajOptimalno(x);


            // ovo je bas debelo zanimljiv parsing mehanizam
            string enumS = TipNekretnine.Zgrada.ToString();
            int enum32 = (int)Enum.Parse(typeof(TipNekretnine), enumS);

            grad.UpisTxt("mojfajl.txt");

            y = grad.IzbaciMin();

            foreach (Parcela p in grad.VratiNoveParcele())
                Console.WriteLine(p);

            grad.CitanjeTxt("mojfajl.txt");

            Console.Write("------------");
            Console.Write("------------");
            Console.Write("------------");
            Console.WriteLine("------------");

            foreach (Parcela p in grad.VratiNoveParcele())
                Console.WriteLine(y);

            // Console.WriteLine("Izbacena:\n" + x);

        }
    }
}
