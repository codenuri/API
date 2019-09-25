using System;
using System.Collections;
using System.Threading;
using System.Collections.Generic;

class Program
{
    // Foo : 해야할 일을 완전히 마무리하고 Main 으로 반환 됩니다.
    // Sub Routine
    public static void Foo()
    {
        int cnt = 0;
        while (++cnt <= 10)
        {
            Console.WriteLine($"Foo : {cnt}");
            Thread.Sleep(1000);
        }
    }
    public static void Main()
    {
        Foo();
        int cnt = 0;
        while (++cnt <= 10)
        {
            Console.WriteLine($"Main : {cnt}");
            Thread.Sleep(1000);
        }
    }
}
