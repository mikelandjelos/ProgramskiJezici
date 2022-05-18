using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _Septembar2021Zad2
{

    enum TipNekretnine : int 
    {
        NullTip = -1,
        Kuca,
        Zgrada,
        Soliter
    }

    internal class Nekretnina : Parcela
    {

        private TipNekretnine tip;
        private int brojJedinica;
        private bool centralnoGrejanje;

        // konstruktori
        public Nekretnina() : base()
        {
            tip = TipNekretnine.NullTip;
            brojJedinica = -1;
            centralnoGrejanje = false;
        }

        public Nekretnina(TipNekretnine _tip, int _brojJedinica,
            bool _centralnoGrejanje, int _id, double _povrsina,
            string _adresa, DateTime _datum)
            : base(_id, _povrsina, _adresa, _datum)
        {
            tip = _tip;
            brojJedinica = _brojJedinica;
            centralnoGrejanje = _centralnoGrejanje;
        }

        public Nekretnina(int _tip, int _brojJedinica,
            bool _centralnoGrejanje, int _id, double _povrsina,
            string _adresa, DateTime _datum)
            : base(_id, _povrsina, _adresa, _datum)
        {
            tip = (TipNekretnine)_tip;
            brojJedinica = _brojJedinica;
            centralnoGrejanje = _centralnoGrejanje;
        }

        // override apstraktnog svojstva
        override public double Vrednost
        {
            get
            {
                double ret = brojJedinica * povrsina;
                switch (tip)
                {
                    case TipNekretnine.Soliter:
                        return ret * 1.5;
                    case TipNekretnine.Zgrada:
                        return ret * 1.3;
                    case TipNekretnine.Kuca:
                        return ret * 1.2;
                    default:
                        throw 
                            new NullReferenceException("Nemoguce izracunati Vrednost!");
                }
            }
        }

        // override metode za upis u *.txt fajl
        override public void UpisTxt(StreamWriter sw)
        {
            try
            {
                base.UpisTxt(sw);
                sw.WriteLine((int)tip);
                sw.WriteLine(brojJedinica);
                sw.WriteLine(centralnoGrejanje);
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
                tip = (TipNekretnine)Int32.Parse(sr.ReadLine());
                brojJedinica = Int32.Parse(sr.ReadLine());
                centralnoGrejanje = Boolean.Parse(sr.ReadLine());
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
            sb.Append(tip + "\n");
            sb.Append(brojJedinica + "\n");
            sb.Append(centralnoGrejanje + "\n");
            return sb.ToString();
        }

    }
}
