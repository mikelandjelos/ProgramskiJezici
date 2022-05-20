using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
            MaintainRatio();
        }

        private void BtnSizeRatio(out int w, out int h)
        {
            w = this.Size.Width / 20;
            h = this.Size.Height / 20;
        }

        private void MaintainRatio()
        {
            int w, h;
            BtnSizeRatio(out w, out h);
            btnAdd.Size = new Size(w, h);
            btnSub.Size = new Size(w, h);
            btnMul.Size = new Size(w, h);
            btnDiv.Size = new Size(w, h);
        }

        public double First
        {
            get
            {
                double firstOperand;
                if (!Double.TryParse(txtFirstOperand.Text, out firstOperand))
                    throw new FormatException("First operand bad format!");
                return firstOperand;
            }
        }

        public double Second
        {
            get
            { 
                double secondOperand;
                if (!Double.TryParse(txtSecondOperand.Text, out secondOperand))
                    throw new FormatException("Second operand bad format!");
                return secondOperand;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                txtResult.Text = (First + Second).ToString();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (First - Second).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (First * Second).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                txtResult.Text = (First / Second).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstOperand.Clear();
            txtSecondOperand.Clear();
            txtResult.Clear();
        }

        private void Calculator_Resize(object sender, EventArgs e)
        {
            MaintainRatio();
        }
    }
}
