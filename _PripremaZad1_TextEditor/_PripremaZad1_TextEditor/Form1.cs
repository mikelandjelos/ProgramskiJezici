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

namespace _PripremaZad1_TextEditor
{
    public partial class Forma : Form
    {
        public Forma()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Control | Keys.S:
                    snimiToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.Control | Keys.O:
                    otvoriToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.Control | Keys.A:
                    selektujSveToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.Control | Keys.D:
                    datumVremeToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.Control | Keys.Z:
                    txtBox.Undo();
                    break;
            }
        }

        private void snimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = null;
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Tekstualni fajl | *.txt";
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                streamWriter = new StreamWriter(
                    new FileStream(saveFileDialog.FileName, FileMode.Create));
                streamWriter.Write(txtBox.Text);
            }
            catch (IOException ex)
            { 
                MessageBox.Show(ex.Message);
            }
            finally
            {
                streamWriter?.Close();
            }
        }

        private void otvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader streamReader = null;
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Tekstualni fajl | *.txt";
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                streamReader = new StreamReader(
                    new FileStream(openFileDialog.FileName, FileMode.Open));
                txtBox.Text = streamReader.ReadToEnd();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                streamReader?.Close();
            }
        }

        private void datumVremeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox.Text += DateTime.Now.ToString();
        }

        private void selektujSveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBox.SelectAll();
        }
    }
}
