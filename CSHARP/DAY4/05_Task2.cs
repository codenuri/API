using System;
using System.Threading;
using System.Threading.Tasks;

// TaskCreationOptions.LongRunning

class Task1
{
    public static void Foo(string name)
    {
        Console.WriteLine($"{name} : {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(4000);
        Console.WriteLine($"{name} end");
    }
    public static void Main()
    {
        /*
        Task.Run(() => Foo("A1"));
        Task.Run(() => Foo("\tB1"));
        Task.Run(() => Foo("\t\tC1"));
        Task.Run(() => Foo("\t\t\tD1"));

        Task.Run(() => Foo("A2") );
        Task.Run(() => Foo("\tB2") );
        Task.Run(() => Foo("\t\tC2"));
        Task.Run(() => Foo("\t\t\tD2"));

        Task.Run(() => Foo("A3"));
        Task.Run(() => Foo("\tB3"));
        Task.Run(() => Foo("\t\tC3"));
        Task.Run(() => Foo("\t\t\tD3"));
        */
        Task.Factory.StartNew(() => Foo("A1"), TaskCreationOptions.LongRunning);
        Task.Factory.StartNew(() => Foo("\tB1"), TaskCreationOptions.LongRunning);
        Task.Factory.StartNew(() => Foo("\t\tC1"), TaskCreationOptions.LongRunning);
        Task.Factory.StartNew(() => Foo("\t\t\tD1"), TaskCreationOptions.LongRunning);

        Task.Factory.StartNew(() => Foo("A2"), TaskCreationOptions.LongRunning);
        Task.Factory.StartNew(() => Foo("\tB2"), TaskCreationOptions.LongRunning);
        Task.Factory.StartNew(() => Foo("\t\tC2"), TaskCreationOptions.LongRunning);
        Task.Factory.StartNew(() => Foo("\t\t\tD2"), TaskCreationOptions.LongRunning);

        Task.Factory.StartNew(() => Foo("A3"), TaskCreationOptions.LongRunning);
        Task.Factory.StartNew(() => Foo("\tB3"), TaskCreationOptions.LongRunning);
        Task.Factory.StartNew(() => Foo("\t\tC3"), TaskCreationOptions.LongRunning);
        Task.Factory.StartNew(() => Foo("\t\t\tD3"), TaskCreationOptions.LongRunning);

        Console.WriteLine("I am Main");
        Console.ReadLine();
    }
}

