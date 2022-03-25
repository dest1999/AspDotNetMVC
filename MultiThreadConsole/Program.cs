// See https://aka.ms/new-console-template for more information


Thread thread1 = new(Method);
thread1.Name = "MyThread";
thread1.Start();

Console.WriteLine($"New thread id: {thread1.ManagedThreadId}");

thread1.Join();
thread1.Interrupt();


static void Method()
{
    int i = 0;
    while (i < 500)
    {
        i++;
        Console.WriteLine(i);
        Thread.Sleep(10);
    }
}
