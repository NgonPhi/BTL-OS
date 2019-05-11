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
            this.components = new System.ComponentModel.Container();
            this.btnCD = new System.Windows.Forms.Button();
            this.txbDD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDisk = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDD = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txbFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDisk = new MetroFramework.Controls.MetroLabel();
            this.pbDisk = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pDisk = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.pDisk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCD
            // 
            this.btnCD.BackColor = System.Drawing.Color.White;
            this.btnCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCD.Location = new System.Drawing.Point(447, 341);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(165, 39);
            this.btnCD.TabIndex = 2;
            this.btnCD.Text = "Create Directory";
            this.btnCD.UseVisualStyleBackColor = false;
            this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // txbDD
            // 
            this.txbDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDD.Location = new System.Drawing.Point(409, 151);
            this.txbDD.Name = "txbDD";
            this.txbDD.Size = new System.Drawing.Size(203, 30);
            this.txbDD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập đường dẫn:";
            // 
            // pnlDisk
            // 
            this.pnlDisk.BackColor = System.Drawing.Color.Transparent;
            this.pnlDisk.ForeColor = System.Drawing.Color.Black;
            this.pnlDisk.Location = new System.Drawing.Point(30, 131);
            this.pnlDisk.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDisk.Name = "pnlDisk";
            this.pnlDisk.Size = new System.Drawing.Size(373, 446);
            this.pnlDisk.TabIndex = 4;
            // 
            // btnDD
            // 
            this.btnDD.BackColor = System.Drawing.Color.White;
            this.btnDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDD.Location = new System.Drawing.Point(409, 398);
            this.btnDD.Name = "btnDD";
            this.btnDD.Size = new System.Drawing.Size(203, 39);
            this.btnDD.TabIndex = 3;
            this.btnDD.Text = "Delete Directory";
            this.btnDD.UseVisualStyleBackColor = false;
            this.btnDD.Click += new System.EventHandler(this.btnDD_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.White;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(484, 282);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(128, 38);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txbFile
            // 
            this.txbFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFile.Location = new System.Drawing.Point(409, 235);
            this.txbFile.Name = "txbFile";
            this.txbFile.Size = new System.Drawing.Size(203, 30);
            this.txbFile.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nhập tên file:";
            // 
            // lbDisk
            // 
            this.lbDisk.AutoSize = true;
            this.lbDisk.Location = new System.Drawing.Point(423, 80);
            this.lbDisk.Name = "lbDisk";
            this.lbDisk.Size = new System.Drawing.Size(29, 20);
            this.lbDisk.TabIndex = 36;
            this.lbDisk.Text = "0%";
            // 
            // pbDisk
            // 
            this.pbDisk.Location = new System.Drawing.Point(75, 71);
            this.pbDisk.Name = "pbDisk";
            this.pbDisk.Size = new System.Drawing.Size(328, 29);
            this.pbDisk.TabIndex = 35;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 20);
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "Disk:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pDisk
            // 
            this.pDisk.CategoryName = "Paging File";
            this.pDisk.CounterName = "% Usage";
            this.pDisk.InstanceName = "_Total";
            // 
            // Disk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(654, 653);
            this.Controls.Add(this.lbDisk);
            this.Controls.Add(this.pbDisk);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbFile);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnDD);
            this.Controls.Add(this.txbDD);
            this.Controls.Add(this.btnCD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDisk);
            this.Location = new System.Drawing.Point(250, 150);
            this.Name = "Disk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormDisk";
            this.Load += new System.EventHandler(this.Disk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pDisk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.TextBox txbDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlDisk;
        private System.Windows.Forms.Button btnDD;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txbFile;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLabel lbDisk;
        private MetroFramework.Controls.MetroProgressBar pbDisk;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Timer timer;
        private System.Diagnostics.PerformanceCounter pDisk;
    }
}