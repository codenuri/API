using System;

// 함수 재정의(override)
class Base
{
    //public void Foo() { Console.WriteLine("Base Foo"); }   

    // static binding 하지 말고 dynamic binding 해달라는 지시어.
    public virtual void Foo() { Console.WriteLine("Base Foo"); }
}
class Derived : Base
{
    // 동일 이름이 있으므로 경고.
    //public void Foo() { Console.WriteLine("Derived Foo"); }

    // 경고를 없애려면 new 사용
    //public new void Foo() { Console.WriteLine("Derived Foo"); }


    // Foo가 가상함수 일때
    // 1. new : 가상함수 재정의 아님. 새로운 함수 
    //public new void Foo() { Console.WriteLine("Derived Foo"); }

    // 2. override  : 가상함수 재정의 
    public override void Foo() { Console.WriteLine("Derived Foo"); }
} 

class Program
{
    public static void Main()
    {
        Base    b = new Derived();
        Derived d = new Derived();


        b.Foo();
        d.Foo(); // Derived Foo

        //--------------------------------------
       // Base b1 = new Derived();

//        if ( 사용자 입력값 == 0 ) b1 = new Base();

  //      b1.Foo(); // 이순간 컴파일러는 b1이 누구인지 알수 있을까 ?
    }
}

// b.Foo()를 어느 함수로 연결할것인가? 함수 바인딩

// 1. static 바인딩 : 컴파일러가 컴파일 시간에 결정
//                     컴파일러는 실제 객체를 모른다.
//                     무조건 참조 타입으로만 함수 호출결정
//                      Base Foo               
// early binding, 빠르다. C++, C#


// 2. dynamic 바인딩 : 컴파일시간에 b의 메모리를 조사하는 코드를 생성
//                      실행시에 b의 메모리 조사후 함수 호출
//                      Derived Foo 호출
// late binding. 느리다. java, swift, objective-c, kotlin, 
//                  C++과 C#의 virtual 함수.