using System;

// C# 4.0 부터 디폴트 파라미터 가능. 
// 선택적 파라미터(Optional Parameter)라고 부름.
class Program
{
    public static void goo(int x = 0, int y = 0, int z = 0) { }

    public static void Main()
    {
        goo(1, 2, 3);
        goo(1, 2 );
        goo(1);

        // 아래 함수의 인자의 의미를 생각해 보세요
        //SetRect(0, 0, width:100, height:100);
        
        goo(x:1, y:2, z:3);
        goo(1, z: 3, y: 2);
        goo(y: 2);


        Base b = new Derived();
        if (사용자입력 == 0) b = new Base();

        b.foo(); // Derived : 10
                 // 실행시간에 b가 가리키는 메모리를 조사한후에
                 // 실제객체.foo( )를 호출하는 기계어 코드 생성
                 // 실제객체.foo( 10  )

        // 핵심 : 디폴트 값을 채우는 시점은 컴파일 시점입니다.
        //        되도록이면 가상함수에서는 디폴트값을 사용하지 마세요

    }
}
class Base
{
    public virtual void foo(int n = 10) { Console.WriteLine($"Base : {n}"); }
}
class Derived : Base
{
    public override void foo(int n = 20) { Console.WriteLine($"Derived : {n}"); }
}
