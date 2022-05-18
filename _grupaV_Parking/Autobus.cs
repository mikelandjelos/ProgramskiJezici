using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _grupaV_Parking
{
    class Autobus : Vozilo
    {

        private int brojPutnika;
        public override int BrojMesta
        {
            get { return 5; }
        }

        public int BrojPutnika {
            get { return brojPutnika; }
            set { brojPutnika = value; }
        }

        public Autobus(string reg = null, string proizv = null, string mod = null,
            int brojPutnika = -1)
            : base(reg, proizv, mod) 
        {
            this.brojPutnika = brojPutnika;
        }

        public override string ToAsciiArt()
        {
            return @"
           ___________
          [__         |
         __/_| [] []  |
        [_,________,__|
          0        0";
        }

        public override string ToString()
        {
            return base.ToString() + 
                "\nBroj putnika: " + brojPutnika;
        }

        public override void upisBin(BinaryWriter bw)
        {
            try
            {
                base.upisBin(bw);
                bw.Write(brojPutnika);
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
                brojPutnika = br.ReadInt32();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static bool operator ==(in Autobus levi, in Autobus desni)
        {
            return levi.Equals(desni);
        }

        public static bool operator !=(in Autobus levi, in Autobus desni)
        {
            return !levi.Equals(desni);
        }

        public override bool Equals(object obj)
        {
            Autobus autobus = obj as Autobus;
            if (autobus == null)
                return false;
            return registarskaOznaka == autobus.registarskaOznaka &&
                proizvodjac == autobus.Proizvodjac &&
                model == autobus.model &&
                brojPutnika == autobus.brojPutnika;
        }

        public override int GetHashCode()
        {
            return (registarskaOznaka + proizvodjac + model).GetHashCode()
                + brojPutnika * 33;
        }

    }
}
