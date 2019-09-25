using System;
using System.Threading;
using System.Threading.Tasks;

// Task 개념.
// run() 반환값 : task


class Task1
{
    public static void Foo()
    {
        for (int i = 0; i < 1000; i++)
            Console.Write("Foo ");
    }

    public static void Main()
    {
        // C#의 스레드 풀 - 아래 코드는 예전 스타일
        //Task t = Task.Factory.StartNew(Foo); // 스레드 풀에 스레드에
                                    // 작업 요청
                                    // 풀에 스레드가 없으면 스레드 생성
                                    // 생성된 스레드가 있으면 깨워서 작업

        Task t = Task.Run((Action)Foo);

        Console.WriteLine(t.IsCompleted);

        t.Wait(); // 종료 대기

        Console.WriteLine(t.IsCompleted);


        /*
        Thread t1 = new Thread(Foo);      
        t1.Start();

        Thread.Sleep(5000);

        Thread t2 = new Thread(Foo);
        t2.Start();
        */

    }
}

