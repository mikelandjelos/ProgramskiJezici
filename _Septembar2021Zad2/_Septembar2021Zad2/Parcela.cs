using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _Septembar2021Zad2
{
    abstract internal class Parcela
    {
        protected int id;
        protected double povrsina;
        protected string adresa;
        protected DateTime datum;

        // konstruktori
        public Parcela()
        {
            id = -1;
            povrsina = -1;
            adresa = "";
            datum = DateTime.MinValue;
        }

        public Parcela(int _id, double _povrsina, string _adresa, DateTime _datum)
        { 
            id = _id;
            povrsina = _povrsina;
            adresa = _adresa;
            // (year, month, day, hour, minute, second)
            // prostije datum = _datum, ali onda se oba
            // referenciraju na isti obj
            datum = new DateTime(_datum.Year, _datum.Month,
                _datum.Day, _datum.Hour, _datum.Minute, _datum.Second);
        }

        // svojstva koja VRACAJU (-> read-only) id i datum kupovine
        public int Id
        { 
            get { return id; }
        }

        public DateTime Datum
        {
            get { return datum; }
        }

        // apstraktno svojstvo koje VRACA vrednost parcele
        abstract public double Vrednost { get; }

        // virtuelnu metodu za upis u *.txt fajl
        virtual public void UpisTxt(StreamWriter sw)
        {
            try
            {
                sw.WriteLine(id);
                sw.WriteLine(povrsina);
                sw.WriteLine(adresa);
                sw.WriteLine(datum);
            }
            catch (IOException ex)
            { 
                Console.WriteLine(ex.StackTrace + "\n" + ex.ToString());
            }
        }

        // virtuelnu metodu za citanje iz *.txt fajla
        virtual public void CitanjeTxt(StreamReader sr)
        {
            try
            {
                id = Int32.Parse(sr.ReadLine());
                povrsina = Double.Parse(sr.ReadLine());
                adresa = sr.ReadLine();
                datum = DateTime.Parse(sr.ReadLine());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace + "\n" + ex.ToString());
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(id + "\n");
            sb.Append(povrsina + "\n");
            sb.Append(adresa + "\n");
            sb.Append(datum + "\n");
            return sb.ToString();
        }

    }
}
