using System;

// 안전한 코드를 만들기 위한 문법들

class Program
{
    public static void Main()
    {
        int n;
        //Console.WriteLine(n);  // error. 초기화 하지 않은 변수는
                                //사용할수 없다. 좋은 문법.

        int n1 = int.MaxValue;
        //int n2 = n1 + 1; // error 가 없다. n1은 변수이므로
                            // 컴파일러가 값을 알지 못한다.
        //int n2 = checked(n1 + 1); // 실행시간에 값을 검사해서
                                    // overflow 가 발생시 예외발생

        //Console.WriteLine($"{n2}");

        //int n3 = int.MaxValue + 1;  // compile error

        int n3 = unchecked(int.MaxValue + 1); // 컴파일 시간에
                                        //검사하지 말라.
    }
}