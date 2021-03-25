using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        string timeZoneName => TimeZoneInfo.Local.IsDaylightSavingTime(DateTime.Now) ? TimeZoneInfo.Local.DaylightName : TimeZoneInfo.Local.DisplayName;
        string timeLabel => $"The Date and Time for {timeZoneName} is:";

        bool stopWatchRunning = false;

        Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            clockTimer.Start();
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lblTimePrompt.Text = timeLabel;
            stopwatch = new Stopwatch();
        }
        
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            stopWatchRunning = !stopWatchRunning;
            if(stopWatchRunning) { stopwatch.Start(); } else { stopwatch.Stop(); }
            stopwatchTimer.Enabled = stopWatchRunning;
            btnStartStop.Text = stopWatchRunning ? "Stop" : "Start";
            btnLapTime.Enabled = stopWatchRunning;
        }

        private void stopwatchTimer_Tick(object sender, EventArgs e)
        {
            var timeSpan = stopwatch.Elapsed;
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}:{3:00}.{4:00}", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);

            lblStopWatch.Text = elapsedTime;
            if (stopwatch.Elapsed.Days > 999)
            {
                stopwatch.Reset();
                stopwatch.Start();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            if (stopWatchRunning)
            {
                stopwatch.Start();
            }
        }

        private void btnLapTime_Click(object sender, EventArgs e)
        {
            var timeSpan = stopwatch.Elapsed;
            string lapTime = string.Format("{0:00}:{1:00}:{2:00}:{3:00}.{4:00}", timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            lstLapTimes.Items.Add(lapTime);
        }
    }
}
