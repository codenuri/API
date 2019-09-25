using System;
using System.Collections;               // 1. non generic collections
using System.Collections.Specialized;   // 2. 타입에 특화된 collections
using System.Collections.Generic;       // 3. generic collections
using System.Collections.ObjectModel;   // 4. for Custom collections 
using System.Collections.Concurrent;    // 5. thread safe collections

// 컬렉션 : 여러개의 객체를 보관하는 클래스(자료구조)
//         배열, linked list, stack, queue, dictionary, hash table
class Program
{
    public static void Main()
    {
        // 1. object 를 보관하는 컬렉션
        //    예전 스타일 : 타입 안전성이 떨어 진다.
        ArrayList c1 = new ArrayList(); // 동적 배열
        c1.Add("AA");
        c1.Add("BB");
        c1.Add(10);

        // 2. Generic 컬렉션(컨테이너) - 타입 안정성이 뛰어나다.
        List<int> c2 = new List<int>(); // 동적 배열
        c2.Add(10);
        //c2.Add("A"); // error

        LinkedList<int> c3 = new LinkedList<int>(); // linked list
        c3.AddFirst(10);

        //---------------------------------------------
        // System.Collections.Specialized;
        // 3. 특정 타입을 보관하는 컬렉션
        StringDictionary d = new StringDictionary();


        // 4. 멀티 스레드에 안전한 컬렉션
        // System.Collections.Concurrent
        ConcurrentStack<int> cs = new ConcurrentStack<int>();
        cs.Push(10);

    }
}
