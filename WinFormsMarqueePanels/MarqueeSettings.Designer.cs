namespace WinFormsMarqueePanels
{
    partial class MarqueeSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbInterval = new System.Windows.Forms.ComboBox();
            this.lblMarqueePrompt = new System.Windows.Forms.Label();
            this.lblTextPrompt = new System.Windows.Forms.Label();
            this.txtMarqueeLabel = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbInterval
            // 
            this.cmbInterval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbInterval.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterval.FormattingEnabled = true;
            this.cmbInterval.Items.AddRange(new object[] {
            "1",
            "25",
            "50",
            "100",
            "250",
            "500",
            "1000",
            "1500",
            "2500",
            "5000"});
            this.cmbInterval.Location = new System.Drawing.Point(235, 12);
            this.cmbInterval.Name = "cmbInterval";
            this.cmbInterval.Size = new System.Drawing.Size(132, 28);
            this.cmbInterval.TabIndex = 0;
            // 
            // lblMarqueePrompt
            // 
            this.lblMarqueePrompt.AutoSize = true;
            this.lblMarqueePrompt.Location = new System.Drawing.Point(12, 15);
            this.lblMarqueePrompt.Name = "lblMarqueePrompt";
            this.lblMarqueePrompt.Size = new System.Drawing.Size(217, 20);
            this.lblMarqueePrompt.TabIndex = 1;
            this.lblMarqueePrompt.Text = "Marquee Interval (Milliseconds)";
            // 
            // lblTextPrompt
            // 
            this.lblTextPrompt.AutoSize = true;
            this.lblTextPrompt.Location = new System.Drawing.Point(12, 63);
            this.lblTextPrompt.Name = "lblTextPrompt";
            this.lblTextPrompt.Size = new System.Drawing.Size(139, 20);
            this.lblTextPrompt.TabIndex = 2;
            this.lblTextPrompt.Text = "Marquee Label Text";
            // 
            // txtMarqueeLabel
            // 
            this.txtMarqueeLabel.Location = new System.Drawing.Point(157, 60);
            this.txtMarqueeLabel.Name = "txtMarqueeLabel";
            this.txtMarqueeLabel.Size = new System.Drawing.Size(362, 27);
            this.txtMarqueeLabel.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(327, 93);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(427, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // MarqueeSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(556, 143);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMarqueeLabel);
            this.Controls.Add(this.lblTextPrompt);
            this.Controls.Add(this.lblMarqueePrompt);
            this.Controls.Add(this.cmbInterval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MarqueeSettings";
            this.Text = "Marquee Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbInterval;
        private System.Windows.Forms.Label lblMarqueePrompt;
        private System.Windows.Forms.Label lblTextPrompt;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMarqueeLabel;
    }
}