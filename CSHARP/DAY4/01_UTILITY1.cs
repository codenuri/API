// cafe.naver.com/codenuri 
// 게시판에서 4일차 사전 소스 받으시면 됩니다.
// 프로젝트 메뉴 -> 속성 선택
// .net framework 버전 4.6 으로 맞추어 주세요.












using System;
using System.Threading;

// TimeSpan : "특정 시각(2시 30분)" 또는 "시간의 기간(2시간 30분)"
// DateTime : 그레고리안 날짜, 시간을 관리

class Program
{
    public static void Main()
    {
        TimeSpan ts = new TimeSpan(2, 30, 11);
        Console.WriteLine(ts);  // 2시 30분 11초

        DateTime dt = DateTime.Now; // 현재 날짜와 시간
        Console.WriteLine(dt);

        // 알고리즘 작성
        Thread.Sleep(1000);

        // 다시 시간 얻기
        DateTime dt2 = DateTime.Now;

        // 알고리즘이 걸리 시간 측정
        TimeSpan ts2 = dt2 - dt;
        Console.WriteLine(ts2);
        



    }
}
