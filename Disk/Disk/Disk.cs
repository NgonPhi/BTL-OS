using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disk
{
    public partial class Disk : Form
    {
        class API
        {
            [DllImport("kernel32.dll")]
            public static extern uint GetLogicalDriveStrings(uint nBufferLength, [Out] char[] lpBuffer);

            [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
                                           out ulong lpFreeBytesAvailable,
                                           out ulong lpTotalNumberOfBytes,
                                           out ulong lpTotalNumberOfFreeBytes);

            [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern bool CreateDirectory(string lpPathName, IntPtr lpSecurityAttributes);

            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess,
                                            uint dwShareMode,
                                            int lpSecurityAttributes,
                                            uint dwCreationDisposition,
                                            uint dwFlagsAndAttributes,
                                            int hTemplateFile);
        }

        public Disk()
        {
            InitializeComponent();
        }

        private void Disk_Load(object sender, EventArgs e)
        {
            const int size = 512;
            char[] buffer = new char[size];
            uint code = API.GetLogicalDriveStrings(size, buffer);

            if (code == 0)
            {
                MessageBox.Show("Error");
                return;
            }

            StringCollection list = new StringCollection();
            int start = 0;
            for (int i = 0; i < code; ++i)
            {
                if (buffer[i] == 0)
                {
                    string s = new string(buffer, start, i - start);
                    list.Add(s);
                    start = i + 1;
                }
            }

            lbDisk.Items.Clear();
            foreach (string s in list)
            {
                ulong FreeBytesAvailable;
                ulong TotalNumberOfBytes;
                ulong TotalNumberOfFreeBytes;

                bool success = API.GetDiskFreeSpaceEx(s, out FreeBytesAvailable, out TotalNumberOfBytes, out TotalNumberOfFreeBytes);
                if (!success)
                    throw new System.ComponentModel.Win32Exception();
                lbDisk.Items.Add(s);                
                lbDisk.Items.Add("Tổng số GB: " + FreeBytesAvailable / (1024 * 1024 * 1024));
                lbDisk.Items.Add("Tống số GB đã dùng: " + TotalNumberOfBytes / (1024 * 1024 * 1024));
                lbDisk.Items.Add("Tổng số GB đã trống: " + TotalNumberOfFreeBytes / (1024 * 1024 * 1024));
                lbDisk.Items.Add("");
            }            
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            string path = @txbDD.Text;
            if (!API.CreateDirectory(@"\\?\" + path, IntPtr.Zero))
                MessageBox.Show("Lỗi đường dẫn hoặc đã tồn tại thư mục");
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            IntPtr ptr = API.CreateFile(@"D:\new.txt", 3, 3, 0, 3, 0, 0);
            if (ptr.ToInt32() == -1)
            {
                MessageBox.Show("Lỗi");
            }     
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
