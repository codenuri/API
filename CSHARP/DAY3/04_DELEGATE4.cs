using System;

delegate void HANDLER();

// 개발자 명령 프롬프트 실행
// csc 04_DELEGATE4.cs    빌드해서 04_DELEGATE4.exe

// ildasm 04_DELEGATE4.exe

// ildasm : 실행파일이 가진 클래스 를 보여주는 도구..

class Button
{
    // 아래 처럼 만들면 외부에서 Click 을 마음대로 접근가능합니다.
    //public HANDLER Click = null;

    // 아래 처럼 만들면 Button 클래스 안에
    // add_Click(), remove_Click() 멤버 함수가 생성됩니다.
    // 멤버 함수안에서 Click 에 추가/삭제 합니다.
    public event HANDLER Click = null;

    public void Press()
    {
        //Click = null; // 멤버 함수에서는 마음대로 접근 가능.
                        // 외부 함수에서는 +=, -= 만 가능.
        Click?.Invoke();
    }
}


class Program
{
    public static void OnClick1() { Console.WriteLine("Button Click"); }
    public static void OnClick2() { Console.WriteLine("Button Click2"); }
    public static void OnClick3() { Console.WriteLine("Button Click3"); }

    public static void Main()
    {
        Button b = new Button();

        b.Click += OnClick1; // += : add_Click()호출
        b.Click += OnClick2; // -= : remove_Click() 호출
        //b.Click += OnClick3; // = : 사용안됨.

        //b.Click = OnClick3; // += 를 사용해야 하는데 실수 했다
                            // 이전에 등록된 함수가 지워진다.
                         
        b.Press();  
    }
}