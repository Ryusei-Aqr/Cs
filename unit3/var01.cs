using System;

/*var型はコンパイルの実行時に型が決まるため
変数とその中身を一緒に宣言する必要がある*/
class var01{
    public static int Main(){
        var mytext="猫でもわかるC#";//暗黙のString型
        var no=2;
        var myc="版";

        Console.WriteLine(mytext+no+myc);
        Console.WriteLine(
            "mytextの型は{0}で、noの型は{1}で、mycの型は{2}です",
            mytext.GetType(),no.GetType(),myc.GetType()
        );

        return 0;
    }
}