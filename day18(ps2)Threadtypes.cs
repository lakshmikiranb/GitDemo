using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadingDemo
{
    class Threadtypes
    {
        static void MyThreadMethod()
        {
            Thread newThread =
             new Thread(new ThreadStart(ThreadMethod));

            Console.WriteLine("ThreadState: {0}", newThread.ThreadState);
            newThread.Start();

            // Wait for newThread to start and go to sleep.
            Thread.Sleep(300);
            Console.WriteLine("ThreadState: {0}", newThread.ThreadState);

            // Wait for newThread to restart.
            Thread.Sleep(1000);
            Console.WriteLine("ThreadState: {0}", newThread.ThreadState);
        }

        static void ThreadMethod()
        {
            Thread.Sleep(1000);
        }
    }
}