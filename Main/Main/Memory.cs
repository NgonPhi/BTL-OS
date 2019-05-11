using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct MEMORYSTATUSEX
    {
        internal uint dwLength;
        internal uint dwMemoryLoad;
        internal ulong ullTotalPhys;
        internal ulong ullAvailPhys;
        internal ulong ullTotalPageFile;
        internal ulong ullAvailPageFile;
        internal ulong ullTotalVirtual;
        internal ulong ullAvailVirtual;
        internal ulong ullAvailExtendedVirtual;
    }
    public partial class Memory : MetroFramework.Forms.MetroForm
    {
        class API
        {
            [return: MarshalAs(UnmanagedType.Bool)]
            [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer);
        }

        public Memory()
        {
            InitializeComponent();
            GetMemoryInfo();
            timer.Start();
        }

        private void GetMemoryInfo()
        {
            MEMORYSTATUSEX statEX = new MEMORYSTATUSEX();
            statEX.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            API.GlobalMemoryStatusEx(ref statEX);

            lbxInfo.Items.Clear();

            pbRAM.Value = (int)statEX.dwMemoryLoad;
            lbRAM.Text = statEX.dwMemoryLoad + " %"; // 0-100
            
            lbxInfo.Items.Add("Tổng kích thước (Vật lý): " + statEX.ullTotalPhys + " bytes");
            lbxInfo.Items.Add("Kích thước (Vật lý) có sẵn: " + statEX.ullAvailPhys + " bytes");
            lbxInfo.Items.Add("Kích thước (Ảo) đã sử dụng: " + (statEX.ullTotalPageFile - statEX.ullTotalPhys) + " bytes");
            lbxInfo.Items.Add("Kích thước (Ảo) khả dụng: " + (statEX.ullAvailPageFile - statEX.ullAvailPhys) + " bytes");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GetMemoryInfo();
        }
    }
}
