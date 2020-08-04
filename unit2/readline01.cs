using System;

class readline01{
    public static void Main(){
        string name;
        Console.WriteLine("あなたの名前は何ですか？");
        name=Console.ReadLine();
        Console.WriteLine("あなたの名前は{0}さんですね",name);
    }
}