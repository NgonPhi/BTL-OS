namespace Main
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnTask = new System.Windows.Forms.Button();
            this.btnThread = new System.Windows.Forms.Button();
            this.btnDisk = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblDisk = new System.Windows.Forms.Label();
            this.lblThread = new System.Windows.Forms.Label();
            this.lblTaskM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.White;
            this.btnTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTask.BackgroundImage")));
            this.btnTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.ForeColor = System.Drawing.Color.LightCoral;
            this.btnTask.Location = new System.Drawing.Point(799, 182);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(129, 121);
            this.btnTask.TabIndex = 4;
            this.btnTask.UseVisualStyleBackColor = false;
            this.btnTask.Click += new System.EventHandler(this.BtnTask_Click);
            // 
            // btnThread
            // 
            this.btnThread.BackColor = System.Drawing.Color.White;
            this.btnThread.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThread.BackgroundImage")));
            this.btnThread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThread.ForeColor = System.Drawing.Color.LightCoral;
            this.btnThread.Location = new System.Drawing.Point(1065, 182);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(128, 121);
            this.btnThread.TabIndex = 5;
            this.btnThread.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThread.UseVisualStyleBackColor = false;
            this.btnThread.Click += new System.EventHandler(this.BtnThread_Click);
            // 
            // btnDisk
            // 
            this.btnDisk.BackColor = System.Drawing.Color.White;
            this.btnDisk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisk.BackgroundImage")));
            this.btnDisk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisk.ForeColor = System.Drawing.Color.LightCoral;
            this.btnDisk.Location = new System.Drawing.Point(799, 394);
            this.btnDisk.Name = "btnDisk";
            this.btnDisk.Size = new System.Drawing.Size(129, 121);
            this.btnDisk.TabIndex = 6;
            this.btnDisk.UseVisualStyleBackColor = false;
            this.btnDisk.Click += new System.EventHandler(this.BtnDisk_Click);
            // 
            // btnMemory
            // 
            this.btnMemory.BackColor = System.Drawing.Color.White;
            this.btnMemory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMemory.BackgroundImage")));
            this.btnMemory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory.ForeColor = System.Drawing.Color.LightCoral;
            this.btnMemory.Location = new System.Drawing.Point(1065, 394);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(128, 121);
            this.btnMemory.TabIndex = 7;
            this.btnMemory.UseVisualStyleBackColor = false;
            this.btnMemory.Click += new System.EventHandler(this.BtnMemory_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.Color.Transparent;
            this.lblMain.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(551, 60);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(487, 56);
            this.lblMain.TabIndex = 8;
            this.lblMain.Text = "HỆ ĐIỀU HÀNH MINI";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.BackColor = System.Drawing.Color.Transparent;
            this.lblMemory.Location = new System.Drawing.Point(1060, 362);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(69, 17);
            this.lblMemory.TabIndex = 11;
            this.lblMemory.Text = "MEMORY";
            // 
            // lblDisk
            // 
            this.lblDisk.AutoSize = true;
            this.lblDisk.BackColor = System.Drawing.Color.Transparent;
            this.lblDisk.Location = new System.Drawing.Point(794, 362);
            this.lblDisk.Name = "lblDisk";
            this.lblDisk.Size = new System.Drawing.Size(39, 17);
            this.lblDisk.TabIndex = 10;
            this.lblDisk.Text = "DISK";
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.BackColor = System.Drawing.Color.Transparent;
            this.lblThread.Location = new System.Drawing.Point(1060, 150);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(65, 17);
            this.lblThread.TabIndex = 9;
            this.lblThread.Text = "THREAD";
            // 
            // lblTaskM
            // 
            this.lblTaskM.AutoSize = true;
            this.lblTaskM.BackColor = System.Drawing.Color.Transparent;
            this.lblTaskM.Location = new System.Drawing.Point(794, 150);
            this.lblTaskM.Name = "lblTaskM";
            this.lblTaskM.Size = new System.Drawing.Size(44, 17);
            this.lblTaskM.TabIndex = 8;
            this.lblTaskM.Text = "TASK";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Main.Properties.Resources.hinh_nen_win_10_dep_42_023523736;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(202, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 392);
            this.panel1.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 653);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnDisk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.lblTaskM);
            this.Controls.Add(this.lblThread);
            this.Controls.Add(this.lblDisk);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.btnMemory);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.Button btnDisk;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblTaskM;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblDisk;
        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.Panel panel1;
    }
}

