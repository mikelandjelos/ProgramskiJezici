using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _GUI_Automobili
{
    public partial class Form1 : Form
    {

        private List<Automobil> automobili;

        public Form1()
        {
            InitializeComponent();
            automobili = new List<Automobil>();
        }

        private void FormaUAutomobil(out Automobil a)
        { 
            a = new Automobil();
            a.Proizvodjac = tbxProizvodjac.Text;
            a.Model = tbxModel.Text;
            a.ZapreminaMotora = (double)numZapremina.Value;
            a.DatumProizvodnje = datDatum.Value;
            UcitajVrstuGoriva(ref a);
            if (chkAtest.Enabled)
                a.ImaAtest = chkAtest.Checked;
        }

        private void AutomobilUFormu(in Automobil a)
        {
            tbxProizvodjac.Text = a.Proizvodjac;
            tbxModel.Text = a.Model;
            numZapremina.Value = (decimal)a.ZapreminaMotora;
            datDatum.Value = a.DatumProizvodnje;
            UpisiVrstuGoriva(in a);
            if (chkAtest.Enabled)
                chkAtest.Checked = a.ImaAtest;
        }

        private void UcitajVrstuGoriva(ref Automobil a)
        {
            if (rdbBenzin.Checked)
                a.VrstaGoriva = VrsteGoriva.Benzin;
            else if (rdbDizel.Checked)
                a.VrstaGoriva = VrsteGoriva.Dizel;
            else if (rdbGas.Checked)
                a.VrstaGoriva = VrsteGoriva.Gas;
        }

        private void UpisiVrstuGoriva(in Automobil a)
        {
            switch (a.VrstaGoriva)
            {
                case VrsteGoriva.Benzin:
                    rdbBenzin.Checked = true;
                    break;
                case VrsteGoriva.Dizel:
                    rdbDizel.Checked = true;
                    break;
                case VrsteGoriva.Gas:
                    rdbGas.Checked = true;
                    break;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Automobil a;
            FormaUAutomobil(out a);
            automobili.Add(a);
            lbxAutomobili.Items.Clear();
            lbxAutomobili.Items.AddRange(automobili.ToArray());
        }

        private void rdbBenzin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGas.Checked)
                chkAtest.Enabled = true;
            else
                chkAtest.Enabled = false;
        }

        private void lbxAutomobili_DoubleClick(object sender, EventArgs e)
        {
            if (lbxAutomobili.SelectedItem == null)
                return;
            Automobil b = lbxAutomobili.SelectedItem as Automobil;
            if (b != null)
                AutomobilUFormu(in b);
        }

        private void snimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = " Tekstualni fajlovi | *.txt ";
            if (save.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                Automobil.UpisiTxt(save.FileName, automobili);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
