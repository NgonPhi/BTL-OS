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
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.txbDD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.pnlDisk = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(632, 146);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(129, 38);
            this.btnCreateDirectory.TabIndex = 1;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // txbDD
            // 
            this.txbDD.Location = new System.Drawing.Point(632, 106);
            this.txbDD.Name = "txbDD";
            this.txbDD.Size = new System.Drawing.Size(129, 22);
            this.txbDD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập đường dẫn:";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(632, 355);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(94, 38);
            this.btnCreateFile.TabIndex = 4;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // pnlDisk
            // 
            this.pnlDisk.Location = new System.Drawing.Point(12, 72);
            this.pnlDisk.Name = "pnlDisk";
            this.pnlDisk.Size = new System.Drawing.Size(582, 318);
            this.pnlDisk.TabIndex = 5;
            // 
            // Disk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 450);
            this.Controls.Add(this.pnlDisk);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDD);
            this.Controls.Add(this.btnCreateDirectory);
            this.Name = "Disk";
            this.Text = "FormDisk";
            this.Load += new System.EventHandler(this.Disk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.TextBox txbDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.FlowLayoutPanel pnlDisk;
    }
}

