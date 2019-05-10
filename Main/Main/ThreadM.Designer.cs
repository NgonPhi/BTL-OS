namespace Main
{
    partial class ThreadM
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
            this.btnStart1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRes2 = new System.Windows.Forms.Button();
            this.btnRes1 = new System.Windows.Forms.Button();
            this.btnTer2 = new System.Windows.Forms.Button();
            this.btnTer1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSsp2 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnSsp1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart1
            // 
            this.btnStart1.Location = new System.Drawing.Point(44, 39);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(93, 43);
            this.btnStart1.TabIndex = 7;
            this.btnStart1.Text = "Start 1";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(250, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "???";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRes2);
            this.panel1.Controls.Add(this.btnRes1);
            this.panel1.Controls.Add(this.btnTer2);
            this.panel1.Controls.Add(this.btnTer1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSsp2);
            this.panel1.Controls.Add(this.btnStart2);
            this.panel1.Controls.Add(this.btnSsp1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStart1);
            this.panel1.Location = new System.Drawing.Point(417, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 339);
            this.panel1.TabIndex = 9;
            // 
            // btnRes2
            // 
            this.btnRes2.Location = new System.Drawing.Point(474, 103);
            this.btnRes2.Name = "btnRes2";
            this.btnRes2.Size = new System.Drawing.Size(100, 38);
            this.btnRes2.TabIndex = 17;
            this.btnRes2.Text = "Resume 2";
            this.btnRes2.UseVisualStyleBackColor = true;
            this.btnRes2.Click += new System.EventHandler(this.btnRes2_Click);
            // 
            // btnRes1
            // 
            this.btnRes1.Location = new System.Drawing.Point(150, 103);
            this.btnRes1.Name = "btnRes1";
            this.btnRes1.Size = new System.Drawing.Size(100, 38);
            this.btnRes1.TabIndex = 16;
            this.btnRes1.Text = "Resume 1";
            this.btnRes1.UseVisualStyleBackColor = true;
            this.btnRes1.Click += new System.EventHandler(this.btnRes1_Click);
            // 
            // btnTer2
            // 
            this.btnTer2.Location = new System.Drawing.Point(474, 39);
            this.btnTer2.Name = "btnTer2";
            this.btnTer2.Size = new System.Drawing.Size(100, 43);
            this.btnTer2.TabIndex = 15;
            this.btnTer2.Text = "Terminate 2";
            this.btnTer2.UseVisualStyleBackColor = true;
            this.btnTer2.Click += new System.EventHandler(this.btnTer2_Click);
            // 
            // btnTer1
            // 
            this.btnTer1.Location = new System.Drawing.Point(149, 39);
            this.btnTer1.Name = "btnTer1";
            this.btnTer1.Size = new System.Drawing.Size(101, 43);
            this.btnTer1.TabIndex = 14;
            this.btnTer1.Text = "Terminate 1";
            this.btnTer1.UseVisualStyleBackColor = true;
            this.btnTer1.Click += new System.EventHandler(this.btnTer1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Thread 1: In Số Lẻ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thread 1: In Số Chẵn";
            // 
            // btnSsp2
            // 
            this.btnSsp2.Location = new System.Drawing.Point(367, 103);
            this.btnSsp2.Name = "btnSsp2";
            this.btnSsp2.Size = new System.Drawing.Size(93, 38);
            this.btnSsp2.TabIndex = 11;
            this.btnSsp2.Text = "Suspend 2";
            this.btnSsp2.UseVisualStyleBackColor = true;
            this.btnSsp2.Click += new System.EventHandler(this.btnSsp2_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Location = new System.Drawing.Point(367, 39);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(93, 43);
            this.btnStart2.TabIndex = 10;
            this.btnStart2.Text = "Start 2";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // btnSsp1
            // 
            this.btnSsp1.Location = new System.Drawing.Point(44, 103);
            this.btnSsp1.Name = "btnSsp1";
            this.btnSsp1.Size = new System.Drawing.Size(93, 38);
            this.btnSsp1.TabIndex = 9;
            this.btnSsp1.Text = "Suspend 1";
            this.btnSsp1.UseVisualStyleBackColor = true;
            this.btnSsp1.Click += new System.EventHandler(this.btnSsp1_Click);
            // 
            // ThreadM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Main.Properties.Resources.hinh_nen_win_10_dep_42_023523736;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.panel1);
            this.Name = "ThreadM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thread";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThreadM_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSsp1;
        private System.Windows.Forms.Button btnSsp2;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTer2;
        private System.Windows.Forms.Button btnTer1;
        private System.Windows.Forms.Button btnRes2;
        private System.Windows.Forms.Button btnRes1;
    }
}