using System;
/*
// C# 표준에 있는 delegate
// 반환값이 없는 delegate
delegate void Action();
delegate void Action<T>(T arg);
delegate void Action<T1, T2>(T1 arg1, T2 arg2);

// 반환값이 있는 delegate
delegate TResult Func<TResult>();
delegate TResult Func<TResult, T1>(T1 arg1);
delegate TResult Func<TResult, T1, T2>(T1 arg1, T2 arg2);
*/
// 반환값이 없으면 Action
// 반환값이 있으면 Func

class Program
{
    public static void F1()      { Console.WriteLine("F1"); }
    public static void F2(int a) { Console.WriteLine("F2"); }
    public static void F3(int a, double b) { Console.WriteLine("F3"); }

    public static int F4() { Console.WriteLine("F4"); return 0; }
    public static double F5() { Console.WriteLine("F5"); return 0; }
    public static double F6(string s) { Console.WriteLine("F6"); return 0; }

    public static void Main()
    {
        Action a1 = F1;
        Action<int> a2 = F2;
        Action<int, double> a3 = F3;

        a1();

        Func<int> f1 = F4;
        Func<double> f1 = F5;
        Func<double, string> f1 = F6;

    }


}

