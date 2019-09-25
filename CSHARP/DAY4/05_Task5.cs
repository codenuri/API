using System;
using System.Threading;
using System.Threading.Tasks;

// async, await

class Task1
{
    public static int Sum(int n)
    {
        int s = 0;
        for (int i = n; i < n + 10; i++)
            s = s + i;
        Thread.Sleep(1000);
        Console.WriteLine($"{n} : {s}");
        return s;
    }
    public static Task<int> SumAsync(int n)
    {
        return Task.Factory.StartNew(() => Sum(n));
    }
    // await 를 사용하는 함수는 만들때 async 를 붙여야 합니다.
    public async static void Test()
    {
        //        Sum(10); // 동기 실행. 스레드 생성 안됨.
        //        SumAsync(10); // 비동기 실행. 스레드 생성됨.

        // 방법 1. 비동기 버전의 결과 꺼내기
        //int ret = SumAsync(10).Result; // 주스레드 대기

        // 방법 2. 새로운 스레드가 대기 하려면
        //var awaiter = SumAsync(10).GetAwaiter();
        //awaiter.OnCompleted( () { 여기에서 결과값 처리 } );

        int ret = await SumAsync(10); // 주스레드는 여기까지만 실행합니다.
                                      // 주스레드는 main으로 돌아갑니다   
        // 아래 부분은 새로운 스레드가 실행합니다.
        Console.WriteLine(ret);
    }







    public static void Main()
    {
        Test();
        Console.WriteLine("Main");
        Console.ReadKey();
    }
}

