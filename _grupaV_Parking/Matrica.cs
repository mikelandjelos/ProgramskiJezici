using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _grupaV_Parking
{
    internal class Matrica<T> // parametrizovana kolekcija objekata
        where T : Vozilo
        // ...koja će u sebi pamti matricu elemenata tipa Vozilo ili tipa
        // izvedenog iz klase Vozilo...
    {
        private T[,] matrix;
        private int n, m;

        // write-only svojstva
        public T[,] Matrix {
            get { return matrix; }
        }

        public int brojVrsta {
            get { return n; }
        }

        public int brojKolona { 
            get { return m; }
        }

        public Matrica(int n, int m) {
            matrix = new T[n, m];
            this.n = n;
            this.m = m;
        }

        private bool indeksiDobri(int i, int j) {
            return i >= 0 && i < n && j >= 0 && j < m;
        }

        public void postavi(int i, int j, T obj) {
            if (!indeksiDobri(i, j))
                throw new IndexOutOfRangeException("Indeksi van granica!");
            matrix[i, j] = obj;
        }

        public T vrati(int i, int j) {
            if (!indeksiDobri(i, j))
                throw new IndexOutOfRangeException("Indeksi van granica!");
            return matrix[i, j];
        }

        public T izbaci(int i, int j) {
            if (!indeksiDobri(i, j))
                throw new IndexOutOfRangeException("Indeksi van granica!");
            T ret = matrix[i, j];
            matrix[i, j] = null;
            return ret;
        }

        public T this[int i, int j] {
            get { return vrati(i,j); }
            set { postavi(i, j, value); }
        }

        public override string ToString()
        {
            string ispis = "";
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j) {

                    ispis = ispis + "[" + i + "][" + j + "]:\n" +
                        ((matrix[i, j] != null) ?
                        matrix[i, j].ToString() + "\n" +
                        matrix[i, j].ToAsciiArt() : "-") + "\n";

                    j += ((matrix[i, j] != null) ?
                        matrix[i, j].BrojMesta - 1 : 0);

                }
            return ispis;
        }

    }
}
