using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
namespace NumericKeyBoard
{
    public partial class Form1 : Form
    {
        public event EventHandler OKClicked;
        public event EventHandler CancleClicked;
        public Form1()
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

            double idisplay;
            double.TryParse(display, out idisplay);

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
                    idisplay += 1;
                    display = idisplay.ToString();
                    break;
                case "+10":
                    idisplay += 10;
                    display = idisplay.ToString();
                    break;
                case "+100":
                    idisplay += 100;
                    display = idisplay.ToString();
                    break;
                case "-1":
                    idisplay -= 1;
                    display = idisplay.ToString();
                    break;
                case "-10":
                    idisplay -= 10;
                    display = idisplay.ToString();
                    break;
                case "-100":
                    idisplay -= 100;
                    display = idisplay.ToString();
                    break;
                case "+/-":
                    idisplay = idisplay * -1;
                    display = idisplay.ToString();
                    break;
                case "Back":
                    if (display.Length > 0)
                        display = display.Substring(0, display.Length - 1);
                    break;
                case "C":
                    display = "";
                    break;
                case "OK":
                    OKClicked?.Invoke(display, null);
                    break;
                case "Cancel":
                    CancleClicked?.Invoke(display, null);
                    break;
                
                default:
                    break;
            }

            this.txtDisplay.Text = display;
        }
    }
}
