using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ThreadExamFormApp
{
    public partial class ThreadForm : Form
    {
        Thread t1, t2;

        public ThreadForm()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            //스레드 생성과 실행 
            ThreadStart ts1 = new ThreadStart(print_increase); //델리게이트 -> increase 메서드
            ThreadStart ts2 = new ThreadStart(print_decrease); //델리게이트 -> decrease 메서드
            t1 = new Thread(ts1); // 델리게이트를 이용한 스레드 객체 생성
            t2 = new Thread(ts2);

            t1.Start();
            t2.Start();
        }
        private void print_increase()
        {
            int i = 0;
            while (true)
            {
                txtPrintView1.Text += i + Environment.NewLine;
                i++;
                Thread.Sleep(1000);
            }
        }
        private void print_decrease()
        {
            int i = 100000;
            while (true)
            {
                txtPrintView2.Text += i + Environment.NewLine;
                i--;
                Thread.Sleep(1000);
            }
        }

        private void ThreadForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            t1.Suspend();
            t2.Suspend();
        }
    }
}
