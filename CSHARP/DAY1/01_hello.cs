

// cafe.naver.com/codenuri 에 가시면 "C# 기본" 게시판 있습니다.

// "1일차 사전 소스" 받으시면 됩니다.

// 강석민 강사(smkang @ codenuri.co.kr )









using System;

// 1. 컴파일 하는 방법
// 실행파일로 빌드       : csc 1_Hello.cs
// 동적 모듈(DLL)로 빌드 : csc /target:library 1_Hello.cs

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#");
    }
}

