using System;

// 핵심 5. equality
// 비교 방법            ==          Equals 함수
// reference type    참조비교        디폴트는 참조비교, 사용자가 변경가능

/*
class Point
{
    public int x = 0;
    public int y = 0;

    public Point(int a, int b) { x = a; y = b; }

    public override bool Equals(object obj)
    {
        Point p = obj as Point;
        return x == p.x && y == p.y;
    }
}
*/
struct Point
{
    public int x;
    public int y;
    public Point(int a, int b) { x = a; y = b; }

    // reference type : == 연산이 제공된다.(주소 비교 이므로 제공가능)
    // value type : == 연산이 제공되지 않는다.
    //             필요하면 사용자가 제공한다.
    public static bool operator==( Point p1, Point p2)
    {
        return p1.x == p2.x && p1.y == p2.y;
    }
    
    // == 를 만든 경우 반드시 != 도 만들어야 한다.
    public static bool operator !=(Point p1, Point p2)
    {
        return !(p1 == p2);

//        return p1.x != p2.x && p1.y != p2.y;
    }
    

}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 1);  // 힙 객체
        Point p2 = new Point(1, 1);  // 힙 객체

        // 방법 1. == 를 사용한 상등성(레퍼런스(주소) 비교)
        Console.WriteLine(p1 == p2); // false (0)

        // 방법 2. object 로 부터 물려 받은 Equals 함수를 사용한 비교
        // 디폴트 구현 : p1.GetHashCode() == p2.GetHashCode()로 비교
        //              결국 GetHashCode()를 어떻게 만들었는지가 관건
        //               디폴트 구현은 메모리 주소로 GetHashCode 구현

        // 구현방식을 변경하려면
        // 1. GetHashCode()를 재정의 하거나
        // 2. Equals()를 재정의 하면 된다.
        Console.WriteLine(p1.Equals(p2));
    }

    /*
    public static void Main()
    {
        Point p1 = new Point(1, 1);  // 힙 객체
        Point p2 = new Point(1, 1);  // 힙 객체

        // 방법 1. == 를 사용한 상등성(레퍼런스(주소) 비교)
        Console.WriteLine(p1 == p2); // false (0)

        // 방법 2. object 로 부터 물려 받은 Equals 함수를 사용한 비교
        // 디폴트 구현 : p1.GetHashCode() == p2.GetHashCode()로 비교
        //              결국 GetHashCode()를 어떻게 만들었는지가 관건
        //               디폴트 구현은 메모리 주소로 GetHashCode 구현

        // 구현방식을 변경하려면
        // 1. GetHashCode()를 재정의 하거나
        // 2. Equals()를 재정의 하면 된다.
        Console.WriteLine(p1.Equals(p2));
    }
    */
}




