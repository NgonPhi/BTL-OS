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
using System.Runtime.InteropServices;

namespace Task_Manager
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct PROCESS_INFORMATION
    {
        public IntPtr hProcess;
        public IntPtr hThread;
        public int dwProcessId;
        public int dwThreadId;
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct STARTUPINFO
    {
        public Int32 cb;
        public string lpReserved;
        public string lpDesktop;
        public string lpTitle;
        public Int32 dwX;
        public Int32 dwY;
        public Int32 dwXSize;
        public Int32 dwYSize;
        public Int32 dwXCountChars;
        public Int32 dwYCountChars;
        public Int32 dwFillAttribute;
        public Int32 dwFlags;
        public Int16 wShowWindow;
        public Int16 cbReserved2;
        public IntPtr lpReserved2;
        public IntPtr hStdInput;
        public IntPtr hStdOutput;
        public IntPtr hStdError;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SECURITY_ATTRIBUTES
    {
        public int nLength;
        public IntPtr lpSecurityDescriptor;
        public int bInheritHandle;
    }
    public partial class FormTaskManager : Form
    {
        class API
        {
            [DllImport("user32.dll", EntryPoint = "MessageBox")]
            // type:0 --> Oke --> 1 and Cancel --> 2
            public static extern int MessageBox(int hwnd, string lpText, string lpCaption, int wType);
        }
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        static extern bool CreateProcess(
                           string lpApplicationName,
                           string lpCommandLine,
                           ref SECURITY_ATTRIBUTES lpProcessAttributes,
                           ref SECURITY_ATTRIBUTES lpThreadAttributes,
                           bool bInheritHandles,
                           uint dwCreationFlags,
                           IntPtr lpEnvironment,
                           string lpCurrentDirectory,
                           [In] ref STARTUPINFO lpStartupInfo,
                           out PROCESS_INFORMATION lpProcessInformation);

        public FormTaskManager()
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
                MessageBox.Show("Out Size");
                return;
            }
            else
            {
                int result = API.MessageBox(0, "Ban co muon xoa tien trinh nay khong ?", "Message", 1);
                if (result == 1)
                    procs[index].Kill();
            }

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
                if (loai == 0)
                {
                    if (tt == "")
                        Process.Start(ud);
                    // Mở file = ứng dụng mặc định
                    else if (ud == "")
                        Process.Start(tt);
                    else
                    {
                        Process.Start(ud, tt);
                    }
                }
                else if (loai == 1)
                {
                    // Trình duyệt mặc định
                    if (ud == "")
                        Process.Start(@link);
                    else
                        Process.Start(ud, @link);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }

        }

        private void btnKillProcess_Click(object sender, EventArgs e)
        {
            KillProcess(lbxProcess.SelectedIndex);
        }
        
        private void btnTest_Click(object sender, EventArgs e)
        {
            const uint NORMAL_PRIORITY_CLASS = 0x0020;

            bool retValue;
            string Application = Environment.GetEnvironmentVariable("windir") + @"\Notepad.exe";
            string CommandLine = @"";
            PROCESS_INFORMATION pInfo = new PROCESS_INFORMATION();
            STARTUPINFO sInfo = new STARTUPINFO();
            SECURITY_ATTRIBUTES pSec = new SECURITY_ATTRIBUTES();
            SECURITY_ATTRIBUTES tSec = new SECURITY_ATTRIBUTES();
            pSec.nLength = Marshal.SizeOf(pSec);
            tSec.nLength = Marshal.SizeOf(tSec);

            retValue = CreateProcess(Application, CommandLine,
            ref pSec, ref tSec, false, NORMAL_PRIORITY_CLASS,
            IntPtr.Zero, null, ref sInfo, out pInfo);

            Console.WriteLine("Process ID (PID): " + pInfo.dwProcessId);
            Console.WriteLine("Process Handle : " + pInfo.hProcess);
        }
    }

}
