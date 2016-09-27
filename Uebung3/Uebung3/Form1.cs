using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uebung3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.numericUpDownValue.ValueChanged += NumericUpDownValue_ValueChanged;
            this.buttonClear.Click += ButtonClear_Click;
            this.textBoxAbsValue.Text = 0.ToString();
            this.checkBoxNegative.Checked = false;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.textBoxAbsValue.Text = "";
            this.checkBoxNegative.Checked = false;
            this.numericUpDownValue.Value = 0;
        }

        private void NumericUpDownValue_ValueChanged(object sender, EventArgs e)
        {
            this.checkBoxNegative.Checked = (numericUpDownValue.Value)  < 0;
            this.textBoxAbsValue.Text = Math.Abs(numericUpDownValue.Value).ToString();
        }
    }
}
