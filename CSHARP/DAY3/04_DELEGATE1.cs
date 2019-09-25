using System;

// C++ 멤버 함수 포인터
// void (Dialog::*f)(int)   => 클래스 이름이 포함되어 있다.
//                          Dialog 클래스의 멤버 함수만 담는다.

// C#의 delegate : 타입(클래스)이름이 없다.
//                  signature(반환값과 인자)만 맞으면 모든 타입의 
//                  함수 보관 가능.

delegate void FP(int a);

// 위 한줄의 코드를 보고 아래 클래스를 컴파일러 생성합니다.
/*
class FP : MulticastDelegate
{
}
*/ 

class Program
{
    public static void Foo(int a) { }

    public static void Main()
    {
        int    n = 10;     // 10은 int 타입
        double d = 3.4; // 3.4 는 double 타입

        // 함수를 담을수 있는 타입이 필요 - delegate
        //? f = Foo; // Foo 는 함수..

        // delegate : 함수(주소)를 보관했다가 다시 호출하는 문법.
        //FP f = new FP(foo); // 정확한 표현
        FP f = foo; // 축약 표현.. 위와 동일합니다.

        //f.Invoke(10); // 이순간 foo(10) 으로 호출됩니다.
        f(10); // 위와 동일 합니다.

    }
}