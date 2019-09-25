// COROUTINE1 을 복사해오세요
using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;

class Program
{
    // Foo : 해야할 일을 완전히 마무리하고 Main 으로 반환 됩니다.
    // CoRoutine

    // C# 에서 Coroutine 만들기
    // 1. 반환값은 IEnumerator를 반환해야 합니다.
    // 2. 실행을 중지하고 돌아가고 싶을때 yield return 을 사용합니다.
    // 3. Main 에서 coroutine 을 호출하고 싶을때는 MoveNext()함수를 호출합니다
    public static IEnumerator Foo()
    {
        int cnt = 0;
        while (++cnt <= 10)
        {
            Console.WriteLine($"Foo : {cnt}");
            Thread.Sleep(1000);
            yield return null; // 반환값 null은 결국 it.current 로 
                                // 전달됩니다.
                                // 물론 null 대신 원하는 값을 반환해도 됩니다.
        }
    }
    public static void Main()
    {
        // 코루틴을 호출하려면
        // 1. 코루틴 함수(열거자를 꺼내는 함수)를 호출합니다.
        IEnumerator it = Foo(); // 이순간 Foo를 호출하지 않습니다.
                                // it.MoveNext()에서 호출됩니다.

        int cnt = 0;
        while (++cnt <= 10)
        {
            Console.WriteLine($"Main : {cnt}");
            Thread.Sleep(1000);

            it.MoveNext(); // 이순간 Foo()를 호출합니다.
        }
    }
}

