using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _GUI_Filmovi
{
    public partial class Form1 : Form
    {

        private List<Film> filmovi;

        public Form1()
        {
            InitializeComponent();
            filmovi = new List<Film>();
            foreach (string fz in Enum.GetNames(typeof(Film.FilmskiZanr)))
                if (fz != "NullFilm")
                    cmbxZanr.Items.Add(fz);
        }

        private void FormaUFilm(out Film film)
        {
            film = new Film();
            film.Naslov = tbxNaslov.Text;
            film.Reditelj = tbxReditelj.Text;
            film.Ocena = (double)numOcena.Value;
            film.DatumPremijere = datDatum.Value;
            EkstraktujZanr(ref film);
            film.MinimalniUzrast = (int)numMinUzr.Value;
        }

        private void FilmUFormu(in Film film)
        {
            tbxNaslov.Text = film.Naslov.ToString();
            tbxReditelj.Text = film.Reditelj.ToString();
            numOcena.Value = (decimal)film.Ocena;
            datDatum.Value = film.DatumPremijere;
            InsertujZanr(in film);
            numMinUzr.Value = (decimal)film.MinimalniUzrast;
        }

        private bool EkstraktujZanr(ref Film film)
        {
            Film.FilmskiZanr fz;
            if (!Enum.TryParse(cmbxZanr.Text, out fz))
            {
                film.Zanr = Film.FilmskiZanr.NullFilm;
                return false;
            }
            film.Zanr = fz;
            return true;
        }

        private void InsertujZanr(in Film film)
        {
            cmbxZanr.Text = film.Zanr.ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Film film;
            FormaUFilm(out film);
            filmovi.Add(film);
            lbxFilmovi.Items.Clear();
            lbxFilmovi.Items.AddRange(filmovi.ToArray());
        }

        private void lbxFilmovi_DoubleClick(object sender, EventArgs e)
        {
            if (lbxFilmovi.SelectedItem == null)
                return;
            Film film = lbxFilmovi.SelectedItem as Film;
            if (film == null)
                return;
            PodaciOFilmu pof = new PodaciOFilmu(in film);
            pof.Show();
            //    FilmUFormu(in film);
        }

        private void cmbxZanr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxZanr.SelectedIndex == -1)
                return;
            Film.FilmskiZanr fz;
            Enum.TryParse(cmbxZanr.SelectedItem.ToString(), out fz);
            if (fz == Film.FilmskiZanr.Bajka)
                numMinUzr.Enabled = false;
            else
                numMinUzr.Enabled = true;
        }
    }
}
