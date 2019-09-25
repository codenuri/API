using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // 홀수를 출력하는 방법
        // 1. foreach 또는 반복자 사용
        foreach( var n in arr )
        {
            if ( n % 2 == 1)
                Console.WriteLine(n);
        }

        // 방법 2. Linq( language integrated query) 사용
        IEnumerable<int> c = arr.Where( n => n % 2 == 1);

        foreach (var n2 in c)
            Console.WriteLine(n2);

    }
}
