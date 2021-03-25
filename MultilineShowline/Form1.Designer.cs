namespace MultilineShowline
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
            this.txtLines = new System.Windows.Forms.TextBox();
            this.btnShowLines = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLines
            // 
            this.txtLines.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLines.Location = new System.Drawing.Point(0, 0);
            this.txtLines.Multiline = true;
            this.txtLines.Name = "txtLines";
            this.txtLines.Size = new System.Drawing.Size(800, 410);
            this.txtLines.TabIndex = 0;
            // 
            // btnShowLines
            // 
            this.btnShowLines.Location = new System.Drawing.Point(694, 416);
            this.btnShowLines.Name = "btnShowLines";
            this.btnShowLines.Size = new System.Drawing.Size(94, 29);
            this.btnShowLines.TabIndex = 1;
            this.btnShowLines.Text = "Show Lines";
            this.btnShowLines.UseVisualStyleBackColor = true;
            this.btnShowLines.Click += new System.EventHandler(this.btnShowLines_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowLines);
            this.Controls.Add(this.txtLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLines;
        private System.Windows.Forms.Button btnShowLines;
    }
}

