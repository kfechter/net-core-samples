namespace SystemInfo
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
            this.txtProcessor = new System.Windows.Forms.TextBox();
            this.txtMachineName = new System.Windows.Forms.TextBox();
            this.txtOSVersion = new System.Windows.Forms.TextBox();
            this.txtCLRVersion = new System.Windows.Forms.TextBox();
            this.txtSystemUptime = new System.Windows.Forms.TextBox();
            this.txtStyleSupported = new System.Windows.Forms.TextBox();
            this.txtVisualStyle = new System.Windows.Forms.TextBox();
            this.txtSystemDirectory = new System.Windows.Forms.TextBox();
            this.txtDomainName = new System.Windows.Forms.TextBox();
            this.uptimeClock = new System.Windows.Forms.Timer(this.components);
            this.trDriveInfo = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txtProcessor
            // 
            this.txtProcessor.Location = new System.Drawing.Point(12, 12);
            this.txtProcessor.Name = "txtProcessor";
            this.txtProcessor.ReadOnly = true;
            this.txtProcessor.Size = new System.Drawing.Size(387, 27);
            this.txtProcessor.TabIndex = 0;
            // 
            // txtMachineName
            // 
            this.txtMachineName.Location = new System.Drawing.Point(12, 45);
            this.txtMachineName.Name = "txtMachineName";
            this.txtMachineName.ReadOnly = true;
            this.txtMachineName.Size = new System.Drawing.Size(387, 27);
            this.txtMachineName.TabIndex = 0;
            // 
            // txtOSVersion
            // 
            this.txtOSVersion.Location = new System.Drawing.Point(12, 78);
            this.txtOSVersion.Name = "txtOSVersion";
            this.txtOSVersion.ReadOnly = true;
            this.txtOSVersion.Size = new System.Drawing.Size(387, 27);
            this.txtOSVersion.TabIndex = 0;
            // 
            // txtCLRVersion
            // 
            this.txtCLRVersion.Location = new System.Drawing.Point(12, 111);
            this.txtCLRVersion.Name = "txtCLRVersion";
            this.txtCLRVersion.ReadOnly = true;
            this.txtCLRVersion.Size = new System.Drawing.Size(387, 27);
            this.txtCLRVersion.TabIndex = 0;
            // 
            // txtSystemUptime
            // 
            this.txtSystemUptime.Location = new System.Drawing.Point(12, 247);
            this.txtSystemUptime.Name = "txtSystemUptime";
            this.txtSystemUptime.ReadOnly = true;
            this.txtSystemUptime.Size = new System.Drawing.Size(387, 27);
            this.txtSystemUptime.TabIndex = 0;
            // 
            // txtStyleSupported
            // 
            this.txtStyleSupported.Location = new System.Drawing.Point(12, 214);
            this.txtStyleSupported.Name = "txtStyleSupported";
            this.txtStyleSupported.ReadOnly = true;
            this.txtStyleSupported.Size = new System.Drawing.Size(387, 27);
            this.txtStyleSupported.TabIndex = 0;
            // 
            // txtVisualStyle
            // 
            this.txtVisualStyle.Location = new System.Drawing.Point(12, 181);
            this.txtVisualStyle.Name = "txtVisualStyle";
            this.txtVisualStyle.ReadOnly = true;
            this.txtVisualStyle.Size = new System.Drawing.Size(387, 27);
            this.txtVisualStyle.TabIndex = 0;
            // 
            // txtSystemDirectory
            // 
            this.txtSystemDirectory.Location = new System.Drawing.Point(12, 145);
            this.txtSystemDirectory.Name = "txtSystemDirectory";
            this.txtSystemDirectory.ReadOnly = true;
            this.txtSystemDirectory.Size = new System.Drawing.Size(387, 27);
            this.txtSystemDirectory.TabIndex = 0;
            // 
            // txtDomainName
            // 
            this.txtDomainName.Location = new System.Drawing.Point(12, 280);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.ReadOnly = true;
            this.txtDomainName.Size = new System.Drawing.Size(387, 27);
            this.txtDomainName.TabIndex = 0;
            // 
            // uptimeClock
            // 
            this.uptimeClock.Interval = 1000;
            this.uptimeClock.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trDriveInfo
            // 
            this.trDriveInfo.Location = new System.Drawing.Point(405, 12);
            this.trDriveInfo.Name = "trDriveInfo";
            this.trDriveInfo.Size = new System.Drawing.Size(360, 298);
            this.trDriveInfo.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(777, 322);
            this.Controls.Add(this.trDriveInfo);
            this.Controls.Add(this.txtDomainName);
            this.Controls.Add(this.txtSystemDirectory);
            this.Controls.Add(this.txtVisualStyle);
            this.Controls.Add(this.txtStyleSupported);
            this.Controls.Add(this.txtSystemUptime);
            this.Controls.Add(this.txtCLRVersion);
            this.Controls.Add(this.txtOSVersion);
            this.Controls.Add(this.txtMachineName);
            this.Controls.Add(this.txtProcessor);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer systemUptime;
        private System.Windows.Forms.Label lblProcessorInformation;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblOSVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProcessor;
        private System.Windows.Forms.TextBox txtMachineName;
        private System.Windows.Forms.TextBox txtOSVersion;
        private System.Windows.Forms.TextBox txtCLRVersion;
        private System.Windows.Forms.TextBox txtSystemUptime;
        private System.Windows.Forms.TextBox txtStyleSupported;
        private System.Windows.Forms.TextBox txtVisualStyle;
        private System.Windows.Forms.TextBox txtSystemDirectory;
        private System.Windows.Forms.TextBox txtDomainName;
        private System.Windows.Forms.Timer uptimeClock;
        private System.Windows.Forms.TreeView trDriveInfo;
    }
}

