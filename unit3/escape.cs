using System;

class escape{
    public static void Main(){
        char n="\n";
        string str1="今日は";
        string str2="良い天気ですね";

        Console.WriteLine(str1+n+str2);

        string str3="そうですね。\nとてもいい天気です。";
        Console.WriteLine(str3);
    }
}