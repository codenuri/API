using System;

// 생성자 호출 순서
class BM { public BM() { Console.WriteLine("BM()"); } }
class DM { public DM() { Console.WriteLine("DM()"); } }

class Base
{
    public int data = BaseFieldInit();
    public BM bm = new BM();
    protected Base() { Console.WriteLine("Base()"); }

    public static int BaseFieldInit() { Console.WriteLine("BaseFieldInit"); return 0; }
}

class Derived : Base
{
    public int data = DerivedFieldInit();
    public DM dm =  new DM();
    
    public Derived()
    {
     //   dm = new DM();
        Console.WriteLine("Derived()"); }

    
    public static int DerivedFieldInit() { Console.WriteLine("DerivedFieldInit"); return 0; }
}


class Program
{
    public static void Main()
    {
        Derived d = new Derived();
        // 화면 출력 결과 예측해 보세요.
        // C++
        // 1. 기반 클래스 멤버의 생성자
        // 2. 기반 클래스 생성자
        // 3. 파생 클래스 멤버의 생성자
        // 4. 파생 클래스 생성자

        // C#
        // 1. 자신 멤버의 필드 초기화
        // 2. 기반 클래스의 필드 초기화
        // 3. 기반 클래스 생성자
        // 4. 파생 클래스 생성자

        // 멤버가 여러개 있을경우. 메모리에 놓이는 순서로
    }
}