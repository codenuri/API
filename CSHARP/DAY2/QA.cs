using System;

class Point
{
    public static bool operator==(Point p1, Point p2)
    {
        Console.WriteLine("==");
        return true;
    }
    public static bool operator !=(Point p1, Point p2)
    {
        Console.WriteLine("==");
        return true;
    }
}
class QA
{
    public static void Main()
    {
        Point p1 = new Point();
        Point p2 = new Point();

        Console.WriteLine(p1 == p2); // *p1 == *P2
    }
}