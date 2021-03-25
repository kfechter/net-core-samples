using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultilineShowline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowLines_Click(object sender, EventArgs e)
        {
            StringBuilder lineinfo = new StringBuilder();
            lineinfo.Append("There are " + txtLines.Lines.Length.ToString() + " lines.\n");
            foreach (string line in txtLines.Lines)
            {
                lineinfo.Append(line + "\n");
            }
            MessageBox.Show(lineinfo.ToString());
        }
    }
}
