using System;

class space{
    public static void Main(){
        int x=10;

        Console.WriteLine(x);
        Console.WriteLine("{0,10}",x);
        Console.WriteLine("{0,-10}{0,-10}",x);
        Console.WriteLine("{0,-5}{1,0}",x,"hoge");
        //標準指定
        Console.WriteLine("{0:C}",x);
        Console.WriteLine("{0:D}",x);
        Console.WriteLine("{0:e1}",0.0006);
        Console.WriteLine("{0:f10}",Math.PI);
        Console.WriteLine("{0:n9}",1000);
        Console.WriteLine("{0:p}",0.01);
        Console.WriteLine("{0:x}",13);
        //プレースホルダ
        Console.WriteLine("{0:#,###.###}",1234567.123);
        Console.WriteLine("{0:(000)####-####}",1132104566);

        
    }
}