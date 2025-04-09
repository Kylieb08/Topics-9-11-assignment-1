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
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
            double numOne, numTwo;
            numOne = Convert.ToDouble(txtNumOne.Text);
            numTwo = Convert.ToDouble(txtNumTwo.Text);
        }

        
    }
}
