using System;

// 3. param

class Program
{
    public static void foo( int[] arr )
    {
        foreach (var n in arr)
            Console.WriteLine(n);
    }

    public static void goo( params int[] arr)
    {
        foreach (var n in arr)
            Console.WriteLine(n);
    }

    public static void Main()
    {
        foo(new int[] { 10, 20, 30 });
        goo(10, 20, 30, 40);  // 모든 인자를 가지고 배열을 만들어서
                              // goo로 전달한다

        f1(10, 20, 30, 40);
    }

    // 주의 사항 - params 는 마지막 인자로만 사용가능.
    public static void f1(int a, params int[] arr) { }
    //public static void f1(params int[] arr, int n) { }  // error
}