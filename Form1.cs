using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topics_9_11_assignment_1
{
    public partial class FormCalculator : Form
    {
        string operation;
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
            double numOne, numTwo;
            numOne = Convert.ToDouble(txtNumOne.Text);
            numTwo = Convert.ToDouble(txtNumTwo.Text);
            if (operation == "+")
            {
                lblAnswer.Text = (numOne + numTwo).ToString();
            }
            else if (operation == "-")
            {
                lblAnswer.Text = (numOne - numTwo).ToString();
            }
            else if (operation == "*")
            {
                lblAnswer.Text = (numOne * numTwo).ToString();
            }
            else if (operation == "/")
            {
                lblAnswer.Text = (numOne / numTwo).ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            operation = "+";
            lblOperator.Text = operation;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            lblOperator.Text = operation;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operation = "/";
            lblOperator.Text = operation;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operation = "*";
            lblOperator.Text = operation;
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            operation = "";
            lblOperator.Text = operation;
        }

        
    }
}
