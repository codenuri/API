using System;

// OCP : 기능 확장에는 열려 있고(Open)
//       코드 수정에는 닫혀 있어야(Close)
//        원칙(Principle )
// 개방 - 폐쇄의 법칙

// SW설계의 5대원칙 : OCP, LSP, DIP, SRP, ISP

// 강한 결합(tightly coupling)
// 하나의 클래스가 다른 클래스 사용시 이름을 직접사용
// 교체불가능하고, 경직된 디자인

class Camera
{
    public void Take() { Console.WriteLine("take picture with Camera"); }
}

class HDCamera
{
    public void Take() { Console.WriteLine("take picture with HDCamera"); }
}


class People
{
    public void UseCamera(Camera c) { c.Take(); }
    public void UseCamera(HDCamera c) { c.Take(); }
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