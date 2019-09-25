// cafe.naver.com/codenuri  "C# 기본 게시판"에서 
// "3일차 사전소스" 받으시면 됩니다.







using System;

// Generic 개념 1.
// Point<T>   : Open Type
// Point<int> : Closed Type
class Point<T>
{
    public T x;
    public T y;

    // default(T) : 참조 타입이면 null, primitive 타입이면 0
    // C++ : T a = T()
    public Point(T a = default(T), T b = default(T)) { x = a; y = b; }
}
class Generic1
{
    public static void Main()
    {
        Point<int> p1 = new Point<int>(1, 1);
    }
}



