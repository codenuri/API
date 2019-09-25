using System;

// 주제 : 생성자와 가상함수 호출

// 1. 생성자에서는 가상함수를 사용하지 않는것이 좋습니다.
// 2. 가상함수에서 사용하는 멤버 데이타는 필드 초기화를 사용해서 초기화
//    하는 것이 안전합니다.

// 참고 : C++언어의 생성자에서는 가상함수 호출이 안됩니다.

class DM
{
    public DM()         { Console.WriteLine("DM()"); }
    public void UseDM() { Console.WriteLine("Use DM"); }
}

class Base
{
    // 생성자와 가상함수 호출
    public Base() { foo(); } // 1. Base::foo => C++
                        //    C++ 은 생성자에서는 가상함수가 동작하지 않는다.

                        // 2. Derived::foo => C#
                        //   C#은 생성자에서 가상함수가 동작합니다.
    public virtual void foo() { Console.WriteLine("Base foo()"); }
}
class Derived : Base
{
    public DM dm = new DM();
    //public DM dm = null;

    public Derived() 
    {
        // 생성자 인자값들을 사용해서 참조변수가 가리키는 객체 생성.
        //dm = new DM();
    }
    public override void foo()
    {
        Console.WriteLine("Derived foo()");
        dm.UseDM();
    }
}


class Program
{
    public static void Main()
    {
        Derived d = new Derived();
    }
}