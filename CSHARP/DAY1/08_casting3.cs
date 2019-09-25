using System;

// 변환 연산자
// 
class Point
{
    public int x = 0;
    public int y = 0;
    public Point(int a, int b) { x = a; y = b; }
    public void Dump() { Console.WriteLine("x = {0}, y = {0}", x, y); }

    // 사용자 정의 변환 함수
    // int => Point : operator Point(int)
    // Point=>int   : operator int(Point)
    public static explicit operator Point(int n)
    {
        Console.WriteLine("operator Point");

        Point p = new Point(n, n); // 원하는 정책으로 객체를 생성후
        return p; // 반환.
    }
}

class Program
{
    public static void Main()
    {
        int n = 10;
        Point p = (Point)n; // 1. 언어가 지원하는 변환인가 ?
                            // 2. 1이 아니면. 사용자 정의 변환 함수가 
                            //    있는가 ?

        //Point p = n as Point; // 언어가 허용하는 변환만 할수 있다.
                                // 사용자 정의 변환을 사용할수 없다.

        p.Dump();

       // foo(p);
    }

    public static void foo<T>(T a)
    {
        // Point p = a;
        // Point p = (Point)a;
        Point p = a as Point;   // Point
    }
}



// 오늘 소스는 cafe.naver.com/codenuri 에 올려 놓겠습니다.
