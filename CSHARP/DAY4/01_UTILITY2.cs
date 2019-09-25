using System;
using System.Diagnostics; // Process 클래스
using System.Threading;

class Program
{
    public static void Main()
    {
        Process.Start("calc.exe"); // 결국 CreateProcess()

        // 모든 프로세스 열거
        // C# 규칙 : 함수 이름이 복수형이면
        // 반환타입은 배열 또는 Collection 이 된다.
        Process[] arr = Process.GetProcesses();

        foreach( Process pr in arr )
        {
            Console.WriteLine($"{pr.ProcessName}");
        }

    }
}