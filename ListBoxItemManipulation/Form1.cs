using Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxItemManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if(txtItem.Text.IsNullWhitespaceOrEmpty())
            {
                return;
            }

            if(lstItems.SelectedItem != null)
            {
                lstItems.Items[lstItems.SelectedIndex] = txtItem.Text;
                lstItems.Refresh();
                lstItems.ClearSelected();
                txtItem.Clear();
            }
            else
            {
                lstItems.Items.Add(txtItem.Text);
                txtItem.Clear();
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if(lstItems.SelectedItem != null)
            {
                lstItems.Items.Remove(lstItems.SelectedItem);
                lstItems.ClearSelected();
                txtItem.Clear();
            }
        }

        private void lstItems_SelectedValueChanged(object sender, EventArgs e)
        {
            if(lstItems.SelectedItem != null)
            {
                txtItem.Text = ((ListBox)sender).SelectedItem.ToString();
            }
        }
    }
}
