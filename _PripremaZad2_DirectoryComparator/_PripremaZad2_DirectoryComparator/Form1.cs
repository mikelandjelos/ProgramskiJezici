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
using System.Windows;

namespace _PripremaZad2_DirectoryComparator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIzaberi_Help(ref TextBox tbx, ref ListBox lbx)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() != DialogResult.OK)
                return;
            DirectoryInfo dir = new DirectoryInfo(fbd.SelectedPath);
            tbx.Text = dir.Name;
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo fi in files)
                lbx.Items.Add(fi);
        }

        private void btnIzaberiPrvi_Click(object sender, EventArgs e)
        {
            lbxPrviDir.Items.Clear();
            btnIzaberi_Help(ref tbxPrviDir, ref lbxPrviDir);
        }

        private void btnIzaberiDrugi_Click(object sender, EventArgs e)
        {
            lbxDrugiDir.Items.Clear();
            btnIzaberi_Help(ref tbxDrugiDir, ref lbxDrugiDir);
        }

        private void btnPronadjiIste_Click(object sender, EventArgs e)
        {
            lbxNadjeno.Items.Clear();
            foreach (object op in lbxPrviDir.Items)
                foreach (object od in lbxDrugiDir.Items)
                {
                    if (op.ToString() == od.ToString())
                        lbxNadjeno.Items.Add(op);
                }
        }
    }
}
