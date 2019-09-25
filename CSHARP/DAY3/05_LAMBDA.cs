using System;

class Labmda1
{
    public static int Add(int a, int b) { return a + b; }

    public static void Main()
    {
        int v1 = 10;

        // Func : 반환값이 있는 delegate 
        // Func<int, int, int> plus = Add;

        // int n = 10;  // 정수 리터널(integer literal)
        // string s = "hello"; // string literal

        // 람다 : 함수 리터널
        // 델리게이트변수 = (함수인자리스트) => { 함수 구현};

        //Func<int, int, int> plus = (int a, int b) => { return a + b; };
        //Func<int, int, int> plus = (a, b) => { return a + b; };
        Func<int, int, int> plus = (a, b) => a + b;  // C#
        //Func<int, int, int> plus =  $0 + $1; // swift

    }
}








