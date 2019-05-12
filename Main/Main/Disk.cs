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
    public partial class Disk : MetroFramework.Forms.MetroForm
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

            // Hàm xóa thư mục theo đường dẫn
            [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
            public static extern bool RemoveDirectory(string lpPathName);

            // Hàm mở file / thư mục / link web
            [DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        }
        public Disk()
        {
            InitializeComponent();
            timer.Start();
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
                if (!API.GetDiskFreeSpaceEx(s, out FreeBytesAvailable, out TotalNumberOfBytes, out TotalNumberOfFreeBytes))
                    throw new System.ComponentModel.Win32Exception();

                Button btnx = new Button();
                btnx.BackgroundImage = bkg;
                btnx.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
                btnx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                btnx.Name = "btnx" + t;
                btnx.Size = new System.Drawing.Size(100, 80);
                pnlDisk.Controls.Add(btnx);

                Button btn = new Button();
                btn.Name = "btn" + t;
                btn.Size = new System.Drawing.Size(160, 80);
                btn.Margin = new System.Windows.Forms.Padding(0, 3, 20, 3);
                btn.Text = s + "\n" + TotalNumberOfFreeBytes / (1024 * 1024 * 1024) + " GB free of " + TotalNumberOfBytes / (1024 * 1024 * 1024) + " GB\r\n";

                btn.Click += btn_Click;
                pnlDisk.Controls.Add(btn);
                t++;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string path = btn.Text.Substring(0, 3);
            if (!API.ShellExecute(IntPtr.Zero, "open", null, null, @path, 1))
                API.ShowMessage(0, "Loi duong dan !", "Thong bao", 0);
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            string path = @txbDD.Text;
            if (!API.CreateDirectory(@"\\?\" + path, IntPtr.Zero))
                API.ShowMessage(0, "Loi duong dan / ton tai thu muc !", "Thong bao", 0);
        }

        private void btnDD_Click(object sender, EventArgs e)
        {
            string path = @txbDD.Text;
            int rs = API.ShowMessage(0, "Ban co muon xoa thu muc khong?", "Thong bao", 1);
            if (rs == 1)
                if (!API.RemoveDirectory(@"\\?\" + path))
                    API.ShowMessage(0, "Loi duong dan / ton tai thu muc !", "Thong bao", 0);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string path = @txbDD.Text;
            string nameF = txbFile.Text;
            if (!API.ShellExecute(IntPtr.Zero, "open", nameF, null, @path, 1))
                API.ShowMessage(0, "Loi duong dan / ten file !", "Thong bao", 0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fdisk = pDisk.NextValue();
            pbDisk.Value = (int)fdisk;
            lbDisk.Text = string.Format("{0:0.00}%", fdisk);
        }
    }
}
