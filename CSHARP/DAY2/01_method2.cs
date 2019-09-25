using System;

// 2. 인자 전달 방식과 참조 타입
// 참조 변수를
// 1. 값으로 보낼때 : 해당 함수에서 객체의 상태를 수정할수 있다.
//                   하지만 새로운 객체를 만들어서 담아올수 없다.

// 2. ref 로 보낼때 : 새로운 객체를 만들어서 담아올수 있다.
//                   당연히 원본 객체수정도 가능하다.
class Point
{
    public int x = 0;
    public int y = 0;

    public Point(int a, int b) { x = a; y = b; }
}

class Program
{
    public static void f1(Point p)     { p.x = 10; }
    public static void f2(ref Point p) { p.x = 10; }

    public static void Main()
    {
        Point p1 = new Point(0, 0);

        //f1(p1);    // 1. call by value 이지만 원본 객체를 수정할수 있다.
        //f2(ref p1);  // 2. call by reference 이고 위 코드와 유사하게
        //  원본 변경 가능.

        //f3(p1);  // f3은 객체를 새로 만들지만 p1은 계속 0,0 객체를 가리킨다

        f4(ref p1);

        Console.WriteLine($"{p1.x}, {p1.x}");
    }
    public static void f3(Point p)     { p = new Point(1, 1); }
    public static void f4(ref Point p)
    {
        p = new Point(1, 1); // C로 생각할때
                        // *p = new Point(1,1)
                         
    }

}