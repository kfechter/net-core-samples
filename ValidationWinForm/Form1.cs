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

namespace ValidationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            var parsedUserInput = txtInput.Text.IsValidIntegerandWithinBounds(1, 10);
            var dialogTitle = parsedUserInput.Item1 ? "Congratulations" : "Validation Error";
            MessageBox.Show(parsedUserInput.Item2, dialogTitle);
        }
    }
}
