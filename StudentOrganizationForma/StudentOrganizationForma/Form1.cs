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

namespace StudentOrganizationForma
{
    public partial class Form1 : Form
    {

        // List<Student> studenti;

        public Form1()
        {
            InitializeComponent();
            // studenti = new List<Student>();
        }

        #region Misc
        //private void SinhronizujLBX()
        //{ 
        //    if (lbxStudenti.Items.Count > 0)
        //        lbxStudenti.Items.Clear();
        //    lbxStudenti.Items.AddRange(studenti.ToArray());
        //}

        //private void SinhronizujListu()
        //{ 
        //    if (studenti.Count > 0)
        //        studenti.Clear();
        //    foreach (Student s in lbxStudenti.Items)
        //        studenti.Add(s);
        //}

        private void StudentUFormu(in Student s)
        {
            tbxIme.Text = s.Ime;
            tbxPrezime.Text = s.Prezime;
            numBrInd.Value = s.BrInd;
            PostaviNivo(in s);
            numGodStud.Value = s.GodinaStudija;
            numProsek.Value = (decimal)s.Prosek;
            if (s.FIB)
                cbxBudzet.Checked = true;
            else cbxBudzet.Checked = false;
            datRodj.Value = s.DatRodj;
        }

        private void FormaUStudenta(out Student s)
        {
            s = new Student();
            s.Ime = tbxIme.Text;
            s.Prezime = tbxPrezime.Text;
            s.BrInd = (int)numBrInd.Value;
            ProcitajNivo(ref s);
            s.GodinaStudija = (int)numGodStud.Value;
            s.Prosek = (double)numProsek.Value;
            s.FIB = cbxBudzet.Checked;
            s.DatRodj = datRodj.Value;
        }

        private void PostaviNivo(in Student s)
        {
            switch ((int)s.NivoStudija)
            {
                case 0:
                    rdbOsnovne.Checked = true;
                    break;
                case 1:
                    rdbMaster.Checked = true;
                    break;
                case 2:
                    rdbDoktorske.Checked = true;
                    break;
            }
        }

        private void ProcitajNivo(ref Student s)
        {
            if (rdbOsnovne.Checked)
                s.NivoStudija = (NivoStudija)0;
            else if (rdbMaster.Checked)
                s.NivoStudija = (NivoStudija)1;
            else if (rdbDoktorske.Checked)
                s.NivoStudija = (NivoStudija)2;
        }
        #endregion

        #region EventHandlers
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Student student;
            this.FormaUStudenta(out student);
            if (lbxStudenti.Items.Contains(student))
                return;
            //studenti.Add(student);
            //SinhronizujLBX();
            lbxStudenti.Items.Add(student);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (lbxStudenti.SelectedItem == null)
                return;
            lbxStudenti.Items.Remove(lbxStudenti.SelectedItem);
            // SinhronizujListu();
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if (lbxStudenti.SelectedIndex == -1)
                return;
            Student s;
            FormaUStudenta(out s);
            lbxStudenti.Items[lbxStudenti.SelectedIndex] = s;
            // SinhronizujListu();
        }

        private void rdbOsnovne_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOsnovne.Checked)
                numGodStud.Maximum = 4;
            else if (rdbMaster.Checked)
                numGodStud.Maximum = 1;
            else if (rdbDoktorske.Checked)
                numGodStud.Maximum = 3;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary Files | *.bin";
            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string path = saveFileDialog.FileName;
            BinaryWriter bw = null;
            try
            {
                bw
                    = new BinaryWriter(new FileStream(path, FileMode.Create));
                bw.Write(lbxStudenti.Items.Count);
                foreach (Student s in lbxStudenti.Items)
                    Student.UpisBin(bw, in s);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                bw.Close();
            }
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary Files | *.bin";
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            string path = openFileDialog.FileName;
            BinaryReader br = null;
            try
            {
                br = 
                    new BinaryReader(new FileStream(path, FileMode.Open));
                int count = br.ReadInt32();
                for (int i = 0; i < count; ++i) {
                    Student s;
                    Student.CitajBin(br, out s);
                    lbxStudenti.Items.Add(s);
                }
                // SinhronizujLBX();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                br.Close();
            }
        }

        private void lbxStudenti_DoubleClick(object sender, EventArgs e)
        {
            Student student = lbxStudenti.SelectedItem as Student;
            if (student == null)
                return;
            StudentUFormu(student);
        }
        #endregion
    }
}
