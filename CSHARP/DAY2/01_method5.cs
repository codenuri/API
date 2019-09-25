using System;

// 식본문 메소드(expression-bodied method)

class Program
{
    //public static int square1(int x) { return x * x; }

    // 함수의 구현부가 간단하다면 => 구현; 으로 작성해도 됩니다.
    public static int square1(int x) => x * x;

    public static void Main()
    {
        Console.WriteLine(square1(3));
    }

}