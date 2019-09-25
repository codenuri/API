using System;

// 핵심 5. 캐스팅
// is, as, 캐스트

class Animal { };

class Dog : Animal
{
    public void Cry() { Console.WriteLine("Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        // 기반 클래스 타입의 참조로 파생 클래스를 가리킬수 있다.
        //Animal a = new Dog();
        Animal a = new Animal();

        //a.Cry(); // error.

        // 파생 클래스의 고유 멤버에 접근하려면 캐스팅해야 한다.
        // Dog d = (Dog)a; // a가 Dog 가 아니라면 실행시간 예외
        //d.Cry();

        // a가 정말 어느 객체를 가리키는 지 조사후 캐스팅해야 한다.

        // 방법 1. is 연산자
        if ( a is Dog )
        {
            Dog d = (Dog)a;
            d.Cry();
        }
        else
            Console.WriteLine("a는 Dog가 아닙니다");

        // 방법 2. as 연산자
        Dog d2 = a as Dog;  // a가 Dog 면 참조가 나온다.
                            // Dog가 아니면 null
        if (d2 != null)
            Console.WriteLine("a 는 Dog");
        else
            Console.WriteLine("a 는 Dog 아님");

        // 정리
        // is : 캐스팅이 아니라 조사
        // 캐스팅은 2개
        // Dog d = (Dog)a;  // 실패시 예외
        // Dog d = a as Dog;// 실패시 null

    }
}



