using System;

class object01{
    public static void Main(){
        /*
        object型はC#固有の型でどんな型の変数も代入することができる
        厳密には変数oに入っている訳ではなく、マネージドヒープ領域と呼ばれる
        メモリ領域に保存されている。（ボックス化）
        しかし、このメモリには限りがあるのでいっぱいになるとガベージコレクション
        と呼ばれる操作をする必要がある。
        */
        object o;
        byte b=50;
        string str="aqr";

        o=b;//ボックス化
        Console.WriteLine(o);

        o=str;//ボックス化
        Console.WriteLine(o);
    }
}