using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsMarqueePanels
{
    public partial class Form1 : Form
    {
        private Timer marqueeTimer;

        private int timerInterval = 100;

        private string marqueeLabelText = "Example Timer Marquee";

        private List<Control> FormControls => Controls.OfType<Panel>().Cast<Control>().ToList();

        public Form1()
        {
            InitializeComponent();
            marqueeTimer = new Timer
            {
                Interval = timerInterval,
                Enabled = true
            };
            marqueeTimer.Tick += MarqueeTimer_Tick;
            lblMarqueeText.Text = marqueeLabelText;
        }

        private void MarqueeTimer_Tick(object sender, EventArgs e)
        {
            foreach(var control in FormControls)
            {
                control.BackColor = (control.BackColor == Color.Blue) ? Color.Yellow : Color.Blue;
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            marqueeTimer.Enabled = !marqueeTimer.Enabled;
            btnStartStop.Text = marqueeTimer.Enabled ? "Stop" : "Start";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MarqueeSettings marqueeSettings = new MarqueeSettings(timerInterval, marqueeLabelText);
            if(marqueeSettings.ShowDialog() == DialogResult.OK)
            {
                timerInterval = marqueeSettings.TimerInterval;
                marqueeLabelText = marqueeSettings.MarqueeText;

                lblMarqueeText.Text = marqueeLabelText;
                marqueeTimer.Interval = timerInterval;
            }
        }
    }
}
