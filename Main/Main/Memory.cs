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
    public struct PERFORMANCE_INFORMATION
    {
        public uint cb;
        public UIntPtr CommitTotal;
        public UIntPtr CommitLimit;
        public UIntPtr CommitPeak;
        public UIntPtr PhysicalTotal;
        public UIntPtr PhysicalAvailable;
        public UIntPtr SystemCache;
        public UIntPtr KernelTotal;
        public UIntPtr KernelPaged;
        public UIntPtr KernelNonpaged;
        public UIntPtr PageSize;
        public uint HandleCount;
        public uint ProcessCount;
        public uint ThreadCount;
    }

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
            // Hàm lấy thông tin trạng thái Memory
            [return: MarshalAs(UnmanagedType.Bool)]
            [DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool GlobalMemoryStatusEx(ref MEMORYSTATUSEX lpBuffer);

            // Hàm lấy thông tin hiệu suất
            [DllImport("psapi.dll", SetLastError = true)]
            public static extern bool GetPerformanceInfo(out PERFORMANCE_INFORMATION pPerformanceInformation, uint cb);
        }

        public Memory()
        {
            InitializeComponent();            
        }

        private void GetMemoryInfo()
        {
            // Lấy thông tin trạng thái Memory
            MEMORYSTATUSEX statEX = new MEMORYSTATUSEX();
            statEX.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            lbxInfo.Items.Clear();
            if (API.GlobalMemoryStatusEx(ref statEX))
            {               
                pbRAM.Value = (int)statEX.dwMemoryLoad;
                lbRAM.Text = statEX.dwMemoryLoad + " %"; // 0-100

                lbxInfo.Items.Add("Tổng kích thước (Vật lý): " + statEX.ullTotalPhys + " bytes");
                lbxInfo.Items.Add("Kích thước (Vật lý) có sẵn: " + statEX.ullAvailPhys + " bytes");
                lbxInfo.Items.Add("Kích thước (Ảo) đã sử dụng: " + (statEX.ullTotalPageFile - statEX.ullTotalPhys) + " bytes");
                lbxInfo.Items.Add("Kích thước (Ảo) khả dụng: " + (statEX.ullAvailPageFile - statEX.ullAvailPhys) + " bytes");
            }

            // Hàm lấy thông tin hiệu suất
            PERFORMANCE_INFORMATION perfInfo = new PERFORMANCE_INFORMATION();
            uint input_size = (uint)System.Runtime.InteropServices.Marshal.SizeOf(typeof(PERFORMANCE_INFORMATION));
            if (API.GetPerformanceInfo(out perfInfo, input_size))
            {
                lbxInfo.Items.Add("-----------------------------------------------------------------------");
                lbxInfo.Items.Add("Số trang tối đa hiện tại: " + perfInfo.CommitLimit.ToUInt64() + " pages");
                lbxInfo.Items.Add("Số trang tối đa đồng thời: " + perfInfo.CommitPeak.ToUInt64() + " pages");
                lbxInfo.Items.Add("Kích thước 1 trang: " + perfInfo.PageSize.ToUInt64() + " bytes");
                lbxInfo.Items.Add("Số handle: " + perfInfo.HandleCount);
                lbxInfo.Items.Add("Số process: " + perfInfo.ProcessCount);
                lbxInfo.Items.Add("Số thread: " + perfInfo.ThreadCount);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GetMemoryInfo();
        }

        private void Memory_Load(object sender, EventArgs e)
        {
            GetMemoryInfo();
            timer.Start();
        }
    }
}
