using System;

// this를 사용한 다른 생성자 호출

class Point
{
    public int x;
    public int y;

    public Point(int a, int b) { x = a; y = b; Console.WriteLine("Point(int, int)"); }

    // 하나의 생성자에서 다른 생성자를 호출하는 방법
    // 위임 생성자 
    public Point() : this(0,0) {  Console.WriteLine("Point()"); }
    // C++ : public Point() : Point(0,0) {  Console.WriteLine("Point()"); }
    //
}


class Program
{
    public static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point();

        Console.WriteLine($"{p2.x}, {p2.y}");
    }
}