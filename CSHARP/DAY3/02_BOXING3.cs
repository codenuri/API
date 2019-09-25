using System;
/*
// C# 2.0 부터 제공하는 인터페이스
interface IEquatable<T>
{
    bool Equals(T obj);
}
*/

// Equals : object 에 있는 멤버 함수
//          모든 타입에는 Equals 함수가 있다.
struct Point  : IEquatable<Point>
{
    public int x;
    public int y;
    public Point(int a = 0, int b = 0) { x = a; y = b; }

    public bool Equals(Point p)
    {
        return x == p.x && y == p.y;
    }

    public override bool Equals(object obj)
    {
        Point p = (Point)obj;
        return x == p.x && y == p.y;

        //return base.Equals(obj);
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(0, 1);

        if (p1.Equals(p2))
        {
            Console.WriteLine("Same");
        }
        else
            Console.WriteLine("not Same");

    }
}