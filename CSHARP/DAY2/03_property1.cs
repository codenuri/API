using System;

// 주제 : property
// ildasm 으로 확인
// 1. 사용시에는 필드처럼 보이지만 구현시에는 메서드 처럼 만드는 코드.

class Bike
{
    public int gear = 0;

    // setter 와 getter 만들기
    //public int getGear()       { return gear; }
    //public void setGear(int n) {  gear = n; }

    // C#의 property 개념 : setter 와 getter를 자동으로 만드는
    //                      개념
    // public int gear;       // 멤버 데이타(필드)
    // public int gear() { }; // 멤버 함수(메소드)
    public int Gear
    {
        get { return gear; }
        set { gear = value; }
    }
}
class Program
{
    public static void Main()
    {
        Bike b = new Bike();
        b.Gear = 10; // setter 호출
        //b.gear = -10;
        Console.WriteLine(b.Gear); // getter 호출

    }
}

