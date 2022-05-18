using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _grupaV_Parking
{
    internal class Kamion : Vozilo
    {

        private double nosivost;

        //...a kamion može da zauzme različit broj
        //parking mesta(čuva taj broj kao atribut klase)...
        private static int? brMesta;

        // => mora biti postavljen pre prvog
        // instanciranja klase

        // nullable type mehanizmom smo postigli da
        // se staticki atribut brMesta moze
        // inicijalizovati samo jednom
        public static void initBrMesta(int brMesta) { 
            if (!Kamion.brMesta.HasValue)
                Kamion.brMesta = brMesta;
        }

        public override int BrojMesta {
            get {
                return (Kamion.brMesta.HasValue) ? 
                    Kamion.brMesta.Value : -1;
            }
        }

        public double Nosivost {
            get { return nosivost; }
            set { nosivost = value; }
        }

        public Kamion(string reg = null, string proizv = null, string mod = null,
            double nosivost = -1)
            : base(reg, proizv, mod) {
            if (!Kamion.brMesta.HasValue)
                throw new Exception("Nemoguce instancirati klasu kamion");
            this.nosivost = nosivost;
        }

        public override string ToAsciiArt()
        {
            return @"
         __   __________
       _//]| |          |
      |____|-|__________|
        0      0     0";
        }

        public override string ToString() {
            return base.ToString() +
                "\nNosivost: " + nosivost;
        }

        public override void upisBin(BinaryWriter bw)
        {
            try
            {
                base.upisBin(bw);
                bw.Write(nosivost);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public override void procitajBin(BinaryReader br)
        {
            try
            {
                base.procitajBin(br);
                nosivost = br.ReadDouble();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool operator ==(in Kamion levi, in Kamion desni)
        {
            return levi.Equals(desni);
        }

        public static bool operator !=(in Kamion levi, in Kamion desni)
        {
            return !levi.Equals(desni);
        }

        public override bool Equals(object obj)
        {
            Kamion kamion = obj as Kamion;
            if (kamion == null)
                return false;
            return registarskaOznaka == kamion.registarskaOznaka &&
                proizvodjac == kamion.Proizvodjac &&
                model == kamion.model &&
                nosivost == kamion.nosivost;
        }

        public override int GetHashCode()
        {
            return (registarskaOznaka + proizvodjac + model).GetHashCode()
                + nosivost.GetHashCode() * 33;
        }

    }
}
