namespace Disk
{
    partial class Disk
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
            this.lbDisk = new System.Windows.Forms.ListBox();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.txbDD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDisk
            // 
            this.lbDisk.FormattingEnabled = true;
            this.lbDisk.ItemHeight = 16;
            this.lbDisk.Location = new System.Drawing.Point(12, 86);
            this.lbDisk.Name = "lbDisk";
            this.lbDisk.Size = new System.Drawing.Size(451, 340);
            this.lbDisk.TabIndex = 0;
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(496, 160);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(129, 38);
            this.btnCreateDirectory.TabIndex = 1;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // txbDD
            // 
            this.txbDD.Location = new System.Drawing.Point(496, 120);
            this.txbDD.Name = "txbDD";
            this.txbDD.Size = new System.Drawing.Size(129, 22);
            this.txbDD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập đường dẫn:";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(720, 160);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(94, 38);
            this.btnCreateFile.TabIndex = 4;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(674, 370);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Disk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDD);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.lbDisk);
            this.Name = "Disk";
            this.Text = "FormDisk";
            this.Load += new System.EventHandler(this.Disk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDisk;
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.TextBox txbDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnTest;
    }
}

