using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads_In_CSharp
{
    public partial class Form1 : Form
    {
        
        static WorkerClass worker1 = new WorkerClass(1000);
        static WorkerClass worker2 = new WorkerClass(1300);
        static WorkerClass worker3 = new WorkerClass(1600);
        static WorkerClass worker4 = new WorkerClass(1900);
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            worker1.Name = "Thread 1";
            worker2.Name = "Thread 2";
            worker3.Name = "Thread 3";
            worker4.Name = "Thread 4";

            timer1.Interval = (200);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxThread1.Text = worker1.GetValue().ToString();
            textBoxThread2.Text = worker2.GetValue().ToString();
            textBoxThread3.Text = worker3.GetValue().ToString();
            textBoxThread4.Text = worker4.GetValue().ToString();
        }

        private void buttonThread1_Click(object sender, EventArgs e)
        {
            manage_Click(buttonThread1, worker1);
        }

        private void buttonThread2_Click(object sender, EventArgs e)
        {
            manage_Click(buttonThread2, worker2);
        }

        private void buttonThread3_Click(object sender, EventArgs e)
        {
            manage_Click(buttonThread3, worker3);
        }

        private void buttonThread4_Click(object sender, EventArgs e)
        {
            manage_Click(buttonThread4, worker4);
        }

        private void manage_Click(Button button, WorkerClass worker)
        {
            if (worker == null)
            {
                return;
            }

            if (worker.ThreadState() == ThreadState.Unstarted)
            {
                button.BackColor = Color.Red;
                button.Text = worker.Name + " Running";
                // if not started, start.
                worker.Start(190);
            }
            else if (worker4.RunningState() == true)
            {
                button.BackColor = Color.Blue;
                button.Text = worker.Name + " Paused";
                // if running, pause.
                worker.Pause();
            }
            else if (worker4.RunningState() == false)
            {
                button.BackColor = Color.Red;
                button.Text = worker.Name + " Running";
                // if pause, resume it.
                worker.Resume();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            worker1.Stop();
            worker2.Stop();
            worker3.Stop();
            worker4.Stop();
        }
    }
}
