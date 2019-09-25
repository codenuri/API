using System;

// 핵심 5. value_type vs reference type

// C/C++ : 객체가 놓이는 장소를 객체 사용자가 결정한다.

//Point pt; // 스택 객체
//Point* p = new Point ; // 힙

// java, C#, swift, kotlin 등의 요즘언어
// 타입설계자가 객체가 놓이는 위치를 결정한다.
// struct : 객체를 만들면 스택에 놓인다.(작은크기)
// class  : 객체를 만들면 힙에 놓인다(일반적으로 큰 객체)


// value type : 객체 생성시 스택에 놓이는 것
//              primitive type(int, double 등, 사실은 int도 구조체)
//              struct, enum


// reference type : 객체생성시 힙에 놓이고 참조 변수로 가리키는것
//              class, array, string, interface, delegate




struct SPoint    // 객체를 만들면 스택
{
    public int x;
    public int y;
}
class CPoint    // 객체를 만들면 힙..
{
    public int x;
    public int y;
}
class Program
{
    public static void Main()
    {
        // 아래 2줄의 메모리 그림을 항상 생각하세요
        SPoint sp1 = new SPoint();
        SPoint sp2 = sp1;

        sp1.x = 100;
        sp1.y = 200;

        Console.WriteLine("sp1.x = {0}, sp2.x = {1}", sp1.x, sp2.x);

        // 아래 2줄의 메모리 그림을 위의 코드와 비교하세요
        CPoint cp1 = new CPoint(); // 2번의 메모리 할당
                                   // 객체는 힙에, 참조변수 cp1 은 스택에

        CPoint cp2 = cp1;   // 참조변수만 스택에 생성 

        cp1.x = 100;
        cp1.y = 200;

        Console.WriteLine("cp1.x = {0}, cp2.x = {1}", cp1.x, cp2.x);


    }
}



// value type     : numeric primitive type, struct, enum
// reference type : string, array, class, interface, delegate