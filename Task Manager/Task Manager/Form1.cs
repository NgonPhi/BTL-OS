using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Task_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] procs;
        private void GetProcesses()
        {
            procs = Process.GetProcesses(); //Trả về tất cả các tiến trình đang chạy trên máy tính

            if (Convert.ToInt32(lbProcess.Text) != procs.Length)
            {
                lbxProcess.Items.Clear();
                for (int i = 0; i < procs.Length; i++)
                {
                    lbxProcess.Items.Add("> " + procs[i].ProcessName); // Tạo danh sách tương tự task manager
                }                
            }
            lbProcess.Text = procs.Length.ToString();
        }

        private void KillProcess(int index)
        {
            if(index < 0 || index >= procs.Length) //TH khi không chọn item
            {
                MessageBox.Show("Out Size");
                return;
            }
            procs[index].WaitForExit(3000); //Đợi 3s rồi tắt
            procs[index].Kill();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProcesses();
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetProcesses();
        }

        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KillProcess(lbxProcess.SelectedIndex);
        }

        // Tương tự window run(window + R)
        private void btnCreateProcess_Click(object sender, EventArgs e)
        {
            string ud = tbUD.Text;
            string tt = tbTT.Text;
            string link = tbLink.Text;
            int loai = cbbLoai.SelectedIndex;

            try
            {
                switch (loai)
                {
                    //Nếu ứng dụng / tệp tin
                    case 0:
                        if (tt == "")
                            Process.Start(ud);
                        // Mở file = ứng dụng mặc định
                        else if(ud == "")
                            Process.Start(tt);
                        else
                            Process.Start(ud, tt);
                        break;
                    //Nếu web
                    case 1:
                        // Trình duyệt mặc định
                        if (ud == "")
                            Process.Start(@link);
                        else
                            Process.Start(ud, @link);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
            
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            KillProcess(lbxProcess.SelectedIndex);
        }
    }
}
