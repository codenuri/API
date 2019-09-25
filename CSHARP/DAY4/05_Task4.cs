using System;
using System.Threading;
using System.Threading.Tasks;

// onCompleted

class Task1
{
    public static int Sum(int n)
    {
        Console.WriteLine($"Sum : {Thread.CurrentThread.ManagedThreadId}");
        int s = 0;
        for (int i = n; i < n + 10; i++)
            s = s + i;
        Thread.Sleep(1000);
        Console.WriteLine($"{n} : {s}");
        return s;
    }

    public static void Main()
    {
        //Task task = Task.Run(() => Sum(10));

        Task<int> task = Task.Run(() => Sum(10));

        // 아래 2줄은 주스레드가 대기하다가, 결과를 처리하는 코드 입니다.
        //int ret = task.Result;
        //Console.WriteLine($"Main : {ret}");

        // 아래 코드는 스레드 풀에 있는 스레드에게
        // Sum 스레드 종료를 대기했다가 스레드가 종료되면 작업을 수행하게 합니다.
        var awaiter = task.GetAwaiter();

        awaiter.OnCompleted(() => {

            Console.WriteLine($"OnComplte스레드 : {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine(task.Result);

        });


        Console.WriteLine($"main 계속실행 : {Thread.CurrentThread.ManagedThreadId}");

        Console.ReadKey();
    }
}

