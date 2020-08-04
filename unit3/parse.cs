using System;

class parse{
    public static void Main(){
        int x,age;
        Console.WriteLine("整数を入力してください");
        x=int.Parse(Console.ReadLine());
        Console.WriteLine("今の数字を２倍すると{0}ですね",x*2);
        
        Console.WriteLine("次にあなたの年齢を入力してください");
        age=int.Parse(Console.ReadLine());
        Console.WriteLine("あと{0}年で100歳ですね",100-age);

    }
}