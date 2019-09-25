using System;

// 인터페이스의 메소드를 구현하는 방법

// 추상 클래스 : 추상 메소드 + 일반 메소드 + 필드
// 인터페이스 : 모든 멤버가 추상 메소드인 경우.
//              물려줄건 없고, 규칙만 있는 경우.

interface IShape
{
    void DrawImp();
}

class Rect : IShape
{
    // 1. 비가상함수로 만들때
    public void DrawImp() { Console.WriteLine("Rect DrawImp"); }

    // 2. 가상함수로 재정의 
    public virtual void DrawImp() { Console.WriteLine("Rect DrawImp"); }
}

class Program
{
    public static void Main()
    {
        IShape p = new Rect();
        p.DrawImp();
    }
}
