using System;

class interestRate{
    public static void Main(){
        decimal total;

        Console.Write("借入金額---");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("利息（%）---");
        decimal p = decimal.Parse(Console.ReadLine());

        decimal r = p/100M;//Mはdecimalに代入する際エラーを起こさないようにするためのもの

        for(int i=1;i<=4;i++){
        total = a*(1m+r);//decimalに変換するときエラーを起こさないようにするためのもの
        Console.WriteLine("{0}週間後の元利合計は{1:c}です",i,total);
        a=total;
        }



    }
}