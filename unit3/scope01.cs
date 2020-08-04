using System;

class scope01{
    public static void Main(){
        int a=1;
        {
            int b=2;
            {
                int c=3;
                //複数の変数を表示するときは番号を割り振らなければいけない
                Console.WriteLine("{0},{1},{2}",a,b,c);
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
        }
        Console.WriteLine(a);
    }
}