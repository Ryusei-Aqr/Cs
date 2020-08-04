using System;

class prac3{

    public static void Main(){

        int n,i,sum=0;

        Console.Write("整数を入力してください---");
        n=int.Parse(Console.ReadLine());

        for(i=1; i <= n; i++){
            sum+=i;
        }

        Console.WriteLine(sum);

    }
}