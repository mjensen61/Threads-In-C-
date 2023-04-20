using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads_In_CSharp
{
    class WorkerClass
    {
        public string Name = "Unnamed";
        private bool isRunning = false;
        int i = 1;
        int waittime = 1000;

        private Thread thread;
        private ManualResetEvent resetEvent = new ManualResetEvent(true);

        // Create a class constructor for the Car class
        public WorkerClass(int milliseconds)
        {
            thread = new Thread(MainWorkerTread);
            //thread.IsBackground = true;
        }

        public bool RunningState()
        {
            return isRunning;
        }

        public ThreadState ThreadState()
        {
            return thread.ThreadState;
        }
        private void MainWorkerTread()
        {
            while (true)
            {
                for (i = 1; i <= 10000000; i++)
                {
                    Thread.Sleep(1000);
                    resetEvent.WaitOne();
                }
            }
        }
        public void Start(int milliseconds)
        {
            // Can only start once
            if (this.ThreadState() == System.Threading.ThreadState.Unstarted)
            {
                waittime = milliseconds;
                MessageBox.Show(Name + " Starting");
                this.isRunning = true;
                thread.Start();
            }
        }
        public void Pause()
        {
            // unset the reset event which will cause the loop to pause
            this.resetEvent.Reset();
            this.isRunning = false;
            MessageBox.Show(Name + " Paused");
        }
        public void Resume()
        {
            // set the reset event which will cause the loop to continue
            this.resetEvent.Set();
            //this.isRunning = true;
            MessageBox.Show(Name + " Resumed");
        }
        public void Stop()
        {
            // set a flag that will abort the loop
            this.isRunning = false;

            // set the event incase we are currently paused
            this.resetEvent.Set();

            // wait for the thread to finish
            this.thread.Abort();
        }

        public int GetValue()
        {
            return i;
        }
    }
}
