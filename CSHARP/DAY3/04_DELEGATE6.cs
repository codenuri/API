using System;

class Animal { }
class Dog : Animal { }

// Dog 가 Animal 로 변환 될수 있을때
// X<Dog>가 X<Animal>로 변환 될수 있다면 "공변성(Covariance)"를 지원한다고 표현합니다.
//                  out 지시어를 사용합니다.

delegate TResult MyFunc<out TResult>();

// X<Animal>가 X<Dog>로 변환 될수 있다면 "반변성(contravariance)"를 지원한다고 표현합니다.
//                  int 지시어를 사용합니다.

delegate void Action<in T>(T arg);


class Delegate6
{
    public static Animal F1() { return null; }
    public static Dog F2()    { return null; }

    public static void Main()
    {
        /*
        MyFunc<Animal> d1 = F1; // 반환값이 Animal 인 함수를 담는다.
        MyFunc<Dog>    d2 = F2; // 반환값이 Dog    인 함수를 담는다.

        MyFunc<Animal> d3 = d1; // ok. d3와 d1은 같은 타입이다.
        MyFunc<Animal> d4 = d2; // Animal 반환 delegate = Dog 반환 delegate
                                // 현재 error

        Animal ret = d4();  // d4는 Animal을 반환하는 함수
                            // 이때 d4가 반드시 Animal 을 리턴해야만 할까 ?
                            // Dog를 리턴하면 안될까 ?


        */


        Action<Animal> a1 = F3; // Animal을 인자로 가지는 함수
        Action<Dog> a2 = F4;    // Dog를 인자로 가지는 함수

        Action<Dog> a3 = a2; // ok.. 동일 타입.

        Action<Dog> a4 = a1; // Dog를 인자로 가지는 함수 = Animal을 인자로 가지는 함수

        a4(new Dog()); // a4는 인자로 Dog 참조를 받아야 한다.
                       // a4가 인자로 Animal 참조를 받는 함수라면 안될까 ?
    }

    public static void F3(Animal a) { }
    public static void F4(Dog a) { }
}

