using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimitivniKalkulator
{
    public partial class Forma : Form
    {

        private CalculatorLogic calculatorLogic;
        private bool justCalculated;

        public Forma()
        {
            InitializeComponent();
            justCalculated = false;
        }

        public void btnOp_Click(object sender, EventArgs e)
        {
            if (justCalculated)
            {
                btnClr_Click(sender, e);
                justCalculated = false;
            }
            Button btn = sender as Button;
            if (btn == null)
                return;
            this.txtBox.AppendText(btn.Text);
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "")
                return;
            try
            {
                // expression prolazi kroz validaciju tokom
                // samog kreiranja objekta
                calculatorLogic
                    = new CalculatorLogic(this.txtBox.Text);

                this.txtBox.Text 
                    = calculatorLogic.CalculateExpression().ToString();

                justCalculated = true;

            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error ocurred: " + ex.Message);
                btnClr_Click(sender, e);
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
        }

        private void btnBckspc_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            txtBox.Text 
                = txtBox.Text.Remove(txtBox.Text.Length - 1);
        }
    }

}
