using System;
using System.Reflection;
// 타입 정보 얻기
class Program
{
    public static void Main()
    {
        int n = 10;  // int의 진짜 이름은 Int32 입니다.

        //var n = goo();// 우변을 검사해서 좌변의 타입을 결정해 달라.

        // n의 타입을 조사하는 방법
        Type t1 = n.GetType(); // 객체.GetType()
        Type t2 = typeof(int); // typeof(타입)

        Console.WriteLine(t1.Name ); // 타입 이름 출력

        MethodInfo[] mi = t1.GetMethods();

        foreach( MethodInfo m in mi )
        {
            Console.WriteLine(m.ToString());
        }

    }
}












