using System;

// 싱글리스트 코드 입니다.
class Node<T>
{
    public T data = default(T);
    public Node<T> next = null;

    public Node(T d, Node<T> n) { data = d; next = n; }
}

class MyLinkedList<T>
{
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


    }
}