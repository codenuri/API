using System;

// 상속과 생성자

class Base
{
    public Base()      { Console.WriteLine("Base()"); }
    public Base(int a) { Console.WriteLine("Base(int)"); }
}

class Derived : Base
{
    public Derived() : base()    { Console.WriteLine("Derived()"); }
    public Derived(int a) : base(a) { Console.WriteLine("Derived(int)"); }
}

class Program
{
    public static void Main()
    {
        Derived d = new Derived(5);

        // 다음중 에러를 모두 고르세요
        Animal a  = new Animal(); // error. protected 생성자
        Dog    d2 = new Dog();    // ok..

        // protected 생성자 : 자신은 만들수 없지만(추상적인 존재)
        //                  파생클래스는 만들수 있게 하는 기법.
    }
}

class Animal
{
    protected Animal() { }
}
class Dog : Animal 
{
}