using System;

// 약한 결합(Loosely coupling)
// 하나의 클래스가 다른 클래스 사용시 이름대신 인터페이스를 사용하는것
// 교체가능하고, 유연한 디자인

// 카메라 제작자와 카메라 사용자 사이에 지켜야 하는 규칙을 먼저 설계한다.
// 규칙 : 모든 카메라는 ICamera 로 부터 파생되어야 한다. 라고 하지말고

//       "모든 카메라는 ICamera 인터페이스를 구현해야 한다."

interface ICamera
{
    void Take();
}
// 카메라는 없지만 규칙이 있다.
// 규칙대로만 사용하면 된다.
class People
{
    public void UseCamera(ICamera c) { c.Take(); }
}
// 모든 카메라 제작자는 규칙을 지켜야 한다.
class Camera : ICamera
{
    public void Take() { Console.WriteLine("take picture with Camera"); }
}
class HDCamera : ICamera
{
    public void Take() { Console.WriteLine("take picture with HDCamera"); }
}

class Coupling
{
    public static void Main()
    {
        People p = new People();
        Camera c = new Camera();
        p.UseCamera(c);

        HDCamera c2 = new HDCamera();
        p.UseCamera(c2);
    }
}
