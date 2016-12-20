namespace RobotClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCommand = new System.Windows.Forms.ComboBox();
            this.txtValueA = new System.Windows.Forms.TextBox();
            this.lblValueA = new System.Windows.Forms.Label();
            this.lblValueL = new System.Windows.Forms.Label();
            this.txtValueL = new System.Windows.Forms.TextBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send Command";
            // 
            // cbCommand
            // 
            this.cbCommand.FormattingEnabled = true;
            this.cbCommand.Items.AddRange(new object[] {
            "TrackLine",
            "TrackTurnLeft",
            "TrackTurnRight",
            "TrackArcLeft",
            "TrackArcRight",
            "Start"});
            this.cbCommand.Location = new System.Drawing.Point(21, 60);
            this.cbCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCommand.Name = "cbCommand";
            this.cbCommand.Size = new System.Drawing.Size(160, 24);
            this.cbCommand.TabIndex = 1;
            this.cbCommand.SelectedIndexChanged += new System.EventHandler(this.cbCommand_SelectedIndexChanged);
            // 
            // txtValueA
            // 
            this.txtValueA.Location = new System.Drawing.Point(272, 60);
            this.txtValueA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValueA.Name = "txtValueA";
            this.txtValueA.Size = new System.Drawing.Size(132, 22);
            this.txtValueA.TabIndex = 2;
            // 
            // lblValueA
            // 
            this.lblValueA.AutoSize = true;
            this.lblValueA.Location = new System.Drawing.Point(201, 64);
            this.lblValueA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueA.Name = "lblValueA";
            this.lblValueA.Size = new System.Drawing.Size(61, 17);
            this.lblValueA.TabIndex = 3;
            this.lblValueA.Text = "Value A:";
            // 
            // lblValueL
            // 
            this.lblValueL.AutoSize = true;
            this.lblValueL.Location = new System.Drawing.Point(439, 68);
            this.lblValueL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueL.Name = "lblValueL";
            this.lblValueL.Size = new System.Drawing.Size(56, 17);
            this.lblValueL.TabIndex = 4;
            this.lblValueL.Text = "ValueL:";
            // 
            // txtValueL
            // 
            this.txtValueL.Location = new System.Drawing.Point(505, 60);
            this.txtValueL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValueL.Name = "txtValueL";
            this.txtValueL.Size = new System.Drawing.Size(132, 22);
            this.txtValueL.TabIndex = 5;
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Location = new System.Drawing.Point(661, 60);
            this.btnSendCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(100, 28);
            this.btnSendCommand.TabIndex = 6;
            this.btnSendCommand.Text = "Send";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "or";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(21, 134);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(145, 28);
            this.btnOpenFile.TabIndex = 8;
            this.btnOpenFile.Text = "Select File 2 Send";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(179, 140);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 17);
            this.lblFileName.TabIndex = 9;
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(661, 140);
            this.btnSendFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(100, 28);
            this.btnSendFile.TabIndex = 11;
            this.btnSendFile.Text = "Send";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 206);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSendCommand);
            this.Controls.Add(this.txtValueL);
            this.Controls.Add(this.lblValueL);
            this.Controls.Add(this.lblValueA);
            this.Controls.Add(this.txtValueA);
            this.Controls.Add(this.cbCommand);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCommand;
        private System.Windows.Forms.TextBox txtValueA;
        private System.Windows.Forms.Label lblValueA;
        private System.Windows.Forms.Label lblValueL;
        private System.Windows.Forms.TextBox txtValueL;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnSendFile;
    }
}

