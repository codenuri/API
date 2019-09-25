using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// into 
class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var result = arr.Where(s => s.Contains('i'))
             .OrderBy(s => s.Length)
             .Select(s => s.ToUpper());


        foreach (int n in result)
            Console.WriteLine(n);
    }
}