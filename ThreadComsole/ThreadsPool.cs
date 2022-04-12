using System.Runtime.CompilerServices;

namespace ThreadConsole;

internal class ThreadsPool
{
    private readonly Thread[] threads = new Thread[8];
    private readonly Queue<Thread> queue = new ();

    private static ThreadsPool? threadPool = null;
    private bool needToCheckEmptyTask = false;

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

        do
        {
            for (int i = 0; i < threads.Length; i++)
            {
                if (threads[i] == null || !threads[i].IsAlive)
                {
                    threads[i] = queue.Dequeue();
                    threads[i].Start();
                    break;
                }
            }
            if (queue.Count == 0)
            {
                needToCheckEmptyTask = false;
            }
            else
            {
                needToCheckEmptyTask = true;
                Thread.Sleep(50);
            }
        } while (needToCheckEmptyTask);
    }
}
