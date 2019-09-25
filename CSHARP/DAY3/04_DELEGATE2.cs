using System;

// Multicast Delegate, reference type, immutable
delegate void FP(int a);

class Program
{
    public static void Foo(int a) { Console.WriteLine($"Foo : {a}"); }
    public static void Goo(int a) { Console.WriteLine($"Goo : {a}"); }
    public void Hoo(int a) { Console.WriteLine($"Hoo : {a}"); }

    public static void Main()
    {
        // 핵심 1 . 델리게이트에는 여러개 함수 등록 가능.
        // FP f = new FP(Foo)
        FP f = Foo;         // static 메소드 등록 방법 1.
        f   += Program.Goo; // static 메소드 등록 방법 2.

        //f   += Hoo; // error. instance method는 객체가 필요하다.

        Program pr = new Program();
        f += pr.Hoo;

        f(10); // 이순간 등록된 모든 메소드 호출

        // 핵심2. delegate는 class이므로 reference type입니다.

        FP f1 = Foo; // FP f1 = new FP(Foo)
        FP f2 = f1;

        if (f1 == f2)
            Console.WriteLine("same");     // !!
        else
            Console.WriteLine("not same");

        // 핵심 3. 델리게이트는 immutable 합니다.
        f1 += Goo; // f1 = f1 + Goo
                   // 이순간, 새로운 델리게이트가 생성되어서
                   // f1이 가리키게 됩니다.
                   // f1, f2는 이제 다른 객체 를 가리킵니다

        if (f1 == f2)
            Console.WriteLine("same");     // ?
        else
            Console.WriteLine("not same"); // ...

    }
}















