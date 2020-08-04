using System;

class logic{
    public static void Main(){
        bool a=true;
        bool b=false;

        Console.WriteLine("a={0},b={1}",a,b);
        Console.WriteLine("aは{0}",a.GetType());
        Console.WriteLine("aとbを文字列に変換すると{0},{1}になる",a.ToString(),b.ToString());
    }
}