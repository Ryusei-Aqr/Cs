using System;
/*dynamic型はプログラムの実行時に型が決まる*/

class dynamic01{
    public static int Main(){
        dynamic x=10, y="abc",z;
        z=1.25;

        Console.WriteLine("x --- {0}",x.GetType());
        Console.WriteLine("y --- {0}",y.GetType());
        Console.WriteLine("z --- {0}",z.GetType());
    
    return 0;
    }
}