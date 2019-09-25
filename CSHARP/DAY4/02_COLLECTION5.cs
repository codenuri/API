using System;
using System.Collections;         // IEnumerable
using System.Collections.Generic; // IEnumerable<T>
using static System.Console;

class Node<T>
{
    public T data = default(T);
    public Node<T> next = null;

    public Node(T d, Node<T> n) { data = d; next = n; }
}

// 핵심 : 이소스에는 MyEnumerator 라는 열거자 클래스가 없습니다.
//        단지 컨테이너만 있습니다.

class MyLinkedList<T> : IEnumerable<T>
{
    // yield 를 사용한 반복자 만들기.
    // 핵심1 : 반복자 객체 없이 그냥 값을 리턴합니다.
    // 핵심2 : 반환 타입은 IEnumerator<T> 인데
    //         실제 반환값은 T 입니다.
    public IEnumerator<T> GetEnumerator()
    {
        Console.WriteLine("3 GetEnumerator Start");
        Node<T> current = head;

        while( current != null )
        {
            yield return current.data;
            current = current.next;
            Console.WriteLine("5. GetEnumerator MoveNext");
        }
    }

   
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
   
    public Node<T> head = null;

    public void AddFirst(T value)
    {
        head = new Node<T>(value, head);
    }
}

class Program
{
    public static void Main()
    {
        MyLinkedList<int> s = new MyLinkedList<int>();

        s.AddFirst(10);
        s.AddFirst(20);
        s.AddFirst(30);
        s.AddFirst(40);

        Console.WriteLine("1 Before Call GetEnumerator");
        IEnumerator<int> it = s.GetEnumerator();   // 실제 호출 안됨.
        Console.WriteLine("2 After Call GetEnumerator");
        while (it.MoveNext())
        {
            Console.WriteLine("4. After MoveNext");
            Console.WriteLine(it.Current); 
            
        }

    }
}