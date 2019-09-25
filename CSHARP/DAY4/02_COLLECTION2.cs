using System;
using System.Collections.Generic;       
// Enumerator

class Program
{
    public static void Main()
    {
        LinkedList<int> s = new LinkedList<int>();

        s.AddFirst(10);
        s.AddFirst(20);
        s.AddFirst(30);
        s.AddFirst(40);

        // 열거자(enumerator) : 컨테이너에 있는 모든 요소를 열거할때 사용한느
        //              객체
        // 1. 모든 컬렉션의 열거자는 동일한 멤버 함수가 있어야 한다
        //          IEnumerator<T> 라는 인터페이스를 구현해야 한다.

        // 2. 모든 컬렉션은 열거자를 꺼내는 함수가 있어야 한다.
        //         IEnumeable<T> 인터페이스 - 컬렉션 인터페이스

        var it = s.GetEnumerator();

        // 주의. MoveNext()를 한번 호출해야 처음을 가리킨다.
        while( it.MoveNext() )
        {
            Console.WriteLine(it.Current); // it 가 가리키는 요소의
                                           // 값을 얻기
        }
    }


}
