using System;

// event handling #1. 

class Button
{
    public delegate void HANDLER(); // class HANDLER : MulticastDelegate {}
    public HANDLER handler = null;
    public void Press()
    {
        // 여기서 직접 일을 하면 - 모든 버튼은 동일한 일을 하게 된다.

        // 버튼이 눌린 사실을 외부에 알려준다.
        //if ( handler != null )
        //    handler();
        //   handler?(); // error

        handler?.Invoke(); // ok..
    }
}
class Program
{
    public static void OnClick() { Console.WriteLine("Button Click"); }
    public static void Main()
    {
        Button b1 = new Button();
        Button b2 = new Button();

        //b1.handler = OnClick;   // 버튼을 눌렀을때 처리할 함수 등록

        b1.Press();
    }
}
