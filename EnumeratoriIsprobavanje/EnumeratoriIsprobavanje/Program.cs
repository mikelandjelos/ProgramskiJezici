using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratoriIsprobavanje
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IEnumerator<int> v = new VektorEnumerator<int>();

            Console.Write("Koliko elemenata zelite u svom vektoru: ");
            int n = Int32.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < n; ++i)
                ((VektorEnumerator<int>)v).Add(random.Next() % 100 - 50);

            v.Reset();

            while (v.MoveNext())
                Console.Write(v.Current + " ");

            Console.WriteLine();

        }
    }
}
