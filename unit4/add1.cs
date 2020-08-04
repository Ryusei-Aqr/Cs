using System;

class add1{
    public static void Main(){
        Console.WriteLine(3.0+6);
        Console.WriteLine("3.5"+6);
        Console.WriteLine(3.5+"6");
        Console.WriteLine("(3.0+6)の型は{0}",(3.0+6).GetType());//int?
        Console.WriteLine("文字列3.5+intの6の型は{0}",("3.5"+6).GetType());//String?
        Console.WriteLine("doubleの3.5+文字列6の型は{0}",(3.5+"6"));//String   
    }
}

/*
文章+数字　の扱いになる。
+の演算子の前後のどちらかにString型があると、全体としてはString型になる
*/