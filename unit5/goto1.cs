using System;

class goto1{
    public static void Main(){
        Console.WriteLine("これからジャンプします。");
        goto jump01;

        jump01:
        Console.WriteLine("ここまで飛んできました。");
        Console.WriteLine("プログラムを終了します。");
    }
}