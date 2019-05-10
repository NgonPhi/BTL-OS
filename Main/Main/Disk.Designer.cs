namespace Main
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
            this.pnlDisk = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.BackColor = System.Drawing.Color.White;
            this.btnCreateDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDirectory.Location = new System.Drawing.Point(525, 134);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(160, 38);
            this.btnCreateDirectory.TabIndex = 1;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = false;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // txbDD
            // 
            this.txbDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDD.Location = new System.Drawing.Point(435, 98);
            this.txbDD.Name = "txbDD";
            this.txbDD.Size = new System.Drawing.Size(250, 30);
            this.txbDD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập đường dẫn:";
            // 
            // pnlDisk
            // 
            this.pnlDisk.BackColor = System.Drawing.Color.Transparent;
            this.pnlDisk.ForeColor = System.Drawing.Color.Black;
            this.pnlDisk.Location = new System.Drawing.Point(54, 70);
            this.pnlDisk.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDisk.Name = "pnlDisk";
            this.pnlDisk.Size = new System.Drawing.Size(373, 446);
            this.pnlDisk.TabIndex = 4;
            // 
            // Disk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(720, 653);
            this.Controls.Add(this.txbDD);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDisk);
            this.Location = new System.Drawing.Point(250, 150);
            this.Name = "Disk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormDisk";
            this.Load += new System.EventHandler(this.Disk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateDirectory;
        private System.Windows.Forms.TextBox txbDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlDisk;
    }
}