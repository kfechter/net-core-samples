namespace Clock
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.W = new System.Windows.Forms.TabControl();
            this.tbClockPage = new System.Windows.Forms.TabPage();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTimePrompt = new System.Windows.Forms.Label();
            this.tbStopwatchPage = new System.Windows.Forms.TabPage();
            this.btnLapTime = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.lblStopWatch = new System.Windows.Forms.Label();
            this.lstLapTimes = new System.Windows.Forms.ListBox();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.stopwatchTimer = new System.Windows.Forms.Timer(this.components);
            this.W.SuspendLayout();
            this.tbClockPage.SuspendLayout();
            this.tbStopwatchPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // W
            // 
            this.W.Controls.Add(this.tbClockPage);
            this.W.Controls.Add(this.tbStopwatchPage);
            this.W.Dock = System.Windows.Forms.DockStyle.Fill;
            this.W.Location = new System.Drawing.Point(0, 0);
            this.W.Name = "W";
            this.W.SelectedIndex = 0;
            this.W.Size = new System.Drawing.Size(800, 232);
            this.W.TabIndex = 0;
            // 
            // tbClockPage
            // 
            this.tbClockPage.Controls.Add(this.lblTime);
            this.tbClockPage.Controls.Add(this.lblTimePrompt);
            this.tbClockPage.Location = new System.Drawing.Point(4, 29);
            this.tbClockPage.Name = "tbClockPage";
            this.tbClockPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbClockPage.Size = new System.Drawing.Size(792, 199);
            this.tbClockPage.TabIndex = 0;
            this.tbClockPage.Text = "Clock";
            this.tbClockPage.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 46F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(8, 59);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(262, 102);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label1";
            // 
            // lblTimePrompt
            // 
            this.lblTimePrompt.AutoSize = true;
            this.lblTimePrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimePrompt.Location = new System.Drawing.Point(8, 20);
            this.lblTimePrompt.Name = "lblTimePrompt";
            this.lblTimePrompt.Size = new System.Drawing.Size(217, 20);
            this.lblTimePrompt.TabIndex = 0;
            this.lblTimePrompt.Text = "The Current Time and Date is:";
            // 
            // tbStopwatchPage
            // 
            this.tbStopwatchPage.Controls.Add(this.btnLapTime);
            this.tbStopwatchPage.Controls.Add(this.btnReset);
            this.tbStopwatchPage.Controls.Add(this.btnStartStop);
            this.tbStopwatchPage.Controls.Add(this.lblStopWatch);
            this.tbStopwatchPage.Controls.Add(this.lstLapTimes);
            this.tbStopwatchPage.Location = new System.Drawing.Point(4, 29);
            this.tbStopwatchPage.Name = "tbStopwatchPage";
            this.tbStopwatchPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbStopwatchPage.Size = new System.Drawing.Size(792, 199);
            this.tbStopwatchPage.TabIndex = 2;
            this.tbStopwatchPage.Text = "Stopwatch";
            this.tbStopwatchPage.UseVisualStyleBackColor = true;
            // 
            // btnLapTime
            // 
            this.btnLapTime.Enabled = false;
            this.btnLapTime.Location = new System.Drawing.Point(391, 131);
            this.btnLapTime.Name = "btnLapTime";
            this.btnLapTime.Size = new System.Drawing.Size(94, 29);
            this.btnLapTime.TabIndex = 2;
            this.btnLapTime.Text = "Lap Time";
            this.btnLapTime.UseVisualStyleBackColor = true;
            this.btnLapTime.Click += new System.EventHandler(this.btnLapTime_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(201, 131);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(30, 131);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(94, 29);
            this.btnStartStop.TabIndex = 2;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // lblStopWatch
            // 
            this.lblStopWatch.AutoSize = true;
            this.lblStopWatch.Font = new System.Drawing.Font("Segoe UI", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStopWatch.Location = new System.Drawing.Point(4, 29);
            this.lblStopWatch.Name = "lblStopWatch";
            this.lblStopWatch.Size = new System.Drawing.Size(489, 99);
            this.lblStopWatch.TabIndex = 2;
            this.lblStopWatch.Text = "00:00:00.000";
            // 
            // lstLapTimes
            // 
            this.lstLapTimes.FormattingEnabled = true;
            this.lstLapTimes.ItemHeight = 20;
            this.lstLapTimes.Location = new System.Drawing.Point(627, 18);
            this.lstLapTimes.Name = "lstLapTimes";
            this.lstLapTimes.Size = new System.Drawing.Size(150, 164);
            this.lstLapTimes.TabIndex = 2;
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // stopwatchTimer
            // 
            this.stopwatchTimer.Interval = 1;
            this.stopwatchTimer.Tick += new System.EventHandler(this.stopwatchTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 232);
            this.Controls.Add(this.W);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Clock/Stopwatch";
            this.W.ResumeLayout(false);
            this.tbClockPage.ResumeLayout(false);
            this.tbClockPage.PerformLayout();
            this.tbStopwatchPage.ResumeLayout(false);
            this.tbStopwatchPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl W;
        private System.Windows.Forms.TabPage tbClockPage;
        private System.Windows.Forms.TabPage tbStopwatchPage;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTimePrompt;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button btnLapTime;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label lblStopWatch;
        private System.Windows.Forms.ListBox lstLapTimes;
        private System.Windows.Forms.Timer stopwatchTimer;
    }
}

