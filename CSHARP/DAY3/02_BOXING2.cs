using System;


// 모든 타입의 비교 함수의 이름을 동일하게 할수 있도록 규칙을 만들자
// 인터페이스를 도입하자
// C# 1.0 : 함수 인자가 object 이므로 boxing/unboxing이 자주 나타난다.
/*
interface IComparable
{
    int CompareTo(object obj);
}
*/
// C# 2.0 : generic 이 도입됩니다. 
// 대부분의 인터페이스가 generic 기반 입니다.
/*
interface IComparable<T>
{
    int CompareTo(T obj);
}
*/
// 모든 타입에서 비교함수를 제공하려면 IComparable를 구현해야 한다.
struct Point : IComparable, IComparable<Point>
{
    public int x;
    public int y;
    public Point(int a = 0, int b = 0) { x = a; y = b; }

    public int CompareTo(Point o)
    {
        Console.WriteLine("T");
       
        return x.CompareTo(o.x);
    }
    public int CompareTo(object o)
    {
        Console.WriteLine("object");
        Point p = (Point)o;

        // 구현은 x로만 비교하겠습니다.
        return x.CompareTo(p.x); 
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(1, 1);

        // 객체의 크기를 비교하는 방법
        //p1 > p2;            // 방법 1. > 연산자 사용
        //p1.CompareTo(p2);   // 방법 2. 크기를 비교하는 함수 제공

        Console.WriteLine(p1.CompareTo(p2));
    }
}









