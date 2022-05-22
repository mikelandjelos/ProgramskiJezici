using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _PripremaZad3_Dictionary
{
    public partial class Form1 : Form
    {

        HashLogic hashLogic = new HashLogic();

        public Form1()
        {
            InitializeComponent();
        }

        // engleske reci su TKey
        private void btnEng_Click(object sender, EventArgs e)
        {
            if (tbxEng.Text == string.Empty)
                return;
            string key = tbxEng.Text;
            tbxEng.Clear();
            hashLogic.InsertKey(key);
            lbxEng.Items.Add(key);
        }

        // srpske su deo liste koja predstavlja TValue
        private void btnSrb_Click(object sender, EventArgs e)
        {
            if (lbxEng.SelectedItem == null)
                return;
            string key = lbxEng.SelectedItem.ToString();
            hashLogic.InsertTranslation(key, tbxSrb.Text);
            tbxSrb.Clear();
            TranslationsRefresh(key);
        }

        private void TranslationsRefresh(string key)
        {
            lbxSrb.Items.Clear();
            foreach (string s in hashLogic[key])
                lbxSrb.Items.Add(s);
        }

        private void lbxEng_DoubleClick(object sender, EventArgs e)
        {
            if (lbxEng.SelectedIndex == -1)
                return;
            tbxEng.Text = lbxEng.SelectedItem.ToString();
            TranslationsRefresh(lbxEng.SelectedItem.ToString());
        }

        private void lbxSrb_DoubleClick(object sender, EventArgs e)
        {
            if (lbxSrb.SelectedIndex == -1)
                return;
            tbxSrb.Text = lbxSrb.SelectedItem.ToString();
        }

        private void btnUkloniEng_Click(object sender, EventArgs e)
        {
            
            if (lbxEng.SelectedIndex == -1)
                return;
            hashLogic.WithdrawKey(lbxEng.SelectedItem.ToString());
            lbxEng.Items.Remove(lbxEng.SelectedItem);
            lbxSrb.Items.Clear();
        }

        private void btnUkloniSrb_Click(object sender, EventArgs e)
        {
            if (lbxSrb.SelectedIndex == -1 ||
                tbxEng.Text == String.Empty)
                return;
            string key = tbxEng.Text;
            hashLogic.WithdrawTranslation(key, lbxSrb.SelectedItem.ToString());
            lbxSrb.Items.Remove(lbxSrb.SelectedItem);
        }
    }
}
