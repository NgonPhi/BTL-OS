using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disk
{
    public partial class Disk : Form
    {
        public Disk()
        {
            InitializeComponent();
        }

        private void Disk_Load(object sender, EventArgs e)
        {
            const int size = 512;
            char[] buffer = new char[size];
            uint code = APIWin32.GetLogicalDriveStrings(size, buffer);

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

                bool success = APIWin32.GetDiskFreeSpaceEx(s, out FreeBytesAvailable, out TotalNumberOfBytes, out TotalNumberOfFreeBytes);
                if (!success)
                    throw new System.ComponentModel.Win32Exception();
                lbDisk.Items.Add(s);                
                lbDisk.Items.Add("Tổng số GB: " + FreeBytesAvailable / (1024 * 1024 * 1024));
                lbDisk.Items.Add("Tống số GB đã dùng: " + TotalNumberOfBytes / (1024 * 1024 * 1024));
                lbDisk.Items.Add("Tổng số GB đã trống: " + TotalNumberOfFreeBytes / (1024 * 1024 * 1024));
                lbDisk.Items.Add("");
            }            
        }
    }
}
