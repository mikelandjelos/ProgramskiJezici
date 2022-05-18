using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _Septembar2021Zad2
{
    internal class Park : Parcela
    {

        private int brojKafica;
        private int brojKlupica;
        private bool deoZaPse;

        // konstruktori
        public Park() : base() 
        {
            brojKafica = -1;
            brojKlupica = -1;
            deoZaPse = false;
        }

        public Park(int _brojKafica, int _brojKlupica, bool _deoZaPse,
            int _id, double _povrsina, string _adresa, DateTime _datum)
            : base(_id, _povrsina, _adresa, _datum)
        { 
            brojKafica = _brojKafica;
            brojKlupica = _brojKlupica;
            deoZaPse = _deoZaPse;
        }

        // override apstraktnog svojstva
        override public double Vrednost 
        {
            get
            { 
                return povrsina * povrsina * 
                    brojKafica * brojKlupica *
                    (deoZaPse ? 1.2 : 1);
            }
        }

        // override metode za upis u *.txt fajl
        override public void UpisTxt(StreamWriter sw)
        {
            try
            {
                base.UpisTxt(sw);
                sw.WriteLine(brojKafica);
                sw.WriteLine(brojKlupica);
                sw.WriteLine(deoZaPse);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace + "\n" + ex.ToString());
            }
        }

        // override metode za citanje iz *.txt fajla
        override public void CitanjeTxt(StreamReader sr)
        {
            try
            {
                base.CitanjeTxt(sr);
                brojKafica = Int32.Parse(sr.ReadLine());
                brojKlupica = Int32.Parse(sr.ReadLine());
                deoZaPse = Boolean.Parse(sr.ReadLine());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace + "\n" + ex.ToString());
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(brojKafica + "\n");
            sb.Append(brojKlupica + "\n");
            sb.Append(deoZaPse + "\n");
            return sb.ToString();
        }

    }
}
