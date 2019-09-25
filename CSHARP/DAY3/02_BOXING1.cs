using System;

// boxing / unboxing 개념

struct Point
{
    public int x;
    public int y;

    public Point(int a = 0, int b = 0) { x = a; y = b; }
}

class Program
{
    public static void Main()
    {
        // value type 이므로 stack 에 놓인다.
        Point p1 = new Point(0, 0);

        // object 는 class 이다. - reference type
        // object 모든 타입의 부모 이다.
        // BOXING : 스택 객체를 reference type으로 참조할때 나오는 현상
        //          스택 객체가 힙에 복사된다.
        object o1 = p1; // boxing
                        // 스택 객체인 p1 의 복사본을 힙에 만들고
                        // o1 이 복사 본을 가리키게 된다.

        //Point p2 = o1; // error.
        Point p2 = (Point)o1; // ok. unboxing
                              // 힙에 있던 객체를 다시 스택으로 
                              // 복사해오는 과정.

        p1.x = 100;
        Console.WriteLine(p2.x); // 0
    }
}