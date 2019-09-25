using System;
using System.Threading;

// background, join, suspend, resume, state

class Program
{
    public static void Foo()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.Write("Foo");
            Thread.Sleep(10);
        }
        Console.WriteLine("Foo Finish");
    }

    public static void Main(string[] args)
    {
        Thread t = new Thread(Foo);
        // foreground 스레드 : 주스레드가 종료되어도 계속 실행된다.
        // background 스레드 : 주스레드가 종료되면 따라서 종료.
        t.IsBackground = true;   
        t.Start();

        //t.Join(); // 스레드 종료 대기 - WaitForSingleObject()
        t.Suspend(); // 잠시 멈춤
        t.Resume();  // 계속 실행



        Console.WriteLine("main finish");

    }
}
