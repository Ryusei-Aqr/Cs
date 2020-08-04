using System;

class myclass{
    private string name;
    private int age;
    private string address;

    public void show(){
        string aetas;
        if(age == -1){
            aetas = ("不明");
        }else{
            aetas  = age.ToString();
        }

        Console.WriteLine("氏名:{0} 住所:{1} 年齢{2}", name, address, aetas);
    }

    public myclass(string str){
        name=str;
        address="不定";
        age=-1;
    }

    public myclass(int x){
        age=x;
        address="不定";
        name="不明";
    }

    public myclass(string str1, string str2, int x){
        name=str1;
        address=str2;
        age=x;
    }
}

class construct{
    public static void Main(){
        myclass mc1 = new myclass(18);
        myclass mc2 = new myclass("雪音クリス");
        myclass mc3 = new myclass("立花響", "ガングニール", 17);

        mc1.show();
        mc2.show();
        mc3.show();
    }
}
/*
・オーバーロードは引数が異なる入力になるようなシステムを使う時に有効
・３つ引数が異なるメソッドがあるが、そのメソッド名と引数が異なる型のことをシグニチャと呼ぶ
*/