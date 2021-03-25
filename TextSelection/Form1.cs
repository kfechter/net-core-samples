using System;
using System.Text;
using System.Windows.Forms;

namespace TextSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowSelection_Click(object sender, EventArgs e)
        {
            if(txtInput.SelectionLength == 0)
            {
                MessageBox.Show("You need to select something inside the box first", "No Text Selected");
                return;
            }

            StringBuilder builder = new StringBuilder();
            builder.Append($"The input box contains {txtInput.Text}\n");
            builder.Append($"You have selected {txtInput.SelectionLength} characters, starting at {txtInput.SelectionStart}\n");
            builder.Append($"The selection is {txtInput.SelectedText}");
            MessageBox.Show(builder.ToString(), "Selection Info");
        }
    }
}
