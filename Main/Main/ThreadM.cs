using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Main
{
    public partial class ThreadM : MetroFramework.Forms.MetroForm
    {
        class API
        {
            // Hàm hiển thị thông báo : type : 0 (OK) / 1 (OK - Cancel)
            [DllImport("user32.dll", EntryPoint = "MessageBox")]
            public static extern int ShowMessage(int hWnd, string text, string caption, uint type);

            // Hàm tạo thread --> handle
            [DllImport("kernel32")]
            public static extern IntPtr CreateThread(
                                   IntPtr lpThreadAttributes,
                                   UInt32 dwStackSize,
                                   ThreadStart lpStartAddress,
                                   IntPtr param,
                                   UInt32 dwCreationFlags,
                                   UInt32 lpThreadId
                                 );
            // Hàm dừng thread bằng handle
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern int SuspendThread(IntPtr hThread);

            // Hàm tiếp tục thread bằng handle
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern int ResumeThread(IntPtr hThread);

            // Hàm hủy Thread bằng handle
            [DllImport("Kernel32.dll", CharSet = CharSet.Auto)]
            public static extern bool TerminateThread(IntPtr hThread, uint dwExitCode);
        }
        
        public ThreadM()
        {
            InitializeComponent();
        }

        // Fix cross thread ( Dùng chung 1 tài nguyên )
        private void ChangeText(Label lb, string s)
        {
            if (lb.InvokeRequired)
            {
                lb.BeginInvoke(new MethodInvoker(delegate () { ChangeText(lb, s); }));
            }
            else
            {
                lock (lb)
                {
                    lb.Text = s;
                }
            }
        }

        IntPtr th1;
        int dem1 = 0;
        IntPtr th2;
        int dem2 = 1;

        // Start
        private void btnStart1_Click(object sender, EventArgs e)
        {
            dem1 = 0;
            ThreadStart ThreadFunc = new ThreadStart(Action1);
            th1 = API.CreateThread(IntPtr.Zero, 0, ThreadFunc, IntPtr.Zero, 0, 0);
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            dem2 = 1;
            ThreadStart ThreadFunc = new ThreadStart(Action2);
            th2 = API.CreateThread(IntPtr.Zero, 0, ThreadFunc, IntPtr.Zero, 0, 0);
        }

        // Action
        private void Action1()
        {
            while (true)
            {
                ChangeText(label1, dem1.ToString());
                dem1 += 2;
                Thread.Sleep(1000);
            }
        }

        private void Action2()
        {
            while (true)
            {
                ChangeText(label1, dem2.ToString());
                dem2 += 2;
                Thread.Sleep(500);
            }
        }

        // Suspend - Dừng
        private void btnSsp1_Click(object sender, EventArgs e)
        {
            if (API.SuspendThread(th1) == -1)
                API.ShowMessage(0, "Loi khong ton tai Thread / Thread dang dung!", "Thong bao", 0);
        }

        private void btnSsp2_Click(object sender, EventArgs e)
        {
            if (API.SuspendThread(th2) == -1)
                API.ShowMessage(0, "Loi khong ton tai Thread / Thread dang dung!", "Thong bao", 0);
        }

        // Resume
        private void btnRes1_Click(object sender, EventArgs e)
        {
            if (API.ResumeThread(th1) == 0)
                API.ShowMessage(0, "Loi khong ton tai Thread / Thread dang chay!", "Thong bao", 0);
        }

        private void btnRes2_Click(object sender, EventArgs e)
        {
            if (API.ResumeThread(th2) == 0)
                API.ShowMessage(0, "Loi khong ton tai Thread / Thread dang chay!", "Thong bao", 0);
        }

        // Terminate - Hủy    
        private void btnTer1_Click(object sender, EventArgs e)
        {
            int result = API.ShowMessage(0, "Ban co muon huy Thread 1 khong", "Thong bao", 1);
            if(result == 1 )
                if(!API.TerminateThread(th1, 1))
                    API.ShowMessage(0, "Loi khong ton tai Thread", "Thong bao", 0);
        }

        private void btnTer2_Click(object sender, EventArgs e)
        {
            int result = API.ShowMessage(0, "Ban co muon huy Thread 2 khong", "Thong bao", 1);
            if (result == 1)
                if (!API.TerminateThread(th2, 1))
                    API.ShowMessage(0, "Loi khong ton tai Thread", "Thong bao", 0);
        }

        private void ThreadM_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                API.TerminateThread(th1, 1);
                API.TerminateThread(th2, 1);
            }
            catch(Exception ex)
            {
                API.ShowMessage(0, ex.Message, "Thong bao", 0);
            }
        }
    }
}
