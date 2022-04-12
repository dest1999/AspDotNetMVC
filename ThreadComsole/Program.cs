using ThreadComsole;



var thPool = ThreadsPool.GetInstance();


for (int i = 0; i < 7; i++)
{
    var tmp = i;
    var thread = new Thread(() => TestMethod(tmp));
    thPool.AddNewThread(thread);

}


static void TestMethod(int i)
{
    //Thread.Sleep(1000);
    Console.WriteLine(i);

}



