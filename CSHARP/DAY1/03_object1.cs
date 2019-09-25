using System;

// 핵심 2. 모든 것은 객체이다.

// C/C++
// int n;  // 객체가 아니다.  n.
// Point p;// 객체 ..         p.멤버.


class Program
{
    public static void Main()
    {
        // 1. 10도 객체이다.
        string s2 = 10.ToString();  // "10"  
                        // 10이라는 객체의 instance method 사용
        Console.WriteLine(s2); // 10

        // 2. 문자열을 int 변환
        string s = "10";
        int n = int.Parse(s); // int 도 멤버 함수가 있다.
                                // static 멤버 함수 Parse 사용
                               
        Console.WriteLine(n);

        // 3. 문자열이 아닌 정수 입력 받기.
        // ReadLine 은 문자열 밖에 입력이 안됩니다.

        // scanf("%d", &n);  // 사용자가 55 입력

        // 숫자 입력이 필요하면
        // 문자열로 입력후.. 변환해서 사용.
        int n2 = int.Parse( Console.ReadLine() );
        Console.WriteLine(n2);
    }
}








