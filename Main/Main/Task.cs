using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public struct PROCESS_INFORMATION
    {
        public IntPtr hProcess;
        public IntPtr hThread;
        public uint dwProcessId;
        public uint dwThreadId;
    }
    public struct STARTUPINFO
    {
        public uint cb;
        public string lpReserved;
        public string lpDesktop;
        public string lpTitle;
        public uint dwX;
        public uint dwY;
        public uint dwXSize;
        public uint dwYSize;
        public uint dwXCountChars;
        public uint dwYCountChars;
        public uint dwFillAttribute;
        public uint dwFlags;
        public short wShowWindow;
        public short cbReserved2;
        public IntPtr lpReserved2;
        public IntPtr hStdInput;
        public IntPtr hStdOutput;
        public IntPtr hStdError;
    }
    public struct SECURITY_ATTRIBUTES
    {
        public int length;
        public IntPtr lpSecurityDescriptor;
        public bool bInheritHandle;
    }

    public partial class Task : MetroFramework.Forms.MetroForm
    {
        class API
        {
            // Hàm hiển thị thông báo : type : 0 (OK) / 1 (OK - Cancel)
            [DllImport("user32.dll", EntryPoint = "MessageBox")]
            public static extern int ShowMessage(int hWnd, string text, string caption, uint type);

            // Hàm tạo process theo đường dẫn tới ứng dụng
            [DllImport("kernel32.dll")]
            public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes,
                            bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment,
                            string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

            // Hàm lấy thông số process (Time) theo process handle
            [DllImport("Kernel32",
                       EntryPoint = "GetProcessTimes",
                       ExactSpelling = true,
                       CharSet = CharSet.Ansi,
                       SetLastError = true)]
            public static extern bool GetProcessTimes(
                                IntPtr hProcess,
                                ref long lpCreationTime,
                                ref long lpExitTime,
                                ref long lpKernelTime,
                                ref long lpUserTime);

            // Hàm hủy Process
            [DllImport("kernel32.dll")]
            public static extern void ExitProcess(uint uExitCode);
        }

        public Task()
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
            if (index < 0 || index >= procs.Length) //TH khi không chọn item
            {
                API.ShowMessage(0, "Loi khong chon item !", "Thong bao", 0);
                return;
            }
            else
            {
                int result = API.ShowMessage(0, "Ban co muon xoa tien trinh nay khong ?", "Message", 1);
                if (result == 1)
                    procs[index].Kill();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProcesses();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GetProcesses();
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            pbCPU.Value = (int)fcpu;
            pbRAM.Value = (int)fram;
            lbCPU.Text = string.Format("{0:0.00}%", fcpu);
            lbRAM.Text = string.Format("{0:0.00}%", fram);
        }

        private void killProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KillProcess(lbxProcess.SelectedIndex);
        }

        private void btnCreateProcess_Click(object sender, EventArgs e)
        {
            string path = tbPath.Text;
            STARTUPINFO si = new STARTUPINFO();
            PROCESS_INFORMATION pi = new PROCESS_INFORMATION();
            if (!API.CreateProcess(@path, null, IntPtr.Zero, IntPtr.Zero, false, 0, IntPtr.Zero, null, ref si, out pi))
                API.ShowMessage(0, "Loi duong dan !", "Thong bao", 0);
        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            KillProcess(lbxProcess.SelectedIndex);
        }

        private void GetProcessTimes(int index)
        {
            try
            {
                if (index < 0 || index >= procs.Length) //TH khi không chọn item
                {
                    API.ShowMessage(0, "Loi khong chon item !", "Thong bao", 0);
                    return;
                }
                else
                {
                    lbInformation.Items.Clear();
                    long lpCreationTime = 0;
                    long lpExitTime = 0;
                    long lpKernelTime = 0;
                    long lpUserTime = 0;
                    Process P = procs[index];
                    bool RetVal = API.GetProcessTimes(P.Handle, ref lpCreationTime, ref lpExitTime, ref lpKernelTime, ref lpUserTime);
                    lbInformation.Items.Add("Handle" + P.Handle.ToString() + " ");
                    lbInformation.Items.Add("Creation Time" + lpCreationTime.ToString() + " ");
                    lbInformation.Items.Add("Kernel Time" + lpKernelTime.ToString() + " ");
                    lbInformation.Items.Add("User Time" + lpUserTime);
                    lbInformation.Items.Add("Start Time Tick" + (P.StartTime.Ticks - DateTime.Parse("1/1/1601").Ticks).ToString() + " ");
                    lbInformation.Items.Add("Privileged Processor Time" + P.PrivilegedProcessorTime.Ticks.ToString() + " ");
                    lbInformation.Items.Add("User Processor Time" + P.UserProcessorTime.Ticks.ToString() + " ");
                }
            }
            catch (Exception ex)
            {
                API.ShowMessage(0, "Loi: " + ex.Message, "Thong bao", 0);
            }
        }

        private void getProcssTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetProcessTimes(lbxProcess.SelectedIndex);
        }

        private void btnGetProcessTime_Click(object sender, EventArgs e)
        {
            GetProcessTimes(lbxProcess.SelectedIndex);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            API.ExitProcess(1);
        }
        
    }
}
