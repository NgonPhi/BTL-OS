using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Disk
{
    public class APIWin32
    {
        [DllImport("kernel32.dll")]
        public static extern uint GetLogicalDriveStrings(uint nBufferLength, [Out] char[] lpBuffer);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetDiskFreeSpaceEx(string lpDirectoryName,
                                       out ulong lpFreeBytesAvailable,
                                       out ulong lpTotalNumberOfBytes,
                                       out ulong lpTotalNumberOfFreeBytes);
    }
}
