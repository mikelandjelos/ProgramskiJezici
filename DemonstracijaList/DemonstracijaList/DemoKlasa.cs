using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonstracijaList
{
    internal class DemoKlasa
    {

        private List<string> nekaLista;
        private int mojInt = 15;
        private DateTime mojDatum = DateTime.Now;

        public DemoKlasa(List<string> _nekaLista)
        {
            if (_nekaLista == null)
                nekaLista = new List<string>();
            else
                nekaLista = _nekaLista;
        }

        public DemoKlasa(string[] _nekaLista)
        {
            nekaLista = new List<string>(_nekaLista);
        }

        public DemoKlasa()
        {
            nekaLista = new List<string>();
        }

        public DemoKlasa(DemoKlasa dk)
        {
            nekaLista = new List<string>(dk.nekaLista);
            mojInt = dk.mojInt;
            mojDatum = dk.mojDatum;
        }

        public void dodajElement(string element)
        {
            nekaLista.Add(element);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(mojInt.ToString() + "\n");
            sb.Append(mojDatum.ToString() + "\n");

            foreach (string s in nekaLista)
                sb.Append(s + "\n");

            return sb.ToString();

        }

        public void SortList()
        {
            for (int i = 0; i < nekaLista.Count; ++i)
            {
                int imin = i;
                for (int j = i + 1; j < nekaLista.Count; ++j)
                    if (String.Compare(nekaLista[j], nekaLista[imin]) < 0)
                        imin = j;
                if (imin != i) {
                    string xchg = nekaLista[i];
                    nekaLista[i] = nekaLista[imin];
                    nekaLista[imin] = xchg;
                }
            }
        }

        // morace da se poziva sa dk = dk + "nesto";
        public static DemoKlasa operator+(DemoKlasa dk, string element)
        { 
            DemoKlasa nova = new DemoKlasa(dk);
            nova.dodajElement(element);
            return nova;
        }

        public override bool Equals(object obj)
        {
            DemoKlasa that = obj as DemoKlasa;
            if (Object.ReferenceEquals(that, null))
                return false;
            bool ret = true;
            foreach (string s in nekaLista) {
                if (!that.nekaLista.Contains(s))
                    ret = false;
                if (!ret)
                    break;
            }
            return ret && this.mojInt.Equals(that.mojInt)
                && this.mojDatum.Equals(that.mojDatum);
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(DemoKlasa dkl, DemoKlasa dkd)
        {
            return dkl.Equals(dkd);
        }

        public static bool operator !=(DemoKlasa dkl, DemoKlasa dkd)
        {
            return !dkl.Equals(dkd);
        }

    }
}
