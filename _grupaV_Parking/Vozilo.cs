using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _grupaV_Parking
{
    internal abstract class Vozilo
    {

        // ...svako vozilo karakterise registarska oznaka,
        // proizvodjac i naziv modela...
        protected string registarskaOznaka;
        protected string proizvodjac;
        protected string model;

        // ... Vozilo samo odredjuje koliko
        // standardnih parking mesta mu je potrebno...

        // kreiramo apstraktno svojstvo ciji cemo 'get deo'
        // da override-ujemo u izvedenim klasama
        public abstract int BrojMesta {
            get;
        }

        // javna read-write svojstva za manipulaciju atributima
        public string RegistarskaOznaka {
            get { 
                return registarskaOznaka;
            }
            set { 
                registarskaOznaka = value;
            }
        }

        public string Proizvodjac {
            get { 
                return proizvodjac;
            }
            set {
                proizvodjac = value;
            }
        }

        public string Model {
            get { 
                return model;
            }
            set { 
                model = value;
            }
        }

        // metode

        protected Vozilo(string reg = null, string proizv = null, string mod = null)
        {
            registarskaOznaka = reg;
            proizvodjac = proizv;
            model = mod;
        }

        public abstract string ToAsciiArt();

        public override string ToString()
        {
            return "Registarska oznaka: " + registarskaOznaka
                + "\nProizvodjac: " + proizvodjac
                + "\nModel: " + model;
        }

        public virtual void upisBin(BinaryWriter bw)
        {
            try
            {
                bw.Write(registarskaOznaka);
                bw.Write(proizvodjac);
                bw.Write(model);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public virtual void procitajBin(BinaryReader br) {
            try
            {
                registarskaOznaka = br.ReadString();
                proizvodjac= br.ReadString();
                model = br.ReadString();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
