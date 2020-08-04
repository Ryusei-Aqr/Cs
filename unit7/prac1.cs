using System;

class prac1{
    public static void Main(){
        int result=0;

        result=calc(21);
        Console.WriteLine("{0}",result);
    }

    public static int calc(int x){//同じクラスの中で呼び出すときはstaticが必要不可欠
        int a=100;

        return a+x;
    }
}