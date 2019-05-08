using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnDisk_Click(object sender, EventArgs e)
        {
            Disk t = new Disk();
            t.Show();
        }

        private void BtnTask_Click(object sender, EventArgs e)
        {
            Task t = new Task();
            t.Show();
        }
    }
}
