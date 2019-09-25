using System;
// CIL : 중간언어 ( 옛날 이름 : MSIL)
// CLR : 가상 머신 + .net Framework
// CLS : Common Language Specification

// .net Framework
// mscorlib.dll

class Program
{
    public static void Main()
    {
        int n1 = 10;  // 결국 .net Framework 의 Int32입니다.
        Int32 n2 = 10; // CTS : Common Type System
                       // CLR 에서 정의된 타입

        // C++ int => CLR Int32
        // C#  int => CLR Int32

        Type t1 = n1.GetType();
        Type t2 = n2.GetType();

        Console.WriteLine(t1.Name);
        Console.WriteLine(t2.Name);

    }
}

