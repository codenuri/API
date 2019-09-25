using System;

// 추상 클래스 와 추상 메소드

// 추상 메소드 : abstract 가 붙고, 구현이 없다.(C++ 순수 가상함수)
// 추상 클래스 : 추상메소드가 한개 이상인 클래스. 객체를 만들수 없다.

// 의도 : 특정 함수를 반드시 만들라는 지시어
abstract class Shape
{
    public int color = 0;
    public abstract void DrawImp(); // 추상 메소드
    public void Draw() { DrawImp(); }
}
class Rect : Shape
{
    public void DrawImp() { Console.WriteLine("DrawImp"); }
}

class Program
{
    public static void Main()
    {
        //Shape s = new Shape(); // error
        Shape p = new Rect();
    }
}