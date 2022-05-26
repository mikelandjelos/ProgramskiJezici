using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _GUI_Filmovi
{
    public class Film
    {

        public enum FilmskiZanr
        { 
            NullFilm = -1,
            Drama,
            Ratni,
            Horor,
            Bajka
        }

        #region Attributes

        private string naslov;
        private string reditelj;
        private double ocena;
        private DateTime datumPremijere;
        private FilmskiZanr zanr;
        private int minimalniUzrast;

        #endregion

        #region Properties

        public string Naslov
        { get { return naslov; } set { naslov = value; } }

        public string Reditelj
        { get { return reditelj; } set { reditelj = value; } }

        public double Ocena
        { get { return ocena; } set { ocena = value; } }

        public DateTime DatumPremijere
        { get { return datumPremijere; } set { datumPremijere = value; } }

        public FilmskiZanr Zanr
        { get { return zanr; } set { zanr = value; } }

        public int MinimalniUzrast
        { get { return minimalniUzrast; } set { minimalniUzrast = value; } }

        #endregion

        #region Constructors

        public Film()
        {
            naslov = "";
            reditelj = "";
            ocena = -1;
            datumPremijere = DateTime.MinValue;
            zanr = FilmskiZanr.NullFilm;
            minimalniUzrast = -1;
        }

        #endregion

        #region Misc

        public override string ToString()
        {
            if (zanr == FilmskiZanr.NullFilm)
                return "null";

            StringBuilder sb = new StringBuilder();

            sb.Append(naslov + " by ");
            sb.Append(reditelj + ", ");
            sb.Append(ocena + ", ");
            sb.Append(zanr + ", ");
            if (zanr != Film.FilmskiZanr.Bajka)
                sb.Append("(nije prikladan za mladje od " + minimalniUzrast + " godina), ");
            sb.Append(datumPremijere.ToShortDateString());

            return sb.ToString();
        }

        #endregion

    }
}
