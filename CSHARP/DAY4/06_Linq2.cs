using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        string[] arr = { "kim", "park", "choi", "lee", "jung" };

        // Fluent Syntax : Where, OrderBy, Select
        var names = arr.Where(s => s.Contains('i'))
                       .OrderBy(s => s.Length)
                       .Select(s => s.ToUpper());

        
        foreach (var n in names)
        {
            Console.WriteLine(n);
        }

    }
}
