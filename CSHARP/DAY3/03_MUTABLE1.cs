using System;
using System.Text;

// mutable vs immutable

// mutable   : 객체의 속성을 변경할수 있는것
// immutable : 객체의 속성을 변경할수 없는것

class Program
{
    public static void Main()
    {
        String s1 = "hello";
        s1[3] = 'A'; // error. string 은 immutable 합니다.

        StringBuilder s2 = "hello";
        s2[3] = 'A'; // ok. mutable 합니다.

        s1 = "hello"; // new string("hello")
        s1 = "world"; // new string("world")
    }
}






