using System;
using System.Threading;
using System.Threading.Tasks;

// Task 반환값 꺼내기
// C++ Future

class Task1
{
    public static int Foo(string name)
    {
        Console.WriteLine($"{name} : {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000);
        Console.WriteLine($"{name} end");

        return 100;
    }
    public static void Main()
    {
        // 반환값이 없는 함수를 풀에 넣을때 코드
        //Task task = Task.Run(Foo);

        // 반환값이 있는 함수를 풀에 넣으려면
        Task<int> task = Task.Run(() => Foo("AAA"));

        Console.WriteLine("Main");

        int ret = task.Result; // 이순간 스레드가 종료 될때를 대기 합니다.

        Console.WriteLine($"반환값 : {ret}");
    }
}
