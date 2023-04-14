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

namespace Threads_In_CSharp
{
    public partial class Form1 : Form
    {
        
        static WorkerClass worker1 = new WorkerClass();
        static WorkerClass worker2 = new WorkerClass();
        static WorkerClass worker3 = new WorkerClass();
        static WorkerClass worker4 = new WorkerClass();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            worker1.Name = "worker1";
            worker2.Name = "worker2";
            worker3.Name = "worker3";
            worker4.Name = "worker4";
        }

        private void buttonThread1_Click(object sender, EventArgs e)
        {
            if (worker1 == null)
            {
                return;
            }

            if (worker1.ThreadState() == ThreadState.Unstarted)
            {
                buttonThread1.BackColor = Color.Red;
                textBoxThread1.Text = worker1.GetValue().ToString();
                // if not started, start.
                worker1.Start();
            }
            else if (worker1.RunningState() == true)
            {
                buttonThread1.BackColor = Color.Blue;
                textBoxThread1.Text = worker1.GetValue().ToString();
                // if running, pause.
                worker1.Pause();
            }
            else if (worker1.RunningState() == false)
            {
                buttonThread1.BackColor = Color.Red;
                textBoxThread1.Text = worker1.GetValue().ToString();
                // if pause, resume it.
                worker1.Resume();
            }
        }

        private void buttonThread2_Click(object sender, EventArgs e)
        {

            
        }

        private void buttonThread3_Click(object sender, EventArgs e)
        {
            buttonThread3.BackColor = Color.Red;
        }

        private void buttonThread4_Click(object sender, EventArgs e)
        {
            buttonThread4.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
                worker1.Stop();
            
        }
    }
}
