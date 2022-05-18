using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _grupaV_Parking
{
    internal class Parking
    {

        private Matrica<Vozilo> parking;
        private int count;

        public Parking(int n, int m) { 
            parking = new Matrica<Vozilo>(n, m);
            count = 0;
        }

        // read-only svojstvo => mogu da ga menjaju samo metode klase
        // (konkretno uparkirajVozilo i isparkirajVozilo)
        public int BrojVozila { get { return count; } }

        public void uparkirajVozilo(Vozilo v) {
            int brMesta = v.BrojMesta;
            for (int i = 0; i < parking.brojVrsta; ++i) {
                for (int j = 0; j < parking.brojKolona; ++j) {
                    bool slobodno = true;
                    if (parking[i, j] == null) { // ako nadjemo slobodno mesto
                        int k;
                        for (k = 0; k < brMesta && j + k < parking.brojKolona; ++k)
                            if (parking[i, j + k] != null) { // gledamo da li su i narednih brMesta slobodna
                                slobodno = false;
                                break;
                            }
                        if (slobodno && k == brMesta) { // ako jesu (i nismo izasli van granica kolone)
                            for (k = 0; k < brMesta; ++k) // uparkiraj vozilo
                                parking[i, j + k] = v;
                            count++;
                            return;
                        }
                        j += k - 1;
                    }
                    //bool slobodno = true;
                    //for (int k = 0; k < brMesta; ++k)
                    //    if (parking[i, j + k] != null) { 
                    //        slobodno = false;
                    //        break;
                    //    }
                    //if (slobodno) {
                    //    for (int k = 0; k < brMesta; ++k)
                    //        parking[i, j + k] = v;
                    //    count++;
                    //    return;
                    //}
                }
            }
            throw new NemaMesta();
        }

        public bool isparkirajVozilo(Vozilo v)
        {
            int brMesta = v.BrojMesta;
            for (int i = 0; i < parking.brojVrsta; ++i)
            {
                for (int j = 0; j < parking.brojKolona; ++j)
                {
                    if (parking[i,j] == v)
                    {
                        for (int k = 0; k < brMesta; ++k)
                            parking[i, j + k] = null;
                        count--;
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            return parking.ToString();
        }

        public void upisiBin(string binFajl)
        {
            using (BinaryWriter bw
                = new BinaryWriter(new FileStream(binFajl, FileMode.Open)))
            {
                bw.Write(count);
                bw.Write(parking.brojVrsta);
                bw.Write(parking.brojKolona);

                for (int i = 0; i < parking.brojVrsta; ++i)
                    for (int j = 0; j < parking.brojKolona; ++j)
                        if (parking[i, j] != null)
                        {
                            bw.Write(i);
                            bw.Write(j);
                            bw.Write(parking[i, j].GetType().Name);
                            bw.Write(parking[i, j].BrojMesta);
                            parking[i, j].upisBin(bw);
                            j += parking[i, j].BrojMesta - 1;
                        }
            }
        }

        public void procitajBin(string binFajl) {
            using (BinaryReader br
                = new BinaryReader(new FileStream(binFajl, FileMode.Open))) {
                count = br.ReadInt32();
                int l = count;
                int n = br.ReadInt32();
                int m = br.ReadInt32();
                parking = new Matrica<Vozilo>(n, m);
                while (l > 0) { 
                    int i = br.ReadInt32();
                    int j = br.ReadInt32();
                    string tip = br.ReadString();
                    int brMesta = br.ReadInt32();
                    Vozilo vozilo = null;
                    switch (tip) {
                        case "Automobil":
                            vozilo = new Automobil();
                            break;
                        case "Autobus":
                            vozilo = new Autobus();
                            break;
                        case "Kamion":
                            vozilo = new Kamion();
                            break;
                    }
                    if (vozilo != null) { 
                        vozilo.procitajBin(br);
                        for (int k = 0; k < vozilo.BrojMesta; ++k)
                            parking[i, j + k] = vozilo;
                        l--;
                    }
                }
            }
        }

    }
}
