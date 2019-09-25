using System;

// value_type 과 reference_type 조사

class Program
{
    public static void Main()
    {
        // 1. Type 객체의 멤버 함수 사용

        // C# 배열 만들기 - 레퍼런스 타입
        // 참고 : swift 는 배열이 value type 입니다.
        int[] x = new int[] { 1, 2, 3, 4, 5 };
        int[] y = x;  // 배열은 힙에 있고, x, y가 같이 가리킨다.

        //foo(x);

        // 타입 조사
        Type t = x.GetType();

        if (t.IsValueType)
            Console.WriteLine("배열은 value type");
        else
            Console.WriteLine("배열은 reference type");

        x[0] = 10;
        Console.WriteLine(y[0]); // 1 일까요 10 일까요 ?

        int[] ar1 = x; // 참조 복사
        int[] ar2 = (int[])ar1.Clone(); // 힙객체(배열)의 복사본 생성
                                       // "prototype 디자인 패턴"

        x[0] = 200;
        Console.WriteLine(ar1[0]); // 200
        Console.WriteLine(ar2[0]); // 10
    }
}



