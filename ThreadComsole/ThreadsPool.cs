using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ThreadComsole
{
    internal class ThreadsPool
    {
        private static Thread[] threads = new Thread[4];
        private Queue<Thread> queue = new ();

        private static ThreadsPool? threadPool = null;

        private ThreadsPool()
        {
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static ThreadsPool GetInstance()
        {
            if (threadPool == null)
            {
                threadPool = new ThreadsPool();
                return threadPool;
            }
            return threadPool;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void AddNewThread(Thread thread)
        {
            queue.Enqueue(thread);
            for (int i = 0; i < threads.Length; i++)
            {
                if (threads[i] == null || !threads[i].IsAlive)
                {
                    threads[i] = queue.Dequeue();
                    threads[i].Start();
                    break;
                }
            }

        }






    }
}
