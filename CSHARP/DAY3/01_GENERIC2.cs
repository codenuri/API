using System;

// method generic

class Generic1
{
    //public static void Foo(int n)    { }
    //public static void Foo(object n) { }

    public static void Foo<T>(T n) { }


    public static void Main()
    {
        Foo<int>(10); // 사용자가 T의 타입을 전달..
        //Foo(10);    // 컴파일러가 인자 10을 보고 T의 타입을 결정 : int
        Foo("aaa");
    }
}




