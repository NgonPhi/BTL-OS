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

namespace Main
{
    public partial class Disk : Form
    {
        class API
        {
            // Hàm hiển thị thông báo : type : 0 (OK) / 1 (OK - Cancel)
            [DllImport("user32.dll", EntryPoint = "MessageBox")]
            public static extern int ShowMessage(int hWnd, string text, string caption, uint type);

            // Hàm lấy danh sách tên phân vùng ổ đĩa
            [DllImport("kernel32.dll")]
            public static extern uint GetLogicalDriveStrings(uint nBufferLength, [Out] char[] lpBuffer);

            // Hàm lấy thông số phân vùng ổ đĩa theo tên
            [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
                                           out ulong lpFreeBytesAvailable,
                                           out ulong lpTotalNumberOfBytes,
                                           out ulong lpTotalNumberOfFreeBytes);

            // Hàm tạo thư mục theo đường dẫn
            [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern bool CreateDirectory(string lpPathName, IntPtr lpSecurityAttributes);


            // Test
            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern IntPtr CreateFile(
                 [MarshalAs(UnmanagedType.LPTStr)] string filename,
                 [MarshalAs(UnmanagedType.U4)] FileAccess access,
                 [MarshalAs(UnmanagedType.U4)] FileShare share,
                 IntPtr securityAttributes, // optional SECURITY_ATTRIBUTES struct or IntPtr.Zero
                 [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
                 [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes,
                 IntPtr templateFile);

            [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
            public static extern IntPtr CreateFileA(
                 [MarshalAs(UnmanagedType.LPStr)] string filename,
                 [MarshalAs(UnmanagedType.U4)] FileAccess access,
                 [MarshalAs(UnmanagedType.U4)] FileShare share,
                 IntPtr securityAttributes,
                 [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
                 [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes,
                 IntPtr templateFile);

            [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern IntPtr CreateFileW(
                 [MarshalAs(UnmanagedType.LPWStr)] string filename,
                 [MarshalAs(UnmanagedType.U4)] FileAccess access,
                 [MarshalAs(UnmanagedType.U4)] FileShare share,
                 IntPtr securityAttributes,
                 [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
                 [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes,
                 IntPtr templateFile);
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
                API.ShowMessage(0, "Loi lay danh sach ten phan vung o dia !", "Thong bao", 0);
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

            int t = 1;
            Image bkg = Image.FromFile(@"C:\hard-drive-disk-icon.png");
            foreach (string s in list)
            {
                ulong FreeBytesAvailable;
                ulong TotalNumberOfBytes;
                ulong TotalNumberOfFreeBytes;

                bool success = API.GetDiskFreeSpaceEx(s, out FreeBytesAvailable, out TotalNumberOfBytes, out TotalNumberOfFreeBytes);
                if (!success)
                    throw new System.ComponentModel.Win32Exception();

                Button btnx = new Button();
                btnx.BackgroundImage = bkg;
                btnx.BackColor = Color.LemonChiffon;
                btnx.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
                btnx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                btnx.Name = "btnx" + t;
                btnx.Size = new System.Drawing.Size(100, 80);

                pnlDisk.Controls.Add(btnx);


                Button btn = new Button();
                btn.Name = "btn" + t;
                btn.Size = new System.Drawing.Size(160, 80);
                btn.Margin = new System.Windows.Forms.Padding(0, 3, 20, 3);
                btn.BackColor = Color.LemonChiffon;
                btn.Text = s + "\n" + TotalNumberOfFreeBytes / (1024 * 1024 * 1024) + " GB free of " + TotalNumberOfBytes / (1024 * 1024 * 1024) + " GB\r\n";
                pnlDisk.Controls.Add(btn);
                t++;
            }
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            string path = @txbDD.Text;
            if (!API.CreateDirectory(@"\\?\" + path, IntPtr.Zero))
                API.ShowMessage(0, "Loi duong dan / ton tai thu muc !", "Thong bao", 0);
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
