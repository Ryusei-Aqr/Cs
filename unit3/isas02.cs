using System;

class isas02{
    /*as演算子
    式　as データ型
    式を指定のデータ型に変換する。失敗するとnullが返る
    この時、式もデータ型も参照型ではなくてはならない
    */
    public static void Main(){
        long l=100;
        object o;
        string s;

        o=l;
        s= o as string;
        Console.WriteLine("{0} is string.",o);
    }
}