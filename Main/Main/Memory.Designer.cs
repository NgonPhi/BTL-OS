namespace Main
{
    partial class Memory
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
            this.components = new System.ComponentModel.Container();
            this.lbRAM = new MetroFramework.Controls.MetroLabel();
            this.pbRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.lbRAM.Location = new System.Drawing.Point(493, 84);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(29, 20);
            this.lbRAM.TabIndex = 33;
            this.lbRAM.Text = "0%";
            // 
            // pbRAM
            // 
            this.pbRAM.Location = new System.Drawing.Point(72, 75);
            this.pbRAM.Name = "pbRAM";
            this.pbRAM.Size = new System.Drawing.Size(417, 29);
            this.pbRAM.TabIndex = 32;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 20);
            this.metroLabel3.TabIndex = 31;
            this.metroLabel3.Text = "RAM:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbxInfo
            // 
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.ItemHeight = 16;
            this.lbxInfo.Location = new System.Drawing.Point(72, 124);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.Size = new System.Drawing.Size(417, 68);
            this.lbxInfo.TabIndex = 34;
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(656, 653);
            this.Controls.Add(this.lbxInfo);
            this.Controls.Add(this.lbRAM);
            this.Controls.Add(this.pbRAM);
            this.Controls.Add(this.metroLabel3);
            this.Location = new System.Drawing.Point(250, 150);
            this.Name = "Memory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Memory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbRAM;
        private MetroFramework.Controls.MetroProgressBar pbRAM;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox lbxInfo;
    }
}