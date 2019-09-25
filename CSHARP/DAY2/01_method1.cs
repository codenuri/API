using System;

// 주제 1. 인자 전달 방식
// 핵심 : out, ref 키워드

class Program
{
    public static void f1(int n) { n = 20; }
    public static void f2(ref int n) { n = 20; }
    public static void f3(out int n) { n = 20; }

    public static void Main()
    {
        int n1 = 10;
        int n2 = 10;
        int n3;

        f1(n1);
        f2(ref n2); // 값이 아닌 참조로 전달
                    // 초기화된 변수만 사용가능하다.
                    // in/out parameter

        f3(out n3); // 값을 담아 오기만 할 것이라는 의미
                    // 초기화 되지 않은 변수도 사용가능.
                    // out parameter

        Console.WriteLine($"{n1}, {n2}, {n3}");

        //int n;
        //f2(ref n);
        //f3(out n);
    }
}