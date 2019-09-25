


// cafe.naver.com/codenuri 
// C# 게시판에서 "2일차 사전소스" 받으시면 됩니다.
















using System;

// null1.cs
// 1. ?  : 널 조건부 연산자(null-conditional operator, 'Elvis' operator)
// 2. ?? : 널 접합 연산자(null-coalescing operator)

class Car
{
    public void Go() { Console.WriteLine("Car Go"); }
}

class Program
{
    public static Car CreateCar(int speed)
    {
        if (speed < 200)
            return new Car();
        return null;
    }

    public static void Main()
    {
        Car c = CreateCar(100);
        c.Go();

        Car c2 = CreateCar(300);
        //c2.Go();

        // 실패 가능성이 있는 객체 사용시 반드시 유효성 조사가 필요..
        //if (c2 != null)
        //    c2.Go();
        // 1. elvis operator : ?
        c2?.Go();    // 위와 동일한 코드
                     // c2가 null 이면 nop   
                     // c2?.d?.e?.foo();

        // 2. ??
        Car c3 = CreateCar(300) ?? new Car();
        // A ?? B  : A의 결과가 null 이면 B를 사용

        string s1 = null;
        string name = s1 ?? "이름없음";

        Console.WriteLine(name); 






        /*
        CPoint p1 = new CPoint(); // class라고 가정
                            // 2번의 메모리 할당
                            // p1은 스택에 참조로, 객체는 힙에

        SPoint p2 = new SPoint(); // struct 라고 가정
                                  // 한번의 메모리 할당
                                  // p2라는 객체가 스택에

        p1 = null; // ok.  reference type은 null이 될수 있다
        p2 = null; // error. value type 은 null이 될수 없다.
        */
    }



}

