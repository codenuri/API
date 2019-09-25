using System;

// 확장 메소드

public class Car
{
    public void Go() { Console.WriteLine("Car Go"); }
}
// 기존 클래스에 새로운 멤버함수를 추가할수 있습니다.
// extension method 라는 문법
// 1. static class 로 만들어야 한다.
// 2. Car를 1번째 인자로 가지는 static 메소드를 작성한다.
public static class CarExtension
{
    // Car를 1번째 인자로 가지는 static 함수를 만들면 됩니다.
    public static void Stop ( this Car c)
    {
        // 구현은 c의 public 함수만으로 구현해야 합니다.
        Console.WriteLine("Car Stop");
    }
}
class Extension
{
    public static void Main()
    {
        Car c = new Car();
        c.Go();
        c.Stop();  // CarExtension.Stop(c);
    }
}