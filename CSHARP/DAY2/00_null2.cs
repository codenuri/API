using System;

// Nullable 타입, ?, ??
// 1. Nullable<T> :  value type T가 null을 가질수 있게 한다.
//   C++ ) optional<int> 

class Program
{
    //public static int Foo()   {  return -1;    }

    //public static Nullable<int> Foo() { return null; }
    
    // int?  == Nullable<int> 
    public static int? Foo() { return null; }

    public static void Main()
    {
        //int ret = Foo();
        Nullable<int> ret = Foo();
        if (ret == null)
            Console.WriteLine("fail");

        //------------------
        // 집합 관계를 생각하세요
        // int? = int + null
        int n1 = 10;
        int? n2 = n1;  // ok.

        //int n3 = n2; //  error. int? 는 int에 담을수 없다.

        int n3 = (int)n2; //  ok.. 하지만 n2가 null이면 예외

        var n4 = n2 ?? 0; // n4는 int?  , int
                          // n4는 int 가 된다.
        Type t = n4.GetType();
        Console.WriteLine(t.Name); // Int32                     

    }
}












