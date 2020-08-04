using System;

class myclass{
    public int x;
}

class simpleClass{
    public static void Main(){
        myclass mc = new myclass();//オブジェクトの作成
        mc.x=10;

        Console.WriteLine("mc.x={0}",mc.x);
    }
}