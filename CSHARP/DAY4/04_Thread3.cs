using System;
using System.Threading;

// lock

class Program
{
    public static void Delay() { for (int i = 0; i < 10000; i++) ; }

    
    public static void Foo(string name)
    {
        int x = 0;

        for (int i = 0; i < 10; i++)
        {
            x = 100;   Delay();
            x = x + 1; Delay();
            Console.WriteLine($"{name} : {x}"); Delay();
        }
    }

    public static void Main(string[] args)
    {
        Thread t1 = new Thread(() => Foo("A"));
        Thread t2 = new Thread(() => Foo("\tB"));

        t1.Start();
        t2.Start();
    }
}
