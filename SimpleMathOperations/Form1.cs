using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extensions;

namespace SimpleMathOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            switch(cmbOperation.Text)
            {
                case "Add":
                    ValidateResult(txtValueOne.Text.TryAdd(txtValueTwo.Text), $"{txtValueOne.Text} + {txtValueTwo.Text}");
                    break;
                case "Subtract":
                    ValidateResult(txtValueOne.Text.TrySubtract(txtValueTwo.Text), $"{txtValueOne.Text} - {txtValueTwo.Text}");
                    break;
                case "Multiply":
                    ValidateResult(txtValueOne.Text.TryMultiply(txtValueTwo.Text), $"{txtValueOne.Text} * {txtValueTwo.Text}");
                    break;
                case "Divide":
                    ValidateResult(txtValueOne.Text.TryDivide(txtValueTwo.Text), $"{txtValueOne.Text} / {txtValueTwo.Text}");
                    break;
                default:
                    MessageBox.Show("Invalid Operation Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ValidateResult(Tuple<bool, double> result, string operation)
        {
            if(!result.Item1)
            {
                MessageBox.Show($"{operation} Failed, please check inputs and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"The Result of {operation} is {result.Item2}");
            }
        }
    }
}
