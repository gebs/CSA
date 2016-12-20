using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotClient
{
    public partial class Form1 : Form
    {
        private const string SERVERIP = "192.168.1.30";
        private const int SERVERPORT = 7300;
        public Form1()
        {
            InitializeComponent();
        }

        private void cbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            switch (cb.SelectedItem.ToString())
            {
                case "TrackLine":
                    this.lblValueA.Visible = false;
                    this.txtValueA.Visible = false;
                    this.lblValueL.Visible = true;
                    this.txtValueL.Visible = true;
                    break;
                case "TrackTurnLeft":
                case "TrackTurnRight":
                    this.lblValueA.Visible = true;
                    this.txtValueA.Visible = true;
                    this.lblValueL.Visible = false;
                    this.txtValueL.Visible = false;
                    break;
                case "TrackArcLeft":
                case "TrackArcRight":
                    this.lblValueA.Visible = true;
                    this.txtValueA.Visible = true;
                    this.txtValueL.Visible = true;
                    this.lblValueL.Visible = true;
                    break;
                case "Start":
                    this.lblValueA.Visible = false;
                    this.txtValueA.Visible = false;
                    this.txtValueL.Visible = false;
                    this.lblValueL.Visible = false;
                    break;
                default:
                    break;
            }
            this.txtValueL.Text = "";
            this.txtValueA.Text = "";
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            double td;
            int tint;

            if (this.txtValueL.Text != "" && !double.TryParse(this.txtValueL.Text, out td))
            {
                MessageBox.Show("Invalide Value L");
                return;
            }
            if (this.txtValueA.Text != "" && !int.TryParse(this.txtValueA.Text, out tint))
            {
                MessageBox.Show("Invalide Value A");
                return;
            }
            if (cbCommand.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Select a Command");
                return;
            }

            string commandString = $"{cbCommand.SelectedItem.ToString()} {txtValueA.Text} {txtValueL.Text}".Replace("  ", " ").TrimEnd();

            SendCommandLine(commandString);
        }

        private void SendCommandLine(string command)
        {
            TcpClient client = new TcpClient(SERVERIP, SERVERPORT); 
            StreamWriter sw = new StreamWriter(client.GetStream());
            StreamReader sr = new StreamReader(client.GetStream());
           
            try
            {
                sw.Write(command);
                sw.Flush();
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                client?.Close();
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.lblFileName.Text = openFileDialog1.FileName;
                
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(this.lblFileName.Text))
            {
                string content = sr.ReadToEnd();
                string[] scontent = content.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

                foreach (string line in scontent)
                {
                    if (line.StartsWith("/"))
                        continue;

                    SendCommandLine(line);
                    Thread.Sleep(500);
                }
            }
        }
    }
}
