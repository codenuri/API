using System;

// 핵심 4. 컴파일 시간 상수 vs 실행시간 상수

// csc 06_const.cs /r:Const.dll
// 06_const.exe
class Program
{
    public static int n = 10;

    //public const int c1 = 10;           // const : 컴파일 시간 상수
    //public static readonly int c2 = 10; // readonly : 실행시간 상수

    // c1은 메모리 공간이 아닌 10일 뿐입니다.
    // c2는 메모리 공간에 놓이게 됩니다.
    //public const int c1 = n;           // error. C의 매크로와 유사
    //public static readonly int c2 = n; // ok.

    public static void Main()
    {
        //Console.WriteLine(c1); // Console.WriteLine(10); 으로 변경
        //Console.WriteLine(c2); // Console.WriteLine(c2); 
        // 즉, 항상 메모리에서 읽어 온다.

        Console.WriteLine(Const.const_value); // Console.WriteLine(10); 으로 변경
        Console.WriteLine(Const.readonly_value); // Console.WriteLine(c2); 
    }
}
// 코드 수정하고 const.cs 코드 열어 보세요.














// const    : 컴파일   시간상수, method 내에서도 만들수 있다
//            primitive, enum, string, null 만 가능.
// readonly : 실행시간 시간상수, method 내에서도 만들수 없다

