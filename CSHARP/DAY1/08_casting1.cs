using System;

// implicit casting : 캐스팅 연산없이 캐스팅 되는것
// explicit casting : 캐스팅 연산이 필요한것

// C/C++ : 모든 primitive 타입은 implicit casting 된다.
// C#    : 모든 primitive 타입은 데이타 손실이 없을때만
//         implicit casting 된다.
// 함수형 언어 : 모든 암시적 변환은 error.
class Program
{
    public static void Main()
    {
        int n1 = 3;
        double d = n1; // 1. 실패하지 않고, 2. 데이타 손실도 없다.
                       // ok

        //int n2 = d; // error 암시적 안됨
        int n2 = (int)d; // ok. 명시적 가능. 하지만 좋지 않은 코드

    }
}