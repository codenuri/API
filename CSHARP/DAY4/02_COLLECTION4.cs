using System;
using System.Collections.Generic;

// C# 1.0
// Collection4.cs 에러 나오신분은 아래 인터페이스 주석을 풀러 주세요
// 
interface IEnumerator
{
    void Reset();    // 초기화
    bool MoveNext(); // 다음으로 이동
    object Current { get; }    // 현재 위치의 객체에 접근하는 Property
}

// C# 2.0
interface IEnumerator<T> : IEnumerator
{
    T Current { get; }
}


class Node<T>
{
    public T data = default(T);
    public Node<T> next = null;
    public Node(T d, Node<T> n) { data = d; next = n; }
}

// MyLinkedList 의 열거자(반복자)
class MyEnumerator<T> : IEnumerator<T>
{
    // 결국 열거자는 list의 node를 가리킬수 있어야 합니다.
    public Node<T> head = null;
    public Node<T> current = null;  // list내의 node를 가리키는 참조

    public MyEnumerator(Node<T> p) { head = p; current = null; }

    // IEnumerator 함수 구현
    public void Reset() { current = head; }

    public bool MoveNext()
    {
        if (current == null) // 최초에 호출할때
            current = head;
        else
            current = current.next;

        return current == null ? false : true;
    }

    public T Current { get { return current.data; } }

    // 아래 함수는 사용하지 않으므로 private 으로..
    object IEnumerator.Current { get { return current.data; } }
}

// 모든 컨테이너에는 반복자를 꺼낼수 있어야 한다.
// C# 2.0 의 인터페이스

interface IEnumerable<T> // 컬렉션의 인터페이스
{
    IEnumerator<T> GetEnumerator();
}

class MyLinkedList<T> : IEnumerable<T>
{
    public Node<T> head = null;
    public void AddFirst(T value) { head = new Node<T>(value, head); }

    // 모든 컬렉션은 열거자를 반환할수 있어야 한다.
    public IEnumerator<T> GetEnumerator()
    {
        return new MyEnumerator<T>(head);
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

 
    }
}





