using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _grupaV_Parking
{
    internal class Automobil : Vozilo
    {

        public override int BrojMesta 
        {
            get { return 1; }
        }

        public Automobil(string reg = null, string proizv = null, string mod = null)
            : base(reg, proizv, mod) { }

        public override string ToAsciiArt()
        {
            return @"
             _
         ___/_|_____
        [_,_______,_]
          0       0";
        }

        public static bool operator ==(in Automobil levi, in Automobil desni) 
        {
            return levi.Equals(desni);
        }

        public static bool operator !=(in Automobil levi, in Automobil desni)
        {
            return !levi.Equals(desni);
        }

        public override bool Equals(object obj) 
        { 
            Automobil automobil = obj as Automobil;
            if (automobil == null)
                return false;
            return registarskaOznaka == automobil.registarskaOznaka &&
                proizvodjac == automobil.Proizvodjac &&
                model == automobil.model;
        }

        public override int GetHashCode()
        {
            return (registarskaOznaka + proizvodjac + model).GetHashCode();
        }

    }
}
