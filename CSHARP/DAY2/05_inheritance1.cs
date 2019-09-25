using System;

// 주제 : 멤버 이름 충돌과 new
class Base
{
    public int value = 10;
}
class Derived : Base
{
    // 에러는 없지만 컴파일 하면 경고가 나온다.
    // public int value = 20;
    public new int value = 20; // 경고가 없다.
}
class Program
{
    public static void Main()
    {
        Derived d = new Derived();
        Console.WriteLine(d.value); // 20
        Console.WriteLine(((Base)d).value); // 10

    }
}