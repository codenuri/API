using System;

// indexer : 객체를 배열처럼
class Sentense
{
    protected string[] words;
    public Sentense(string s) { words = s.Split(); }

    // C# indexer : 객체를 배열처럼 사용할수 있게 하는 문법
    // 결국 [] 연산자의 재정의
    // 프라퍼티 이름대신  this[] 로 만든다
    public string this[int idx]
    {
        set { words[idx] = value; }
        get { return words[idx]; }
    }
}
class Program
{
    public static void Main()
    {
        Sentense s = new Sentense("we are the world");
        Console.WriteLine(s[3]);
        s[3] = "frield";
        
    }
}



