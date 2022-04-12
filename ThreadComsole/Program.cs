using ThreadConsole;

var thPool = ThreadsPool.GetInstance();
Random rnd = new();

for (int i = 0; i < 15; i++)
{
    var tmp = i;
    var thread = new Thread(() => TestMethod(tmp, rnd));
    thPool.AddNewThread(thread);
}


static void TestMethod(int i, Random rnd)
{
    Thread.Sleep(rnd.Next(100, 500));
    Console.WriteLine(i);
}
