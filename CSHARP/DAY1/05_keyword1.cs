using System;

// 핵심 3. 키워드와 식별자

// 기존에 있는 키워드를 식별자로 사용하려면 @를 붙인다.
// 다른 언어와 연동될때 @는 사라진다.
// C++ 로 A라는 이름의 객체 생성.
class @int
{
    public void show() { Console.WriteLine("int.show()"); }
}
class where { }

class Program
{
    public static void Main()
    {
        int n;

        @int n2 = new @int();
        n2.show();

        where w = new where();
    }

    public static void foo<T>(T a) where T : new()
    {
    }
}








// 문맥의존 키워드 : add, dynamic, into, partial, when, ascending, equals, join, remove,where
//                  async, from, let, select, yield, await, get, nameof, set, by, global, on,
//                  on, value, descending, group, orderby, var

