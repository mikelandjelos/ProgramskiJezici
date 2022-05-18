using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _Septembar2021Zad2
{
    internal class Grad
    {

        private string naziv;
        private Parcela[,] matrica;
        private int mdim;
        private int count = 0;

        // konstruktor
        public Grad(string _naziv, int _mdim)
        { 
            naziv = _naziv;
            mdim = _mdim;
            matrica = new Parcela[_mdim, _mdim];
            count = 0;
        }

        // read-write indekser
        public Parcela this[in int i, in int j]
        {
            get 
            {
                return matrica[i, j];
            }
            set 
            {
                matrica[i, j] = value;
            }
        }

        /*
            (i-3,j-3) (i-3,j-2) (i-3,j-1) (i-3, j ) (i-3,j+1) (i-3,j+2) (i-3,j+3)
            (i-2,j-3) (i-2,j-2) (i-2,j-1) (i-2, j ) (i-2,j+1) (i-2,j+2) (i-2,j+3)
            (i-1,j-3) (i-1,j-2) (i-1,j-1) (i-1, j ) (i-1,j+1) (i-1,j+2) (i-1,j+3)
            ( i ,j-3) ( i ,j-2) ( i ,j-1) ( i , j ) ( i ,j+1) ( i ,j+2) ( i ,j+3)
            (i+1,j-3) (i+1,j-2) (i+1,j-1) (i+1, j ) (i+1,j+1) (i+1,j+2) (i+1,j+3)
            (i+2,j-3) (i+2,j-2) (i+2,j-1) (i+2, j ) (i+2,j+1) (i+2,j+2) (i+2,j+3)
            (i+3,j-3) (i+3,j-2) (i+3,j-1) (i+3, j ) (i+3,j+1) (i+3,j+2) (i+3,j+3)
        */

        public double FaktorParcele(in int _i, in int _j)
        {

            double ret = 0d;

            if (_i < 0 || _i >= mdim ||
                _j < 0 || _j >= mdim)
                return -1;

            if (matrica[_i, _j] != null)
                return -1;

            for (int i = 3; i >= -3; --i) 
            {
                if (_i - i >= 0 && _i - i < mdim) 
                {
                    for (int j = 3; j >= -3; --j) 
                    {
                        if (_j - j >= 0 && _j - j < mdim && 
                            matrica[_i - i, _j - j] != null) 
                        {
                            if (i == 3 || i == -3
                                || j == 3 || j == -3)
                                ret += matrica[_i - i, _j - j].Vrednost * 0.125;
                            else if (i == 2 || i == -2
                                || j == 2 || j == -2)
                                ret += matrica[_i - i, _j - j].Vrednost * 0.25;
                            else if (i == 1 || i == -1
                                || j == 1 || j == -1)
                                ret += matrica[_i - i, _j - j].Vrednost * 0.5;
                        }
                            
                    }
                }
            }

            return ret;
        }

        public Parcela[] VratiNoveParcele()
        { 
            List<Parcela> lista = new List<Parcela> ();
            for (int i = 0; i < mdim; ++i)
                for (int j = 0; j < mdim; ++j)
                    if (matrica[i, j] != null &&
                        DateTime.Now.DayOfYear - 
                        matrica[i, j].Datum.DayOfYear <= 30)
                        lista.Add (matrica[i, j]);
            return lista.ToArray();
        }

        public void DodajOptimalno(Parcela p)
        {
            if (Object.ReferenceEquals(p, null))
                return;
            if (count == 0) {
                count++;
                matrica[0, 0] = p;
                return;
            }
            int maxi = -1, maxj = -1;
            double faktor = -1;
            for (int i = 0; i < mdim; ++i)
                for (int j = 0; j < mdim; ++j) 
                {
                    double temp = FaktorParcele(i, j);
                    if (faktor < temp)
                    {
                        maxi = i;
                        maxj = j;
                        faktor = temp;
                    }
                }
            if (faktor == -1)
                throw new Exception("Nema slobodnih parcela!");
            matrica[maxi, maxj] = p;
            count++;
        }

        public Parcela IzbaciMin()
        {
            double avg = 0d;
            for (int i = 0; i < mdim; ++i)
                for (int j = 0; j < mdim; ++j)
                    if (matrica[i, j] != null)
                        avg += matrica[i, j].Vrednost;
            avg /= count;
            int ir = -1, il = -1;
            for (int i = 0; i < mdim; ++i)
                for (int j = 0; j < mdim; ++j)
                    if (matrica[i, j] != null && 
                        matrica[i, j].Vrednost <= avg) 
                    {
                        ir = i;
                        il = j;
                        break;
                    }
            if (ir == -1)
                return null;
            Parcela parcela = matrica[ir, il];
            matrica[ir, il] = null;
            count--;
            return parcela;
                        
        }

        public void UpisTxt(string opath)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(
                        new FileStream(opath, FileMode.OpenOrCreate));
                sw.WriteLine(naziv);
                sw.WriteLine(mdim);
                sw.WriteLine(count);
                for (int i = 0; i < mdim; ++i)
                    for (int j = 0; j < mdim; ++j)
                        if (matrica[i, j] != null)
                        {
                            sw.WriteLine(i);
                            sw.WriteLine(j);
                            sw.WriteLine(matrica[i, j].GetType().Name);
                            matrica[i, j].UpisTxt(sw);
                        }
                
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace + "\n" + ex.ToString());
            }
            finally { sw.Close(); }
        }

        public void CitanjeTxt(string ipath)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(
                        new FileStream(ipath, FileMode.OpenOrCreate));
                naziv = sr.ReadLine();
                mdim = Int32.Parse(sr.ReadLine());
                int i = count = Int32.Parse(sr.ReadLine());
                matrica = new Parcela[mdim, mdim];
                while (i > 0)
                {
                    int ii = Int32.Parse(sr.ReadLine());
                    int ji = Int32.Parse(sr.ReadLine());
                    string tip = sr.ReadLine();
                    switch (tip)
                    {
                        case "Nekretnina":
                            matrica[ii, ji] = new Nekretnina();
                            break;
                        case "Park":
                            matrica[ii, ji] = new Park();
                            break;
                    }
                    matrica[ii, ji].CitanjeTxt(sr);
                    i--;
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.StackTrace + "\n" + ex.ToString());
            }
            finally { sr.Close(); }
        }

    }
}
