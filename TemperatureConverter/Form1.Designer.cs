namespace TemperatureConverter
{
    partial class frmTempConversion
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
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpConversionMethod = new System.Windows.Forms.GroupBox();
            this.rdoFToC = new System.Windows.Forms.RadioButton();
            this.rdoCToF = new System.Windows.Forms.RadioButton();
            this.btnConvert = new System.Windows.Forms.Button();
            this.grpConversionMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(12, 32);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(243, 27);
            this.txtTemperature.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature to Convert";
            // 
            // grpConversionMethod
            // 
            this.grpConversionMethod.Controls.Add(this.rdoFToC);
            this.grpConversionMethod.Controls.Add(this.rdoCToF);
            this.grpConversionMethod.Location = new System.Drawing.Point(12, 65);
            this.grpConversionMethod.Name = "grpConversionMethod";
            this.grpConversionMethod.Size = new System.Drawing.Size(250, 95);
            this.grpConversionMethod.TabIndex = 2;
            this.grpConversionMethod.TabStop = false;
            this.grpConversionMethod.Text = "Conversion Method";
            // 
            // rdoFToC
            // 
            this.rdoFToC.AutoSize = true;
            this.rdoFToC.Location = new System.Drawing.Point(3, 56);
            this.rdoFToC.Name = "rdoFToC";
            this.rdoFToC.Size = new System.Drawing.Size(157, 24);
            this.rdoFToC.TabIndex = 1;
            this.rdoFToC.Text = "Farenheit to Celsius";
            this.rdoFToC.UseVisualStyleBackColor = true;
            // 
            // rdoCToF
            // 
            this.rdoCToF.AutoSize = true;
            this.rdoCToF.Checked = true;
            this.rdoCToF.Location = new System.Drawing.Point(3, 26);
            this.rdoCToF.Name = "rdoCToF";
            this.rdoCToF.Size = new System.Drawing.Size(157, 24);
            this.rdoCToF.TabIndex = 0;
            this.rdoCToF.TabStop = true;
            this.rdoCToF.Text = "Celsius to Farenheit";
            this.rdoCToF.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(261, 30);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(94, 29);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // frmTempConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 187);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.grpConversionMethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemperature);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmTempConversion";
            this.Text = "Temp Conversion";
            this.grpConversionMethod.ResumeLayout(false);
            this.grpConversionMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpConversionMethod;
        private System.Windows.Forms.RadioButton rdoFToC;
        private System.Windows.Forms.RadioButton rdoCToF;
        private System.Windows.Forms.Button btnConvert;
    }
}

