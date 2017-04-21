namespace NewFeaturesCSharp7
{
    partial class frmMain
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
            this.btnBinaryLiterals_DigitSeparators = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBinaryLiterals_DigitSeparators
            // 
            this.btnBinaryLiterals_DigitSeparators.Location = new System.Drawing.Point(15, 44);
            this.btnBinaryLiterals_DigitSeparators.Name = "btnBinaryLiterals_DigitSeparators";
            this.btnBinaryLiterals_DigitSeparators.Size = new System.Drawing.Size(209, 35);
            this.btnBinaryLiterals_DigitSeparators.TabIndex = 3;
            this.btnBinaryLiterals_DigitSeparators.Text = "Binary Literals and Digit Separators";
            this.btnBinaryLiterals_DigitSeparators.UseVisualStyleBackColor = true;
            this.btnBinaryLiterals_DigitSeparators.Click += new System.EventHandler(this.btnBinaryLiterals_DigitSeparators_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "C# 7.0 adds a lot of small useful features that can clean up your code. ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 320);
            this.Controls.Add(this.btnBinaryLiterals_DigitSeparators);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Tag = "New Features in C# 7.0 by Naji El Kotob";
            this.Text = "New Features in C# 7.0 by Naji El Kotob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBinaryLiterals_DigitSeparators;
        private System.Windows.Forms.Label label1;
    }
}