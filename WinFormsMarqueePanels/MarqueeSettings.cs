using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsMarqueePanels
{
    public partial class MarqueeSettings : Form
    {
        public string MarqueeText { get; set; }

        public int TimerInterval { get; set; }

        public MarqueeSettings(int timerInterval, string marqueeText)
        {
            InitializeComponent();
            TimerInterval = timerInterval;
            MarqueeText = marqueeText;

            cmbInterval.SelectedItem = timerInterval.ToString();
            txtMarqueeLabel.Text = marqueeText;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MarqueeText = txtMarqueeLabel.Text;
            TimerInterval = int.Parse(cmbInterval.SelectedItem.ToString());
        }
    }
}
