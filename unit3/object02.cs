using System;

class object02{
    public static void Main(){
        object o;
        int i,a=100;

        o=a;
        i=(int)o;//キャストを使ってボックス化解除を行う

        Console.WriteLine(i);
    }
}