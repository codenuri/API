using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 지연된 실행, ToList(), 캡쳐된 변수

class Program
{
    public static void Main()
    {
        IList<int> list = new List<int> { 1, 2, 3 };

        //var result = list.Select(n => n * 10);

        // 원리
        // 1. Select, Where, Orderby 등의 절을 분석해서 함수를 만들어
        //    놓습니다.
        // 2. 반환값 result 는 list 자체와 1에서 만든 함수를 보관합니다.
        //    핵심은 아직 적용되지 않습니다.
        IEnumerable<int> result = list.Select(n => n * 10);

        list.Clear();

        // 아래 처럼 각요소를 꺼낼때,
        // 위에서 만든 연산이 적용되어서 꺼내게 됩니다.
        foreach (int n in result)  
            Console.WriteLine(n);
    }
}




