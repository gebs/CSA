namespace Uebung3
{
    partial class Form1
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
            this.checkBoxNegative = new System.Windows.Forms.CheckBox();
            this.textBoxAbsValue = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.numericUpDownValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxNegative
            // 
            this.checkBoxNegative.AutoSize = true;
            this.checkBoxNegative.Enabled = false;
            this.checkBoxNegative.Location = new System.Drawing.Point(53, 27);
            this.checkBoxNegative.Name = "checkBoxNegative";
            this.checkBoxNegative.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxNegative.Size = new System.Drawing.Size(58, 21);
            this.checkBoxNegative.TabIndex = 0;
            this.checkBoxNegative.Text = ".neg";
            this.checkBoxNegative.UseVisualStyleBackColor = true;
            // 
            // textBoxAbsValue
            // 
            this.textBoxAbsValue.Location = new System.Drawing.Point(162, 25);
            this.textBoxAbsValue.Name = "textBoxAbsValue";
            this.textBoxAbsValue.ReadOnly = true;
            this.textBoxAbsValue.Size = new System.Drawing.Size(120, 22);
            this.textBoxAbsValue.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(53, 77);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // numericUpDownValue
            // 
            this.numericUpDownValue.Location = new System.Drawing.Point(162, 77);
            this.numericUpDownValue.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.numericUpDownValue.Name = "numericUpDownValue";
            this.numericUpDownValue.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownValue.TabIndex = 3;
            this.numericUpDownValue.ThousandsSeparator = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 142);
            this.Controls.Add(this.numericUpDownValue);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxAbsValue);
            this.Controls.Add(this.checkBoxNegative);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxNegative;
        private System.Windows.Forms.TextBox textBoxAbsValue;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.NumericUpDown numericUpDownValue;
    }
}

