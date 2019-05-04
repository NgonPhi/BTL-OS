using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Task_Manager
{
    public class APIWin32
    {
        [DllImport("user32.dll", EntryPoint = "MessageBox")]
        // Oke --> 1 and Cancel --> 2
        public static extern int MessageBox(int hwnd, string lpText, string lpCaption, int wType);
    }

}
