using System;

// 모든 타입은 object로 부터 파생 된다.
// object : 4개의 instance method 와 2개의 static method를 가지고 있다
/*
// int의 원리
struct int : object 
{
    //......
}
*/
class Program
{
    public static void Foo(object o)
    {

        // ToString() : 객체의 상태를 문자열로 변경
        string s = o.ToString();
        Console.WriteLine(s);    

      
    }

    public static void Main()
    {
        Foo(10);
        Foo(3.4);
        Foo("aaa");
    }
}