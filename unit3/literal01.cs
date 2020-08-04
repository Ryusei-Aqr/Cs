using System;

class litelal01{
    public static void Main(){
        string format="{0}の型は.NET型で{1}です。";
    /*
    longならL/l、uintならU/u、ulongならUL/ulなどのように
    型を言い張るサフィックスと呼ばれるものがある
    それを知るための、Object.GetTypeメソッドが存在*/
        Console.WriteLine(format, "1000UL",1000UL.GetType());
        Console.WriteLine(format, "-10D",(-100).GetType());
    }
}