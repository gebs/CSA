using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RobotView
{
    public partial class NumericKeyBoard : Form
    {
        public double FormValue { get; set; }
        public NumericKeyBoard()
        {
            InitializeComponent();

            foreach (Control item in Controls)
            {
                if (item.GetType() == typeof(Button))
                    item.Click += Item_Click;
            }

        }
        private void Item_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string display = this.txtDisplay.Text;


            try
            {
                if (!string.IsNullOrEmpty(display) && !display.StartsWith("."))
                    FormValue = double.Parse(display);
            }
            catch (Exception ex)
            {
                FormValue = 0;
            }

            switch (btn.Tag.ToString())
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    display += btn.Tag.ToString();
                    break;
                case ".":
                    if (!display.Contains("."))
                        display += ".";
                    break;
                case "+1":
                    FormValue += 1;
                    display = FormValue.ToString();
                    break;
                case "+10":
                    FormValue += 10;
                    display = FormValue.ToString();
                    break;
                case "+100":
                    FormValue += 100;
                    display = FormValue.ToString();
                    break;
                case "-1":
                    FormValue -= 1;
                    display = FormValue.ToString();
                    break;
                case "-10":
                    FormValue -= 10;
                    display = FormValue.ToString();
                    break;
                case "-100":
                    FormValue -= 100;
                    display = FormValue.ToString();
                    break;
                case "+/-":
                    FormValue = FormValue * -1;
                    display = FormValue.ToString();
                    break;
                case "Back":
                    if (display.Length > 0)
                        display = display.Substring(0, display.Length - 1);
                    break;
                case "C":
                    display = "";
                    break;
                default:
                    break;
            }

            this.txtDisplay.Text = display;

            //Set FormValue

            if (!string.IsNullOrEmpty(display) && !display.StartsWith("."))
                FormValue = double.Parse(display);

        }

    }
}