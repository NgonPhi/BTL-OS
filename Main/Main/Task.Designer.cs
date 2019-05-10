namespace Main
{
    partial class Task
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbxProcess = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getProcssTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbProcess = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCreateProcess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.lbInformation = new System.Windows.Forms.ListBox();
            this.btnGetProcessTime = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxProcess
            // 
            this.lbxProcess.ContextMenuStrip = this.contextMenuStrip1;
            this.lbxProcess.FormattingEnabled = true;
            this.lbxProcess.ItemHeight = 16;
            this.lbxProcess.Location = new System.Drawing.Point(27, 112);
            this.lbxProcess.Name = "lbxProcess";
            this.lbxProcess.Size = new System.Drawing.Size(318, 420);
            this.lbxProcess.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killProcessToolStripMenuItem,
            this.getProcssTimesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 52);
            // 
            // killProcessToolStripMenuItem
            // 
            this.killProcessToolStripMenuItem.Name = "killProcessToolStripMenuItem";
            this.killProcessToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.killProcessToolStripMenuItem.Text = "Kill Process";
            this.killProcessToolStripMenuItem.Click += new System.EventHandler(this.killProcessToolStripMenuItem_Click);
            // 
            // getProcssTimesToolStripMenuItem
            // 
            this.getProcssTimesToolStripMenuItem.Name = "getProcssTimesToolStripMenuItem";
            this.getProcssTimesToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.getProcssTimesToolStripMenuItem.Text = "Get Procss Times";
            this.getProcssTimesToolStripMenuItem.Click += new System.EventHandler(this.getProcssTimesToolStripMenuItem_Click);
            // 
            // lbProcess
            // 
            this.lbProcess.AutoSize = true;
            this.lbProcess.BackColor = System.Drawing.Color.Transparent;
            this.lbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcess.Location = new System.Drawing.Point(220, 78);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(18, 20);
            this.lbProcess.TabIndex = 3;
            this.lbProcess.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCreateProcess
            // 
            this.btnCreateProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProcess.Location = new System.Drawing.Point(351, 199);
            this.btnCreateProcess.Name = "btnCreateProcess";
            this.btnCreateProcess.Size = new System.Drawing.Size(157, 36);
            this.btnCreateProcess.TabIndex = 4;
            this.btnCreateProcess.Text = "Create Process";
            this.btnCreateProcess.UseVisualStyleBackColor = true;
            this.btnCreateProcess.Click += new System.EventHandler(this.btnCreateProcess_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh Sách Process: ";
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKillProcess.Location = new System.Drawing.Point(516, 304);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(146, 35);
            this.btnKillProcess.TabIndex = 13;
            this.btnKillProcess.Text = "Kill Process";
            this.btnKillProcess.UseVisualStyleBackColor = true;
            this.btnKillProcess.Click += new System.EventHandler(this.btnKillProcess_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(351, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nhập đường dẫn";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(573, 199);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(88, 38);
            this.btnTest.TabIndex = 19;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lbInformation
            // 
            this.lbInformation.FormattingEnabled = true;
            this.lbInformation.ItemHeight = 16;
            this.lbInformation.Location = new System.Drawing.Point(350, 384);
            this.lbInformation.Name = "lbInformation";
            this.lbInformation.Size = new System.Drawing.Size(311, 148);
            this.lbInformation.TabIndex = 20;
            // 
            // btnGetProcessTime
            // 
            this.btnGetProcessTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetProcessTime.Location = new System.Drawing.Point(351, 304);
            this.btnGetProcessTime.Name = "btnGetProcessTime";
            this.btnGetProcessTime.Size = new System.Drawing.Size(158, 35);
            this.btnGetProcessTime.TabIndex = 21;
            this.btnGetProcessTime.Text = "Get Process Time";
            this.btnGetProcessTime.UseVisualStyleBackColor = true;
            this.btnGetProcessTime.Click += new System.EventHandler(this.btnGetProcessTime_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Process Times:";
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPath.Location = new System.Drawing.Point(351, 149);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(310, 27);
            this.tbPath.TabIndex = 24;
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(697, 653);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGetProcessTime);
            this.Controls.Add(this.lbInformation);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKillProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreateProcess);
            this.Controls.Add(this.lbProcess);
            this.Controls.Add(this.lbxProcess);
            this.Location = new System.Drawing.Point(250, 150);
            this.Name = "Task";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListBox lbxProcess;
        private System.Windows.Forms.Label lbProcess;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem killProcessToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCreateProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKillProcess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ListBox lbInformation;
        private System.Windows.Forms.Button btnGetProcessTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem getProcssTimesToolStripMenuItem;
        private System.Windows.Forms.TextBox tbPath;
    }
}