using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Select 만들기.

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var result  = arr.MySelect(n => n * 2);

        foreach (int n in result)
            Console.WriteLine(n);
    }
}

// 배열에 MySelect 함수를 추가합니다.
static class ArrayExtension
{
    public static IEnumerable<int> MySelect( this Array ar, 
                                             Func<int, int> f)
    {
        foreach (int elem in ar)
            yield return f(elem);
    }   
}



/*
// 확장 메소드 문법 ( static 클래스로 만들고, static 멤버 함수로 작성)
class Car
{
    public void Go() { }
}
static class CarExtension
{
    public static void Stop(this Car c) { }
}
*/
