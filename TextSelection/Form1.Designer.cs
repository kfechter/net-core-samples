﻿namespace TextSelection
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnShowSelection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(13, 13);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(77, 20);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Input Text:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 37);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(613, 27);
            this.txtInput.TabIndex = 1;
            // 
            // btnShowSelection
            // 
            this.btnShowSelection.Location = new System.Drawing.Point(501, 70);
            this.btnShowSelection.Name = "btnShowSelection";
            this.btnShowSelection.Size = new System.Drawing.Size(125, 29);
            this.btnShowSelection.TabIndex = 2;
            this.btnShowSelection.Text = "Show Selection";
            this.btnShowSelection.UseVisualStyleBackColor = true;
            this.btnShowSelection.Click += new System.EventHandler(this.btnShowSelection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 111);
            this.Controls.Add(this.btnShowSelection);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Text Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnShowSelection;
    }
}

