using System;
using System.Runtime.CompilerServices;

// attribute : 컴파일러에게 지시하는 명령어. [ 명령어 ]
//[ObsoleteAttribute]

[Obsolete]
class Button
{
}

class Program
{
    public static void Main()
    {
        Button b = new Button();

    }
}