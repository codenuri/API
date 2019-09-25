using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


        // 순차열을 반환하는 질의
        var result = numbers.Take(3);
        
        foreach (int n in result)
            Console.WriteLine(n);

        // 순차열이 아닌 값을 반환하는 질의 연산자
        int ret = numbers.First();
        Console.WriteLine(ret);

        //---------------------
        // 순차열 결합
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 3, 4, 5 };

        var arr3 = arr1.Concat(arr2);
        
        foreach (int n in arr3)
            Console.WriteLine(n);
    }
}
