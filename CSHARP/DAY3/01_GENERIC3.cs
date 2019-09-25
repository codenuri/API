using System;

// type parameter 제약
// int, string, template

class Generic3
{
    /*
    public static int Max( int a, int b)
    {
        //return a < b ? b : a;
        return a.CompareTo(b) < 0 ? b : a;
    }
    public static string Max(string a, string b)
    {
        //return a < b ? b : a;
        return a.CompareTo(b) < 0 ? b : a;
    }
    */

    // C++ : T 타입에 대해 다양한 연산, 함수 호출을 모두 허용
    // C#  : T 타입에 대해서는 object로 가능한 연산만 허용
    /*
   public static T Max<T>(T a, T b)
   {
       // 아래 코드가 가능할지를 생각해 보세요..
       //return a.CompareTo(b) < 0 ? b : a; // error

       // CompareTo 는 IComparable 인터페이스의 멤버 입니다
       IComparable ia = a as IComparable;
       IComparable ib = b as IComparable;

       return ia.CompareTo(ib) < 0 ? b : a;
   }
   */
   // 타입 파라미터 제약 : T 가 가져야 하는 제약을 표기하는 문법
   // C++ 20 의 concept 과 유사한 기능.
    // template<typename T> T Max(T a, T b) require IComparable<T> {}
    public static T Max<T>(T a, T b) where T : IComparable, new() 
    {
        T t = new T();
        return a.CompareTo(b) < 0 ? b : a; 
    }

    public static void Main()
    {
        Console.WriteLine(Max(10, 3));

        Console.WriteLine(Max("AAA", "BBB"));
    }
}










// where T : class, IComparable,  new()
// where T : struct
// where T : new()
// where T : interface이름
// where T : base class 이름
// 2개이상의 제약은 , 로 연결, 단, new()는 제일 마지막에.