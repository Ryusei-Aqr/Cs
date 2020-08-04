using System;

class isas01{
    /*
    is演算子
    式　is データ型
    式＝データ型の関係が成り立てばtrueを返し、そうでなければfalseを返す。
    この時、式は参照型出なくてはならない。
    */
    public static void Main(){
        object o;
        long l=1;
        o=l;

        Console.WriteLine("oにlongをボックス化しました");
        Console.WriteLine("o is long --- {0}",o is long);
        Console.WriteLine("次にoに文字列を代入しました。");
        o="abc";
        Console.WriteLine("o is string --- {0}", o is string);
    }
}