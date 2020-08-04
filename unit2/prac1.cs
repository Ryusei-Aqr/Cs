using System;

class prac1{
    public static void Main(){
        string thing;
        Console.WriteLine("Plese tell me your favorite things.");
        thing=Console.ReadLine();//文字列で取得
        Console.WriteLine("Your favorite thing is {0}, isn't it?",thing);
    }
}