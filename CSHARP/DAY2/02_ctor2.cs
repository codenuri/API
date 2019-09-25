using System;

// 주제 : static 생성자
// 1. 인자를 가질수 없고, 오직 한개만 만들수 있다. 단, 한번만 호출된다.
// 2. 클래스의 static 멤버에 접근할때 호출.
// 3. 객체를 생성하면 호출.
class Car
{
    public int speed = 0;
    public static int count = 10;

    // 일반 생성자 : 객체를 만들때 호출된다.
    //              일반 멤버 데이타를 초기화 할때 사용
    public Car() { speed = 0; }

    // static 생성자 : 객체를 만들거나 또는 static 멤버를
    //              최초에 접근할때 1회만 호출
    static Car()
    {
        // static 멤버 초기화를 위해
        //speed = 10; // error
        count = 20;
        Console.WriteLine($"static Car() : {count}");
    }
}
class Program
{
    public static void Main()
    {
        int n = Car.count; // 객체를 만들지 않았지만
                      // static 멤버에 접근하므로 static 생성자 호출

        Car c = new Car(); // 1. static 생성자 호출
                            // 2. 일반 생성자 호출
    }
}