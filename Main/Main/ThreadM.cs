using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Main
{
    public partial class ThreadM : Form
    {
        class API
        {

        }

        Thread th1 = null;
        bool stop1 = false;
        int dem1 = 0;
        Thread th2 = null;
        bool stop2 = false;
        int dem2 = 1;
        public ThreadM()
        {
            InitializeComponent();
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            th1 = new Thread(Action1);
            th1.Start();
        }

        private void ChangeText(Label lb, string s)
        {
            if (lb.InvokeRequired)
            {
                lb.BeginInvoke(new MethodInvoker(delegate () { ChangeText(lb, s); }));
            }
            else
            {
                lock (lb)
                {
                    lb.Text = s;
                }
            }
        }

        private void Action1()
        {
            stop1 = false;
            while (!stop1)
            {                
                ChangeText(label1, dem1.ToString());
                dem1 += 2;
                Thread.Sleep(1000);
            }
        }

        private void btnStop1_Click(object sender, EventArgs e)
        {
            stop1 = true;
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            th2 = new Thread(Action2);
            th2.Start();
        }

        private void Action2()
        {
            stop2 = false;
            while (!stop2)
            {                
                ChangeText(label1, dem2.ToString());
                dem2 += 2;
                Thread.Sleep(500);
            }
        }

        private void btnStop2_Click(object sender, EventArgs e)
        {
            stop2 = true;
        }

        private void ThreadM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th1 != null) th1.Abort();
            if (th2 != null) th2.Abort();
        }
    }
}
