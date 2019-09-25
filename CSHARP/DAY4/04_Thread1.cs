using System;
using System.Threading;

// Thread1.cs

class Program
{
    //public static void Foo()
    //public static void Foo(object obj)
    public static void Foo(string s)
    {
        for (int i = 0; i < 1000; i++)
            Console.Write("Foo ");
    }

    public static void Main(string[] args)
    {
        // Thread 만들기 1
        //Thread t = new Thread(Foo);
        //t.Start();      // 이순간 스레드가 실행됩니다.       
        //t.Start("hello"); // 스레드 함수에 인자 전달.
        // 스레드 함수의 인자는 object type이어야 합니다

        // 스레드 함수로 람다 표현식 전달 가능
        // 인자가 object 가 아닌 함수 호출하고 싶을때 많이 사용

        Thread t = new Thread( () => Foo("hello") );
        t.Start();


        for (int i = 0; i < 1000; i++)
            Console.Write("Main ");
    }
}
