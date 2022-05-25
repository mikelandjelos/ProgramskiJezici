using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _GUI_Automobili
{

    public enum VrsteGoriva
    { 
        NullGorivo = -1, Benzin, Dizel, Gas
    }

    internal class Automobil
    {

        private string proizvodjac;
        private string model;
        private double zapreminaMotora;
        private DateTime datumProizvodnje;
        private VrsteGoriva vrstaGoriva;
        private bool imaAtest;

        #region Konstruktori

        public Automobil()
        {
            proizvodjac = "";
            model = "";
            zapreminaMotora = -1;
            datumProizvodnje = DateTime.MinValue;
            vrstaGoriva = VrsteGoriva.NullGorivo;
            imaAtest = false;
        }

        public Automobil(string _proizvodjac, string _model,
            double _zapreminaMotora, DateTime _datumProizvodnje,
            VrsteGoriva _vrstaGoriva, bool _imaAtest)
        { 
            proizvodjac = _proizvodjac;
            model = _model;
            zapreminaMotora = _zapreminaMotora;
            datumProizvodnje = _datumProizvodnje;
            vrstaGoriva = _vrstaGoriva;
            imaAtest = _imaAtest;
        }

        #endregion

        #region Properties

        public string Proizvodjac 
        { get { return proizvodjac; } set { proizvodjac = value; } }

        public string Model
        { get { return model; } set { model = value; } }

        public double ZapreminaMotora
        { get { return zapreminaMotora; } set { zapreminaMotora = value; } }

        public DateTime DatumProizvodnje
        { get { return datumProizvodnje; } set { datumProizvodnje = value; } }

        public VrsteGoriva VrstaGoriva
        { get { return vrstaGoriva; } set { vrstaGoriva = value; } }

        public bool ImaAtest
        { get { return imaAtest; } set { imaAtest = value; } }

        #endregion

        #region Misc

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(proizvodjac + " ");
            sb.Append(model + " ");
            sb.Append(zapreminaMotora + " ");
            sb.Append(vrstaGoriva + " ");
            if (vrstaGoriva == VrsteGoriva.Gas)
                if (imaAtest)
                    sb.Append("(ima atest) ");
                else
                    sb.Append("(nema atest) ");
            sb.Append(datumProizvodnje.ToShortDateString() + " ");
            return sb.ToString();
        }

        public void UpisiTxt(StreamWriter sw)
        {
            try
            {

                sw.WriteLine(proizvodjac);
                sw.WriteLine(model);
                sw.WriteLine(zapreminaMotora);
                sw.WriteLine(datumProizvodnje);
                sw.WriteLine(imaAtest);

            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpisiTxt(string path, in List<Automobil> list)
        {

            try
            {

                using (StreamWriter sw = new StreamWriter(
                    new FileStream(path, FileMode.OpenOrCreate)))
                {

                    sw.WriteLine(list.Count);
                    foreach (Automobil automobil in list)
                        automobil.UpisiTxt(sw);

                }

            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        #endregion

    }
}
